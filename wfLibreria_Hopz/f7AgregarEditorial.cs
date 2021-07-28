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
    public partial class f7AgregarEditorial : Form
    {
        claseConexionBD ee = new claseConexionBD();
        public f7AgregarEditorial()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Form l7 = new Form1();
            l7.Show();
            this.Hide();
        }

        private void F7AgregarEditorial_Load(object sender, EventArgs e)
        {
            ee.abrirBd();
        }

        private void F7AgregarEditorial_FormClosing(object sender, FormClosingEventArgs e)
        {
            ee.cerrarBd();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string txt1, txt2, txt3;
            bool v = false;
            if (txtNombre.Text == "" || txtCodigo.Text == "" || txtDireccion.Text == "") 
            {
                MessageBox.Show("Se deben llenar todos los campos", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txt1 = txtCodigo.Text; 
                txt2 = txtNombre.Text;
                txt3 = txtDireccion.Text;
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtDireccion.Text = "";
                v = ee.registroEditoriales(txt1, txt2, txt3);
                if (v == true)
                {
                    MessageBox.Show("Regitro exitoso", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
