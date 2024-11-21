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
    public partial class ReporteLibros : Form
    {
        public ReporteLibros()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ReporteLibrosAñoResultado imprimirlibros = new ReporteLibrosAñoResultado();
            imprimirlibros.año = int.Parse(this.txtdesde.Text);
            imprimirlibros.año2 = int.Parse(this.txthasta.Text);
            imprimirlibros.ShowDialog();
        }

        private void txthasta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdesde_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblAñoDesde_Click(object sender, EventArgs e)
        {

        }

        private void ReporteLibros_Load(object sender, EventArgs e)
        {

        }
    }
}
