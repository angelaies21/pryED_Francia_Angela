using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryED_Francia_Angela
{
    public partial class frmMostrarTabla : Form
    {
        clsParteDOS cone = new clsParteDOS();

        public frmMostrarTabla()
        {

            InitializeComponent();

            cmbDatos.Items.Add("Autor");
            cmbDatos.Items.Add("Idioma");
            cmbDatos.Items.Add("libro");
            cmbDatos.Items.Add("Pais");    
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            cone.listar(dgvTabla, cmbDatos.Text);

        }
    }
}
