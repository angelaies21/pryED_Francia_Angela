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

            objCola.Agregar(objNodo);
            objCola.Recorrer(lstListado);

            txtCodigNv.Text = "";
            txtNomNv.Clear();
            txtTramiteNv.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            clsNodo elim = objPila.verPrimero(); // Obtener el primer nodo de la pila sin eliminarlo
            if (elim == null)
            {
                MessageBox.Show("No hay elementos para eliminar");
            }
            else
            {
                txtCodigElim.Text = elim.Codigo.ToString(); // Convertir el código del nodo a cadena y asignarlo al TextBox correspondiente
                txtNomElim.Text = elim.Nombre; // Asignar el nombre del nodo al TextBox correspondiente
                txtTramiteElim .Text = elim.Tramite;

                objPila.Eliminar();
                lstListado.Items.Clear();
                dgvTabla.Rows.Clear();
                objPila.Recorrer(lstListado);
                objPila.Recorrer(dgvTabla);


            }
        }

        private void frmCola_Load(object sender, EventArgs e)
        {

        }
    }
}
