using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryED_Francia_Angela
{
    internal class clsPila
    {
        private clsNodo primero;
        
        public void Agregar(clsNodo nuevo)
        {
            nuevo.siguiente = primero;
            primero = nuevo;

        }

        public void Eliminar()
        {
            if (primero == null)
            {
                MessageBox.Show("La pila esta vacia");
            }
            else
            {
                primero = primero.siguiente;

            }

        }

        public void Recorrer(ListBox lstLista)
        {
            clsNodo aux = primero;

            while (aux != null)
            {
                lstLista.Items.Add(aux.Codigo+ " - " + aux.Nombre + " - " + aux.Tramite + " - ");
                aux = aux.siguiente;
            }
        }


        public void Recorrer(DataGridView dgvTabla)
        {
            clsNodo aux= primero;

            while (aux != null)
            {
                dgvTabla.Rows.Add(aux.Codigo + " - " + aux.Nombre + " - " + aux.Tramite + " - ");
                aux = aux.siguiente;
            }

        }

        public clsNodo verPrimero()
        {
            return primero; //sirve p q el formulario pueda consultar cual es el nodo

        }
    }
}
