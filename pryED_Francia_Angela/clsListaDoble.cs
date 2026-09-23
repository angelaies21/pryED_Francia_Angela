using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryED_Francia_Angela
{
    internal class clsListaDoble
    {
            private clsNodo prim;
            private clsNodo ultim;

            public clsNodo Primero
            {
                get { return prim; }
                set { prim = value; }
            }

            public clsNodo Ultimo
            {
                get { return ultim; }
                set { ultim = value; }
            }

            public void Agregar(clsNodo nuevo)
            {
                if (nuevo == null)
                {
                    return;
                }

                nuevo.siguiente = null;
                nuevo.Anterior = null;

                if (Primero == null)
                {
                    Primero = nuevo;
                    Ultimo = nuevo;
                }
                else if (nuevo.Codigo < Primero.Codigo)
                {
                    nuevo.siguiente = Primero;
                    Primero.Anterior = nuevo;
                    Primero = nuevo;
                }
                else if (nuevo.Codigo >= Ultimo.Codigo)
                {
                    Ultimo.siguiente = nuevo;
                    nuevo.Anterior = Ultimo;
                    Ultimo = nuevo;
                }
                else
                {
                    clsNodo aux = Primero;

                    while (aux != null && aux.Codigo <= nuevo.Codigo)
                    {
                        aux = aux.siguiente;
                    }

                    clsNodo anterior = aux.Anterior;

                    anterior.siguiente = nuevo;
                    nuevo.Anterior = anterior;
                    nuevo.siguiente = aux;
                    aux.Anterior = nuevo;
                }
            }

            public void Eliminar(int codigo)
            {
                clsNodo aux = Primero;

                while (aux != null && aux.Codigo != codigo)
                {
                    aux = aux.siguiente;
                }

                if (aux == null)
                {
                    MessageBox.Show("No se encontró el código");
                    return;
                }

                if (aux.Anterior == null)
                {
                    Primero = aux.siguiente;
                }
                else
                {
                    aux.Anterior.siguiente = aux.siguiente;
                }

                if (aux.siguiente == null)
                {
                    Ultimo = aux.Anterior;
                }
                else
                {
                    aux.siguiente.Anterior = aux.Anterior;
                }
            }

            public void Recorrer(DataGridView grilla)
            {
                grilla.Rows.Clear();

                clsNodo aux = Primero;

                while (aux != null)
                {
                    grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                    aux = aux.siguiente;
                }
            }

            public void RecorrerDes(DataGridView grilla)
            {
                grilla.Rows.Clear();

                clsNodo aux = Ultimo;

                while (aux != null)
                {
                    grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                    aux = aux.Anterior;
                }
            }

            public void Recorrer(ListBox lista)
            {
                lista.Items.Clear();

                clsNodo aux = Primero;

                while (aux != null)
                {
                    lista.Items.Add(aux.Codigo + " | " + aux.Nombre + " | " + aux.Tramite);
                    aux = aux.siguiente;
                }
            }

            public void Recorrer(ComboBox combo)
            {
                combo.Items.Clear();

                clsNodo aux = Primero;

                while (aux != null)
                {
                    combo.Items.Add(aux.Codigo);
                    aux = aux.siguiente;
                }
            }
        }
    }
