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
    public partial class consultar : Form
    {
        public consultar()
        {
            InitializeComponent();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            cbelegir.Items.Add("Titulo");
            cbelegir.Items.Add("Pais");
            cbelegir.Items.Add("Editorial");

            CLsLibros.ListarLibros();
            DtgriLibro.DataSource = CLsLibros.ds;
            DtgriLibro.DataMember = "Cargar Libros";
        }

        private void DtgrLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbelegir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Metodo_libros Gl = new Metodo_libros();
            if(cbelegir.SelectedIndex == 0)
            {
                Gl.titulolibro = txt.Text;
                CLsLibros.ColsultarLibrosTitulo(Gl);
                DtgriLibro.DataSource = CLsLibros.ds;
                DtgriLibro.DataMember = "Cargar Titulos";
            }

            if(cbelegir.SelectedIndex == 1)
            {
                Gl.pais = txt.Text;
                CLsLibros.ColsultarLibrosPais(Gl);
                DtgriLibro.DataSource= CLsLibros.ds;
                DtgriLibro.DataMember = "Cargar Pais";
            }

            if (cbelegir.SelectedIndex == 2)
            {
                Gl.editorial = txt.Text;
                CLsLibros.ColsultarLibrosEditorial(Gl);
                DtgriLibro.DataSource = CLsLibros.ds;
                DtgriLibro.DataMember = "Cargar Editorial";
            }


        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
