using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Armando01.DOMINIO;
using Armando01.NEGOCIO;
using Armando01.VISTA;

namespace Armando01
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();

            log.Usuario = txtUser.Text;
            log.Password = txtPassword.Text;

            ClsLogin clsL = new ClsLogin();

            clsL.acceso(log);


            int variabledeevaluacion = clsL.acceso(log);

            if (variabledeevaluacion == 1)
            {
                MessageBox.Show("Bienvenido");

                FrmAdministrador frm = new FrmAdministrador();
                frm.Show();
                this.Hide();
            
            }
            else {
                MessageBox.Show("False");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();

            log.Usuario = txtUser.Text;
            log.Password = txtPassword.Text;

            ClsLogin clsL = new ClsLogin();

            clsL.acceso(log);


            int variabledeevaluacion = clsL.acceso(log);

            if (variabledeevaluacion == 2)
            {
                MessageBox.Show("Bienvenido");

                FrmUsuario frm = new FrmUsuario();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("False");
            }
        }
    }
    }

