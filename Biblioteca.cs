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
    public partial class Biblioteca : Form
    {
        public Biblioteca()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RegistrarNuuevoActor formSecundario = new RegistrarNuuevoActor();
            formSecundario.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RegistrarLibros formSecundario = new RegistrarLibros();
            formSecundario.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Prestamos formSecundario = new Prestamos();
            formSecundario.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarLibros formSecundario = new RegistrarLibros();
            formSecundario.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarLibroAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultar formSecundario = new consultar();
            formSecundario.Show();
        }

        private void consultarLibrosPorAñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar_Libros_Por_Año formSecundario = new Consultar_Libros_Por_Año();
            formSecundario.Show();
        }

        private void prestamosLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prestamos formSecundario = new Prestamos();
            formSecundario.Show();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarNuuevoActor formSecundario = new RegistrarNuuevoActor();
            formSecundario.Show();
        }

        private void consultarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar_Prestamo formSecundario = new Buscar_Prestamo();
            formSecundario.Show();
        }
    }
}
