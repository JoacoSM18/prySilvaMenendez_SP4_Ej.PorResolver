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

        float[,] matVentas = new float[5,4];

        private void frmBarVentas_Load(object sender, EventArgs e)
        {
            dgvDatos.Rows.Add("Julio");
            dgvDatos.Rows.Add("Esteban");
            dgvDatos.Rows.Add("Javier");
            dgvDatos.Rows.Add("Gonzalo");
            dgvDatos.Rows.Add("Alberto");
            dgvDatos [0,1].ReadOnly = true;
            dgvDatos [0,2].ReadOnly = true;
            dgvDatos [0,3].ReadOnly = true;
            dgvDatos [0,4].ReadOnly = true;
            dgvDatos [0,0].ReadOnly = true;
            dgvDatos.Columns[0].DefaultCellStyle.BackColor = Color.Maroon;
            dgvDatos.Columns[0].DefaultCellStyle.ForeColor = Color.White;
            dgvDatos.CurrentCell = dgvDatos.Rows[0].Cells[1];
        }

        private void btnValidarDatos_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvDatos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                return;
            }   
            if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
            {
                return;
            }

            if (!double.TryParse(e.FormattedValue.ToString(), out _))
            {
                MessageBox.Show(
                    $"Solo se Permiten Valores Numéricos.\nError en la Celda ({e.RowIndex + 1}, {e.ColumnIndex}).",
                    "Error de Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                e.Cancel = true;
            }
        }
    }
}
