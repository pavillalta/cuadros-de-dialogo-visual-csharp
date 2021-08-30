using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient; //Acceso a bd SQLServer
using System.Data.OleDb; //Acceso a bd Access

namespace CuadrosDeDialogo
{
    public partial class flogin : Form
    {
  
        public flogin()
        {
            InitializeComponent();
        }

        private void bsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {
            txtusuario.Focus();
        }


private void button1_Click(object sender, EventArgs e)
        {


            //evaluando que clave y usuario sean correctos
            if (txtusuario.Text == "usuario1" || txtclave.Text == "usuario1")
            {
                //llamando formulario principal llamado menu
                menu fprincipal = new menu();
                fprincipal.Show();   //abrir menu
                this.Hide();  //ocultar el formulario de login
            }


        }

    }
}
