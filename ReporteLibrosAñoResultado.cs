using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class ReporteLibrosAñoResultado : Form
    {

        public int año = 0;
        public int año2 = 0;

        public ReporteLibrosAñoResultado()
        {
            InitializeComponent();
        }

        private void ReporteLibroFecha_Load(object sender, EventArgs e)
        {
            ReporteLibrosAño reporte = new ReporteLibrosAño();
            crystalReportLibro.ReportSource = reporte;
            reporte.SetParameterValue("@año", this.año);
            reporte.SetParameterValue("@año2", this.año2);
            reporte.SetDatabaseLogon("sa", "12345");

            crystalReportLibro.ReportSource = reporte;

        }

        private void crystalReportLibro_Load(object sender, EventArgs e)
        {

        }
    }
}
