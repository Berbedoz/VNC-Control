using System;
using System.Windows.Forms;

namespace VNC_Control
{
    public partial class AddItemDGV : Form
    {
        public string pgi = "";
        public AddItemDGV(Form1 f)
        {
            InitializeComponent();
        }

        public void btAddItemDGVOK_Click(object sender, EventArgs e)
        {
            if (Form1.SelfRef != null)
            {
                Form1.SelfRef.addItems(tbAddItemDGVName.Text, tbAddItemDGVIP.Text, tbAddItemDGVPass.Text);
               
            }
            Close();
        }

        private void btAddItemDGVClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbAddItemDGVName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbAddItemDGVIP.Focus();
            }
        }

        private void tbAddItemDGVIP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbAddItemDGVPass.Focus();
            }
        }

        private void tbAddItemDGVPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btAddItemDGVOK_Click(null, null);
            }
        }
    }
}
