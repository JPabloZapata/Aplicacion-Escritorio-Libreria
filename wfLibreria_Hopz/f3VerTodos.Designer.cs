namespace wfLibreria_Hopz
{
    partial class f3VerTodos
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTodosLibros = new System.Windows.Forms.Label();
            this.dgvTodosLibros = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblFrase = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.pnlTitulo.Controls.Add(this.btnVolver);
            this.pnlTitulo.Controls.Add(this.lblTodosLibros);
            this.pnlTitulo.Location = new System.Drawing.Point(1, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(868, 122);
            this.pnlTitulo.TabIndex = 1;
            // 
            // lblTodosLibros
            // 
            this.lblTodosLibros.AutoSize = true;
            this.lblTodosLibros.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodosLibros.ForeColor = System.Drawing.Color.White;
            this.lblTodosLibros.Location = new System.Drawing.Point(186, 28);
            this.lblTodosLibros.Name = "lblTodosLibros";
            this.lblTodosLibros.Size = new System.Drawing.Size(472, 76);
            this.lblTodosLibros.TabIndex = 0;
            this.lblTodosLibros.Text = "LIBROS DISPONIBLES";
            // 
            // dgvTodosLibros
            // 
            this.dgvTodosLibros.AllowUserToAddRows = false;
            this.dgvTodosLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTodosLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodosLibros.Location = new System.Drawing.Point(12, 162);
            this.dgvTodosLibros.Name = "dgvTodosLibros";
            this.dgvTodosLibros.RowHeadersVisible = false;
            this.dgvTodosLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodosLibros.Size = new System.Drawing.Size(805, 226);
            this.dgvTodosLibros.TabIndex = 2;
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
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Tag = "";
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase.Location = new System.Drawing.Point(157, 420);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(550, 50);
            this.lblFrase.TabIndex = 3;
            this.lblFrase.Text = "Disfruta de nuestros libros con una lectura sumergida en la imaginacion.\r\n ";
            // 
            // f3VerTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(830, 489);
            this.Controls.Add(this.lblFrase);
            this.Controls.Add(this.dgvTodosLibros);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "f3VerTodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juan Pablo Zapata Mesa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F3VerTodos_FormClosing);
            this.Load += new System.EventHandler(this.F3VerTodos_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTodosLibros;
        private System.Windows.Forms.DataGridView dgvTodosLibros;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblFrase;
    }
}