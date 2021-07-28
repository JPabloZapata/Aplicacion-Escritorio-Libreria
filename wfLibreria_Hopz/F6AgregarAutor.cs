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
    public partial class F6AgregarAutor : Form
    {
        claseConexionBD x = new claseConexionBD();
        public F6AgregarAutor()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Form l6 = new Form1();
            l6.Show();
            this.Hide();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string txt1, txt2, txt3, cmbx;
            bool v = false;
            if (txtCedula.Text == "" || txtNombre.Text == "" || txtEdad.Text == "" || cmbxSexo.Text == "")
            {
                MessageBox.Show("Se deben llenar todos los campos", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txt1 = txtCedula.Text;
                txt2 = txtNombre.Text;
                txt3 = txtEdad.Text;
                cmbx = cmbxSexo.Text;
                txtCedula.Text = "";
                txtNombre.Text = "";
                txtEdad.Text = "";
                cmbxSexo.Text = "";
                v = x.registroAutores(txt1, txt2, txt3, cmbx);
                if (v == true)
                {
                    MessageBox.Show("Regitro exitoso", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void F6AgregarAutor_Load(object sender, EventArgs e)
        {
            x.abrirBd();
        }

        private void F6AgregarAutor_FormClosing(object sender, FormClosingEventArgs e)
        {
            x.cerrarBd();
        }
    }
}
