using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace pryED_Francia_Angela
{
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsPila objPila = new clsPila();

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

        clsCola objCola = new clsCola();
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigNv.Text);
            objNodo.Nombre = txtNomNv.Text;
            objNodo.Tramite= txtTramiteNv.Text;

            lstListado.Items.Clear();
            dgvTabla.Rows.Clear();

            objCola.Agregar(objNodo);
            objCola.Recorrer(lstListado);
            objCola.Recorrer(dgvTabla);

            txtCodigNv.Text = "";
            txtNomNv.Clear();
            txtTramiteNv.Clear();
            txtCodigNv.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            clsNodo elimina = objCola.verPrimero();

            if (elimina == null)
            {
                MessageBox.Show("No hay elementos para eliminar");
            }
            else
            {
                txtCodigElim.Text = elimina.Codigo.ToString();
                txtNomElim.Text = elimina.Nombre;
                txtTramiteElim.Text = elimina.Tramite;

                objCola.Eliminar();

                lstListado.Items.Clear();
                dgvTabla.Rows.Clear();

                objCola.Recorrer(lstListado);
                objCola.Recorrer(dgvTabla);
            }
        }
        

        private void frmCola_Load(object sender, EventArgs e)
        {

        }

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
