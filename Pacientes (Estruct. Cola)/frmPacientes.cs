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
    public partial class frmPacientes : Form
    {
        private clsCola cola = new clsCola();
        private frmSiguiente frmSecundario;

        public frmPacientes()
        {
            InitializeComponent();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            frmSecundario = new frmSiguiente(cola);
            frmSecundario.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDNI.Text) &&
                !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                cola.Insertar(txtDNI.Text, txtNombre.Text, txtApellido.Text);
                txtDNI.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                frmSecundario.ActualizarPacientes();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if (cola.ObtenerPrimero() != null)
            {
                cola.Eliminar();
                frmSecundario.ActualizarPacientes();
            }
            else
            {
                MessageBox.Show("No hay pacientes en la cola.");
            }
        }
    }
   
}
