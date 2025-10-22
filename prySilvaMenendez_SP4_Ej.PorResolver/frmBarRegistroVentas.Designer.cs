namespace prySilvaMenendez_SP4_Ej.PorResolver
{
    partial class frmBarVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarVentas));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.colMozos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBebidaSAlcohol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBebidaCAlcohol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPostre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnValidarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMozos,
            this.colComidas,
            this.colBebidaSAlcohol,
            this.colBebidaCAlcohol,
            this.colPostre});
            this.dgvDatos.Location = new System.Drawing.Point(12, 12);
            this.dgvDatos.Name = "dgvDatos";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowTemplate.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(504, 243);
            this.dgvDatos.TabIndex = 0;
            // 
            // colMozos
            // 
            this.colMozos.HeaderText = "Mozos";
            this.colMozos.Name = "colMozos";
            // 
            // colComidas
            // 
            this.colComidas.HeaderText = "Comidas";
            this.colComidas.Name = "colComidas";
            // 
            // colBebidaSAlcohol
            // 
            this.colBebidaSAlcohol.HeaderText = "Bebidas Sin Alcohol";
            this.colBebidaSAlcohol.Name = "colBebidaSAlcohol";
            // 
            // colBebidaCAlcohol
            // 
            this.colBebidaCAlcohol.HeaderText = "Bebidas Con Alcohol";
            this.colBebidaCAlcohol.Name = "colBebidaCAlcohol";
            // 
            // colPostre
            // 
            this.colPostre.HeaderText = "Postres";
            this.colPostre.Name = "colPostre";
            // 
            // btnValidarDatos
            // 
            this.btnValidarDatos.Location = new System.Drawing.Point(377, 291);
            this.btnValidarDatos.Name = "btnValidarDatos";
            this.btnValidarDatos.Size = new System.Drawing.Size(93, 33);
            this.btnValidarDatos.TabIndex = 1;
            this.btnValidarDatos.Text = "Validar Datos";
            this.btnValidarDatos.UseVisualStyleBackColor = true;
            this.btnValidarDatos.Click += new System.EventHandler(this.btnValidarDatos_Click);
            // 
            // frmBarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(529, 354);
            this.Controls.Add(this.btnValidarDatos);
            this.Controls.Add(this.dgvDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBarVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bar La Milanga - Registro";
            this.Load += new System.EventHandler(this.frmBarVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMozos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBebidaSAlcohol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBebidaCAlcohol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostre;
        private System.Windows.Forms.Button btnValidarDatos;
    }
}

