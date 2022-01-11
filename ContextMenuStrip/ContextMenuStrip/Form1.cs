using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void lijevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtLijevi.Text == string.Empty)
            {
                MessageBox.Show("Upiši text!", "Nema texta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtLijevi.Text = txtDesni.Text;
                txtDesni.Clear();
            }
        }

        private void desnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtLijevi.Text == string.Empty)
            {
                MessageBox.Show("Upiši text!", "Nema texta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtDesni.Text = txtLijevi.Text;
                txtLijevi.Clear();
            }
        }
    }
}
