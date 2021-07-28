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
    public partial class f5AgregarLibro : Form
    {
        claseConexionBD l = new claseConexionBD();
        string cedulaAutor;
        string codigoEditorial;
        string codigoCategoria;
        public f5AgregarLibro()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Form l5 = new Form1();
            l5.Show();
            this.Hide();
        }

        private void F5AgregarLibro_Load(object sender, EventArgs e)
        {
            l.abrirBd();
            ///Combobox Autor
            string l1Autor = "Nombre", l2Autor = "Autor_Libros";
            l.llenarCmbx(l1Autor, l2Autor, cmbAutor);
            ///Combobox Editorial
            string l1Editorial = "Nombre", l2Editorial = "Empresa_Editorial";
            l.llenarCmbx(l1Editorial, l2Editorial, cmbxEditorial);
            ///Combobox Categoria
            string l1Categoria = "Categoria", l2Categoria = "Categoria_Libros";
            l.llenarCmbx(l1Categoria, l2Categoria, cmbxCategoria);
        }

        private void F5AgregarLibro_FormClosing(object sender, FormClosingEventArgs e)
        {
            l.cerrarBd();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ///------------ SABER PRIMARY KEY DE LAS FOREING KEY-------------//
            ////cedula Autor
            dgvChequeo.Visible = true;
            string n1 = "Cedula", n2 = "Autor_Libros", n3 = "Nombre", n4;
            n4 = cmbAutor.Text;
            l.saberNombreSegunClave1(n1, n2, n3, n4, dgvChequeo);
            cedulaAutor = dgvChequeo.CurrentRow.Cells[0].Value.ToString();
            dgvChequeo.ClearSelection();
            dgvChequeo.Visible = false;
            ////Codigo Editorial
            dgvChequeo.Visible = true;
            string E1 = "Codigo", E2 = "Empresa_Editorial", E3 = "Nombre", E4;
            E4 = cmbxEditorial.Text;
            l.saberNombreSegunClave1(E1, E2, E3, E4, dgvChequeo);
            codigoEditorial = dgvChequeo.CurrentRow.Cells[0].Value.ToString();
            dgvChequeo.ClearSelection();
            dgvChequeo.Visible = false;
            ////Codigo Categotia
            dgvChequeo.Visible = true;
            string C1 = "Codigo", C2 = "Categoria_Libros", C3 = "Categoria", C4;
            C4 = cmbxCategoria.Text;
            l.saberNombreSegunClave1(C1, C2, C3, C4, dgvChequeo);
            codigoCategoria = dgvChequeo.CurrentRow.Cells[0].Value.ToString();
            dgvChequeo.ClearSelection();
            dgvChequeo.Visible = false;
            ///---------------------------------------------------------------//
            string txt1, txt2, txt3, txt4, txt5, txt6;
            bool v = false;
            if (txtNombre.Text == "" || txtCodigo.Text == "" || txtPaginas.Text == "" || txtPrecio.Text == "" || txtImg.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Se deben llenar todos los campos", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txt1 = txtCodigo.Text;
                txt2 = txtNombre.Text;
                txt3 = txtPaginas.Text;
                txt4 = txtPrecio.Text;
                txt5 = txtImg.Text;
                txt6 = txtCantidad.Text;
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtPaginas.Text = "";
                txtPrecio.Text = "";
                txtImg.Text = "";
                txtCantidad.Text = "";
                cmbAutor.Text = "";
                cmbxCategoria.Text = "";
                cmbxEditorial.Text = "";

                v = l.registroLibros(txt1, txt2, txt3, txt4, txt5, txt6, cedulaAutor, codigoCategoria, codigoEditorial);
                if (v == true)
                {
                    MessageBox.Show("Regitro exitoso", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
