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
            this.btnMozodelDia = new System.Windows.Forms.Button();
            this.btnTotales = new System.Windows.Forms.Button();
            this.lblMozodelDia = new System.Windows.Forms.Label();
            this.lblTotales = new System.Windows.Forms.Label();
            this.lblImporteMozoDia = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValidarDatos
            // 
            this.btnValidarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarDatos.Location = new System.Drawing.Point(807, 27);
            this.btnValidarDatos.Name = "btnValidarDatos";
            this.btnValidarDatos.Size = new System.Drawing.Size(101, 36);
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
            this.dgvDatos.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMozos,
            this.colComidas,
            this.colBebidasSAlcohol,
            this.colBebidasCAlcohol,
            this.colPostres});
            this.dgvDatos.Location = new System.Drawing.Point(8, 27);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.Size = new System.Drawing.Size(753, 235);
            this.dgvDatos.TabIndex = 2;
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
            // btnMozodelDia
            // 
            this.btnMozodelDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMozodelDia.Location = new System.Drawing.Point(153, 285);
            this.btnMozodelDia.Margin = new System.Windows.Forms.Padding(2);
            this.btnMozodelDia.Name = "btnMozodelDia";
            this.btnMozodelDia.Size = new System.Drawing.Size(101, 45);
            this.btnMozodelDia.TabIndex = 3;
            this.btnMozodelDia.Text = "Mostrar Mozo del Dia";
            this.btnMozodelDia.UseVisualStyleBackColor = true;
            this.btnMozodelDia.Click += new System.EventHandler(this.btnMozodelDia_Click);
            // 
            // btnTotales
            // 
            this.btnTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotales.Location = new System.Drawing.Point(153, 334);
            this.btnTotales.Margin = new System.Windows.Forms.Padding(2);
            this.btnTotales.Name = "btnTotales";
            this.btnTotales.Size = new System.Drawing.Size(101, 42);
            this.btnTotales.TabIndex = 4;
            this.btnTotales.Text = "Mostrar Totales";
            this.btnTotales.UseVisualStyleBackColor = true;
            this.btnTotales.Click += new System.EventHandler(this.btnTotales_Click);
            // 
            // lblMozodelDia
            // 
            this.lblMozodelDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMozodelDia.Location = new System.Drawing.Point(269, 294);
            this.lblMozodelDia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMozodelDia.Name = "lblMozodelDia";
            this.lblMozodelDia.Size = new System.Drawing.Size(101, 25);
            this.lblMozodelDia.TabIndex = 5;
            this.lblMozodelDia.Text = " ";
            // 
            // lblTotales
            // 
            this.lblTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotales.Location = new System.Drawing.Point(269, 347);
            this.lblTotales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(101, 23);
            this.lblTotales.TabIndex = 6;
            this.lblTotales.Text = "  ";
            this.lblTotales.Click += new System.EventHandler(this.lblTotales_Click);
            // 
            // lblImporteMozoDia
            // 
            this.lblImporteMozoDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteMozoDia.Location = new System.Drawing.Point(374, 294);
            this.lblImporteMozoDia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImporteMozoDia.Name = "lblImporteMozoDia";
            this.lblImporteMozoDia.Size = new System.Drawing.Size(101, 25);
            this.lblImporteMozoDia.TabIndex = 7;
            this.lblImporteMozoDia.Text = " ";
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(374, 347);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(101, 25);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "  ";
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(479, 347);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(101, 25);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "  ";
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(584, 347);
            this.lbl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(101, 25);
            this.lbl3.TabIndex = 10;
            this.lbl3.Text = "  ";
            // 
            // lbl4
            // 
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(689, 347);
            this.lbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(101, 25);
            this.lbl4.TabIndex = 11;
            this.lbl4.Text = "  ";
            // 
            // frmBarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(920, 413);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblImporteMozoDia);
            this.Controls.Add(this.lblTotales);
            this.Controls.Add(this.lblMozodelDia);
            this.Controls.Add(this.btnTotales);
            this.Controls.Add(this.btnMozodelDia);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnValidarDatos);
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
        private System.Windows.Forms.Button btnValidarDatos;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMozos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBebidasSAlcohol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBebidasCAlcohol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostres;
        private System.Windows.Forms.Button btnMozodelDia;
        private System.Windows.Forms.Button btnTotales;
        private System.Windows.Forms.Label lblMozodelDia;
        private System.Windows.Forms.Label lblTotales;
        private System.Windows.Forms.Label lblImporteMozoDia;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
    }
}

