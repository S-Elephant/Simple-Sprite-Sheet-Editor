namespace SpriteSheetEditor
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.sfd1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.paMergeFill = new System.Windows.Forms.Panel();
            this.pbSheet = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMergeRowCnt = new System.Windows.Forms.TextBox();
            this.cboMergeCurrentRow = new System.Windows.Forms.ComboBox();
            this.btnClearAllMerge = new System.Windows.Forms.Button();
            this.imgList16px = new System.Windows.Forms.ImageList(this.components);
            this.chkAutoSortLstImages = new System.Windows.Forms.CheckBox();
            this.btnDelImage = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboExt = new System.Windows.Forms.ComboBox();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFrameHeight = new System.Windows.Forms.TextBox();
            this.txtFrameWidth = new System.Windows.Forms.TextBox();
            this.txtFrameCnt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstImages = new System.Windows.Forms.ListBox();
            this.btnOpenFiles = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.paSplitFill = new System.Windows.Forms.Panel();
            this.pbSplit = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSplitReplaceColor = new System.Windows.Forms.Button();
            this.btnSaveSplitAs = new System.Windows.Forms.Button();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.pgSplit = new System.Windows.Forms.PropertyGrid();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnUseMergeForPreview = new System.Windows.Forms.Button();
            this.paPreviewFill = new System.Windows.Forms.Panel();
            this.pbPreviewAnimation = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pgPreview = new System.Windows.Forms.PropertyGrid();
            this.tpTilePreview = new System.Windows.Forms.TabPage();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.patsRight = new System.Windows.Forms.Panel();
            this.patsImage = new System.Windows.Forms.Panel();
            this.patsLeft = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pgTP = new System.Windows.Forms.PropertyGrid();
            this.splitter6 = new System.Windows.Forms.Splitter();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btntpFill = new System.Windows.Forms.Button();
            this.btntpHelp = new System.Windows.Forms.Button();
            this.cbotpLayer = new System.Windows.Forms.ComboBox();
            this.btntpReset = new System.Windows.Forms.Button();
            this.btntpSaveAs = new System.Windows.Forms.Button();
            this.tpFlashIt = new System.Windows.Forms.TabPage();
            this.paFlashItFill = new System.Windows.Forms.Panel();
            this.pbFlashItSheet = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFlashItFrameCnt = new System.Windows.Forms.Label();
            this.btnFlashItSaveAs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFlashItBGColor = new System.Windows.Forms.Label();
            this.paFlashItFillColor = new System.Windows.Forms.Panel();
            this.chkFlashItTransBG = new System.Windows.Forms.CheckBox();
            this.cboFlashItStep = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkFlashItMirror = new System.Windows.Forms.CheckBox();
            this.btnFlashItBrowse = new System.Windows.Forms.Button();
            this.pbFlashItSourceImg = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rtbAbout = new System.Windows.Forms.RichTextBox();
            this.timPreview = new System.Windows.Forms.Timer(this.components);
            this.timFPS = new System.Windows.Forms.Timer(this.components);
            this.ss1 = new System.Windows.Forms.StatusStrip();
            this.tslbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslbl2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.paMergeFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSheet)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.paSplitFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSplit)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.paPreviewFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewAnimation)).BeginInit();
            this.tpTilePreview.SuspendLayout();
            this.patsRight.SuspendLayout();
            this.patsLeft.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tpFlashIt.SuspendLayout();
            this.paFlashItFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlashItSheet)).BeginInit();
            this.panel10.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlashItSourceImg)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.ss1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            this.ofd1.Multiselect = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tpTilePreview);
            this.tabControl1.Controls.Add(this.tpFlashIt);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 452);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitter2);
            this.tabPage1.Controls.Add(this.paMergeFill);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1008, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Merge";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(157, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 420);
            this.splitter2.TabIndex = 10;
            this.splitter2.TabStop = false;
            // 
            // paMergeFill
            // 
            this.paMergeFill.AllowDrop = true;
            this.paMergeFill.AutoScroll = true;
            this.paMergeFill.Controls.Add(this.pbSheet);
            this.paMergeFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paMergeFill.Location = new System.Drawing.Point(157, 3);
            this.paMergeFill.Name = "paMergeFill";
            this.paMergeFill.Size = new System.Drawing.Size(848, 420);
            this.paMergeFill.TabIndex = 9;
            this.paMergeFill.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstImages_DragDrop);
            this.paMergeFill.DragEnter += new System.Windows.Forms.DragEventHandler(this.Generic_DragEnter);
            // 
            // pbSheet
            // 
            this.pbSheet.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbSheet.Location = new System.Drawing.Point(20, 17);
            this.pbSheet.Name = "pbSheet";
            this.pbSheet.Size = new System.Drawing.Size(256, 256);
            this.pbSheet.TabIndex = 0;
            this.pbSheet.TabStop = false;
            this.pbSheet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_SetCoordinates);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMergeRowCnt);
            this.panel1.Controls.Add(this.cboMergeCurrentRow);
            this.panel1.Controls.Add(this.btnClearAllMerge);
            this.panel1.Controls.Add(this.chkAutoSortLstImages);
            this.panel1.Controls.Add(this.btnDelImage);
            this.panel1.Controls.Add(this.btnMoveDown);
            this.panel1.Controls.Add(this.btnMoveUp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboExt);
            this.panel1.Controls.Add(this.btnSaveAs);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFrameHeight);
            this.panel1.Controls.Add(this.txtFrameWidth);
            this.panel1.Controls.Add(this.txtFrameCnt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lstImages);
            this.panel1.Controls.Add(this.btnOpenFiles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 420);
            this.panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Row Count";
            // 
            // txtMergeRowCnt
            // 
            this.txtMergeRowCnt.Location = new System.Drawing.Point(77, 259);
            this.txtMergeRowCnt.Name = "txtMergeRowCnt";
            this.txtMergeRowCnt.Size = new System.Drawing.Size(42, 20);
            this.txtMergeRowCnt.TabIndex = 14;
            this.txtMergeRowCnt.Text = "1";
            this.txtMergeRowCnt.TextChanged += new System.EventHandler(this.txtMergeRowCnt_TextChanged);
            // 
            // cboMergeCurrentRow
            // 
            this.cboMergeCurrentRow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMergeCurrentRow.FormattingEnabled = true;
            this.cboMergeCurrentRow.Items.AddRange(new object[] {
            "0"});
            this.cboMergeCurrentRow.Location = new System.Drawing.Point(7, 229);
            this.cboMergeCurrentRow.Name = "cboMergeCurrentRow";
            this.cboMergeCurrentRow.Size = new System.Drawing.Size(121, 21);
            this.cboMergeCurrentRow.TabIndex = 12;
            this.cboMergeCurrentRow.SelectedIndexChanged += new System.EventHandler(this.cboMergeCurrentRow_SelectedIndexChanged);
            // 
            // btnClearAllMerge
            // 
            this.btnClearAllMerge.ImageKey = "redCross16px.png";
            this.btnClearAllMerge.ImageList = this.imgList16px;
            this.btnClearAllMerge.Location = new System.Drawing.Point(130, 196);
            this.btnClearAllMerge.Name = "btnClearAllMerge";
            this.btnClearAllMerge.Size = new System.Drawing.Size(24, 24);
            this.btnClearAllMerge.TabIndex = 11;
            this.btnClearAllMerge.UseVisualStyleBackColor = true;
            this.btnClearAllMerge.Click += new System.EventHandler(this.btnClearAllMerge_Click);
            // 
            // imgList16px
            // 
            this.imgList16px.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList16px.ImageStream")));
            this.imgList16px.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList16px.Images.SetKeyName(0, "arrowBlueDown_48px.png");
            this.imgList16px.Images.SetKeyName(1, "arrowBlueUp_48px.png");
            this.imgList16px.Images.SetKeyName(2, "redCross16px.png");
            // 
            // chkAutoSortLstImages
            // 
            this.chkAutoSortLstImages.AutoSize = true;
            this.chkAutoSortLstImages.Checked = true;
            this.chkAutoSortLstImages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoSortLstImages.Location = new System.Drawing.Point(109, 285);
            this.chkAutoSortLstImages.Name = "chkAutoSortLstImages";
            this.chkAutoSortLstImages.Size = new System.Drawing.Size(45, 17);
            this.chkAutoSortLstImages.TabIndex = 10;
            this.chkAutoSortLstImages.Text = "Sort";
            this.chkAutoSortLstImages.UseVisualStyleBackColor = true;
            this.chkAutoSortLstImages.CheckedChanged += new System.EventHandler(this.chkAutoSortLstImages_CheckedChanged);
            // 
            // btnDelImage
            // 
            this.btnDelImage.ImageKey = "redCross16px.png";
            this.btnDelImage.ImageList = this.imgList16px;
            this.btnDelImage.Location = new System.Drawing.Point(130, 166);
            this.btnDelImage.Name = "btnDelImage";
            this.btnDelImage.Size = new System.Drawing.Size(24, 24);
            this.btnDelImage.TabIndex = 7;
            this.btnDelImage.UseVisualStyleBackColor = true;
            this.btnDelImage.Click += new System.EventHandler(this.btnDelImage_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Enabled = false;
            this.btnMoveDown.ImageKey = "arrowBlueDown_48px.png";
            this.btnMoveDown.ImageList = this.imgList16px;
            this.btnMoveDown.Location = new System.Drawing.Point(130, 136);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(24, 24);
            this.btnMoveDown.TabIndex = 6;
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Enabled = false;
            this.btnMoveUp.ImageKey = "arrowBlueUp_48px.png";
            this.btnMoveUp.ImageList = this.imgList16px;
            this.btnMoveUp.Location = new System.Drawing.Point(130, 107);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(24, 24);
            this.btnMoveUp.TabIndex = 5;
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Frame Size";
            // 
            // cboExt
            // 
            this.cboExt.FormattingEnabled = true;
            this.cboExt.Items.AddRange(new object[] {
            "PNG",
            "BMP",
            "JPEG"});
            this.cboExt.Location = new System.Drawing.Point(12, 389);
            this.cboExt.Name = "cboExt";
            this.cboExt.Size = new System.Drawing.Size(121, 21);
            this.cboExt.TabIndex = 1;
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(77, 360);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAs.TabIndex = 8;
            this.btnSaveAs.Text = "Save as...";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(3, 360);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "X";
            // 
            // txtFrameHeight
            // 
            this.txtFrameHeight.Location = new System.Drawing.Point(77, 308);
            this.txtFrameHeight.Name = "txtFrameHeight";
            this.txtFrameHeight.Size = new System.Drawing.Size(42, 20);
            this.txtFrameHeight.TabIndex = 2;
            this.txtFrameHeight.Text = "64";
            this.txtFrameHeight.TextChanged += new System.EventHandler(this.Merge_TextChanged);
            // 
            // txtFrameWidth
            // 
            this.txtFrameWidth.Location = new System.Drawing.Point(14, 308);
            this.txtFrameWidth.Name = "txtFrameWidth";
            this.txtFrameWidth.Size = new System.Drawing.Size(42, 20);
            this.txtFrameWidth.TabIndex = 1;
            this.txtFrameWidth.Text = "64";
            this.txtFrameWidth.TextChanged += new System.EventHandler(this.Merge_TextChanged);
            // 
            // txtFrameCnt
            // 
            this.txtFrameCnt.Location = new System.Drawing.Point(77, 334);
            this.txtFrameCnt.Name = "txtFrameCnt";
            this.txtFrameCnt.Size = new System.Drawing.Size(42, 20);
            this.txtFrameCnt.TabIndex = 3;
            this.txtFrameCnt.Text = "8";
            this.txtFrameCnt.TextChanged += new System.EventHandler(this.Merge_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Frame Count";
            // 
            // lstImages
            // 
            this.lstImages.AllowDrop = true;
            this.lstImages.FormattingEnabled = true;
            this.lstImages.HorizontalScrollbar = true;
            this.lstImages.Location = new System.Drawing.Point(7, 32);
            this.lstImages.Name = "lstImages";
            this.lstImages.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstImages.Size = new System.Drawing.Size(121, 199);
            this.lstImages.TabIndex = 9;
            this.lstImages.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstImages_DragDrop);
            this.lstImages.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstImages_DragEnter);
            // 
            // btnOpenFiles
            // 
            this.btnOpenFiles.Location = new System.Drawing.Point(3, 3);
            this.btnOpenFiles.Name = "btnOpenFiles";
            this.btnOpenFiles.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFiles.TabIndex = 0;
            this.btnOpenFiles.Text = "Open File(s)";
            this.btnOpenFiles.UseVisualStyleBackColor = true;
            this.btnOpenFiles.Click += new System.EventHandler(this.btnOpenFiles_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitter3);
            this.tabPage2.Controls.Add(this.paSplitFill);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1008, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Split";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(203, 3);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 420);
            this.splitter3.TabIndex = 2;
            this.splitter3.TabStop = false;
            // 
            // paSplitFill
            // 
            this.paSplitFill.AllowDrop = true;
            this.paSplitFill.AutoScroll = true;
            this.paSplitFill.Controls.Add(this.pbSplit);
            this.paSplitFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paSplitFill.Location = new System.Drawing.Point(203, 3);
            this.paSplitFill.Name = "paSplitFill";
            this.paSplitFill.Size = new System.Drawing.Size(802, 420);
            this.paSplitFill.TabIndex = 1;
            this.paSplitFill.DragDrop += new System.Windows.Forms.DragEventHandler(this.paSplitFill_DragDrop);
            this.paSplitFill.DragEnter += new System.Windows.Forms.DragEventHandler(this.Generic_DragEnter);
            // 
            // pbSplit
            // 
            this.pbSplit.BackColor = System.Drawing.Color.Transparent;
            this.pbSplit.Location = new System.Drawing.Point(20, 12);
            this.pbSplit.Name = "pbSplit";
            this.pbSplit.Size = new System.Drawing.Size(100, 50);
            this.pbSplit.TabIndex = 0;
            this.pbSplit.TabStop = false;
            this.pbSplit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbSplit_MouseClick);
            this.pbSplit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_SetCoordinates);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.splitter4);
            this.panel4.Controls.Add(this.pgSplit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 420);
            this.panel4.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnSplitReplaceColor);
            this.panel6.Controls.Add(this.btnSaveSplitAs);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 29);
            this.panel6.TabIndex = 2;
            // 
            // btnSplitReplaceColor
            // 
            this.btnSplitReplaceColor.Location = new System.Drawing.Point(86, 3);
            this.btnSplitReplaceColor.Name = "btnSplitReplaceColor";
            this.btnSplitReplaceColor.Size = new System.Drawing.Size(108, 23);
            this.btnSplitReplaceColor.TabIndex = 1;
            this.btnSplitReplaceColor.Text = "Replace Color";
            this.btnSplitReplaceColor.UseVisualStyleBackColor = true;
            this.btnSplitReplaceColor.Click += new System.EventHandler(this.btnSplitReplaceColor_Click);
            // 
            // btnSaveSplitAs
            // 
            this.btnSaveSplitAs.Location = new System.Drawing.Point(5, 3);
            this.btnSaveSplitAs.Name = "btnSaveSplitAs";
            this.btnSaveSplitAs.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSplitAs.TabIndex = 0;
            this.btnSaveSplitAs.Text = "Save as...";
            this.btnSaveSplitAs.UseVisualStyleBackColor = true;
            this.btnSaveSplitAs.Click += new System.EventHandler(this.btnSaveSplitAs_Click);
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter4.Location = new System.Drawing.Point(0, 29);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(200, 3);
            this.splitter4.TabIndex = 1;
            this.splitter4.TabStop = false;
            // 
            // pgSplit
            // 
            this.pgSplit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgSplit.Location = new System.Drawing.Point(0, 32);
            this.pgSplit.Name = "pgSplit";
            this.pgSplit.Size = new System.Drawing.Size(200, 388);
            this.pgSplit.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnUseMergeForPreview);
            this.tabPage3.Controls.Add(this.paPreviewFill);
            this.tabPage3.Controls.Add(this.splitter1);
            this.tabPage3.Controls.Add(this.pgPreview);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1008, 426);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Preview";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnUseMergeForPreview
            // 
            this.btnUseMergeForPreview.Location = new System.Drawing.Point(90, 3);
            this.btnUseMergeForPreview.Name = "btnUseMergeForPreview";
            this.btnUseMergeForPreview.Size = new System.Drawing.Size(90, 23);
            this.btnUseMergeForPreview.TabIndex = 17;
            this.btnUseMergeForPreview.Text = "Use merge img";
            this.btnUseMergeForPreview.UseVisualStyleBackColor = true;
            this.btnUseMergeForPreview.Click += new System.EventHandler(this.btnUseMergeForPreview_Click);
            // 
            // paPreviewFill
            // 
            this.paPreviewFill.AllowDrop = true;
            this.paPreviewFill.AutoScroll = true;
            this.paPreviewFill.BackColor = System.Drawing.Color.Silver;
            this.paPreviewFill.Controls.Add(this.pbPreviewAnimation);
            this.paPreviewFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paPreviewFill.Location = new System.Drawing.Point(186, 3);
            this.paPreviewFill.Name = "paPreviewFill";
            this.paPreviewFill.Size = new System.Drawing.Size(819, 420);
            this.paPreviewFill.TabIndex = 18;
            this.paPreviewFill.DragDrop += new System.Windows.Forms.DragEventHandler(this.paPreviewFill_DragDrop);
            this.paPreviewFill.DragEnter += new System.Windows.Forms.DragEventHandler(this.Generic_DragEnter);
            // 
            // pbPreviewAnimation
            // 
            this.pbPreviewAnimation.BackColor = System.Drawing.Color.White;
            this.pbPreviewAnimation.Location = new System.Drawing.Point(16, 14);
            this.pbPreviewAnimation.Name = "pbPreviewAnimation";
            this.pbPreviewAnimation.Size = new System.Drawing.Size(721, 340);
            this.pbPreviewAnimation.TabIndex = 16;
            this.pbPreviewAnimation.TabStop = false;
            this.pbPreviewAnimation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_SetCoordinates);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(183, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 420);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // pgPreview
            // 
            this.pgPreview.Dock = System.Windows.Forms.DockStyle.Left;
            this.pgPreview.Location = new System.Drawing.Point(3, 3);
            this.pgPreview.Name = "pgPreview";
            this.pgPreview.Size = new System.Drawing.Size(180, 420);
            this.pgPreview.TabIndex = 13;
            // 
            // tpTilePreview
            // 
            this.tpTilePreview.Controls.Add(this.splitter5);
            this.tpTilePreview.Controls.Add(this.patsRight);
            this.tpTilePreview.Controls.Add(this.patsLeft);
            this.tpTilePreview.Location = new System.Drawing.Point(4, 22);
            this.tpTilePreview.Name = "tpTilePreview";
            this.tpTilePreview.Size = new System.Drawing.Size(1008, 426);
            this.tpTilePreview.TabIndex = 4;
            this.tpTilePreview.Text = "Tiling Test";
            this.tpTilePreview.UseVisualStyleBackColor = true;
            // 
            // splitter5
            // 
            this.splitter5.Location = new System.Drawing.Point(200, 0);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(3, 426);
            this.splitter5.TabIndex = 2;
            this.splitter5.TabStop = false;
            // 
            // patsRight
            // 
            this.patsRight.AutoScroll = true;
            this.patsRight.Controls.Add(this.patsImage);
            this.patsRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patsRight.Location = new System.Drawing.Point(200, 0);
            this.patsRight.Name = "patsRight";
            this.patsRight.Size = new System.Drawing.Size(808, 426);
            this.patsRight.TabIndex = 1;
            // 
            // patsImage
            // 
            this.patsImage.AllowDrop = true;
            this.patsImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.patsImage.Location = new System.Drawing.Point(0, 0);
            this.patsImage.Name = "patsImage";
            this.patsImage.Size = new System.Drawing.Size(305, 249);
            this.patsImage.TabIndex = 1;
            this.patsImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.patsImage_DragDrop);
            this.patsImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.Generic_DragEnter);
            this.patsImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.patsImage_MouseDown);
            this.patsImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_SetCoordinates);
            // 
            // patsLeft
            // 
            this.patsLeft.Controls.Add(this.panel8);
            this.patsLeft.Controls.Add(this.splitter6);
            this.patsLeft.Controls.Add(this.panel7);
            this.patsLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.patsLeft.Location = new System.Drawing.Point(0, 0);
            this.patsLeft.Name = "patsLeft";
            this.patsLeft.Size = new System.Drawing.Size(200, 426);
            this.patsLeft.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pgTP);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 93);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 333);
            this.panel8.TabIndex = 0;
            // 
            // pgTP
            // 
            this.pgTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgTP.Location = new System.Drawing.Point(0, 0);
            this.pgTP.Name = "pgTP";
            this.pgTP.Size = new System.Drawing.Size(200, 333);
            this.pgTP.TabIndex = 0;
            // 
            // splitter6
            // 
            this.splitter6.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter6.Location = new System.Drawing.Point(0, 90);
            this.splitter6.Name = "splitter6";
            this.splitter6.Size = new System.Drawing.Size(200, 3);
            this.splitter6.TabIndex = 1;
            this.splitter6.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btntpFill);
            this.panel7.Controls.Add(this.btntpHelp);
            this.panel7.Controls.Add(this.cbotpLayer);
            this.panel7.Controls.Add(this.btntpReset);
            this.panel7.Controls.Add(this.btntpSaveAs);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 90);
            this.panel7.TabIndex = 0;
            // 
            // btntpFill
            // 
            this.btntpFill.Location = new System.Drawing.Point(59, 3);
            this.btntpFill.Name = "btntpFill";
            this.btntpFill.Size = new System.Drawing.Size(44, 23);
            this.btntpFill.TabIndex = 2;
            this.btntpFill.Text = "Fill";
            this.btntpFill.UseVisualStyleBackColor = true;
            this.btntpFill.Click += new System.EventHandler(this.btntpFill_Click);
            // 
            // btntpHelp
            // 
            this.btntpHelp.Location = new System.Drawing.Point(8, 3);
            this.btntpHelp.Name = "btntpHelp";
            this.btntpHelp.Size = new System.Drawing.Size(45, 23);
            this.btntpHelp.TabIndex = 2;
            this.btntpHelp.Text = "Help";
            this.btntpHelp.UseVisualStyleBackColor = true;
            this.btntpHelp.Click += new System.EventHandler(this.btntpHelp_Click);
            // 
            // cbotpLayer
            // 
            this.cbotpLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotpLayer.FormattingEnabled = true;
            this.cbotpLayer.Items.AddRange(new object[] {
            "Layer 0",
            "Layer 1",
            "Layer 2",
            "Layer 3",
            "Layer 4"});
            this.cbotpLayer.Location = new System.Drawing.Point(8, 61);
            this.cbotpLayer.Name = "cbotpLayer";
            this.cbotpLayer.Size = new System.Drawing.Size(186, 21);
            this.cbotpLayer.TabIndex = 1;
            // 
            // btntpReset
            // 
            this.btntpReset.Location = new System.Drawing.Point(109, 3);
            this.btntpReset.Name = "btntpReset";
            this.btntpReset.Size = new System.Drawing.Size(85, 23);
            this.btntpReset.TabIndex = 1;
            this.btntpReset.Text = "Reset";
            this.btntpReset.UseVisualStyleBackColor = true;
            this.btntpReset.Click += new System.EventHandler(this.btntpReset_Click);
            // 
            // btntpSaveAs
            // 
            this.btntpSaveAs.Location = new System.Drawing.Point(8, 32);
            this.btntpSaveAs.Name = "btntpSaveAs";
            this.btntpSaveAs.Size = new System.Drawing.Size(186, 23);
            this.btntpSaveAs.TabIndex = 0;
            this.btntpSaveAs.Text = "Save as...";
            this.btntpSaveAs.UseVisualStyleBackColor = true;
            this.btntpSaveAs.Click += new System.EventHandler(this.btntpSaveAs_Click);
            // 
            // tpFlashIt
            // 
            this.tpFlashIt.Controls.Add(this.paFlashItFill);
            this.tpFlashIt.Controls.Add(this.panel10);
            this.tpFlashIt.Location = new System.Drawing.Point(4, 22);
            this.tpFlashIt.Name = "tpFlashIt";
            this.tpFlashIt.Size = new System.Drawing.Size(1008, 426);
            this.tpFlashIt.TabIndex = 5;
            this.tpFlashIt.Text = "Flash It";
            this.tpFlashIt.UseVisualStyleBackColor = true;
            // 
            // paFlashItFill
            // 
            this.paFlashItFill.AutoScroll = true;
            this.paFlashItFill.Controls.Add(this.pbFlashItSheet);
            this.paFlashItFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paFlashItFill.Location = new System.Drawing.Point(126, 0);
            this.paFlashItFill.Name = "paFlashItFill";
            this.paFlashItFill.Size = new System.Drawing.Size(882, 426);
            this.paFlashItFill.TabIndex = 1;
            // 
            // pbFlashItSheet
            // 
            this.pbFlashItSheet.BackColor = System.Drawing.Color.Gainsboro;
            this.pbFlashItSheet.Location = new System.Drawing.Point(20, 20);
            this.pbFlashItSheet.Name = "pbFlashItSheet";
            this.pbFlashItSheet.Size = new System.Drawing.Size(200, 200);
            this.pbFlashItSheet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFlashItSheet.TabIndex = 0;
            this.pbFlashItSheet.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label6);
            this.panel10.Controls.Add(this.lblFlashItFrameCnt);
            this.panel10.Controls.Add(this.btnFlashItSaveAs);
            this.panel10.Controls.Add(this.groupBox1);
            this.panel10.Controls.Add(this.cboFlashItStep);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.chkFlashItMirror);
            this.panel10.Controls.Add(this.btnFlashItBrowse);
            this.panel10.Controls.Add(this.pbFlashItSourceImg);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(126, 426);
            this.panel10.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Frame Count:";
            // 
            // lblFlashItFrameCnt
            // 
            this.lblFlashItFrameCnt.AutoSize = true;
            this.lblFlashItFrameCnt.Location = new System.Drawing.Point(72, 208);
            this.lblFlashItFrameCnt.Name = "lblFlashItFrameCnt";
            this.lblFlashItFrameCnt.Size = new System.Drawing.Size(13, 13);
            this.lblFlashItFrameCnt.TabIndex = 1;
            this.lblFlashItFrameCnt.Text = "0";
            // 
            // btnFlashItSaveAs
            // 
            this.btnFlashItSaveAs.Location = new System.Drawing.Point(7, 350);
            this.btnFlashItSaveAs.Name = "btnFlashItSaveAs";
            this.btnFlashItSaveAs.Size = new System.Drawing.Size(110, 23);
            this.btnFlashItSaveAs.TabIndex = 1;
            this.btnFlashItSaveAs.Text = "Save As...";
            this.btnFlashItSaveAs.UseVisualStyleBackColor = true;
            this.btnFlashItSaveAs.Click += new System.EventHandler(this.btnFlashItSaveAs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFlashItBGColor);
            this.groupBox1.Controls.Add(this.paFlashItFillColor);
            this.groupBox1.Controls.Add(this.chkFlashItTransBG);
            this.groupBox1.Location = new System.Drawing.Point(7, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Background color";
            // 
            // lblFlashItBGColor
            // 
            this.lblFlashItBGColor.AutoSize = true;
            this.lblFlashItBGColor.Location = new System.Drawing.Point(11, 41);
            this.lblFlashItBGColor.Name = "lblFlashItBGColor";
            this.lblFlashItBGColor.Size = new System.Drawing.Size(91, 13);
            this.lblFlashItBGColor.TabIndex = 1;
            this.lblFlashItBGColor.Text = "Background color";
            this.lblFlashItBGColor.Visible = false;
            // 
            // paFlashItFillColor
            // 
            this.paFlashItFillColor.BackColor = System.Drawing.Color.White;
            this.paFlashItFillColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paFlashItFillColor.Location = new System.Drawing.Point(14, 62);
            this.paFlashItFillColor.Name = "paFlashItFillColor";
            this.paFlashItFillColor.Size = new System.Drawing.Size(85, 25);
            this.paFlashItFillColor.TabIndex = 1;
            this.paFlashItFillColor.Visible = false;
            this.paFlashItFillColor.Click += new System.EventHandler(this.paFlashItFillColor_Click);
            // 
            // chkFlashItTransBG
            // 
            this.chkFlashItTransBG.AutoSize = true;
            this.chkFlashItTransBG.Checked = true;
            this.chkFlashItTransBG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFlashItTransBG.Location = new System.Drawing.Point(9, 16);
            this.chkFlashItTransBG.Name = "chkFlashItTransBG";
            this.chkFlashItTransBG.Size = new System.Drawing.Size(90, 17);
            this.chkFlashItTransBG.TabIndex = 1;
            this.chkFlashItTransBG.Text = "Is transparent";
            this.chkFlashItTransBG.UseVisualStyleBackColor = true;
            this.chkFlashItTransBG.CheckedChanged += new System.EventHandler(this.chkFlashItTransBG_CheckedChanged);
            // 
            // cboFlashItStep
            // 
            this.cboFlashItStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFlashItStep.FormattingEnabled = true;
            this.cboFlashItStep.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "5",
            "10",
            "20",
            "25",
            "50"});
            this.cboFlashItStep.Location = new System.Drawing.Point(43, 168);
            this.cboFlashItStep.Name = "cboFlashItStep";
            this.cboFlashItStep.Size = new System.Drawing.Size(61, 21);
            this.cboFlashItStep.TabIndex = 1;
            this.cboFlashItStep.SelectedIndexChanged += new System.EventHandler(this.cboFlashItStep_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Step";
            // 
            // chkFlashItMirror
            // 
            this.chkFlashItMirror.AutoSize = true;
            this.chkFlashItMirror.Checked = true;
            this.chkFlashItMirror.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFlashItMirror.Location = new System.Drawing.Point(8, 145);
            this.chkFlashItMirror.Name = "chkFlashItMirror";
            this.chkFlashItMirror.Size = new System.Drawing.Size(52, 17);
            this.chkFlashItMirror.TabIndex = 1;
            this.chkFlashItMirror.Text = "Mirror";
            this.chkFlashItMirror.UseVisualStyleBackColor = true;
            this.chkFlashItMirror.CheckedChanged += new System.EventHandler(this.chkFlashItMirror_CheckedChanged);
            // 
            // btnFlashItBrowse
            // 
            this.btnFlashItBrowse.Location = new System.Drawing.Point(8, 105);
            this.btnFlashItBrowse.Name = "btnFlashItBrowse";
            this.btnFlashItBrowse.Size = new System.Drawing.Size(96, 23);
            this.btnFlashItBrowse.TabIndex = 1;
            this.btnFlashItBrowse.Text = "Browse...";
            this.btnFlashItBrowse.UseVisualStyleBackColor = true;
            this.btnFlashItBrowse.Click += new System.EventHandler(this.btnFlashItBrowse_Click);
            // 
            // pbFlashItSourceImg
            // 
            this.pbFlashItSourceImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFlashItSourceImg.Location = new System.Drawing.Point(8, 3);
            this.pbFlashItSourceImg.Name = "pbFlashItSourceImg";
            this.pbFlashItSourceImg.Size = new System.Drawing.Size(96, 96);
            this.pbFlashItSourceImg.TabIndex = 1;
            this.pbFlashItSourceImg.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rtbAbout);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1008, 426);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "About";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rtbAbout
            // 
            this.rtbAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbAbout.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAbout.Location = new System.Drawing.Point(3, 3);
            this.rtbAbout.Name = "rtbAbout";
            this.rtbAbout.ReadOnly = true;
            this.rtbAbout.Size = new System.Drawing.Size(1002, 420);
            this.rtbAbout.TabIndex = 1;
            this.rtbAbout.Text = "ERROR: Failed to load ReadMe.txt";
            // 
            // ss1
            // 
            this.ss1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbl1,
            this.tslbl2});
            this.ss1.Location = new System.Drawing.Point(0, 3);
            this.ss1.Name = "ss1";
            this.ss1.Size = new System.Drawing.Size(1016, 22);
            this.ss1.TabIndex = 7;
            this.ss1.Text = "statusStrip1";
            // 
            // tslbl1
            // 
            this.tslbl1.Name = "tslbl1";
            this.tslbl1.Size = new System.Drawing.Size(35, 17);
            this.tslbl1.Text = "tslbl1";
            // 
            // tslbl2
            // 
            this.tslbl2.Name = "tslbl2";
            this.tslbl2.Size = new System.Drawing.Size(35, 17);
            this.tslbl2.Text = "tslbl2";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.ss1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 452);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1016, 25);
            this.panel9.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 477);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Napoleons Sprite Sheet Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.paMergeFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSheet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.paSplitFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSplit)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.paPreviewFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewAnimation)).EndInit();
            this.tpTilePreview.ResumeLayout(false);
            this.patsRight.ResumeLayout(false);
            this.patsLeft.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tpFlashIt.ResumeLayout(false);
            this.paFlashItFill.ResumeLayout(false);
            this.paFlashItFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlashItSheet)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlashItSourceImg)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.ss1.ResumeLayout(false);
            this.ss1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.SaveFileDialog sfd1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboExt;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFrameHeight;
        private System.Windows.Forms.TextBox txtFrameWidth;
        private System.Windows.Forms.TextBox txtFrameCnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstImages;
        private System.Windows.Forms.Button btnOpenFiles;
        private System.Windows.Forms.PictureBox pbSheet;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PropertyGrid pgPreview;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Timer timPreview;
        private System.Windows.Forms.Timer timFPS;
        private System.Windows.Forms.Panel paPreviewFill;
        private System.Windows.Forms.PictureBox pbPreviewAnimation;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel paMergeFill;
        private System.Windows.Forms.Button btnDelImage;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Panel paSplitFill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PropertyGrid pgSplit;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.PictureBox pbSplit;
        private System.Windows.Forms.Button btnSaveSplitAs;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ImageList imgList16px;
        private System.Windows.Forms.RichTextBox rtbAbout;
        private System.Windows.Forms.CheckBox chkAutoSortLstImages;
        private System.Windows.Forms.Button btnClearAllMerge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMergeRowCnt;
        private System.Windows.Forms.ComboBox cboMergeCurrentRow;
        private System.Windows.Forms.Button btnUseMergeForPreview;
        private System.Windows.Forms.TabPage tpTilePreview;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Panel patsRight;
        private System.Windows.Forms.Panel patsLeft;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PropertyGrid pgTP;
        private System.Windows.Forms.Splitter splitter6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btntpSaveAs;
        private System.Windows.Forms.Button btntpReset;
        private System.Windows.Forms.ComboBox cbotpLayer;
        private System.Windows.Forms.Panel patsImage;
        private System.Windows.Forms.Button btntpHelp;
        private System.Windows.Forms.Button btntpFill;
        private System.Windows.Forms.StatusStrip ss1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ToolStripStatusLabel tslbl1;
        private System.Windows.Forms.Button btnSplitReplaceColor;
        private System.Windows.Forms.ToolStripStatusLabel tslbl2;
        private System.Windows.Forms.TabPage tpFlashIt;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cboFlashItStep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkFlashItMirror;
        private System.Windows.Forms.Button btnFlashItBrowse;
        private System.Windows.Forms.PictureBox pbFlashItSourceImg;
        private System.Windows.Forms.Panel paFlashItFill;
        private System.Windows.Forms.PictureBox pbFlashItSheet;
        private System.Windows.Forms.CheckBox chkFlashItTransBG;
        private System.Windows.Forms.Panel paFlashItFillColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFlashItBGColor;
        private System.Windows.Forms.Button btnFlashItSaveAs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFlashItFrameCnt;
    }
}

