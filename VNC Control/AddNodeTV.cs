using System;
using System.Windows.Forms;

namespace VNC_Control
{
    public partial class AddNodeTV : Form
    {
        public string pgi = "";
        public AddNodeTV(Form1 f)
        {
            InitializeComponent();
        }

        public void btAddNodeOK_Click(object sender, EventArgs e)
        {
            if (Form1.SelfRef != null)
            {
                Form1.SelfRef.addNode(tbAddNode.Text, pgi);
            }
            Close();
        }

        private void btAddNodeClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbAddNode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btAddNodeOK_Click(null, null);
            }
        }
    }
}
