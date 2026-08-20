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
                primero = Nuevo;
                ultimo = Nuevo;
            }
            else
            {
                ultimo.siguiente = Nuevo;
                ultimo = Nuevo;
            }
        }

    public void Recorrer(ListBox lstLista)
        {
            clsNodo aux = primero;
            while (aux != null)
            {
                lstLista.Items.Add(aux.Codigo);
                aux = aux.siguiente;
            }
        }
    }
}
