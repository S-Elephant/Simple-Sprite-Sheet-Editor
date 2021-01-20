using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SpriteSheetEditor
{
    public partial class frmMain : Form
    {
        #region Members
        public Bitmap bm = null;
        PreviewProperty PP;
        SplitProperty SP;
        TilePreviewProperty TPP;
        Thread PreviewThread;
        List<MergeRow> MergeRows = new List<MergeRow>() { new MergeRow(0) };
        int MergeLastSelRow = 0;
        #endregion

        #region Form
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Statusstrip
            tslbl1.Text = string.Empty;
            tslbl2.Text = string.Empty;

            ToolTip tp = new ToolTip();

            // Folders
            if (!Directory.Exists(Global.PREVIEW_FOLDER))
                Directory.CreateDirectory(Global.PREVIEW_FOLDER);

            // Merge
            cboMergeCurrentRow.SelectedIndex = cboExt.SelectedIndex = 0;
            btnMoveDown.Enabled = btnMoveUp.Enabled = !chkAutoSortLstImages.Checked;
            lstImages.Sorted = chkAutoSortLstImages.Checked;
            tp.SetToolTip(txtMergeRowCnt, "The number of rows in the spritesheet.");
            tp.SetToolTip(txtFrameCnt, "The number of frames per row in the spritesheet.");
            tp.SetToolTip(btnDelImage, "Remove selected frame from the list.");
            tp.SetToolTip(btnClearAllMerge, "Remove all frames from all rows from the list.");
            tp.SetToolTip(chkAutoSortLstImages, "When checked: sorts the images in the merge list by name. Uncheck me to enable the sort buttons.");

            // Split
            SP = new SplitProperty(ref pbSplit);
            pgSplit.SelectedObject = SP;

            // Preview animation
            PP = new PreviewProperty(ref pbPreviewAnimation);
            pgPreview.SelectedObject = PP;
            PreviewThread = new Thread(() => { PP.Run(); });
            PreviewThread.Start();

            // TPP
            TPP = new TilePreviewProperty(ref patsImage, ref cbotpLayer);
            pgTP.SelectedObject = TPP;
            cbotpLayer.SelectedIndex = 0;
            tp.SetToolTip(btntpFill, "Fills the selected layer with the selected image. Note that it fills acording to the image size and it will disregard the grid size.");
            tp.SetToolTip(btntpReset, "Resets all layers (to transparent).");
            tp.SetToolTip(cbotpLayer, "Set the active layer.");

            // Flash it
            cboFlashItStep.SelectedIndex = 4;

            // About
            try
            {
                rtbAbout.Text = System.IO.File.ReadAllText("ReadMe.txt");
            }
            catch { }

            // Title
            Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            Text = string.Format("Napoleon's Sprite Sheet Editor (version {0})", version);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            PreviewThread.Abort();

            if (bm != null)
                bm.Dispose();
            SP.Dispose();
            PP.Dispose();
        }

        #endregion

        #region Merge
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnOpenFiles_Click(object sender, EventArgs e)
        {
            if (ofd1.ShowDialog() != DialogResult.Cancel)
            {
                for (int i = 0; i < ofd1.FileNames.Count(); i++)
                {
                    lstImages.Items.Add(new ImgInfo(ofd1.SafeFileNames[i], ofd1.FileNames[i]));
                    CheckForLstFirstItem();
                }
                RefreshMergeSheet();
            }
        }

        /// <summary>
        /// Call this function after adding one frame to the lstImages.
        /// </summary>
        private void CheckForLstFirstItem()
        {
            if (lstImages.Items.Count == 1)
            {
                ImgInfo info = (ImgInfo)lstImages.Items[0];
                Image img = Util.LoadBMPNoLock(info.FullPath);
                txtFrameWidth.Text = img.Width.ToString();
                txtFrameHeight.Text = img.Height.ToString();
                img.Dispose();
            }
        }

        private void RefreshMergeSheet()
        {
            SaveListBoxToMerge();

            int frameWidth = int.Parse(txtFrameWidth.Text);
            int frameHeight = int.Parse(txtFrameHeight.Text);

            New();
            Graphics g = Graphics.FromImage(bm);
            g.Clear(Color.Transparent);
            for (int rowIdx = 0; rowIdx < int.Parse(txtMergeRowCnt.Text); rowIdx++)
            {
                MergeRow currentMergeRow = MergeRows.Find(m => m.Index == rowIdx);

                for (int i = 0; i < currentMergeRow.ImageInfos.Count; i++)
                {
                    Bitmap frame = new Bitmap(Util.LoadBMPNoLock((currentMergeRow.ImageInfos[i]).FullPath));

                    g.DrawImage(frame, new Rectangle(i * frameWidth, rowIdx * frameHeight, frameWidth, frameHeight));
                    frame.Dispose();
                }
            }

            pbSheet.Size = new Size(bm.Width, bm.Height);

            // Clean up
            g.Dispose();
        }

        private void New()
        {
            bm = new Bitmap(int.Parse(txtFrameWidth.Text) * int.Parse(txtFrameCnt.Text), int.Parse(txtFrameHeight.Text) * int.Parse(txtMergeRowCnt.Text));
            pbSheet.Image = bm;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshMergeSheet();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            ImageFormat imgFormat;
            switch (cboExt.SelectedIndex)
            {
                case 0:
                    imgFormat = ImageFormat.Png;
                    sfd1.Filter = "PNG (*.png)|*.png";
                    break;
                case 1:
                    imgFormat = ImageFormat.Bmp;
                    sfd1.Filter = "BMP (*.bmp)|*.bmp";
                    break;
                case 2:
                    imgFormat = ImageFormat.Jpeg;
                    sfd1.Filter = "JPG (*.jpg)|*.jpg";
                    break;
                default:
                    throw new Exception("case missing");
            }

            if (sfd1.ShowDialog() != DialogResult.Cancel)
                bm.Save(sfd1.FileName, imgFormat);
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (lstImages.SelectedIndex > 0)
            {
                object temp = lstImages.SelectedItem;
                int selIdx = lstImages.SelectedIndex;
                lstImages.Items.RemoveAt(lstImages.SelectedIndex);
                lstImages.Items.Insert(selIdx - 1, temp);
                lstImages.SelectedIndex = selIdx - 1;
                RefreshMergeSheet();
            }
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (lstImages.SelectedIndex != -1 && lstImages.SelectedIndex < lstImages.Items.Count - 1)
            {
                object temp = lstImages.SelectedItem;
                int selIdx = lstImages.SelectedIndex;
                lstImages.Items.RemoveAt(lstImages.SelectedIndex);
                lstImages.Items.Insert(selIdx + 1, temp);
                lstImages.SelectedIndex = selIdx + 1;
                RefreshMergeSheet();
            }
        }

        private void btnDelImage_Click(object sender, EventArgs e)
        {
            while (lstImages.SelectedItems.Count > 0)
                lstImages.Items.RemoveAt(lstImages.SelectedIndices[0]);
        }

        private void Merge_TextChanged(object sender, EventArgs e)
        {
            TextBox txb = (TextBox)sender;
            if (!Util.IsInteger(txb.Text))
            {
                txb.Text = "1";
            }
            else
            {
                if (int.Parse(txb.Text) < 1)
                    txb.Text = "1";
            }

            RefreshMergeSheet();
        }

        #region DragAndDrop merge
        private void lstImages_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lstImages_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
            {
                lstImages.Items.Add(new ImgInfo(Path.GetFileName(s[i]), s[i]));
                CheckForLstFirstItem();
            }

            RefreshMergeSheet();
        }
        #endregion

        private void chkAutoSortLstImages_CheckedChanged(object sender, EventArgs e)
        {
            btnMoveDown.Enabled = btnMoveUp.Enabled = !chkAutoSortLstImages.Checked;
            lstImages.Sorted = chkAutoSortLstImages.Checked;
            RefreshMergeSheet();
        }

        private void btnClearAllMerge_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all merge-images in the currently selected row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                lstImages.Items.Clear();
                RefreshMergeSheet();
            }
        }

        private void txtMergeRowCnt_TextChanged(object sender, EventArgs e)
        {
            // Input validation
            if (!Util.IsInteger(txtMergeRowCnt.Text) || (int.Parse(txtMergeRowCnt.Text) < 1 && int.Parse(txtMergeRowCnt.Text) > 999))
                txtMergeRowCnt.Text = "1";

            cboMergeCurrentRow.Items.Clear();
            for (int i = 0; i < int.Parse(txtMergeRowCnt.Text); i++)
            {
                cboMergeCurrentRow.Items.Add(i.ToString());
            }
            cboMergeCurrentRow.SelectedIndex = 0;

            // Create missing ones
            while (int.Parse(txtMergeRowCnt.Text) >= MergeRows.Count)
            {
                MergeRow mergeRow = new MergeRow(MergeRows.Count - 1);
                MergeRows.Add(mergeRow);
            }

            RefreshMergeSheet();
        }

        void SaveListBoxToMerge()
        {
            // save
            MergeRow mergeRow = MergeRows.Find(m => m.Index == MergeLastSelRow);
            mergeRow.ImageInfos.Clear();
            foreach (ImgInfo imgInfo in lstImages.Items)
                mergeRow.ImageInfos.Add(imgInfo);
        }

        private void cboMergeCurrentRow_SelectedIndexChanged(object sender, EventArgs e)
        {
            int newIdx = int.Parse(cboMergeCurrentRow.Text);

            SaveListBoxToMerge();

            // load
            MergeRow mergeRow = MergeRows.Find(m => m.Index == newIdx);
            lstImages.Items.Clear();
            foreach (ImgInfo imgInfo in mergeRow.ImageInfos)
                lstImages.Items.Add(imgInfo);

            MergeLastSelRow = newIdx;
        }

        private void btntpReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset all layers?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                TPP.Reset();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #endregion

        #region Split
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnSaveSplitAs_Click(object sender, EventArgs e)
        {
            if (SP.Image != null)
            {
                SaveFileDialog sfdSplit = new SaveFileDialog();
                sfdSplit.Filter = "Png|*.png|JPeg Image (*.jpg)|*.jpg|Bitmap Image (*.bmp)|*.bmp|All files (*.*)|*.*";
                if (sfdSplit.ShowDialog() != DialogResult.Cancel)
                    SP.SaveAs(sfdSplit.FileName);
                sfdSplit = null;
            }
            else
                MessageBox.Show("You must load an image to split first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void paSplitFill_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            SP.Image = Util.LoadBMPNoLock(s[0]);

            pgSplit.Refresh();
        }

        private void btnSplitReplaceColor_Click(object sender, EventArgs e)
        {
            frmSelectReplaceColor frmSelectReplaceColor = new SpriteSheetEditor.frmSelectReplaceColor(SP.NewReplaceColor);
            SP.IsReplacing = frmSelectReplaceColor.ShowDialog() == DialogResult.OK;
            if (SP.IsReplacing)
                SP.NewReplaceColor = frmSelectReplaceColor.SelectedColor;
        }

        private void pbSplit_MouseClick(object sender, MouseEventArgs e)
        {
            if (SP.IsReplacing)
            {
                SP.Image.ReplaceColor(Util.GetScreenPixel(Cursor.Position), SP.NewReplaceColor);
                SP.RefreshSplit();
                SP.IsReplacing = false;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #endregion

        #region Preview
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void paPreviewFill_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            PP.Image = Util.LoadBMPNoLock(s[0]);

            pgPreview.Refresh();
        }

        private void btnUseMergeForPreview_Click(object sender, EventArgs e)
        {
            if (lstImages.Items.Count > 0)
            {
                // Frame cnt
                PP.FrameCount = int.Parse(txtFrameCnt.Text) * int.Parse(txtMergeRowCnt.Text);

                // Clear the preview folder
                if (File.Exists(Global.PREVIEW_PATH))
                {
                    // Delete the previous temp file
                    File.Delete(Global.PREVIEW_PATH);
                }
                bm.Save(Global.PREVIEW_PATH, ImageFormat.Png); // Save temp image
                PP.Image = Util.LoadBMPNoLock(Global.PREVIEW_PATH); // Load temp image

                // Frame width & height
                PP.FrameWidth = int.Parse(txtFrameWidth.Text);
                PP.FrameHeight = int.Parse(txtFrameHeight.Text);

                // Refresh to show the newly set values
                pgPreview.Refresh();
            }
            else
                MessageBox.Show("There are no items in the merge-tab.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #endregion

        #region Tiling Test
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btntpSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdTP = new SaveFileDialog();
            sfdTP.Filter = "Png|*.png|JPeg Image (*.jpg)|*.jpg|Bitmap Image (*.bmp)|*.bmp|All files (*.*)|*.*";
            if (sfdTP.ShowDialog() != DialogResult.Cancel)
                TPP.SaveAs(sfdTP.FileName);
            sfdTP = null;
        }

        private void patsImage_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < s.Length; i++)
            {
                if (Util.IsImage(s[i]))
                {
                    Point c = patsImage.PointToClient(Cursor.Position);
                    TPP.AddImage(new Point(c.X + patsImage.HorizontalScroll.Value, c.Y + patsImage.VerticalScroll.Value), Util.LoadBMPNoLock(s[i]));
                }
            }
        }

        private void patsImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (TPP.Image != null)
                {
                    Point c = patsImage.PointToClient(Cursor.Position);
                    TPP.AddImage(new Point(c.X + patsImage.HorizontalScroll.Value, c.Y + patsImage.VerticalScroll.Value), TPP.Image);
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                Point c = patsImage.PointToClient(Cursor.Position);
                TPP.DelSection(new Point(c.X + patsImage.HorizontalScroll.Value, c.Y + patsImage.VerticalScroll.Value));
            }
        }

        private void btntpHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Left mouse button: Place image." + Environment.NewLine + "Right mouse button: delete the tile underneath the mouse cursor for the selected layer." + Environment.NewLine + "Drag & Drop of images onto the grid is allowed.");
        }

        private void btntpFill_Click(object sender, EventArgs e)
        {
            if (TPP.Image == null)
                MessageBox.Show("You must set an image in the property grid first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                TPP.FillCurrentLayer(TPP.Image);
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #endregion

        #region Shared
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void MouseMove_SetCoordinates(object sender, MouseEventArgs e)
        {
            Point p = ((Control)sender).PointToClient(Cursor.Position);
            tslbl1.Text = string.Format("X:{0} Y:{0}", p.X, p.Y);
        }

        private void Generic_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #endregion

        #region Flash It
        public void FlashIt_Refresh()
        {
            if (pbFlashItSourceImg.Image != null)
            {
                int stepSize = int.Parse(cboFlashItStep.Text);
                int currentStep = 100;
                int frameCnt = 100 / stepSize;

                // Create the new sheet (empty)
                Bitmap newSheet = new Bitmap(frameCnt * pbFlashItSourceImg.Image.Width, pbFlashItSourceImg.Image.Height);

                using (var g = Graphics.FromImage(newSheet))
                {
                    // Set the background color
                    if (chkFlashItTransBG.Checked)
                        g.Clear(Color.Transparent);
                    else
                        g.Clear(paFlashItFillColor.BackColor);

                    // From opaque -> transparant
                    for (int x = 0; x < frameCnt; x++)
                    {
                        Image temp = new Bitmap(pbFlashItSourceImg.Image);
                        temp = Util.SetImageOpacity(temp, currentStep);
                        g.DrawImage(temp, new Point(x * pbFlashItSourceImg.Image.Width, 0));
                        temp.Dispose();
                        currentStep -= stepSize;
                    }
                }

                if (chkFlashItMirror.Checked)
                { // And back from transparant -> opaque
                    Bitmap sheet = new Bitmap(newSheet);
                    newSheet = new Bitmap(frameCnt * pbFlashItSourceImg.Image.Width * 2 - pbFlashItSourceImg.Image.Width, pbFlashItSourceImg.Image.Height);

                    using (var g = Graphics.FromImage(newSheet))
                    {
                        // Set the background color
                        if (chkFlashItTransBG.Checked)
                            g.Clear(Color.Transparent);
                        else
                            g.Clear(paFlashItFillColor.BackColor);

                        // Draw the previous drawing back onto the new sheet
                        using (var g2 = Graphics.FromImage(newSheet))
                        {
                            g2.DrawImage(sheet, Point.Empty);
                        }

                        // Get the start location X for the new drawings
                        int startLocX = sheet.Width - pbFlashItSourceImg.Image.Width;

                        // Dispose the temporary sheet
                        sheet.Dispose();

                        currentStep = stepSize * 2; // skip the first step
                        for (int x = 1; x < frameCnt; x++)
                        {
                            Image temp = new Bitmap(pbFlashItSourceImg.Image);
                            temp = Util.SetImageOpacity(temp, currentStep);
                            g.DrawImage(temp, new Point(startLocX + x * pbFlashItSourceImg.Image.Width, 0));
                            temp.Dispose();
                            currentStep += stepSize;
                        }
                    }
                }

                // More clean up (is this necessary?)
                if (pbFlashItSheet.Image != null)
                {
                    pbFlashItSheet.Image.Dispose();
                    pbFlashItSheet.Image = null;
                }

                // Assign the new sheet to the picturebox and refresh it
                pbFlashItSheet.Image = newSheet;
                pbFlashItSheet.Refresh();

                // Set the frame count
                lblFlashItFrameCnt.Text = (newSheet.Width / pbFlashItSourceImg.Image.Width).ToString();
            }
        }

        private void btnFlashItBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = Util.CreateOpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pbFlashItSourceImg.Image = Util.LoadBMPNoLock(dialog.FileName);
                FlashIt_Refresh();
            }
        }

        private void paFlashItFillColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                paFlashItFillColor.BackColor = dialog.Color;
                FlashIt_Refresh();
            }
        }

        private void chkFlashItTransBG_CheckedChanged(object sender, EventArgs e)
        {
            lblFlashItBGColor.Visible = paFlashItFillColor.Visible = !chkFlashItTransBG.Checked;
            FlashIt_Refresh();
        }

        private void chkFlashItMirror_CheckedChanged(object sender, EventArgs e)
        {
            FlashIt_Refresh();
        }

        private void cboFlashItStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            FlashIt_Refresh();
        }

        private void btnFlashItSaveAs_Click(object sender, EventArgs e)
        {
            if (pbFlashItSourceImg.Image != null)
            {
                SaveFileDialog dialog = Util.CreateSaveFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string ext = Path.GetExtension(dialog.FileName);
                        ImageFormat imageFormat;

                        switch (ext.ToLower())
                        {
                            case ".jpg":
                                imageFormat = ImageFormat.Jpeg;
                                break;
                            case ".jpeg":
                                imageFormat = ImageFormat.Jpeg;
                                break;
                            case ".bmp":
                                imageFormat = ImageFormat.Bmp;
                                break;
                            case ".gif":
                                imageFormat = ImageFormat.Gif;
                                break;
                            case ".png":
                                imageFormat = ImageFormat.Png;
                                break;
                            default:
                                MessageBox.Show(string.Format("btnFlashItSaveAs_Click: Unknown extension: {0}", ext), "Save failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                        }

                        pbFlashItSheet.Image.Save(dialog.FileName, imageFormat);
                        MessageBox.Show("Save succesful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Save failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("There is nothing to save.", "Nothing to save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}