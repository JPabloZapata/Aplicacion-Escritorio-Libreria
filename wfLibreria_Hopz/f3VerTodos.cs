using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace wfLibreria_Hopz
{
    public partial class f3VerTodos : Form
    {
        
        public f3VerTodos()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Form l3 = new Form1();
            l3.Show();
            this.Hide();
        }

        private void F3VerTodos_Load(object sender, EventArgs e)
        {
            claseConexionBD conexion = new claseConexionBD();
            conexion.abrirBd();
            conexion.llenarDgv(dgvTodosLibros);
            
        }

        private void F3VerTodos_FormClosing(object sender, FormClosingEventArgs e)
        {
            claseConexionBD conexionn = new claseConexionBD();
            conexionn.cerrarBd();
        }
    }
}
