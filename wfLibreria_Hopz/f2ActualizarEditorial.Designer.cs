namespace wfLibreria_Hopz
{
    partial class f2ActualizarEditorial
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
            this.lblTAgregarEditorial = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlTitulof4 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.dgvActEditorial = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlTitulof4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActEditorial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTAgregarEditorial
            // 
            this.lblTAgregarEditorial.AutoSize = true;
            this.lblTAgregarEditorial.Font = new System.Drawing.Font("Mistral", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTAgregarEditorial.ForeColor = System.Drawing.Color.White;
            this.lblTAgregarEditorial.Location = new System.Drawing.Point(119, 28);
            this.lblTAgregarEditorial.Name = "lblTAgregarEditorial";
            this.lblTAgregarEditorial.Size = new System.Drawing.Size(431, 64);
            this.lblTAgregarEditorial.TabIndex = 0;
            this.lblTAgregarEditorial.Text = "ACTUALIZAR EDITORIAL";
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.Color.White;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(31, 212);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(136, 20);
            this.lblCodigo.TabIndex = 54;
            this.lblCodigo.Text = "Codigo";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDireccion
            // 
            this.lblDireccion.BackColor = System.Drawing.Color.White;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(31, 247);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(136, 20);
            this.lblDireccion.TabIndex = 53;
            this.lblDireccion.Text = "Dirección";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(31, 176);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(136, 20);
            this.lblNombre.TabIndex = 52;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTitulof4
            // 
            this.pnlTitulof4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.pnlTitulof4.Controls.Add(this.btnVolver);
            this.pnlTitulof4.Controls.Add(this.lblTAgregarEditorial);
            this.pnlTitulof4.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulof4.Name = "pnlTitulof4";
            this.pnlTitulof4.Size = new System.Drawing.Size(650, 126);
            this.pnlTitulof4.TabIndex = 51;
            // 
            // btnVolver
            // 
            this.btnVolver.AccessibleDescription = "";
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnVolver.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(0, 80);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(113, 46);
            this.btnVolver.TabIndex = 60;
            this.btnVolver.Tag = "";
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.txtNombre.Location = new System.Drawing.Point(182, 176);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 21);
            this.txtNombre.TabIndex = 57;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.txtCodigo.Location = new System.Drawing.Point(182, 212);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(111, 21);
            this.txtCodigo.TabIndex = 58;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.txtDireccion.Location = new System.Drawing.Point(182, 247);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(111, 21);
            this.txtDireccion.TabIndex = 59;
            // 
            // dgvActEditorial
            // 
            this.dgvActEditorial.AllowUserToAddRows = false;
            this.dgvActEditorial.AllowUserToDeleteRows = false;
            this.dgvActEditorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActEditorial.Location = new System.Drawing.Point(365, 176);
            this.dgvActEditorial.Name = "dgvActEditorial";
            this.dgvActEditorial.ReadOnly = true;
            this.dgvActEditorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActEditorial.Size = new System.Drawing.Size(260, 115);
            this.dgvActEditorial.TabIndex = 60;
            this.dgvActEditorial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvActEditorial_CellClick);
            // 
            // btnModificar
            // 
            this.btnModificar.AccessibleDescription = "";
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.btnModificar.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(365, 337);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(154, 46);
            this.btnModificar.TabIndex = 61;
            this.btnModificar.Tag = "";
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleDescription = "";
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.btnEliminar.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(139, 337);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(154, 46);
            this.btnEliminar.TabIndex = 62;
            this.btnEliminar.Tag = "";
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // f2ActualizarEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(650, 419);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvActEditorial);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pnlTitulof4);
            this.Name = "f2ActualizarEditorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juan Pablo Zapata Mesa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F2ActualizarEditorial_FormClosing);
            this.Load += new System.EventHandler(this.F2ActualizarEditorial_Load);
            this.pnlTitulof4.ResumeLayout(false);
            this.pnlTitulof4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActEditorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTAgregarEditorial;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel pnlTitulof4;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DataGridView dgvActEditorial;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}