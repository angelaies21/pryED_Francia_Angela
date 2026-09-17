using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryED_Francia_Angela
{
    internal class clsCola
    {
        private clsNodo primero;
        private clsNodo ultimo;

        public clsNodo Primero { get => primero; set => primero = value; }
        public clsNodo Ultimo { get => ultimo; set => ultimo = value; }


        public void Agregar(clsNodo Nuevo)
        {
            if (primero == null)
            {
                primero = Nuevo; //si la cola está vacía, el primer nodo es el nuevo nodo
                ultimo = Nuevo;
            }
            else
            {
                ultimo.siguiente = Nuevo; //si la cola no está vacía, el último nodo apunta al nuevo nodo
                ultimo = Nuevo; //el último nodo ahora es el nuevo nodo
            }
        }

        public void Recorrer(ListBox lstLista) //recorre el listBox
        {
            clsNodo aux = primero; //crea un nodo auxiliar que apunta al primer nodo de la cola
            lstLista.Items.Clear();
            while (aux != null)
            {
                lstLista.Items.Add(aux.Codigo); //agrega el código del nodo al listBox
                aux = aux.siguiente;
            }
        }

        public void Recorrer(DataGridView dgvTabla)
        {
            clsNodo aux = primero;
            dgvTabla.Rows.Clear();
            while (aux != null)
            {
                dgvTabla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite); //agrega el código, nombre y trámite del nodo al dataGridView

                aux = aux.siguiente;
            }
        }

        public void Eliminar()
        {
            if (primero == null)
            {
                MessageBox.Show("La cola está vacía");
            }
            else
            {
                primero = primero.siguiente; // El segundo pasa a ser el primero

                if (primero == null)
                {
                    ultimo = null; // Si no quedan elementos, la cola queda vacía
                }
            }
        }

        public void Recorrerla(ListBox lst)
        {
            clsNodo aux = primero;

            lst.Items.Clear(); // Limpia el ListBox

            while (aux != null)
            {
                lst.Items.Add(
                    $"{aux.Codigo} {aux.Nombre} {aux.Tramite}"
                ); //agg los datos a la tabla

                aux = aux.siguiente; // Avanza al siguiente nodo
            }
        }

        // RECORRER Y MOSTRAR EN EL DATAGRIDVIEW
        public void RecorrerMos(DataGridView dgv)
        {
            clsNodo aux = primero;

            dgv.Rows.Clear(); // Limpia la tabla

            while (aux != null)
            {
                dgv.Rows.Add(
                    aux.Codigo,
                    aux.Nombre,
                    aux.Tramite
                );

                aux = aux.siguiente; // Avanza al siguiente nodo
            }
        }
    }

}




