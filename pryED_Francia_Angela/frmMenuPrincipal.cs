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

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila ventana = new frmPila();
            ventana.ShowDialog();
        }

        private void listaDoblementeEnlazadaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmDobleEnlanzada ventana = new frmDobleEnlanzada();
            ventana.ShowDialog();
        }

        private void listaEnlazadaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple ventana = new frmListaSimple();
            ventana.ShowDialog();
        }
    }
}
