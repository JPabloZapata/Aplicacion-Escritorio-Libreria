namespace wfLibreria_Hopz
{
    partial class f2ActualizarAutor
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
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTActualizarAutor = new System.Windows.Forms.Label();
            this.pnlTitulof4 = new System.Windows.Forms.Panel();
            this.dgvSexo = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cmbxSexo = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvActuAutor = new System.Windows.Forms.DataGridView();
            this.pnlTitulof4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActuAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCedula
            // 
            this.lblCedula.BackColor = System.Drawing.Color.White;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(31, 213);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(136, 20);
            this.lblCedula.TabIndex = 45;
            this.lblCedula.Text = "Cedula";
            this.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(31, 180);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(136, 20);
            this.lblNombre.TabIndex = 44;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTActualizarAutor
            // 
            this.lblTActualizarAutor.AutoSize = true;
            this.lblTActualizarAutor.Font = new System.Drawing.Font("Mistral", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTActualizarAutor.ForeColor = System.Drawing.Color.White;
            this.lblTActualizarAutor.Location = new System.Drawing.Point(175, 30);
            this.lblTActualizarAutor.Name = "lblTActualizarAutor";
            this.lblTActualizarAutor.Size = new System.Drawing.Size(369, 64);
            this.lblTActualizarAutor.TabIndex = 0;
            this.lblTActualizarAutor.Text = "ACTUALIZAR AUTOR";
            // 
            // pnlTitulof4
            // 
            this.pnlTitulof4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.pnlTitulof4.Controls.Add(this.dgvSexo);
            this.pnlTitulof4.Controls.Add(this.btnVolver);
            this.pnlTitulof4.Controls.Add(this.lblTActualizarAutor);
            this.pnlTitulof4.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulof4.Name = "pnlTitulof4";
            this.pnlTitulof4.Size = new System.Drawing.Size(739, 125);
            this.pnlTitulof4.TabIndex = 43;
            // 
            // dgvSexo
            // 
            this.dgvSexo.AllowUserToAddRows = false;
            this.dgvSexo.AllowUserToDeleteRows = false;
            this.dgvSexo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSexo.Location = new System.Drawing.Point(496, 3);
            this.dgvSexo.Name = "dgvSexo";
            this.dgvSexo.ReadOnly = true;
            this.dgvSexo.Size = new System.Drawing.Size(240, 110);
            this.dgvSexo.TabIndex = 60;
            this.dgvSexo.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.AccessibleDescription = "";
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnVolver.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(0, 79);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(113, 46);
            this.btnVolver.TabIndex = 59;
            this.btnVolver.Tag = "";
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.BackColor = System.Drawing.Color.White;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(31, 285);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(136, 20);
            this.lblSexo.TabIndex = 50;
            this.lblSexo.Text = "Sexo";
            this.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEdad
            // 
            this.lblEdad.BackColor = System.Drawing.Color.White;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(31, 248);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(136, 20);
            this.lblEdad.TabIndex = 49;
            this.lblEdad.Text = "Edad";
            this.lblEdad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleDescription = "";
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.btnEliminar.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(186, 359);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(154, 46);
            this.btnEliminar.TabIndex = 52;
            this.btnEliminar.Tag = "";
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AccessibleDescription = "";
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.btnModificar.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(381, 359);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(154, 46);
            this.btnModificar.TabIndex = 53;
            this.btnModificar.Tag = "";
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // cmbxSexo
            // 
            this.cmbxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.cmbxSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbxSexo.Location = new System.Drawing.Point(186, 285);
            this.cmbxSexo.Name = "cmbxSexo";
            this.cmbxSexo.Size = new System.Drawing.Size(51, 23);
            this.cmbxSexo.TabIndex = 54;
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.txtEdad.Location = new System.Drawing.Point(186, 248);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(51, 21);
            this.txtEdad.TabIndex = 55;
            // 
            // txtCedula
            // 
            this.txtCedula.Enabled = false;
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.txtCedula.Location = new System.Drawing.Point(186, 213);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(86, 21);
            this.txtCedula.TabIndex = 56;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.txtNombre.Location = new System.Drawing.Point(186, 180);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 21);
            this.txtNombre.TabIndex = 57;
            // 
            // dgvActuAutor
            // 
            this.dgvActuAutor.AllowUserToAddRows = false;
            this.dgvActuAutor.AllowUserToDeleteRows = false;
            this.dgvActuAutor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvActuAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActuAutor.Location = new System.Drawing.Point(381, 180);
            this.dgvActuAutor.Name = "dgvActuAutor";
            this.dgvActuAutor.ReadOnly = true;
            this.dgvActuAutor.RowHeadersVisible = false;
            this.dgvActuAutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActuAutor.Size = new System.Drawing.Size(326, 125);
            this.dgvActuAutor.TabIndex = 58;
            this.dgvActuAutor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvActuAutor_CellClick);
            // 
            // f2ActualizarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(739, 431);
            this.Controls.Add(this.dgvActuAutor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.cmbxSexo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pnlTitulof4);
            this.Name = "f2ActualizarAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juan Pablo Zapata Mesa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F2ActualizarAutor_FormClosing);
            this.Load += new System.EventHandler(this.F2ActualizarAutor_Load);
            this.pnlTitulof4.ResumeLayout(false);
            this.pnlTitulof4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActuAutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTActualizarAutor;
        private System.Windows.Forms.Panel pnlTitulof4;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cmbxSexo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvActuAutor;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvSexo;
    }
}