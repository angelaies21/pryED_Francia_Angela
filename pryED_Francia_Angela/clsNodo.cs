using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryED_Francia_Angela
{
    internal class clsNodo
    {

        private clsNodo Primero;
        private clsNodo Ultimo;
        private clsNodo Nuevo;

        private int codigo;
        private string nombre;
        private string tramite;

        public clsNodo siguiente;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tramite { get => tramite; set => tramite = value; }
    


    
     public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;  //el nuevo elemento pasa a ser el primero
                
                Ultimo = Nuevo;   // como era el primer elemento y no habia ninguno antes,
                                  // tmb es el ultimo (primero --> nuevo <-- ultimo
            }
            else
            {
                Ultimo.siguiente = Nuevo; // el elem q estaba ultimo ahora apunta al nuevo elem
                Ultimo = Nuevo; 
            }
        }

        public void Eliminar()
        {
            if (Primero == null)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.siguiente; //el 2do elem pasa a ocupar el lugar del primero
            }
        }


        public void Recorrer(ListBox lst)  //recibe un listBox para mostrar los datos
            //el lst es nom de la variable
        {
            clsNodo aux = Primero;
            lst.Items.Clear(); //items: elem del listBox
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
            dgv.Rows.Clear(); //rows son las filas
            while (aux != null)
            {
                dgv.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite); 
                aux = aux.siguiente ;
            }
        }

    }

    }
