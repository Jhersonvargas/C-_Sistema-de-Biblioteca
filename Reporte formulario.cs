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
    public partial class Reporte_formulario : Form
    {
        public Reporte_formulario()
        {
            InitializeComponent();
        }

        private void Reporte_formulario_Load(object sender, EventArgs e)
        {
            Reporte_libros_autor reporte= new Reporte_libros_autor();
            crystalReportFormulario.ReportSource = reporte;
            reporte.SetDatabaseLogon("sa", "12345");
            reporte.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
