using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuadrosDeDialogo
{
    public partial class Dialogos : Form
    {

                public Dialogos()
        {
            InitializeComponent();
        }

        private void baceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje con boton de aceptar","Ejemplo Mensaje Aceptar");
        }

        private void baceptar_cancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje de información con botones Aceptar y Cancelar", "Ejemplo Mensaje OKCanccel", MessageBoxButtons.OKCancel);
        }

        private void bsi_no_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje informativo con botones Sí, No y Cancelar", "Ejemplo Mensaje YesNoCanccel", MessageBoxButtons.YesNoCancel);
        }

        private void bexclamcion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje informativo con boton Aceptar", "Ejemplo Mensaje Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void binterrogacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje interrogativo", "Ejemplo Mensaje Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void berror_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje informativo", "Titulo Ventana", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
