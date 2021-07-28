namespace wfLibreria_Hopz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLupita = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblInferior = new System.Windows.Forms.Label();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.btnAgregarAutor = new System.Windows.Forms.Button();
            this.pbxImagenCambiante = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnEditorialLibro = new System.Windows.Forms.Button();
            this.btnCategoriaLibro = new System.Windows.Forms.Button();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.btnActualizarLibro = new System.Windows.Forms.Button();
            this.btnActualizarAutor = new System.Windows.Forms.Button();
            this.btnActualizarEditorial = new System.Windows.Forms.Button();
            this.btnActualizarCategoria = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenCambiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(0, -1);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(651, 122);
            this.pnlTitulo.TabIndex = 0;
            this.pnlTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlTitulo_Paint);
            this.pnlTitulo.MouseHover += new System.EventHandler(this.PnlTitulo_MouseHover);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(136, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(363, 76);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "LIBRERIA HOPZ";
            this.lblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
            this.lblTitulo.MouseHover += new System.EventHandler(this.LblTitulo_MouseHover);
            // 
            // btnLupita
            // 
            this.btnLupita.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLupita.BackgroundImage")));
            this.btnLupita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLupita.Location = new System.Drawing.Point(520, 148);
            this.btnLupita.Name = "btnLupita";
            this.btnLupita.Size = new System.Drawing.Size(63, 28);
            this.btnLupita.TabIndex = 2;
            this.btnLupita.UseVisualStyleBackColor = true;
            this.btnLupita.Click += new System.EventHandler(this.BtnLupita_Click);
            this.btnLupita.MouseHover += new System.EventHandler(this.BtnLupita_MouseHover);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AccessibleDescription = "";
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.btnActualizar.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(241, 271);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(154, 46);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Tag = "";
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.MouseHover += new System.EventHandler(this.BtnActualizar_MouseHover);
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.AccessibleDescription = "";
            this.btnVerTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.btnVerTodos.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodos.ForeColor = System.Drawing.Color.White;
            this.btnVerTodos.Location = new System.Drawing.Point(437, 271);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(154, 46);
            this.btnVerTodos.TabIndex = 4;
            this.btnVerTodos.Tag = "";
            this.btnVerTodos.Text = "Ver Todos";
            this.btnVerTodos.UseVisualStyleBackColor = false;
            this.btnVerTodos.Click += new System.EventHandler(this.BtnVerTodos_Click);
            this.btnVerTodos.MouseHover += new System.EventHandler(this.BtnVerTodos_MouseHover);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleDescription = "";
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.btnAgregar.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(44, 271);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(154, 46);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Tag = "";
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.MouseHover += new System.EventHandler(this.BtnAgregar_MouseHover);
            // 
            // lblInferior
            // 
            this.lblInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.lblInferior.Location = new System.Drawing.Point(-3, 480);
            this.lblInferior.Name = "lblInferior";
            this.lblInferior.Size = new System.Drawing.Size(654, 18);
            this.lblInferior.TabIndex = 10;
            this.lblInferior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.BackColor = System.Drawing.Color.White;
            this.btnAgregarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLibro.Location = new System.Drawing.Point(44, 316);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(154, 29);
            this.btnAgregarLibro.TabIndex = 11;
            this.btnAgregarLibro.Text = "Libro";
            this.btnAgregarLibro.UseVisualStyleBackColor = false;
            this.btnAgregarLibro.Visible = false;
            this.btnAgregarLibro.Click += new System.EventHandler(this.BtnAgregarLibro_Click);
            this.btnAgregarLibro.MouseHover += new System.EventHandler(this.BtnAgregarLibro_MouseHover);
            // 
            // btnAgregarAutor
            // 
            this.btnAgregarAutor.BackColor = System.Drawing.Color.White;
            this.btnAgregarAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAutor.Location = new System.Drawing.Point(44, 342);
            this.btnAgregarAutor.Name = "btnAgregarAutor";
            this.btnAgregarAutor.Size = new System.Drawing.Size(154, 22);
            this.btnAgregarAutor.TabIndex = 12;
            this.btnAgregarAutor.Text = "Autor";
            this.btnAgregarAutor.UseVisualStyleBackColor = false;
            this.btnAgregarAutor.Visible = false;
            this.btnAgregarAutor.Click += new System.EventHandler(this.BtnAgregarAutor_Click);
            this.btnAgregarAutor.MouseHover += new System.EventHandler(this.BtnAgregarAutor_MouseHover);
            // 
            // pbxImagenCambiante
            // 
            this.pbxImagenCambiante.Image = ((System.Drawing.Image)(resources.GetObject("pbxImagenCambiante.Image")));
            this.pbxImagenCambiante.Location = new System.Drawing.Point(0, 364);
            this.pbxImagenCambiante.Name = "pbxImagenCambiante";
            this.pbxImagenCambiante.Size = new System.Drawing.Size(651, 113);
            this.pbxImagenCambiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenCambiante.TabIndex = 15;
            this.pbxImagenCambiante.TabStop = false;
            this.pbxImagenCambiante.Click += new System.EventHandler(this.PbxImagenCambiante_Click);
            this.pbxImagenCambiante.MouseHover += new System.EventHandler(this.PbxImagenCambiante_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnEditorialLibro
            // 
            this.btnEditorialLibro.BackColor = System.Drawing.Color.White;
            this.btnEditorialLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditorialLibro.Location = new System.Drawing.Point(44, 364);
            this.btnEditorialLibro.Name = "btnEditorialLibro";
            this.btnEditorialLibro.Size = new System.Drawing.Size(154, 23);
            this.btnEditorialLibro.TabIndex = 16;
            this.btnEditorialLibro.Text = "Editorial";
            this.btnEditorialLibro.UseVisualStyleBackColor = false;
            this.btnEditorialLibro.Visible = false;
            this.btnEditorialLibro.Click += new System.EventHandler(this.BtnEditorialLibro_Click);
            this.btnEditorialLibro.MouseHover += new System.EventHandler(this.BtnEditorialLibro_MouseHover);
            // 
            // btnCategoriaLibro
            // 
            this.btnCategoriaLibro.BackColor = System.Drawing.Color.White;
            this.btnCategoriaLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoriaLibro.Location = new System.Drawing.Point(44, 387);
            this.btnCategoriaLibro.Name = "btnCategoriaLibro";
            this.btnCategoriaLibro.Size = new System.Drawing.Size(154, 23);
            this.btnCategoriaLibro.TabIndex = 17;
            this.btnCategoriaLibro.Text = "Categoria";
            this.btnCategoriaLibro.UseVisualStyleBackColor = false;
            this.btnCategoriaLibro.Visible = false;
            this.btnCategoriaLibro.Click += new System.EventHandler(this.BtnCategoriaLibro_Click);
            this.btnCategoriaLibro.MouseHover += new System.EventHandler(this.BtnCategoriaLibro_MouseHover);
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.AutoSize = true;
            this.lblNombreLibro.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLibro.Location = new System.Drawing.Point(52, 150);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(146, 21);
            this.lblNombreLibro.TabIndex = 18;
            this.lblNombreLibro.Text = "Nombre Del Libro";
            this.lblNombreLibro.Click += new System.EventHandler(this.LblNombreLibro_Click);
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.AllowUserToAddRows = false;
            this.dgvBusqueda.AllowUserToDeleteRows = false;
            this.dgvBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBusqueda.BackgroundColor = System.Drawing.Color.White;
            this.dgvBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBusqueda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Location = new System.Drawing.Point(204, 150);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            this.dgvBusqueda.RowHeadersVisible = false;
            this.dgvBusqueda.Size = new System.Drawing.Size(320, 88);
            this.dgvBusqueda.TabIndex = 19;
            this.dgvBusqueda.Visible = false;
            this.dgvBusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBusqueda_CellContentClick);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscador.Location = new System.Drawing.Point(204, 148);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(320, 28);
            this.txtBuscador.TabIndex = 20;
            this.txtBuscador.TextChanged += new System.EventHandler(this.TxtBuscador_TextChanged_1);
            // 
            // btnActualizarLibro
            // 
            this.btnActualizarLibro.BackColor = System.Drawing.Color.White;
            this.btnActualizarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarLibro.Location = new System.Drawing.Point(241, 316);
            this.btnActualizarLibro.Name = "btnActualizarLibro";
            this.btnActualizarLibro.Size = new System.Drawing.Size(154, 29);
            this.btnActualizarLibro.TabIndex = 21;
            this.btnActualizarLibro.Text = "Libro";
            this.btnActualizarLibro.UseVisualStyleBackColor = false;
            this.btnActualizarLibro.Visible = false;
            this.btnActualizarLibro.Click += new System.EventHandler(this.BtnActualizarLibro_Click);
            this.btnActualizarLibro.MouseHover += new System.EventHandler(this.BtnActualizarLibro_MouseHover);
            // 
            // btnActualizarAutor
            // 
            this.btnActualizarAutor.BackColor = System.Drawing.Color.White;
            this.btnActualizarAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarAutor.Location = new System.Drawing.Point(241, 342);
            this.btnActualizarAutor.Name = "btnActualizarAutor";
            this.btnActualizarAutor.Size = new System.Drawing.Size(154, 22);
            this.btnActualizarAutor.TabIndex = 22;
            this.btnActualizarAutor.Text = "Autor";
            this.btnActualizarAutor.UseVisualStyleBackColor = false;
            this.btnActualizarAutor.Visible = false;
            this.btnActualizarAutor.Click += new System.EventHandler(this.BtnActualizarAutor_Click);
            this.btnActualizarAutor.MouseHover += new System.EventHandler(this.BtnActualizarAutor_MouseHover);
            // 
            // btnActualizarEditorial
            // 
            this.btnActualizarEditorial.BackColor = System.Drawing.Color.White;
            this.btnActualizarEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEditorial.Location = new System.Drawing.Point(241, 364);
            this.btnActualizarEditorial.Name = "btnActualizarEditorial";
            this.btnActualizarEditorial.Size = new System.Drawing.Size(154, 23);
            this.btnActualizarEditorial.TabIndex = 23;
            this.btnActualizarEditorial.Text = "Editorial";
            this.btnActualizarEditorial.UseVisualStyleBackColor = false;
            this.btnActualizarEditorial.Visible = false;
            this.btnActualizarEditorial.Click += new System.EventHandler(this.BtnActualizarEditorial_Click);
            this.btnActualizarEditorial.MouseHover += new System.EventHandler(this.BtnActualizarEditorial_MouseHover);
            // 
            // btnActualizarCategoria
            // 
            this.btnActualizarCategoria.BackColor = System.Drawing.Color.White;
            this.btnActualizarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCategoria.Location = new System.Drawing.Point(241, 387);
            this.btnActualizarCategoria.Name = "btnActualizarCategoria";
            this.btnActualizarCategoria.Size = new System.Drawing.Size(154, 23);
            this.btnActualizarCategoria.TabIndex = 24;
            this.btnActualizarCategoria.Text = "Categoria";
            this.btnActualizarCategoria.UseVisualStyleBackColor = false;
            this.btnActualizarCategoria.Visible = false;
            this.btnActualizarCategoria.Click += new System.EventHandler(this.BtnActualizarCategoria_Click);
            this.btnActualizarCategoria.MouseHover += new System.EventHandler(this.BtnActualizarCategoria_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(649, 498);
            this.Controls.Add(this.btnActualizarCategoria);
            this.Controls.Add(this.btnActualizarEditorial);
            this.Controls.Add(this.btnActualizarAutor);
            this.Controls.Add(this.btnActualizarLibro);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.dgvBusqueda);
            this.Controls.Add(this.lblNombreLibro);
            this.Controls.Add(this.btnCategoriaLibro);
            this.Controls.Add(this.btnEditorialLibro);
            this.Controls.Add(this.pbxImagenCambiante);
            this.Controls.Add(this.btnAgregarAutor);
            this.Controls.Add(this.btnAgregarLibro);
            this.Controls.Add(this.lblInferior);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVerTodos);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnLupita);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juan Pablo Zapata Mesa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenCambiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnLupita;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblInferior;
        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.Button btnAgregarAutor;
        private System.Windows.Forms.PictureBox pbxImagenCambiante;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnEditorialLibro;
        private System.Windows.Forms.Button btnCategoriaLibro;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Button btnActualizarLibro;
        private System.Windows.Forms.Button btnActualizarAutor;
        private System.Windows.Forms.Button btnActualizarEditorial;
        private System.Windows.Forms.Button btnActualizarCategoria;
    }
}

