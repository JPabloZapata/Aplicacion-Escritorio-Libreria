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
    public partial class f2ActualizarEditorial : Form
    {
        claseConexionBD c = new claseConexionBD();
        string texto = "Empresa_Editorial";
        public f2ActualizarEditorial()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Form l11 = new Form1();
            l11.Show();
            this.Hide();
        }

        private void F2ActualizarEditorial_Load(object sender, EventArgs e)
        {
            c.abrirBd();
            c.dgvActualizacion(texto, dgvActEditorial);
        }

        private void F2ActualizarEditorial_FormClosing(object sender, FormClosingEventArgs e)
        {
            c.cerrarBd();
        }

        private void DgvActEditorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvActEditorial.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvActEditorial.CurrentRow.Cells[1].Value.ToString();
            txtDireccion.Text = dgvActEditorial.CurrentRow.Cells[2].Value.ToString();
            txtNombre.Enabled = true;
            txtDireccion.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCodigo.Text == "" || txtDireccion.Text == "")
            {
                MessageBox.Show("Se deben llenar todos los campos");
            }
            else
            {
                string valor;
                valor = txtCodigo.Text;
                bool v = false;
                string nameTabla = "Empresa_Editorial";
                string nameColumna = "Codigo";
                string relleno1 = "", relleno2 = "", relleno3 = "", relleno4 = "";
                c.actuEliminarEditorial(v, nameTabla, nameColumna, valor, relleno1, relleno2, relleno3, relleno4);
                /////////
                txtNombre.Text = "";
                txtCodigo.Text = "";
                txtDireccion.Text = "";
                txtNombre.Enabled = false;
                txtDireccion.Enabled = false;
                MessageBox.Show("Dato eliminado correctamente");
                c.dgvActualizacion(texto, dgvActEditorial);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCodigo.Text == "" || txtDireccion.Text == "")
            {
                MessageBox.Show("Se deben llenar todos los campos");
            }
            else
            {
                bool v = true;
                string nameTabla = "Empresa_Editorial";
                string nameColumna = "Codigo";
                string valor;
                valor = txtCodigo.Text;
                ////columnas
                string nom = "Nombre", dr = "Direccion";
                ////Valor celda de columna
                string nValor, dValor;
                nValor = txtNombre.Text;
                dValor = txtDireccion.Text;
                ////////////////////////////////////////////////////
                c.actuEliminarEditorial(v, nameTabla, nameColumna, valor, nom, nValor, dr, dValor);
                txtNombre.Text = "";
                txtCodigo.Text = "";
                txtDireccion.Text = "";
                txtNombre.Enabled = false;
                txtDireccion.Enabled = false;
                MessageBox.Show("Dato actualizado correctamente");
                c.dgvActualizacion(texto, dgvActEditorial);
            }
        }
    }
}
