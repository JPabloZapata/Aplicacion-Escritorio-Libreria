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
    public partial class f9ClaveAdministrador : Form
    {
        string letra = "";
        public f9ClaveAdministrador(string letra)
        {
            InitializeComponent();
            this.letra = letra;
        }

        public void filtro()
        {
            if (letra == "A") 
            {
                if (txtClave.Text=="2001")
                {
                    Form l9 = new f5AgregarLibro();
                    l9.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Clave incorrecta", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (letra == "B")
                {
                    if (txtClave.Text == "2001")
                    {
                        Form l9 = new F6AgregarAutor();
                        l9.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Clave incorrecta", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (letra == "C")
                    {
                        if (txtClave.Text == "2001")
                        {
                            Form l9 = new f7AgregarEditorial();
                            l9.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Clave incorrecta", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (letra == "D")
                        {
                            if (txtClave.Text == "2001")
                            {
                                Form l9 = new f8AgregarCategorias();
                                l9.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Clave incorrecta", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            if (letra == "E")
                            {
                                if (txtClave.Text == "2001")
                                {
                                    Form l9 = new f2Actualizacion();
                                    l9.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Clave incorrecta", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                if (letra == "F")
                                {
                                    if (txtClave.Text == "2001")
                                    {
                                        Form l9 = new f2ActualizarAutor();
                                        l9.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Clave incorrecta", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    if (letra == "G")
                                    {
                                        if (txtClave.Text == "2001")
                                        {
                                            Form l9 = new f2ActualizarEditorial();
                                            l9.Show();
                                            this.Hide();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Clave incorrecta", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        if (letra == "H")
                                        {
                                            if (txtClave.Text == "2001")
                                            {
                                                Form l9 = new f2ActualizarCategoria();
                                                l9.Show();
                                                this.Hide();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Clave incorrecta", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }  
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Form l9 = new Form1();
            l9.Show();
            this.Hide();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            filtro();
        }

        private void F9ClaveAdministrador_Load(object sender, EventArgs e)
        {
            txtClave.Text = "2001";
        }
    }
}
