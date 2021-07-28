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
    public partial class f4Compra : Form
    {
        string nameLibro = "";
        //////////////
        string codigoLibro = "";
        string cedulaAutor = "";
        string CodigoEditorial = "";
        string CodigoCategoria = "";
        claseConexionBD conexion = new claseConexionBD();
        public f4Compra(string nameLibro)
        {
            this.nameLibro = nameLibro;
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Form l4 = new Form1();
            l4.Show();
            this.Hide();
        }

        private void F4Compra_Load_1(object sender, EventArgs e)
        {
            dgvInvisible.Visible = true;
            dgvAutor.Visible = true;
            dgvCantidad.Visible = true;
            dgvCategoria.Visible = true;
            dgvEditorial.Visible = true;
            conexion.abrirBd();
            conexion.mostrarLibro(nameLibro, dgvInvisible);
            //se llenan las variables
            codigoLibro = dgvInvisible.CurrentRow.Cells[0].Value.ToString();
            cedulaAutor = dgvInvisible.CurrentRow.Cells[6].Value.ToString();
            CodigoCategoria = dgvInvisible.CurrentRow.Cells[7].Value.ToString();
            CodigoEditorial = dgvInvisible.CurrentRow.Cells[8].Value.ToString();
            ////////////////////////////////////////////////////////////////////
            conexion.consultaCantidadLibro(codigoLibro, dgvCantidad);
            conexion.consultaAutor(cedulaAutor, dgvAutor);
            conexion.consultaCategoria(CodigoCategoria, dgvCategoria);
            conexion.consultaEditorial(CodigoEditorial, dgvEditorial);
            //se llena la informacion dgvInvisible
            lblBdCodigo.Text = dgvInvisible.CurrentRow.Cells[0].Value.ToString();
            lblNombreLibro.Text = dgvInvisible.CurrentRow.Cells[1].Value.ToString();
            lblBdPaginas.Text = dgvInvisible.CurrentRow.Cells[2].Value.ToString();
            lblPrecio.Text = $"$ {dgvInvisible.CurrentRow.Cells[3].Value.ToString()}";
            try
            {
                pbxImagenLibro.Image = Image.FromFile(dgvInvisible.CurrentRow.Cells[4].Value.ToString());
            }
            catch (Exception)
            {
                pbxImagenLibro.Image = Image.FromFile("incognito.png");
            }
            //se llena la informacion dgvCantidad
            lblDisponibles.Text = dgvCantidad.CurrentRow.Cells[0].Value.ToString();
            //se llena la informacion dgvAutor
            lblBdAutor.Text = dgvAutor.CurrentRow.Cells[0].Value.ToString();
            //se llena la informacion dgvCategoria
            lblBdCategoria.Text = dgvCategoria.CurrentRow.Cells[0].Value.ToString();
            //se llena la informacion dgvEditorial
            lblBdEditorial.Text = dgvEditorial.CurrentRow.Cells[0].Value.ToString();
            //se coloca invisible el dgv
            dgvInvisible.Visible = false;
            dgvAutor.Visible = false;
            dgvCantidad.Visible = false;
            dgvCategoria.Visible = false;
            dgvEditorial.Visible = false;
        }

        private void F4Compra_FormClosing(object sender, FormClosingEventArgs e)
        {
            conexion.cerrarBd();
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            string code;
            string cantidadActual, cantidadCompra;
            int resultado;
            cantidadActual = lblDisponibles.Text;
            cantidadCompra = cmbCantidad.Text;
            code = lblBdCodigo.Text;
            if (Convert.ToInt32(cantidadActual) <= 0)
            {
                MessageBox.Show("Este libro no se encuentra diponible", "Lo sentimos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                resultado = Convert.ToInt32(cantidadActual) - Convert.ToInt32(cantidadCompra);
                conexion.compraLibro(resultado, code);
                dgvVector.Visible = true;
                conexion.mostrarLibro(nameLibro, dgvVector);
                lblDisponibles.Text = dgvVector.CurrentRow.Cells[5].Value.ToString();
                dgvVector.ClearSelection();
                dgvVector.Visible = false;
                MessageBox.Show("COMPRA EXITOSA", " «« »»", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
