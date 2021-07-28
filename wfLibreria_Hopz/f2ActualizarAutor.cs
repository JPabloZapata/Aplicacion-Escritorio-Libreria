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
    public partial class f2ActualizarAutor : Form
    {
        claseConexionBD a = new claseConexionBD();
        string texto = "Autor_Libros";
        string n1 = "Sexo";
        string n2 = "Autor_Libros";
        string n3 = "Cedula";
        string tCedula;
        //int saberFilasdgv = 0;
        public f2ActualizarAutor()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Form l10 = new Form1();
            l10.Show();
            this.Hide();
        }

        private void F2ActualizarAutor_Load(object sender, EventArgs e)
        {
            /*string t = "Libros";*/
            a.abrirBd();
            a.dgvActualizacion(texto, dgvActuAutor);
            /*a.dgvActualizacion(t, dgvMaraña);*/
            /*for (int i = 1; i <= dgvMaraña.RowCount ; i++)
            {
                saberFilasdgv++;
            }*/
        }

        private void F2ActualizarAutor_FormClosing(object sender, FormClosingEventArgs e)
        {
            a.cerrarBd();
        }

        private void DgvActuAutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tCedula = dgvActuAutor.CurrentRow.Cells[0].Value.ToString();
            txtCedula.Text = dgvActuAutor.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvActuAutor.CurrentRow.Cells[1].Value.ToString();
            txtEdad.Text = dgvActuAutor.CurrentRow.Cells[2].Value.ToString();
            dgvSexo.Visible = true;
            a.saberNombreSegunClave(n1, n2, n3, tCedula, dgvSexo);
            cmbxSexo.Text = dgvSexo.CurrentRow.Cells[0].Value.ToString();
            dgvSexo.Visible = false;
            txtNombre.Enabled = true;
            txtEdad.Enabled = true;
            cmbxSexo.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == "" || txtNombre.Text == "" || txtEdad.Text == "" || cmbxSexo.Text == "")
            {
                MessageBox.Show("Se deben llenar todos los campos");
            }
            else
            {
                string valor;
                valor = txtCedula.Text;
                bool v = false;
                string nameTabla = "Autor_Libros";
                string nameColumna = "Cedula";
                string relleno1 = "", relleno2 = "", relleno3 = "", relleno4 = "", relleno5 = "", relleno6 = "";
                a.actuEliminarAutor(v, nameTabla, nameColumna, valor, relleno1, relleno2, relleno3, relleno4, relleno5, relleno6);
                txtCedula.Text = "";
                txtNombre.Text = "";
                txtEdad.Text = "";
                cmbxSexo.Text = "";
                txtNombre.Enabled = false;
                txtEdad.Enabled = false;
                cmbxSexo.Enabled = false;
                MessageBox.Show("Dato eliminado correctamente");
                a.dgvActualizacion(texto, dgvActuAutor);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == "" || txtNombre.Text == "" || txtEdad.Text == "" || cmbxSexo.Text == "")
            {
                MessageBox.Show("Se deben llenar todos los campos");
            }
            else
            {
                bool v = true;
                string nameTabla = "Autor_Libros";
                string nameColumna = "Cedula";
                string valor;
                valor = txtCedula.Text;
                ////columnas
                string nom = "Nombre", edad = "Edad", sexo = "Sexo";
                ////Valor celda de columna
                string nValor, eValor, sValor;
                nValor = txtNombre.Text;
                eValor = txtEdad.Text;
                sValor = cmbxSexo.Text;
                ////////////////////////////////////////////////////
                a.actuEliminarAutor(v, nameTabla, nameColumna, valor, nom, nValor, edad, eValor, sexo, sValor);
                txtCedula.Text = "";
                txtNombre.Text = "";
                txtEdad.Text = "";
                cmbxSexo.Text = "";
                txtNombre.Enabled = false;
                txtEdad.Enabled = false;
                cmbxSexo.Enabled = false;
                MessageBox.Show("Dato actualizado correctamente");
                a.dgvActualizacion(texto, dgvActuAutor);
            }
        }
    }
}
