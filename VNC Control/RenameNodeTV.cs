using System;
using System.Windows.Forms;

namespace VNC_Control
{
    public partial class RenameNodeTV : Form
    {
        public string pgi = "";
        public RenameNodeTV(Form1 f)
        {
            InitializeComponent();
        }

        private void btRenameNodeOK_Click(object sender, EventArgs e)
        {
            if (Form1.SelfRef != null)
            {
                Form1.SelfRef.renameNode(tbRenameNode.Text, pgi);
            }
            Close();
        }

        private void btRenameNodeClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbRenameNode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btRenameNodeOK_Click(null, null);
            }
        }
    }
}
