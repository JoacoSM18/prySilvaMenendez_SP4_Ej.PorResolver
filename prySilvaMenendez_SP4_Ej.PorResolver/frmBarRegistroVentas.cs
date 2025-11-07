using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaMenendez_SP4_Ej.PorResolver
{
    public partial class frmBarVentas : Form
    {
        public frmBarVentas()
        {
            InitializeComponent();
        }

        float[,] matVentas = new float[100,100];

        private void frmBarVentas_Load(object sender, EventArgs e)
        {
            dgvDatos.Rows.Add("Julio");
            dgvDatos.Rows.Add("Esteban");
            dgvDatos.Rows.Add("Javier");
            dgvDatos.Rows.Add("Gonzalo");
            dgvDatos.Rows.Add("Alberto");
            dgvDatos.Columns[0].DefaultCellStyle.BackColor = Color.Maroon;
            dgvDatos.Columns[0].DefaultCellStyle.ForeColor = Color.White;
            dgvDatos.Columns[0].ReadOnly = true;
            dgvDatos.CurrentCell = dgvDatos.Rows[0].Cells[1];
            btnMozodelDia.Enabled = false;
            btnTotales.Enabled = false;
        }

        private void btnValidarDatos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvDatos.Rows.Count; i++)
            {
                for (int j = 1; j < dgvDatos.Columns.Count; j++)
                {
                    var valorTexto = dgvDatos.Rows[i].Cells[j].Value?.ToString();

                    if (string.IsNullOrWhiteSpace(valorTexto))
                        valorTexto = "0";

                    if (!float.TryParse(valorTexto, out float valor))
                    {
                        MessageBox.Show(
                            $"Solo se Permiten Valores Numéricos.\nError en la Celda ({i + 1}, {j}).",
                            "Error de Validación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        dgvDatos.CurrentCell = dgvDatos.Rows[i].Cells[j];
                        btnMozodelDia.Enabled = false;
                        btnTotales.Enabled = false;
                        return;
                    }
                    matVentas[i, j - 1] = valor;
                }
            }
            MessageBox.Show("Todos Los Valores son Numéricos.", "Validación Exitosa");
            btnMozodelDia.Enabled = true;
            btnTotales.Enabled = true;
        }

        private void lblTotales_Click(object sender, EventArgs e)
        {

        }

        private void btnMozodelDia_Click(object sender, EventArgs e)
        {
            int filas = matVentas.GetLength(0);
            int cols = matVentas.GetLength(1); 

            float maxImporte = float.MinValue;
            int idxMax = -1;

            for (int i = 0; i < filas; i++)
            {
                float sumaMozo = 0f;
                for (int j = 0; j < cols; j++)
                    sumaMozo += matVentas[i, j];

                if (sumaMozo > maxImporte)
                {
                    maxImporte = sumaMozo;
                    idxMax = i;
                }
            }

            if (idxMax == -1)
            {
                MessageBox.Show("No hay datos para calcular el mozo del día.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string nombreMozo = dgvDatos.Rows[idxMax].Cells[0].Value?.ToString() ?? $"Mozo {idxMax + 1}";
            if (this.Controls.ContainsKey("txtMozoNombre"))
                lblMozodelDia.Text = nombreMozo;
            if (this.Controls.ContainsKey("txtMozoImporte"))
                lblMozodelDia.Text = maxImporte.ToString("F2");
            if (!this.Controls.ContainsKey("txtMozoNombre") || !this.Controls.ContainsKey("txtMozoImporte"))
            {
                MessageBox.Show($"Mozo del día: {nombreMozo}\nImporte: {maxImporte:F2}", "Mozo del día", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            int filas = matVentas.GetLength(0);
            int cols = matVentas.GetLength(1);

            float totalGeneral = 0f;
            float[] totalesPorCategoria = new float[cols];

            for (int j = 0; j < cols; j++)
                totalesPorCategoria[j] = 0f;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    totalesPorCategoria[j] += matVentas[i, j];
                    totalGeneral += matVentas[i, j];
                }
            }

            if (this.Controls.ContainsKey("txtTotalGeneral"))
                lblTotales.Text = totalGeneral.ToString("F2");

            if (this.Controls.ContainsKey("txtTotalCat1")) lbl1.Text = totalesPorCategoria[0].ToString("F2");
            if (this.Controls.ContainsKey("txtTotalCat2")) lbl2.Text = totalesPorCategoria[1].ToString("F2");
            if (this.Controls.ContainsKey("txtTotalCat3")) lbl3.Text = totalesPorCategoria[2].ToString("F2");
            if (this.Controls.ContainsKey("txtTotalCat4")) lbl4.Text = totalesPorCategoria[3].ToString("F2");
            if (!this.Controls.ContainsKey("txtTotalGeneral"))
            {
                string msg = $"Total General: {totalGeneral:F2}\n" +
                             $"Comidas: {totalesPorCategoria[0]:F2}\n" +
                             $"Bebidas Sin Alcohol: {totalesPorCategoria[1]:F2}\n" +
                             $"Bebidas Con Alcohol: {totalesPorCategoria[2]:F2}\n" +
                             $"Postres: {totalesPorCategoria[3]:F2}";
                MessageBox.Show(msg, "Totales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
