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
        }

        private void btnValidarDatos_Click(object sender, EventArgs e)
        {
            for (int indiceFilas = 0; indiceFilas < dgvDatos.Rows.Count; indiceFilas++)
            {
                for (int indiceColumnas = 1; indiceColumnas < dgvDatos.Columns.Count; indiceColumnas++)
                {
                    if (dgvDatos.Rows[indiceFilas].Cells[indiceColumnas].Value != null)
                    {
                        float contenidoCelda =
                        float.Parse(dgvDatos.Rows[indiceFilas].Cells [indiceColumnas].Value.ToString());

                        if (float.IsNaN(contenidoCelda))
                        {
                            dgvDatos.Rows[indiceFilas].Cells[indiceColumnas].Value = "Si";
                        }
                        else
                        {
                            dgvDatos.Rows[indiceFilas].Cells[indiceColumnas].Value = "No";
                        }
                    }
                }
            }
        }
    }
}
