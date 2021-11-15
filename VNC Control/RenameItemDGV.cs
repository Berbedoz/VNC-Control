using System;
using System.Windows.Forms;

namespace VNC_Control
{
    public partial class RenameItemDGV : Form
    {
        public string id = "";
        public string pg = "";

        public RenameItemDGV(Form1 f)
        {
            InitializeComponent();
        }

        public void btRenameItemDGVOK_Click(object sender, EventArgs e)
        {
            if (Form1.SelfRef != null)
            {
                Form1.SelfRef.RenameItems(id, pg, tbRenameItemDGVName.Text, tbRenameItemDGVIP.Text, tbRenameItemDGVPass.Text);
               
            }
            Close();
        }

        private void btRenameItemDGVClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbRenameItemDGVName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbRenameItemDGVIP.Focus();
            }
        }

        private void tbRenameItemDGVIP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbRenameItemDGVPass.Focus();
            }
        }

        private void tbRenameItemDGVPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btRenameItemDGVOK_Click(null, null);
            }
        }
    }
}
