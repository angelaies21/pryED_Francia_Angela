using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryED_Francia_Angela
{
    internal class clsNodo //clase nodo
    {

        private clsNodo Primero; // Referencia al primer nodo de la estructura
        private clsNodo Ultimo;
        private clsNodo Nuevo;

        private int codigo;
        private string nombre;
        private string tramite;

        public clsNodo siguiente;

        public int Codigo { get => codigo; set => codigo = value; } //get : devuelve el valor de la variable, set: asigna un valor a la variable
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tramite { get => tramite; set => tramite = value; }
    


    
     public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null) //si no hay elementos en la estructura
            {
                Primero = Nuevo;  //el nuevo elemento pasa a ser el primero
                
                Ultimo = Nuevo;   // como era el primer elemento y no habia ninguno antes,
                                  // tmb es el ultimo (primero --> nuevo <-- ultimo
            }
            else
            {
                Ultimo.siguiente = Nuevo; // el elem q estaba ultimo ahora apunta al nuevo elem
                Ultimo = Nuevo;  // el nuevo elem pasa a ser el ultimo
            }
        }

        public void Eliminar() //elimina el primer elemento de la estructura
        {
            if (Primero == null)
            {
                Primero = null; //si no hay elementos en la estructura, no se puede eliminar nada
                Ultimo = null;
            }
            else
            {
                Primero = Primero.siguiente; //el primer elem pasa a ser el siguiente del primero (el segundo elem)
            }
        }


        public void Recorrer(ListBox lst)  //recorre el listBox
        {
            clsNodo aux = Primero;
            lst.Items.Clear(); //limpia el listBox para que no se repitan los datos
            while (aux != null)
            {
                lst.Items.Add($"{aux.Codigo} {aux.Nombre} {aux.Tramite}"); //agrega un elem al listBox
                aux = aux.siguiente ; //avanzo al siguiente elem de la estructura
                                      //y cuando llega al null termina
            }
        }

        public void Recorrer(DataGridView dgv) //recoore el cuadro
        {
            clsNodo aux = Primero;
            dgv.Rows.Clear(); //limpia el cuadro para que no se repitan los datos
            while (aux != null) //mientras aux sea distinto de null, recorre la estructura
            {
                dgv.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);  //agrega un elem al cuadro
                aux = aux.siguiente ; 
            }
        }

    }

    }
