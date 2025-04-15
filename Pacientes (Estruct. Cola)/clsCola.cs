using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacientes__Estruct.Cola_
{
    internal class clsCola
    {
        public clsPaciente inicio;    
        public clsPaciente fin;

        public clsCola() 
        {   
            inicio = null;
            fin = null;  
        }

        public void Insertar(string dni, string nombre, string apellido)
        {
            clsPaciente nuevo = new clsPaciente(dni, nombre, apellido);
            if (inicio == null)
            {
                inicio = nuevo;
                fin = nuevo;
            }
            else
            {
                fin.siguiente = nuevo;
                fin = nuevo;
            }

        }
        public void Eliminar()
        {
            if (inicio != null)
            {
                inicio = inicio.siguiente;
                if (inicio == null)
                {
                    fin = null;
                }
            }
        }

        public clsPaciente ObtenerPrimero()
        {
            return inicio;
        }

        public clsPaciente ObtenerSiguiente()
        {
            // Caso 1: Cola vacía
            if (inicio == null)
                return null;

            // Caso 2: Existe inicio, pero no hay siguiente
            if (inicio.siguiente == null)
                return null;

            // Caso 3: Existe inicio y siguiente
            return inicio.siguiente;
        }
    }

}

