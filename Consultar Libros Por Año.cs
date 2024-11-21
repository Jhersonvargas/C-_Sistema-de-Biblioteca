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
using static System.Net.Mime.MediaTypeNames;

namespace Biblioteca
{
    public partial class Consultar_Libros_Por_Año : Form
    {
        public Consultar_Libros_Por_Año()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Consultar_Libros_Por_Año_Load(object sender, EventArgs e)
        {
            CLsLibros.ListarLibros();
            DtgriLibroPorAño.DataSource = CLsLibros.ds;
            DtgriLibroPorAño.DataMember = "Cargar Libros";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Metodo_libros Gl = new Metodo_libros();
            {
                Gl.añodesde = int.Parse(txtdesde.Text);
                Gl.añohasta = int.Parse(txthasta.Text);
                CLsLibros.ColsultarLibrosPorAño(Gl);
                DtgriLibroPorAño.DataSource = CLsLibros.ds;
                DtgriLibroPorAño.DataMember = "Cargar Libros Por Año";           
            }
        }
    }
}
