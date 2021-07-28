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
    public partial class Form1 : Form
    {
        private int conta = 0;
        bool aprob = false;
        ///Agregar
        string letra = "A";
        string letra1 = "B";
        string letra2 = "C";
        string letra3 = "D";
        ///Actualizar
        string letra4 = "E";
        string letra5 = "F";
        string letra6 = "G";
        string letra7 = "H";
        string nameLibro = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLupita_Click(object sender, EventArgs e)
        {
            dgvBusqueda.Visible = false;
            nameLibro = txtBuscador.Text;
            if (txtBuscador.Text != "")
            {
                Form l1 = new f4Compra(nameLibro);
                l1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No selecciono ningun libro");
            }
        }

        private void BtnVerTodos_Click(object sender, EventArgs e)
        {
            dgvBusqueda.Visible = false;
            Form l1 = new f3VerTodos();
            l1.Show();
            this.Hide();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            conta++;
            if (conta % 2 == 0)
            {
                if (aprob==false)
                {
                    pbxImagenCambiante.Image = Image.FromFile("l1.jpg");
                    aprob = true;
                }
                else
                {
                    pbxImagenCambiante.Image = Image.FromFile("l3.jpg");
                    aprob = false;
                }

            }
            else
            {
                pbxImagenCambiante.Image = Image.FromFile("l2.jpg");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            dgvBusqueda.Visible = false;
            claseConexionBD conexio = new claseConexionBD();
            conexio.abrirBd();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            claseConexionBD conexio = new claseConexionBD();
            conexio.cerrarBd();
        }

        private void BtnAgregar_MouseHover(object sender, EventArgs e)
        {
            ///Agregar
            btnAgregarLibro.Visible = true;
            btnAgregarAutor.Visible = true;
            btnEditorialLibro.Visible = true;
            btnCategoriaLibro.Visible = true;
            btnAgregarLibro.BackColor = Color.White;
            btnAgregarAutor.BackColor = Color.White;
            btnEditorialLibro.BackColor = Color.White;
            btnCategoriaLibro.BackColor = Color.White;
            //////////////////////////////////////////
            ///Actualizar
            btnActualizarLibro.Visible = false;
            btnActualizarAutor.Visible = false;
            btnActualizarEditorial.Visible = false;
            btnActualizarCategoria.Visible = false;
            btnActualizarLibro.BackColor = Color.White;
            btnActualizarAutor.BackColor = Color.White;
            btnActualizarEditorial.BackColor = Color.White;
            btnActualizarCategoria.BackColor = Color.White;
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            ///Agregar
            btnAgregarLibro.Visible = false;
            btnAgregarAutor.Visible = false;
            btnEditorialLibro.Visible = false;
            btnCategoriaLibro.Visible = false;
            btnAgregarLibro.BackColor = Color.White;
            btnAgregarAutor.BackColor = Color.White;
            btnEditorialLibro.BackColor = Color.White;
            btnCategoriaLibro.BackColor = Color.White;
            //////////////////////////////////////////
            ///Actualizar
            btnActualizarLibro.Visible = false;
            btnActualizarAutor.Visible = false;
            btnActualizarEditorial.Visible = false;
            btnActualizarCategoria.Visible = false;
            btnActualizarLibro.BackColor = Color.White;
            btnActualizarAutor.BackColor = Color.White;
            btnActualizarEditorial.BackColor = Color.White;
            btnActualizarCategoria.BackColor = Color.White;
        }

        private void PnlTitulo_MouseHover(object sender, EventArgs e)
        {
            ///Agregar
            btnAgregarLibro.Visible = false;
            btnAgregarAutor.Visible = false;
            btnEditorialLibro.Visible = false;
            btnCategoriaLibro.Visible = false;
            btnAgregarLibro.BackColor = Color.White;
            btnAgregarAutor.BackColor = Color.White;
            btnEditorialLibro.BackColor = Color.White;
            btnCategoriaLibro.BackColor = Color.White;
            //////////////////////////////////////////
            ///Actualizar
            btnActualizarLibro.Visible = false;
            btnActualizarAutor.Visible = false;
            btnActualizarEditorial.Visible = false;
            btnActualizarCategoria.Visible = false;
            btnActualizarLibro.BackColor = Color.White;
            btnActualizarAutor.BackColor = Color.White;
            btnActualizarEditorial.BackColor = Color.White;
            btnActualizarCategoria.BackColor = Color.White;
        }

        private void LblTitulo_MouseHover(object sender, EventArgs e)
        {
            ///Agregar
            btnAgregarLibro.Visible = false;
            btnAgregarAutor.Visible = false;
            btnEditorialLibro.Visible = false;
            btnCategoriaLibro.Visible = false;
            btnAgregarLibro.BackColor = Color.White;
            btnAgregarAutor.BackColor = Color.White;
            btnEditorialLibro.BackColor = Color.White;
            btnCategoriaLibro.BackColor = Color.White;
            //////////////////////////////////////////
            ///Actualizar
            btnActualizarLibro.Visible = false;
            btnActualizarAutor.Visible = false;
            btnActualizarEditorial.Visible = false;
            btnActualizarCategoria.Visible = false;
            btnActualizarLibro.BackColor = Color.White;
            btnActualizarAutor.BackColor = Color.White;
            btnActualizarEditorial.BackColor = Color.White;
            btnActualizarCategoria.BackColor = Color.White;
        }

        private void TxtBuscador_MouseHover(object sender, EventArgs e)
        {
            ///Agregar
            btnAgregarLibro.Visible = false;
            btnAgregarAutor.Visible = false;
            btnEditorialLibro.Visible = false;
            btnCategoriaLibro.Visible = false;
            btnAgregarLibro.BackColor = Color.White;
            btnAgregarAutor.BackColor = Color.White;
            btnEditorialLibro.BackColor = Color.White;
            btnCategoriaLibro.BackColor = Color.White;
            //////////////////////////////////////////
            ///Actualizar
            btnActualizarLibro.Visible = false;
            btnActualizarAutor.Visible = false;
            btnActualizarEditorial.Visible = false;
            btnActualizarCategoria.Visible = false;
            btnActualizarLibro.BackColor = Color.White;
            btnActualizarAutor.BackColor = Color.White;
            btnActualizarEditorial.BackColor = Color.White;
            btnActualizarCategoria.BackColor = Color.White;
        }

        private void PbxImagenCambiante_MouseHover(object sender, EventArgs e)
        {
            ///Agregar
            btnAgregarLibro.Visible = false;
            btnAgregarAutor.Visible = false;
            btnEditorialLibro.Visible = false;
            btnCategoriaLibro.Visible = false;
            btnAgregarLibro.BackColor = Color.White;
            btnAgregarAutor.BackColor = Color.White;
            btnEditorialLibro.BackColor = Color.White;
            btnCategoriaLibro.BackColor = Color.White;
            //////////////////////////////////////////
            ///Actualizar
            btnActualizarLibro.Visible = false;
            btnActualizarAutor.Visible = false;
            btnActualizarEditorial.Visible = false;
            btnActualizarCategoria.Visible = false;
            btnActualizarLibro.BackColor = Color.White;
            btnActualizarAutor.BackColor = Color.White;
            btnActualizarEditorial.BackColor = Color.White;
            btnActualizarCategoria.BackColor = Color.White;
        }

        private void BtnActualizar_MouseHover(object sender, EventArgs e)
        {
            ///Agregar
            btnAgregarLibro.Visible = false;
            btnAgregarAutor.Visible = false;
            btnEditorialLibro.Visible = false;
            btnCategoriaLibro.Visible = false;
            btnAgregarLibro.BackColor = Color.White;
            btnAgregarAutor.BackColor = Color.White;
            btnEditorialLibro.BackColor = Color.White;
            btnCategoriaLibro.BackColor = Color.White;
            //////////////////////////////////////////
            ///Actualizar
            btnActualizarLibro.Visible = true;
            btnActualizarAutor.Visible = true;
            btnActualizarEditorial.Visible = true;
            btnActualizarCategoria.Visible = true;
            btnActualizarLibro.BackColor = Color.White;
            btnActualizarAutor.BackColor = Color.White;
            btnActualizarEditorial.BackColor = Color.White;
            btnActualizarCategoria.BackColor = Color.White;
        }

        private void BtnVerTodos_MouseHover(object sender, EventArgs e)
        {
            ///Agregar
            btnAgregarLibro.Visible = false;
            btnAgregarAutor.Visible = false;
            btnEditorialLibro.Visible = false;
            btnCategoriaLibro.Visible = false;
            btnAgregarLibro.BackColor = Color.White;
            btnAgregarAutor.BackColor = Color.White;
            btnEditorialLibro.BackColor = Color.White;
            btnCategoriaLibro.BackColor = Color.White;
            //////////////////////////////////////////
            ///Actualizar
            btnActualizarLibro.Visible = false;
            btnActualizarAutor.Visible = false;
            btnActualizarEditorial.Visible = false;
            btnActualizarCategoria.Visible = false;
            btnActualizarLibro.BackColor = Color.White;
            btnActualizarAutor.BackColor = Color.White;
            btnActualizarEditorial.BackColor = Color.White;
            btnActualizarCategoria.BackColor = Color.White;
        }

        private void BtnLupita_MouseHover(object sender, EventArgs e)
        {
            ///Agregar
            btnAgregarLibro.Visible = false;
            btnAgregarAutor.Visible = false;
            btnEditorialLibro.Visible = false;
            btnCategoriaLibro.Visible = false;
            btnAgregarLibro.BackColor = Color.White;
            btnAgregarAutor.BackColor = Color.White;
            btnEditorialLibro.BackColor = Color.White;
            btnCategoriaLibro.BackColor = Color.White;
            //////////////////////////////////////////
            ///Actualizar
            btnActualizarLibro.Visible = false;
            btnActualizarAutor.Visible = false;
            btnActualizarEditorial.Visible = false;
            btnActualizarCategoria.Visible = false;
            btnActualizarLibro.BackColor = Color.White;
            btnActualizarAutor.BackColor = Color.White;
            btnActualizarEditorial.BackColor = Color.White;
            btnActualizarCategoria.BackColor = Color.White;
        }

        private void BtnAgregarLibro_MouseHover(object sender, EventArgs e)
        {
            btnAgregarLibro.BackColor = Color.Gray;
            btnAgregarAutor.BackColor = Color.White;
            btnEditorialLibro.BackColor = Color.White;
            btnCategoriaLibro.BackColor = Color.White;
        }

        private void BtnAgregarAutor_MouseHover(object sender, EventArgs e)
        {
            btnAgregarAutor.BackColor = Color.Gray;
            btnAgregarLibro.BackColor = Color.White;
            btnEditorialLibro.BackColor = Color.White;
            btnCategoriaLibro.BackColor = Color.White;
        }

        private void BtnEditorialLibro_MouseHover(object sender, EventArgs e)
        {
            btnEditorialLibro.BackColor = Color.Gray;
            btnAgregarLibro.BackColor = Color.White;
            btnAgregarAutor.BackColor = Color.White;
            btnCategoriaLibro.BackColor = Color.White;
        }

        private void BtnCategoriaLibro_MouseHover(object sender, EventArgs e)
        {
            btnCategoriaLibro.BackColor = Color.Gray;
            btnAgregarLibro.BackColor = Color.White;
            btnAgregarAutor.BackColor = Color.White;
            btnEditorialLibro.BackColor = Color.White;
        }

        private void BtnAgregarLibro_Click(object sender, EventArgs e)
        {
            dgvBusqueda.Visible = false;
            Form l1 = new f9ClaveAdministrador(letra);
            l1.Show();
            this.Hide();
        }

        private void BtnAgregarAutor_Click(object sender, EventArgs e)
        {
            dgvBusqueda.Visible = false;
            Form l1 = new f9ClaveAdministrador(letra1);
            l1.Show();
            this.Hide();
        }

        private void BtnEditorialLibro_Click(object sender, EventArgs e)
        {
            dgvBusqueda.Visible = false;
            Form l1 = new f9ClaveAdministrador(letra2);
            l1.Show();
            this.Hide();
        }

        private void BtnCategoriaLibro_Click(object sender, EventArgs e)
        {
            dgvBusqueda.Visible = false;
            Form l1 = new f9ClaveAdministrador(letra3);
            l1.Show();
            this.Hide();
        }

        private void PnlTitulo_Paint(object sender, PaintEventArgs e)
        {
            dgvBusqueda.Visible = false;
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {
            dgvBusqueda.Visible = false;
        }

        private void LblNombreLibro_Click(object sender, EventArgs e)
        {
            dgvBusqueda.Visible = false;
        }

        private void PbxImagenCambiante_Click(object sender, EventArgs e)
        {
            dgvBusqueda.Visible = false;
        }

        private void DgvBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBuscador.Text = dgvBusqueda.CurrentRow.Cells[0].Value.ToString();
        }

        private void TxtBuscador_TextChanged_1(object sender, EventArgs e)
        {
            claseConexionBD conexio = new claseConexionBD();
            dgvBusqueda.Visible = true;
            conexio.Buscador(txtBuscador, dgvBusqueda);
        }

        private void BtnActualizarLibro_MouseHover(object sender, EventArgs e)
        {
            btnActualizarLibro.BackColor = Color.Gray;
            btnActualizarAutor.BackColor = Color.White;
            btnActualizarEditorial.BackColor = Color.White;
            btnActualizarCategoria.BackColor = Color.White;
        }

        private void BtnActualizarAutor_MouseHover(object sender, EventArgs e)
        {
            btnActualizarLibro.BackColor = Color.White;
            btnActualizarAutor.BackColor = Color.Gray;
            btnActualizarEditorial.BackColor = Color.White;
            btnActualizarCategoria.BackColor = Color.White;
        }

        private void BtnActualizarEditorial_MouseHover(object sender, EventArgs e)
        {
            btnActualizarLibro.BackColor = Color.White;
            btnActualizarAutor.BackColor = Color.White;
            btnActualizarEditorial.BackColor = Color.Gray;
            btnActualizarCategoria.BackColor = Color.White;
        }

        private void BtnActualizarCategoria_MouseHover(object sender, EventArgs e)
        {
            btnActualizarLibro.BackColor = Color.White;
            btnActualizarAutor.BackColor = Color.White;
            btnActualizarEditorial.BackColor = Color.White;
            btnActualizarCategoria.BackColor = Color.Gray;
        }

        private void BtnActualizarLibro_Click(object sender, EventArgs e)
        {
            dgvBusqueda.Visible = false;
            f9ClaveAdministrador l1 = new f9ClaveAdministrador(letra4);
            l1.Show();
            this.Hide();
            /*
            Form l1 = new f2Actualizacion();
            l1.Show();
            this.Hide();*/
        }

        private void BtnActualizarAutor_Click(object sender, EventArgs e)
        {
            dgvBusqueda.Visible = false;
            f9ClaveAdministrador l1 = new f9ClaveAdministrador(letra5);
            l1.Show();
            this.Hide();
        }

        private void BtnActualizarEditorial_Click(object sender, EventArgs e)
        {
            dgvBusqueda.Visible = false;
            f9ClaveAdministrador l1 = new f9ClaveAdministrador(letra6);
            l1.Show();
            this.Hide();
        }

        private void BtnActualizarCategoria_Click(object sender, EventArgs e)
        {
            dgvBusqueda.Visible = false;
            f9ClaveAdministrador l1 = new f9ClaveAdministrador(letra7);
            l1.Show();
            this.Hide();
        }
    }
}
