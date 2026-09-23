using pryED_Francia_Angela;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryED_Francia_Angela
{
        public partial class frmListaSimple : Form
        {
            public frmListaSimple()
            {
                InitializeComponent();
            }

            clsListaSimple ListaSimple = new clsListaSimple();

            private void limpiarTodo()
            {
                txtCodigL.Text = "";
                txtNomL.Text = "";
                txtTramL.Text = "";
                cmbElimCodig.Text = "";
                LosRecorrer();
            }

            private void btnEliminar_Click(object sender, EventArgs e)
            {
                if (cmbElimCodig.SelectedItem != null)
                {
                    try
                    {
                        ListaSimple.Eliminar(Convert.ToInt32(cmbElimCodig.SelectedItem));
                        MessageBox.Show("Se eliminó correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error: " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún valor a eliminar.");
                }
                limpiarTodo();
            }
            private void LosRecorrer()
            {
                ListaSimple.Recorrer(cmbElimCodig);
                ListaSimple.Recorrer(dgvElementos);
                ListaSimple.Recorrer(lstListaSimple);
            }

            private void lstListaSimple_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigL.Text);
            Persona.Nombre = txtNomL.Text;
            Persona.Tramite = txtTramL.Text;

            ListaSimple.Agregar(Persona);
            LosRecorrer();
            limpiarTodo();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }

        clsListaSimple objListaSimple = new clsListaSimple();

        private void btnElim_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(cmbCodigo.Text);

            objListaSimple.Eliminar(codigo);

            lstSimple.Items.Clear();
            dgvTablas.Rows.Clear();

            objListaSimple.Recorrer(lstSimple);
            objListaSimple.Recorrer(dgvTablas);

            cmbCodigo.Text = "";

        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
            clsNodo nuevo = new clsNodo();
            
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nuevo.Nombre = txtNombre.Text;
            nuevo.Tramite = txtTramite.Text;

            objListaSimple.Agregar(nuevo);
            cmbCodigo.Items.Add(nuevo.Codigo);

            lstSimple.Items.Clear();
            dgvTablas.Rows.Clear();

            objListaSimple.Recorrer(lstSimple);
            objListaSimple.Recorrer(dgvTablas);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();

            txtCodigo.Focus();
        }
    }
}
