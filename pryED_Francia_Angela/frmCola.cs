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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
        clsCola objCola = new clsCola();
        clsNodo objNodo = new clsNodo();


        private void grbElemElim_Enter(object sender, EventArgs e)
        {

        }

        private void lblTramiteElim_Click(object sender, EventArgs e)
        {

        }

        private void lblNomElim_Click(object sender, EventArgs e)
        {

        }

        private void txtNomElim_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            objNodo.Nombre= txtNomNv.Text;
            objCola.Agregar(objNodo);
            objCola.Recorrer(lstListado);
        }
    }
}
