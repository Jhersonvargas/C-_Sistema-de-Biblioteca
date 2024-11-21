using Biblioteca.Capa_Datos;
using Biblioteca.Capa_Logica;
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
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
        }

        private void Prestamos_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            lblFecha.Text = fecha.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Metodo_libros Gl = new Metodo_libros();
            Gl.librosP = txtBuscar.Text;
            CLsLibros.ColsultarLibrosPrestamos(Gl);
            dataGridCL.DataSource = CLsLibros.ds;
            dataGridCL.DataMember = "Cargar LPrestamos";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridCL_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BTAgregar_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;
            Rpt = MessageBox.Show("¿Deseas Insertar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                dataGridView2.Rows.Add(Lblidlibro.Text, LblLibro.Text, LblAutor.Text, DTfechaD.Value.ToString("dd/MM/yyyy"));

                Metodo_Prestamo Gl = new Metodo_Prestamo();
                Gl.idlibro = Lblidlibro.Text;
                Gl.fechaP = DateTime.Parse(lblFecha.Text);
                Gl.fechaD = DateTime.Parse(DTfechaD.Value.ToString("dd/MM/yyyy"));
                Gl.Anulado = "No";

                ClsPrestamo.InsertarPrestamo(Gl);
                Metodo_libros G = new Metodo_libros();
                G.idlibro = Lblidlibro.Text;
                G.existencia = int.Parse(LblExistencia.Text) - 1;
                CLsLibros.ActualizarLibrosExis(G);

                G.librosP = txtBuscar.Text;
                CLsLibros.ColsultarLibrosPrestamos(G);
                dataGridCL.DataSource = CLsLibros.ds;
                dataGridCL.DataMember = "Cargar LPrestamos";

                Lbtotal.Text = dataGridView2.RowCount.ToString();

                MessageBox.Show("Agrego Prestamo Libro Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void BTQuitar_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;
            Rpt = MessageBox.Show("¿Deseas Quitar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);

                Metodo_Prestamo Gl = new Metodo_Prestamo();
                Gl.idlibro = Lblidlibro.Text;
                Gl.Anulado = "Si";

                ClsPrestamo.AnularPrestamo(Gl);

                Metodo_libros G = new Metodo_libros();
                G.idlibro = Lblidlibro.Text;
                try
                {
                    CLsLibros.BuscarLibros(G);
                }
                catch (Exception) { MessageBox.Show("Codigo no encontrado"); }
                string existencia;
                existencia = Convert.ToString(G.existencia);

                G.idlibro = Lblidlibro.Text;
                G.existencia = int.Parse(LblExistencia.Text) + 1;
                CLsLibros.ActualizarLibrosExis(G);

                G.librosP = txtBuscar.Text;
                CLsLibros.ColsultarLibrosPrestamos(G);
                dataGridCL.DataSource = CLsLibros.ds;
                dataGridCL.DataMember = "Cargar LPrestamos";

                Lbtotal.Text = dataGridView2.RowCount.ToString();

                MessageBox.Show("Quitar Prestamo Libro Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridCL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botom_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoPrestamo_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            LblAutor.Text= string.Empty;
            LblExistencia.Text= string.Empty;
            LblLibro.Text= string.Empty;
            Lblidlibro.Text= string.Empty;
            DTfechaD.Text= string.Empty;

            Lbtotal.Text= string.Empty;
            dataGridView2.Rows.Clear();


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Lblidlibro.Text = this.dataGridCL.Rows[e.RowIndex].Cells[0].Value.ToString();
            LblAutor.Text = this.dataGridCL.Rows[e.RowIndex].Cells[1].Value.ToString();
            LblLibro.Text = this.dataGridCL.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void dataGridCL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Lblidlibro.Text = this.dataGridCL.Rows[e.RowIndex].Cells[0].Value.ToString();
            LblAutor.Text = this.dataGridCL.Rows[e.RowIndex].Cells[1].Value.ToString();
            LblLibro.Text = this.dataGridCL.Rows[e.RowIndex].Cells[2].Value.ToString();
            LblExistencia.Text = this.dataGridCL.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void Lbtotal_Click(object sender, EventArgs e)
        {

        }

        private void bttnBuscarPrestamo_Click(object sender, EventArgs e)
        {
            Buscar_Prestamo formSecundario = new Buscar_Prestamo();
            formSecundario.Show();
        }
    }
}
