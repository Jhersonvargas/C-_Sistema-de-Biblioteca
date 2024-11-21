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

using System.Data.SqlClient;
using Biblioteca.Capa_Datos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Biblioteca
{

    public partial class RegistrarLibros : Form
    {
        public RegistrarLibros()
        {
            InitializeComponent();
            //Hago el llamado de cerrar_from1 para cerrar las ventanas
            //this.FormClosed += new FormClosedEventHandler(Cerrar_From1);
        }

        //Es para cerrar todos los formularios al cerrar el formulario principal y evitar que se quede ejecutando
        private void Cerrar_From1(object sender, FormClosedEventArgs e)
        {
            // Me aseguro que la aplicación se cierre al cerrar el formulario principal
            //Application.Exit();
        }


        private void LlenarAutores()
        {
            ClsAutor.Llenarcombox();
            cbAutor.DataSource = ClsAutor.dt;
            cbAutor.DisplayMember = "nomAutor";
            cbAutor.ValueMember = "idAutor";
            cbAutor.Text = "Seleccionar";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarAutores();
            
        }

        private void cmdgrabar_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;
            Rpt = MessageBox.Show("¿Desea grabar los libros?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                Metodo_libros Gl = new Metodo_libros();
                Gl.idlibro = txtid.Text;
                Gl.titulolibro = txtTitulo.Text;
                Gl.editorial = txteditorial.Text;
                Gl.pais = txtpais.Text;
                Gl.año = int.Parse(txtaño.Text);
                Gl.nPag = int.Parse(txtpaginas.Text);
                Gl.existencia = int.Parse(txtexistencia.Text);
                CLsLibros.InsertarLibros(Gl);

                Metodo_Libro_Autor Ga = new Metodo_Libro_Autor();
                Ga.ididlibro = txtid.Text;
                Ga.idAutor = cbAutor.SelectedValue.ToString();
                ClsLibros_Autor.IsentarLibrosAutor(Ga);

                MessageBox.Show("Libro ingreso correcctamente","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmdeditar_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;

            Rpt = MessageBox.Show("¿Desea Actualizar los libros?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes) 
            {
                Metodo_libros Gl = new Metodo_libros();
                Gl.idlibro = txtid.Text;
                Gl.titulolibro = txtTitulo.Text;
                Gl.editorial = txteditorial.Text;
                Gl.pais = txtpais.Text;
                Gl.año = int.Parse(txtaño.Text);
                Gl.nPag = int.Parse(txtpaginas.Text);
                Gl.existencia = int.Parse(txtexistencia.Text);
                CLsLibros.ActualizarLibros(Gl);

                Metodo_Libro_Autor Ga = new Metodo_Libro_Autor();
                Ga.ididlibro = txtid.Text;
                Ga.idAutor = cbAutor.SelectedValue.ToString();
                ClsLibros_Autor.ActualizarLibrosAutores(Ga);

                MessageBox.Show("Libro Actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmdbuscar_Click(object sender, EventArgs e)
        {
            Metodo_libros Gl = new Metodo_libros();
            Gl.idlibro = txtid.Text;
            try
            {
                CLsLibros.BuscarLibros(Gl);
            }
            catch (Exception) { MessageBox.Show("Codigo no encontrado"); }
            txtTitulo.Text = Gl.titulolibro;
            txteditorial.Text = Gl.titulolibro;
            txtpais.Text = Gl.pais;
            txtaño.Text = Convert.ToString(Gl.año);
            txtpaginas.Text = Convert.ToString(Gl.nPag);
            txtexistencia.Text = Convert.ToString(Gl.existencia);

            Metodo_Libro_Autor Ga = new Metodo_Libro_Autor();
            Ga.ididlibro = txtid.Text;
            try
            {
                ClsLibros_Autor.BuscarLibrosAutores(Ga);
            }
            catch (Exception) { MessageBox.Show("Codigo no encotrado"); }
            cbAutor.Text = Ga.nomAutor;
        }

        private void cmdnuevo_Click(object sender, EventArgs e)
        {

            // Limpio las casillas y controles del formulario
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    // En el caso que sea un textbox se va a poner en blanco
                    ((TextBox)control).Text = string.Empty;
                }
                else if (control is ComboBox)
                {
                    // En el caso que sea un combobox se va a poner "seleccionar en ves de mostrar algun nombre de index
                    cbAutor.Text = "Seleccionar";
                }



            }
        }

        //Mostrar el otro formulario
        private void añadir_combox_Click(object sender, EventArgs e)
        {
            LlenarAutores(); 
            RegistrarNuuevoActor formSecundario = new RegistrarNuuevoActor();
            formSecundario.Show();
        }

        private void cbAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbAutor_Click(object sender, EventArgs e)
        {
            LlenarAutores();
        }
    }
}
