using Armando01.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Armando01.VISTA
{
    public partial class FrmListaVisualDeusuario : Form
    {
        public FrmListaVisualDeusuario()
        {
            InitializeComponent();
        }

        private void FrmListaVisualDeusuario_Load(object sender, EventArgs e)
        {
            ClsListaUsuario cls = new ClsListaUsuario();

            foreach (var iteracion in cls.user) {

                dataGridView1.Rows.Add(iteracion.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
