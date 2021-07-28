using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace wfLibreria_Hopz
{
    class claseConexionBD
    {
        DataTable dtTable;
        string Cadena = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Libreria; Integrated Security=True";
        public SqlConnection conectarBd = new SqlConnection();

        public claseConexionBD()
        {
            conectarBd.ConnectionString = Cadena;
        }

        public void abrirBd()
        {
            try
            {
                conectarBd.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al conecytar la Bd " + e.Message);
            }
        }

        public void cerrarBd()
        {
            conectarBd.Close();
        }

        public void llenarDgv(DataGridView dgv)
        {
            try
            {
                SqlCommand consulta = new SqlCommand();
                consulta.Connection = conectarBd;
                consulta.CommandText = "select Libros.Codigo_Libro, Libros.Nombre, Libros.N_Paginas, Libros.Precio, Libros.Ubicacion_Img, Libros.Cantidad, Autor_Libros.Nombre as [Nombre_Autor], Categoria_Libros.Categoria as [Categoria], Empresa_Editorial.Nombre as [Editorial] from Libros INNER JOIN Autor_Libros ON Libros.Cedula_Autor = Autor_Libros.Cedula INNER JOIN Categoria_Libros ON Libros.Codigo_Categoria = Categoria_Libros.Codigo INNER JOIN Empresa_Editorial ON Libros.Codigo_Editorial = Empresa_Editorial.Codigo";
                dtTable = new DataTable();
                dtTable.Load(consulta.ExecuteReader());
                dgv.DataSource = dtTable;
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo conectar la BD" + e.Message);
            }
        }

        public void Buscador(TextBox txt, DataGridView dgv)
        {
            SqlCommand buscator = new SqlCommand();
            buscator.Connection = conectarBd;
            buscator.CommandText = "Select Nombre from Libros where Nombre " + "like '%" + txt.Text + "%'";
            DataTable dt = new DataTable();
            abrirBd();
            dt.Load(buscator.ExecuteReader());
            dgv.DataSource = dt;
        }

        public void mostrarLibro(string txt, DataGridView dgv)
        {
            SqlCommand mostrar = new SqlCommand();
            mostrar.Connection = conectarBd;
            mostrar.CommandText = "Select * from Libros where Nombre " + "='" + txt + "'";
            DataTable dttab = new DataTable();
            dttab.Load(mostrar.ExecuteReader());
            dgv.DataSource = dttab;
        } 

        public void consultaAutor(string txtCedula, DataGridView dgv)
        {
            SqlCommand autor = new SqlCommand();
            autor.Connection = conectarBd;
            autor.CommandText = "select Nombre from Autor_Libros where Cedula = " + txtCedula;
            DataTable dttab = new DataTable();
            dttab.Load(autor.ExecuteReader());
            dgv.DataSource = dttab;

        }
        public void consultaCategoria(string txtCodigoCategoria, DataGridView dgv)
        {
            SqlCommand Categoria = new SqlCommand();
            Categoria.Connection = conectarBd;
            Categoria.CommandText = "select Categoria from Categoria_Libros where Codigo =" + txtCodigoCategoria;
            DataTable dttab = new DataTable();
            dttab.Load(Categoria.ExecuteReader());
            dgv.DataSource = dttab;
        }
        public void consultaEditorial(string txtCodigoEditorial, DataGridView dgv)
        {
            SqlCommand Editorial = new SqlCommand();
            Editorial.Connection = conectarBd;
            Editorial.CommandText = "select nombre from Empresa_Editorial where Codigo =" + txtCodigoEditorial;
            DataTable dttab = new DataTable();
            dttab.Load(Editorial.ExecuteReader());
            dgv.DataSource = dttab;
        }

        public void consultaCantidadLibro(string txtCodigoLibro, DataGridView dgv)
        {
            SqlCommand CantidadLibro = new SqlCommand();
            CantidadLibro.Connection = conectarBd;
            CantidadLibro.CommandText = "select cantidad from Libros where Codigo_Libro =" + txtCodigoLibro;
            DataTable dttab = new DataTable();
            dttab.Load(CantidadLibro.ExecuteReader());
            dgv.DataSource = dttab;

        }

        public void dgvActualizacion(string text, DataGridView dgv)
        {
            SqlCommand autor = new SqlCommand();
            autor.Connection = conectarBd;
            autor.CommandText = "select * from " + text;
            DataTable tabla = new DataTable();
            tabla.Load(autor.ExecuteReader());
            dgv.DataSource = tabla;
        }

        public void llenarCmbx(string n1, string n2, ComboBox cmbx)
        {
            SqlCommand comand = new SqlCommand($"Select " + n1 + " from " + n2, conectarBd);
            SqlDataReader registro = comand.ExecuteReader();
            while (registro.Read())
            {
                cmbx.Items.Add(registro[n1].ToString());
            }
            registro.Close();
        }

        public void saberNombreSegunClave(string n1, string n2, string n3, string n4, DataGridView dgv)
        {
            SqlCommand saber = new SqlCommand();
            saber.Connection = conectarBd;
            saber.CommandText = "Select " + n1 + " from " + n2 + " Where " + n3 + " = " + n4;
            DataTable t = new DataTable();
            t.Load(saber.ExecuteReader());
            dgv.DataSource = t;
        }

        public void saberNombreSegunClave1(string n1, string n2, string n3, string n4, DataGridView dgv)
        {
            SqlCommand saber = new SqlCommand();
            saber.Connection = conectarBd;
            saber.CommandText = "Select " + n1 + " from " + n2 + " Where " + n3 + " = '" + n4 + "'";
            DataTable t = new DataTable();
            t.Load(saber.ExecuteReader());
            dgv.DataSource = t;
        }

        public bool registroLibros (string txt1, string txt2, string txt3, string txt4, string txt5, string txt6, string txt7, string txt8, string txt9)
        {
            SqlCommand registraoo = new SqlCommand();
            registraoo.Connection = conectarBd;
            registraoo.CommandText = "INSERT INTO Libros (Codigo_Libro,Nombre,N_paginas,precio,Ubicacion_Img,Cantidad,Cedula_Autor,Codigo_Categoria,Codigo_Editorial) VALUES (@Codigo_Libro,@Nombre,@N_paginas,@precio,@Ubicacion_Img,@Cantidad,@Cedula_Autor,@Codigo_Categoria,@Codigo_Editorial)";
            registraoo.Parameters.AddWithValue("@Codigo_Libro", txt1);
            registraoo.Parameters.AddWithValue("@Nombre", txt2);
            registraoo.Parameters.AddWithValue("@N_paginas", txt3);
            registraoo.Parameters.AddWithValue("@precio", txt4);
            registraoo.Parameters.AddWithValue("@Ubicacion_Img", txt5);
            registraoo.Parameters.AddWithValue("@Cantidad", txt6);
            registraoo.Parameters.AddWithValue("@Cedula_Autor", txt7);
            registraoo.Parameters.AddWithValue("@Codigo_Categoria", txt8);
            registraoo.Parameters.AddWithValue("@Codigo_Editorial", txt9);
            registraoo.ExecuteNonQuery();
            return true;
        }

        public bool registroAutores(string txt1, string txt2, string txt3, string cmbx)
        {
            SqlCommand registreoo = new SqlCommand();
            registreoo.Connection = conectarBd;
            registreoo.CommandText = "INSERT INTO Autor_Libros (Cedula,Nombre,Edad,Sexo) VALUES (@Cedula,@Nombre,@Edad,@Sexo)";
            registreoo.Parameters.AddWithValue("@Cedula", txt1);
            registreoo.Parameters.AddWithValue("@Nombre", txt2);
            registreoo.Parameters.AddWithValue("@Edad", txt3);
            registreoo.Parameters.AddWithValue("@Sexo", cmbx);
            registreoo.ExecuteNonQuery();
            return true;
        }

        public bool registroCategorias(string txt1, string txt2)
        {
            SqlCommand registrioo = new SqlCommand();
            registrioo.Connection = conectarBd;
            registrioo.CommandText = "INSERT INTO Categoria_Libros (Codigo,Categoria) VALUES (@Codigo,@Categoria)";
            registrioo.Parameters.AddWithValue("@Codigo", txt1);
            registrioo.Parameters.AddWithValue("@Categoria", txt2);
            registrioo.ExecuteNonQuery();
            return true;
        }

        public bool registroEditoriales(string txt1, string txt2, string txt3)
        {
            SqlCommand registruoo = new SqlCommand();
            registruoo.Connection = conectarBd;
            registruoo.CommandText = "INSERT INTO Empresa_Editorial (Codigo,Nombre,Direccion) VALUES (@Codigo,@Nombre,@Direccion)";
            registruoo.Parameters.AddWithValue("@Codigo", txt1);
            registruoo.Parameters.AddWithValue("@Nombre", txt2);
            registruoo.Parameters.AddWithValue("@Direccion", txt3);
            registruoo.ExecuteNonQuery();
            return true;
        }

        public void compraLibro(int n1, string n2)
        {
            SqlCommand compra = new SqlCommand();
            compra.Connection = conectarBd;
            compra.CommandText = "update Libros SET Cantidad = " + n1 + " where Codigo_Libro = " + n2;
            compra.ExecuteNonQuery();
        }

        public void actuEliminarAutor(bool v, string txt1/*Name tabla*/, string txt2/*foreing key a tratar*/, string txt3/*dato*/, string txt4/*namde colum a actualizar*/, string txt5/*celda de columna*/, string txt6/*namde colum a actualizar*/, string txt7/*celda de columna*/, string txt8/*namde colum a actualizar*/, string txt9/*celda de columna*/)
        {
            if (v==true)
            {
                SqlCommand actualizar = new SqlCommand();
                actualizar.Connection = conectarBd;
                actualizar.CommandText = "update " + txt1 + " SET " + txt4 + " = '" + txt5 + "'," + txt6 + " = " + txt7 + "," + txt8 + " = '" + txt9 + "' where " + txt2 + " = " + txt3;                                    
                actualizar.ExecuteNonQuery();
            }
            else
            {
                ///------------------- SE EDITA EL LIBRO QUE PERTENECE A ES AUTOR --------------------///
                SqlCommand eliminartrocate = new SqlCommand();
                eliminartrocate.Connection = conectarBd;
                eliminartrocate.CommandText = "UPDATE Libros SET Cedula_Autor = 0 where Cedula_Autor = " + txt3;
                eliminartrocate.ExecuteNonQuery();
                ///--------------------------------- SE ELIMINA EL AUTOR -------------------------------///
                SqlCommand eliminar = new SqlCommand();
                eliminar.Connection = conectarBd;
                eliminar.CommandText = "delete from " + txt1 + " where " + txt2 + " = " + txt3;
                eliminar.ExecuteNonQuery();

            }
        }

        public void actuEliminarCategoria(bool v, string txt1/*Name tabla*/, string txt2/*foreing key a tratar*/, string txt3/*dato*/, string txt4/*namde colum a actualizar*/, string txt5/*celda de columna*/)
        {
            if (v == true)
            {
                SqlCommand actualizar = new SqlCommand();
                actualizar.Connection = conectarBd;
                actualizar.CommandText = "update " + txt1 + " SET " + txt4 + " = '" + txt5 + "' where " + txt2 + " = " + txt3;
                actualizar.ExecuteNonQuery();
            }
            else
            {
                ///------------------- SE EDITA EL LIBRO QUE PERTENECE A ESA CATEGORIA --------------------///
                SqlCommand eliminartrocate = new SqlCommand();
                eliminartrocate.Connection = conectarBd;
                eliminartrocate.CommandText = "UPDATE Libros SET Codigo_Categoria = 0 where Codigo_Categoria = " + txt3;
                eliminartrocate.ExecuteNonQuery();
                ///--------------------------------- SE ELIMINA LA CATEGORIA -------------------------------///
                SqlCommand eliminar = new SqlCommand();
                eliminar.Connection = conectarBd;
                eliminar.CommandText = "delete from " + txt1 + " where " + txt2 + " = " + txt3;
                eliminar.ExecuteNonQuery();

            }
        }

        public void actuEliminarEditorial(bool v, string txt1/*Name tabla*/, string txt2/*foreing key a tratar*/, string txt3/*dato*/, string txt4/*namde colum a actualizar*/, string txt5/*celda de columna*/, string txt6,/*namde colum a actualizar*/ string txt7/*celda de columna*/)
        {
            if (v == true)
            {
                SqlCommand actualizar = new SqlCommand();
                actualizar.Connection = conectarBd;
                actualizar.CommandText = "update " + txt1 + " SET " + txt4 + " = '" + txt5 + "'," + txt6 + " = '" + txt7 + "' where " + txt2 + " = " + txt3;
                actualizar.ExecuteNonQuery();
            }
            else
            {
                ///------------------- SE EDITA EL LIBRO QUE PERTENECE A ESE EDITORILA  --------------------///
                SqlCommand eliminartrocate = new SqlCommand();
                eliminartrocate.Connection = conectarBd;
                eliminartrocate.CommandText = "UPDATE Libros SET Codigo_Editorial = 0 where Codigo_Editorial = " + txt3;
                eliminartrocate.ExecuteNonQuery();
                ///--------------------------------- SE ELIMINA EL EDITORIAL -------------------------------///
                SqlCommand eliminar = new SqlCommand();
                eliminar.Connection = conectarBd;
                eliminar.CommandText = "delete from " + txt1 + " where " + txt2 + " = " + txt3;
                eliminar.ExecuteNonQuery();
            }
        }

        public void actuEliminarLibro(bool v, string txt1, string txt2, string txt3/**/, string txt4, string txt5/**/, string txt6, string txt7/**/, string txt8, string txt9/**/, string txt10, string txt11/**/, string txt12, string txt13/**/, string txt14, string txt15/**/, string txt16, string txt17/**/, string txt18, string txt19)
        {
            if (v == true)
            {
                SqlCommand actualizar = new SqlCommand();
                actualizar.Connection = conectarBd;
                actualizar.CommandText = "update " + txt1 + " SET " + txt4 + " = '" + txt5 + "'," + txt6 + " = '" + txt7 + "'," + txt8 + " = '" + txt9 + "'," + txt10 + " = '" + txt11 + "'," + txt12 + " = '" + txt13 + "'," + txt14 + " = '" + txt15 + "'," + txt16 + " = '" + txt17 + "'," + txt18 + " = '" + txt19 + "' where " + txt2 + " = " + txt3;
                actualizar.ExecuteNonQuery();
            }
            else
            {
                SqlCommand eliminar = new SqlCommand();
                eliminar.Connection = conectarBd;
                eliminar.CommandText = "delete from " + txt1 + " where " + txt2 + " = " + txt3;
                eliminar.ExecuteNonQuery();
            }
        }

        public string cambiazo(string nameTabla, string nameColumn, string nameColumn2, string valor, DataGridView dgv)
        {
            string retornadora;
            SqlCommand actualizar = new SqlCommand();
            actualizar.Connection = conectarBd;
            actualizar.CommandText = "select " + nameColumn + " from " + nameTabla + " where " + nameColumn2 + " = '" + valor + "'";
            DataTable t = new DataTable();
            t.Load(actualizar.ExecuteReader());
            dgv.DataSource = t;
            retornadora = dgv.CurrentRow.Cells[0].Value.ToString();
            actualizar.ExecuteNonQuery();

            return retornadora;
        }
    }           
}