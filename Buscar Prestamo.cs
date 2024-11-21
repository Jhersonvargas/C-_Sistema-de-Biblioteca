using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Biblioteca.Capa_Datos;
using Biblioteca.Capa_Logica;

namespace Biblioteca
{
    public partial class Buscar_Prestamo : Form
    {
        public Buscar_Prestamo()
        {
            InitializeComponent();
        }

        private void Buscar_Prestamo_Load(object sender, EventArgs e)
        {
            CBtipo.Items.Add("Fecha Prestamo");
            CBtipo.Items.Add("Fecha Devuelto");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Metodo_Prestamo Gl = new Metodo_Prestamo();
            if (CBtipo.SelectedIndex == 0)
            {
                Gl.fechaP = DPdesde.Value;
                Gl.fechaD = DPhasta.Value;
                ClsPrestamo.buscarLibrosP(Gl);
                DGprestamo.DataSource = ClsPrestamo.ds;
                DGprestamo.DataMember = "Cargar LibrosP";
            }
            if (CBtipo.SelectedIndex == 1)
            {
                Gl.fechaP = DPdesde.Value;
                Gl.fechaD = DPhasta.Value;
                ClsPrestamo.buscarLibrosD(Gl);
                DGprestamo.DataSource = ClsPrestamo.ds;
                DGprestamo.DataMember = "Cargar LibrosD";
            }
        }

        private void DGprestamo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
