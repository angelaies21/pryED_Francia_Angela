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
            while (aux != null) 
            {
                lstLista.Items.Add(aux.Codigo); //agrega el código del nodo al listBox
                aux = aux.siguiente;
            }
        }

        public void Recorrer(DataGridView dgvTabla)
        {
            clsNodo aux = primero;
            while (aux != null)
            {
                dgvTabla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite); //agrega el código, nombre y trámite del nodo al dataGridView

                aux = aux.siguiente;
            }
        }

        public void Eliminar ()
        {
            if (primero == null)
            {
                MessageBox.Show("el espacio está vacio");

            }
            else
            {
                primero = primero.siguiente; //el primer nodo pasa a ser el siguiente del primer nodo (el segundo nodo)

                if (primero == null) //si el primer nodo es nulo, significa que la cola está vacía, por lo que el último nodo también debe ser nulo
                {
                    ultimo = null; //el último nodo también es nulo
                }
            }
        }


        public clsNodo verPrimero()
        {
            return primero;  //devuelve el primer nodo de la cola para poder ver sus datos
        }




    }
}
