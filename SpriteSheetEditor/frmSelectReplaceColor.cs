using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpriteSheetEditor
{
    public partial class frmSelectReplaceColor : Form
    {
        public Color SelectedColor;
        public frmSelectReplaceColor(Color initialColor)
        {
            InitializeComponent();
            paColor.BackColor = initialColor;
        }

        private void chkUseTransColor_CheckedChanged(object sender, EventArgs e)
        {
            paColor.Visible = btnSelectColor.Enabled = !chkUseTransColor.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (chkUseTransColor.Checked)
                SelectedColor = Color.Transparent;
            else
                SelectedColor = paColor.BackColor;
            Close();
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() != DialogResult.Cancel)
                paColor.BackColor = colorDialog1.Color;
        }

        private void frmSelectReplaceColor_Load(object sender, EventArgs e)
        {

        }
    }
}
