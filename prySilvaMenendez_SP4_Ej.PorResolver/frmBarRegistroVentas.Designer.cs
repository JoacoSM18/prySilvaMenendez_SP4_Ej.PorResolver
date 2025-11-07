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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarVentas));
            this.btnValidarDatos = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.colMozos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBebidasSAlcohol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBebidasCAlcohol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPostres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValidarDatos
            // 
            this.btnValidarDatos.Location = new System.Drawing.Point(744, 449);
            this.btnValidarDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnValidarDatos.Name = "btnValidarDatos";
            this.btnValidarDatos.Size = new System.Drawing.Size(140, 51);
            this.btnValidarDatos.TabIndex = 1;
            this.btnValidarDatos.Text = "Validar Datos";
            this.btnValidarDatos.UseVisualStyleBackColor = true;
            this.btnValidarDatos.Click += new System.EventHandler(this.btnValidarDatos_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMozos,
            this.colComidas,
            this.colBebidasSAlcohol,
            this.colBebidasCAlcohol,
            this.colPostres});
            this.dgvDatos.Location = new System.Drawing.Point(12, 41);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.Size = new System.Drawing.Size(898, 362);
            this.dgvDatos.TabIndex = 2;
            this.dgvDatos.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDatos_CellValidating);
            // 
            // colMozos
            // 
            this.colMozos.HeaderText = "Mozos";
            this.colMozos.MaxInputLength = 10;
            this.colMozos.MinimumWidth = 8;
            this.colMozos.Name = "colMozos";
            this.colMozos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMozos.Width = 150;
            // 
            // colComidas
            // 
            this.colComidas.HeaderText = "Comidas";
            this.colComidas.MaxInputLength = 10;
            this.colComidas.MinimumWidth = 8;
            this.colComidas.Name = "colComidas";
            this.colComidas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colComidas.Width = 150;
            // 
            // colBebidasSAlcohol
            // 
            this.colBebidasSAlcohol.HeaderText = "Bebidas Sin Alcohol";
            this.colBebidasSAlcohol.MaxInputLength = 10;
            this.colBebidasSAlcohol.MinimumWidth = 8;
            this.colBebidasSAlcohol.Name = "colBebidasSAlcohol";
            this.colBebidasSAlcohol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colBebidasSAlcohol.Width = 150;
            // 
            // colBebidasCAlcohol
            // 
            this.colBebidasCAlcohol.HeaderText = "Bebidas Con Alcohol";
            this.colBebidasCAlcohol.MaxInputLength = 10;
            this.colBebidasCAlcohol.MinimumWidth = 8;
            this.colBebidasCAlcohol.Name = "colBebidasCAlcohol";
            this.colBebidasCAlcohol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colBebidasCAlcohol.Width = 150;
            // 
            // colPostres
            // 
            this.colPostres.HeaderText = "Postres";
            this.colPostres.MaxInputLength = 10;
            this.colPostres.MinimumWidth = 8;
            this.colPostres.Name = "colPostres";
            this.colPostres.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPostres.Width = 150;
            // 
            // frmBarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(961, 596);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnValidarDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBarVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bar La Milanga - Registro";
            this.Load += new System.EventHandler(this.frmBarVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnValidarDatos;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMozos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBebidasSAlcohol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBebidasCAlcohol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostres;
    }
}

