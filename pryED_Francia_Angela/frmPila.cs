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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        clsCola objCola = new clsCola();
        private void btnAgregarPila_Click(object sender, EventArgs e) 
        {

            clsNodo nuevo = new clsNodo(); // Crear un nuevo nodo

            nuevo.Codigo = Convert.ToInt32(txtCodigPila.Text); // Convertir el texto a entero y asignarlo a la propiedad Codigo del nodo
            nuevo.Nombre = txtNomPila.Text; // Asignar el texto del TextBox a la propiedad Nombre del nodo
            nuevo.Tramite=txtTramitePila.Text; // Asignar el texto del TextBox a la propiedad Tramite del nodo

            objCola.Agregar(nuevo); // Agregar el nodo a la cola

            lstPila.Items.Clear(); // Limpiar el ListBox antes de recorrer la cola nuevamente
            objCola.Recorrer(lstPila); // Recorrer la cola y mostrar los elementos en el ListBox

            dgvTablaPila.Rows.Clear(); // Limpiar el DataGridView antes de recorrer la cola nuevamente
            objCola.Recorrer(dgvTablaPila); // Recorrer la cola y mostrar los elementos en el DataGridView

            txtCodigPila.Clear();
            txtNomPila.Clear();
            txtTramitePila.Clear();

            txtCodigPila.Focus(); // Establecer el foco en el TextBox de código para facilitar la entrada de datos

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            
            clsNodo elim = objCola.verPrimero(); // Obtener el primer nodo de la cola sin eliminarlo
            if (elim == null)
            {
                MessageBox.Show("No hay elementos para eliminar");
            }
            else
            {
                txtCodigElim.Text=elim.Codigo.ToString(); // Convertir el código del nodo a cadena y asignarlo al TextBox correspondiente
                txtNom.Text = elim.Nombre; // Asignar el nombre del nodo al TextBox correspondiente
                txtTram.Text = elim.Tramite;

                objCola.Eliminar();
                lstPila.Items.Clear();
                dgvTablaPila.Rows.Clear();
                objCola.Recorrer(lstPila);
                objCola.Recorrer(dgvTablaPila);


            }
        }
    }
    
}

