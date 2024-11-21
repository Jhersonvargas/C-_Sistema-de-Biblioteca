using Biblioteca.Capa_Datos;
using Biblioteca.Capa_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class RegistrarNuuevoActor : Form
    {
        public RegistrarNuuevoActor()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;
            Rpt = MessageBox.Show("¿Desea grabar los Autores?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                Metodo_Autor Gl = new Metodo_Autor();
                Gl.idAutor = txtidnombre.Text;
                Gl.nomAutor = txtnomAutor.Text;
    
                ClsAutor.InsertarAutor(Gl);

               

                MessageBox.Show("Autor ingreso correcctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //esto es para cerrar la ventana despues de agreagr el nuevo elemnto (autor)
            this.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            // Limpio las casillas y controles del formulario
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    // En el caso que sea un textbox se va a poner en blanco
                    ((TextBox)control).Text = string.Empty;
                }

            }
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Metodo_Autor Gl = new Metodo_Autor();
            Gl.idAutor = txtidnombre.Text;
            try
            {
                ClsAutor.BuscarAutores(Gl);
            }
            catch (Exception) { MessageBox.Show("Codigo no encontrado"); }
            txtidnombre.Text = Gl.idAutor;
            txtnomAutor.Text = Gl.nomAutor;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;

            Rpt = MessageBox.Show("¿Desea Actualizar los autores?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                Metodo_Autor Gl = new Metodo_Autor();
                Gl.idAutor = txtidnombre.Text;
                Gl.nomAutor = txtnomAutor.Text;
            
                ClsAutor.ActualizarAutores(Gl);

                MessageBox.Show("Autor Actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }
    }
}
