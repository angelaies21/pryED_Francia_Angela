using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryED_Francia_Angela
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola ventana = new frmCola();
            ventana.ShowDialog();
        }
    }
}
