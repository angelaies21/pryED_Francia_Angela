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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryED_Francia_Angela
{
    public partial class frmDobleEnlanzada : Form
    {
        public frmDobleEnlanzada()
        {
            InitializeComponent();
        }

        clsListaDoble objLista = new clsListaDoble();
   

        private void frmDobleEnlanzada_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nuevo = new clsNodo();

            nuevo.Codigo = Convert.ToInt32(txtCode.Text);
            nuevo.Nombre = txtName.Text;
            nuevo.Tramite = txtTramite.Text;

            objLista.Agregar(nuevo);

            objLista.Recorrer(LstDeDatos);
            objLista.Recorrer(dgvTabladedatos);
            objLista.Recorrer (cmbCodigos);

            txtCode.Clear();
            txtName.Clear();
            txtTramite.Clear();

            txtCode.Focus();
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            objLista.Eliminar(Convert.ToInt32(cmbCodigos.SelectedItem));

            objLista.Recorrer(LstDeDatos);
            objLista.Recorrer(dgvTabladedatos);
            objLista.Recorrer(cmbCodigos);
        }
    }
}
