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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void acercadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codigo de ejemplo para abrir un formulario SDI flotante sobre formulario MDI
            acercade abrir_acercade = new acercade();
            abrir_acercade.ShowDialog();
        }

        private void ayudaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //codigo de ejemplo para abrir un formulario SDI dentro de un MDI
            ayuda abrir_ayuda = new ayuda();
            abrir_ayuda.MdiParent = this;
            abrir_ayuda.Show();
        }

        private void cuadrosDeDialogoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Dialogos abrir_dialogos = new Dialogos();
            abrir_dialogos.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //método Aplicatio.Exit para salir de aplicación
            Application.Exit();
        }

    }
}
