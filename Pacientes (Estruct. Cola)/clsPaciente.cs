using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Pacientes__Estruct.Cola_
    {
        internal class clsPaciente
        {
            public string DNI;
            public string nombre;
            public string apellido;
            public clsPaciente siguiente;

            public clsPaciente (string DNI, string nombre, string apellido) 
            {
                this.DNI = DNI;
                this.nombre = nombre;
                this.apellido = apellido;
                this.siguiente= null;

            }


        }
    }
