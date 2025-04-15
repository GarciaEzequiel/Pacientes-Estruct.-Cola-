using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacientes__Estruct.Cola_
{
    
    public partial class frmSiguiente : Form
    {
        private clsCola cola;

       
        internal frmSiguiente(clsCola cola)
        {
            InitializeComponent();
            this.cola = cola;
            ActualizarPacientes();
        }

        public void ActualizarPacientes()
        {
                var pacienteActual = cola.ObtenerPrimero();
            var siguientePaciente = cola.ObtenerSiguiente();

            lblSiguiente.Text = pacienteActual != null
                ? $"{pacienteActual.nombre} {pacienteActual.apellido} (DNI: {pacienteActual.DNI})"
                : "No hay pacientes";

            lblProximoPaciente.Text = siguientePaciente != null
                ? $"{siguientePaciente.nombre} {siguientePaciente.apellido} (DNI: {siguientePaciente.DNI})"
                : "No hay más pacientes";
        }
    }
}


