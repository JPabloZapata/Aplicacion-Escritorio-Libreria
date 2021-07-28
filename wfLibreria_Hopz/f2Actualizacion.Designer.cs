namespace wfLibreria_Hopz
{
    partial class f2Actualizacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlTitulof2 = new System.Windows.Forms.Panel();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTActualizacion = new System.Windows.Forms.Label();
            this.dgvActualizacion = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbxAutor = new System.Windows.Forms.ComboBox();
            this.cmbxEditorial = new System.Windows.Forms.ComboBox();
            this.cmbxCategoria = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnlTitulof2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleDescription = "";
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.btnEliminar.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(581, 463);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(154, 46);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Tag = "";
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // pnlTitulof2
            // 
            this.pnlTitulof2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.pnlTitulof2.Controls.Add(this.dgvConsulta);
            this.pnlTitulof2.Controls.Add(this.btnVolver);
            this.pnlTitulof2.Controls.Add(this.lblTActualizacion);
            this.pnlTitulof2.Location = new System.Drawing.Point(-3, 0);
            this.pnlTitulof2.Name = "pnlTitulof2";
            this.pnlTitulof2.Size = new System.Drawing.Size(873, 122);
            this.pnlTitulof2.TabIndex = 10;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(119, 0);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.Size = new System.Drawing.Size(268, 119);
            this.dgvConsulta.TabIndex = 34;
            this.dgvConsulta.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.AccessibleDescription = "";
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnVolver.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(0, 76);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(113, 46);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Tag = "";
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // lblTActualizacion
            // 
            this.lblTActualizacion.AutoSize = true;
            this.lblTActualizacion.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTActualizacion.ForeColor = System.Drawing.Color.White;
            this.lblTActualizacion.Location = new System.Drawing.Point(188, 26);
            this.lblTActualizacion.Name = "lblTActualizacion";
            this.lblTActualizacion.Size = new System.Drawing.Size(512, 76);
            this.lblTActualizacion.TabIndex = 0;
            this.lblTActualizacion.Text = "ACTUALIZACIÓN LIBRO";
            // 
            // dgvActualizacion
            // 
            this.dgvActualizacion.AllowUserToAddRows = false;
            this.dgvActualizacion.AllowUserToDeleteRows = false;
            this.dgvActualizacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvActualizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualizacion.Location = new System.Drawing.Point(12, 154);
            this.dgvActualizacion.Name = "dgvActualizacion";
            this.dgvActualizacion.ReadOnly = true;
            this.dgvActualizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActualizacion.Size = new System.Drawing.Size(846, 156);
            this.dgvActualizacion.TabIndex = 11;
            this.dgvActualizacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvActualizacion_CellClick);
            // 
            // btnModificar
            // 
            this.btnModificar.AccessibleDescription = "";
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.btnModificar.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(172, 463);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(154, 46);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Tag = "";
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.txtNombre.Location = new System.Drawing.Point(116, 334);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(186, 21);
            this.txtNombre.TabIndex = 13;
            // 
            // txtPaginas
            // 
            this.txtPaginas.Enabled = false;
            this.txtPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaginas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.txtPaginas.Location = new System.Drawing.Point(463, 367);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(89, 21);
            this.txtPaginas.TabIndex = 16;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.txtPrecio.Location = new System.Drawing.Point(463, 402);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(89, 21);
            this.txtPrecio.TabIndex = 17;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(30, 334);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 20);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAutor
            // 
            this.lblAutor.BackColor = System.Drawing.Color.White;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(30, 368);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(80, 20);
            this.lblAutor.TabIndex = 19;
            this.lblAutor.Text = "Autor";
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEditorial
            // 
            this.lblEditorial.BackColor = System.Drawing.Color.White;
            this.lblEditorial.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorial.Location = new System.Drawing.Point(30, 402);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(123, 20);
            this.lblEditorial.TabIndex = 20;
            this.lblEditorial.Text = "Editorial";
            this.lblEditorial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaginas
            // 
            this.lblPaginas.BackColor = System.Drawing.Color.White;
            this.lblPaginas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginas.Location = new System.Drawing.Point(336, 367);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(121, 20);
            this.lblPaginas.TabIndex = 21;
            this.lblPaginas.Text = "N° paginas";
            this.lblPaginas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.White;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(336, 402);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(121, 20);
            this.lblPrecio.TabIndex = 22;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.White;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(587, 402);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(136, 20);
            this.lblCantidad.TabIndex = 25;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImagen
            // 
            this.lblImagen.BackColor = System.Drawing.Color.White;
            this.lblImagen.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(587, 367);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(123, 23);
            this.lblImagen.TabIndex = 24;
            this.lblImagen.Text = "ubicacion img";
            this.lblImagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategoria
            // 
            this.lblCategoria.BackColor = System.Drawing.Color.White;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(587, 334);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(98, 20);
            this.lblCategoria.TabIndex = 23;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtImagen
            // 
            this.txtImagen.Enabled = false;
            this.txtImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.txtImagen.Location = new System.Drawing.Point(716, 370);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(126, 21);
            this.txtImagen.TabIndex = 27;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.txtCantidad.Location = new System.Drawing.Point(729, 402);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(113, 21);
            this.txtCantidad.TabIndex = 28;
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.Color.White;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(336, 335);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(98, 20);
            this.lblCodigo.TabIndex = 29;
            this.lblCodigo.Text = "Codigo";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.txtCodigo.Location = new System.Drawing.Point(440, 335);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(112, 21);
            this.txtCodigo.TabIndex = 30;
            // 
            // cmbxAutor
            // 
            this.cmbxAutor.Enabled = false;
            this.cmbxAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.cmbxAutor.FormattingEnabled = true;
            this.cmbxAutor.Location = new System.Drawing.Point(116, 368);
            this.cmbxAutor.Name = "cmbxAutor";
            this.cmbxAutor.Size = new System.Drawing.Size(186, 23);
            this.cmbxAutor.TabIndex = 31;
            // 
            // cmbxEditorial
            // 
            this.cmbxEditorial.Enabled = false;
            this.cmbxEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxEditorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.cmbxEditorial.FormattingEnabled = true;
            this.cmbxEditorial.Location = new System.Drawing.Point(159, 402);
            this.cmbxEditorial.Name = "cmbxEditorial";
            this.cmbxEditorial.Size = new System.Drawing.Size(143, 23);
            this.cmbxEditorial.TabIndex = 32;
            // 
            // cmbxCategoria
            // 
            this.cmbxCategoria.Enabled = false;
            this.cmbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.cmbxCategoria.FormattingEnabled = true;
            this.cmbxCategoria.Location = new System.Drawing.Point(691, 334);
            this.cmbxCategoria.Name = "cmbxCategoria";
            this.cmbxCategoria.Size = new System.Drawing.Size(151, 23);
            this.cmbxCategoria.TabIndex = 33;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AccessibleDescription = "";
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(389, 463);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(135, 46);
            this.btnLimpiar.TabIndex = 34;
            this.btnLimpiar.Tag = "";
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // f2Actualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(870, 531);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbxCategoria);
            this.Controls.Add(this.cmbxEditorial);
            this.Controls.Add(this.cmbxAutor);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblPaginas);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvActualizacion);
            this.Controls.Add(this.pnlTitulof2);
            this.Controls.Add(this.btnEliminar);
            this.Name = "f2Actualizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juan Pablo Zapata Mesa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F2Actualizacion_FormClosing);
            this.Load += new System.EventHandler(this.F2Actualizacion_Load);
            this.pnlTitulof2.ResumeLayout(false);
            this.pnlTitulof2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel pnlTitulof2;
        private System.Windows.Forms.Label lblTActualizacion;
        private System.Windows.Forms.DataGridView dgvActualizacion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbxAutor;
        private System.Windows.Forms.ComboBox cmbxEditorial;
        private System.Windows.Forms.ComboBox cmbxCategoria;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnLimpiar;
    }
}