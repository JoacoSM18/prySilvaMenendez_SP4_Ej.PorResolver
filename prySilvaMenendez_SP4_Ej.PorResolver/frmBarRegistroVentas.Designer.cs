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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.colMozos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBebidaSAlcohol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBebidaCAlcohol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPostre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMozos,
            this.colComidas,
            this.colBebidaSAlcohol,
            this.colBebidaCAlcohol,
            this.colPostre});
            this.dgvDatos.Location = new System.Drawing.Point(12, 12);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(545, 243);
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
            // frmBarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 461);
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
    }
}

