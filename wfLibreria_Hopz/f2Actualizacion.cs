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
    public partial class f2Actualizacion : Form
    {
        claseConexionBD conexion = new claseConexionBD();
        string n1Autor = "Nombre";
        string n2Autor = "Autor_Libros";
        //string n3Autor = "Cedula";
        //string n4Autor;
        ///////////
        string n1Editorial = "Nombre";
        string n2Editorial = "Empresa_Editorial";
        //string n3Editorial = "Codigo";
        //string n4Editorial;
        ///////////
        string n1Categoria = "Categoria";
        string n2Categoria = "Categoria_Libros";
        //string n3Categoria = "Codigo";
        //string n4Categoria;
        public f2Actualizacion()
        {
            InitializeComponent();
        }

        private void F2Actualizacion_Load(object sender, EventArgs e)
        {
            conexion.abrirBd();
            conexion.llenarDgv(dgvActualizacion);
            conexion.llenarCmbx(n1Autor, n2Autor, cmbxAutor);
            conexion.llenarCmbx(n1Editorial, n2Editorial, cmbxEditorial);
            conexion.llenarCmbx(n1Categoria, n2Categoria, cmbxCategoria);
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Form l2 = new Form1();
            l2.Show();
            this.Hide();
        }

        private void F2Actualizacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            conexion.cerrarBd();
        }

        private void DgvActualizacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvActualizacion.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvActualizacion.CurrentRow.Cells[1].Value.ToString();
            txtPaginas.Text = dgvActualizacion.CurrentRow.Cells[2].Value.ToString();
            txtPrecio.Text = dgvActualizacion.CurrentRow.Cells[3].Value.ToString();
            txtImagen.Text = dgvActualizacion.CurrentRow.Cells[4].Value.ToString();
            txtCantidad.Text = dgvActualizacion.CurrentRow.Cells[5].Value.ToString();
            cmbxAutor.Text = dgvActualizacion.CurrentRow.Cells[6].Value.ToString();
            cmbxCategoria.Text = dgvActualizacion.CurrentRow.Cells[7].Value.ToString();
            cmbxEditorial.Text = dgvActualizacion.CurrentRow.Cells[8].Value.ToString();
            txtCodigo.Enabled = false;
            txtNombre.Enabled = true;
            txtCantidad.Enabled = true;
            txtImagen.Enabled = true;
            txtPaginas.Enabled = true;
            txtPrecio.Enabled = true;
            cmbxAutor.Enabled = true;
            cmbxCategoria.Enabled = true;
            cmbxEditorial.Enabled = true;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtImagen.Text = "";
            txtPaginas.Text = "";
            txtPrecio.Text = "";
            cmbxAutor.Text = "";
            cmbxCategoria.Text = "";
            cmbxEditorial.Text = "";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCodigo.Text == "" || txtCantidad.Text == "" || txtImagen.Text == "" || txtPaginas.Text == "" || txtPrecio.Text == "" || cmbxAutor.Text == "" || cmbxCategoria.Text == "" || cmbxEditorial.Text == "")
            {
                MessageBox.Show("Se deben llenar todos los campos");
            }
            else
            {
                string valor;
                valor = txtCodigo.Text;
                bool v = false;
                string nameTabla = "Libros";
                string nameColumna = "Codigo_Libro";
                string relleno1 = "", relleno2 = "", relleno3 = "", relleno4 = "", relleno5 = "", relleno6 = "", relleno7 = "", relleno8 = "", relleno9 = "", relleno10 = "", relleno11 = "", relleno12 = "", relleno13 = "", relleno14 = "", relleno15 = "", relleno16 = "";
                conexion.actuEliminarLibro(v, nameTabla, nameColumna, valor/**/, relleno1, relleno2, relleno3, relleno4, relleno5, relleno6, relleno7, relleno8, relleno9, relleno10, relleno11, relleno12, relleno13, relleno14, relleno15, relleno16);
                /////////
                txtNombre.Text = "";
                txtCodigo.Text = "";
                txtCantidad.Text = "";
                txtImagen.Text = "";
                txtPaginas.Text = "";
                txtPrecio.Text = "";
                cmbxAutor.Text = "";
                cmbxCategoria.Text = "";
                cmbxEditorial.Text = "";
                txtNombre.Enabled = false;
                txtCantidad.Enabled = false;
                txtImagen.Enabled = false;
                txtPaginas.Enabled = false;
                txtPrecio.Enabled = false;
                cmbxAutor.Enabled = false;
                cmbxCategoria.Enabled = false;
                cmbxEditorial.Enabled = false;
                MessageBox.Show("Libro eliminado correctamente");
                conexion.llenarDgv(dgvActualizacion);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCodigo.Text == "" || txtCantidad.Text == "" || txtImagen.Text == "" || txtPaginas.Text == "" || txtPrecio.Text == "" || cmbxAutor.Text == "" || cmbxCategoria.Text == "" || cmbxEditorial.Text == "")
            {
                MessageBox.Show("Se deben llenar todos los campos");
            }
            else
            {
                bool v = true;
                string nameTabla = "Libros";
                string nameColumna = "Codigo_Libro";
                string valor, nm, pg, precio, im, can;
                valor = txtCodigo.Text;
                nm = txtNombre.Text;
                pg = txtPaginas.Text;
                precio = txtPrecio.Text;
                im = txtImagen.Text;
                can = txtCantidad.Text;
                ////columnas
                string nom = "Nombre", pag = "N_Paginas", pr = "Precio", img = "Ubicacion_Img", canti = "Cantidad", cedA = "Cedula_Autor", codCat = "Codigo_Categoria", codEdit = "Codigo_Editorial";
                ////Valor celda de columna
                string nValor, cValor, iValor, pValor, prValor, c_A_Valor, C_C_Valor, C_E_Valor;
                nValor = txtNombre.Text;
                cValor = txtCantidad.Text;
                iValor = txtImagen.Text;
                pValor = txtPaginas.Text;
                prValor = txtPrecio.Text;
                ///////Saber cedula autor
                string nameTablaA = "Autor_Libros";
                string nameColumnaA = "Cedula";
                string nameColumna2A = "Nombre";
                string valorA = cmbxAutor.Text;
                dgvConsulta.Visible = true;
                c_A_Valor = conexion.cambiazo(nameTablaA, nameColumnaA, nameColumna2A, valorA, dgvConsulta);
                dgvConsulta.ClearSelection();
                dgvConsulta.Visible = false;
                ////////////////////////////////////////////////////////////////////////////////////////////
                ///////Saber Codigo Categoria
                string nameTablaC = "Categoria_Libros";
                string nameColumnaC = "Codigo";
                string nameColumna2C = "Categoria";
                string valorC = cmbxCategoria.Text;
                dgvConsulta.Visible = true;
                C_C_Valor = conexion.cambiazo(nameTablaC, nameColumnaC, nameColumna2C, valorC, dgvConsulta);
                dgvConsulta.ClearSelection();
                dgvConsulta.Visible = false;
                ////////////////////////////////////////////////////////////////////////////////////////////
                ///////Saber Codigo Editorial
                string nameTablaE = "Empresa_Editorial";
                string nameColumnaE = "Codigo";
                string nameColumna2E = "Nombre";
                string valorE = cmbxEditorial.Text;
                dgvConsulta.Visible = true;
                C_E_Valor = conexion.cambiazo(nameTablaE, nameColumnaE, nameColumna2E, valorE, dgvConsulta);
                dgvConsulta.ClearSelection();
                dgvConsulta.Visible = false;
                ////////////////////////////////////////////////////////////////////////////////////////////

                ////////////////////////////////////////////////////
                conexion.actuEliminarLibro(v, nameTabla, nameColumna, valor,/**/nom, nm, pag, pg, pr, precio, img, im, canti, can, cedA, c_A_Valor, codCat, C_C_Valor, codEdit, C_E_Valor);
                txtNombre.Text = "";
                txtCodigo.Text = "";
                txtCantidad.Text = "";
                txtImagen.Text = "";
                txtPaginas.Text = "";
                txtPrecio.Text = "";
                cmbxAutor.Text = "";
                cmbxCategoria.Text = "";
                cmbxEditorial.Text = "";
                txtNombre.Enabled = false;
                txtCantidad.Enabled = false;
                txtImagen.Enabled = false;
                txtPaginas.Enabled = false;
                txtPrecio.Enabled = false;
                cmbxAutor.Enabled = false;
                cmbxCategoria.Enabled = false;
                cmbxEditorial.Enabled = false;
                MessageBox.Show("Dato actualizado correctamente");
                conexion.llenarDgv(dgvActualizacion);
            }
        }
    }
}
