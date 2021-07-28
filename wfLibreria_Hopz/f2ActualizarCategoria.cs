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
    public partial class f2ActualizarCategoria : Form
    {
        claseConexionBD b = new claseConexionBD();
        string texto = "Categoria_Libros";
        public f2ActualizarCategoria()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Form l12 = new Form1();
            l12.Show();
            this.Hide();
        }

        private void F2ActualizarCategoria_Load(object sender, EventArgs e)
        {
            b.abrirBd();
            b.dgvActualizacion(texto, dgvActCategoria);
        }

        private void F2ActualizarCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            b.cerrarBd();
        }

        private void DgvActCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvActCategoria.CurrentRow.Cells[0].Value.ToString();
            txtCategoria.Text = dgvActCategoria.CurrentRow.Cells[1].Value.ToString();
            txtCategoria.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "" || txtCodigo.Text == "")
            {
                MessageBox.Show("Se deben llenar todos los campos");
            }
            else
            {
                string valor;
                valor = txtCodigo.Text;
                bool v = false;
                string nameTabla = "Categoria_Libros";
                string nameColumna = "Codigo";
                string relleno1 = "", relleno2 = "";
                b.actuEliminarCategoria(v, nameTabla, nameColumna, valor, relleno1, relleno2);
                /////////
                txtCategoria.Text = "";
                txtCodigo.Text = "";
                txtCategoria.Enabled = false;
                MessageBox.Show("Dato eliminado correctamente");
                b.dgvActualizacion(texto, dgvActCategoria);
            }

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "" || txtCodigo.Text == "") 
            {
                MessageBox.Show("Se deben llenar todos los campos");
            }
            else
            {
                bool v = true;
                string nameTabla = "Categoria_Libros";
                string nameColumna = "Codigo";
                string valor;
                valor = txtCodigo.Text;
                ////columnas
                string nom = "Categoria";
                ////Valor celda de columna
                string cValor;
                cValor = txtCategoria.Text;
                ////////////////////////////////////////////////////
                b.actuEliminarCategoria(v, nameTabla, nameColumna, valor, nom, cValor);
                txtCategoria.Text = "";
                txtCodigo.Text = "";
                txtCategoria.Enabled = false;
                MessageBox.Show("Dato actualizado correctamente");
                b.dgvActualizacion(texto, dgvActCategoria);
            }
        }
    }
}
