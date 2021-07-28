using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfLibreria_Hopz
{
    public partial class f8AgregarCategorias : Form
    {
        claseConexionBD c = new claseConexionBD();
        public f8AgregarCategorias()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Form l8 = new Form1();
            l8.Show();
            this.Hide();
        }

        private void F8AgregarCategorias_Load(object sender, EventArgs e)
        {
            c.abrirBd();
        }

        private void F8AgregarCategorias_FormClosing(object sender, FormClosingEventArgs e)
        {
            c.cerrarBd();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string txt1, txt2;
            bool v = false;
            if (txtCategoria.Text == "" || txtCodigo.Text == "")
            {
                MessageBox.Show("Se deben llenar todos los campos", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txt1 = txtCodigo.Text;
                txt2 = txtCategoria.Text;
                txtCodigo.Text = "";
                txtCategoria.Text = "";
                v = c.registroCategorias(txt1, txt2);
                if (v == true)
                {
                    MessageBox.Show("Regitro exitoso", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
