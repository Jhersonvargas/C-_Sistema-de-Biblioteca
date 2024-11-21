using Biblioteca.Capa_Datos;
using Biblioteca.Capa_Logica;
using Biblioteca.Capa_Presentacion;
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
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
        }






        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            Metodo_Acceso Gl = new Metodo_Acceso();
            Gl.idusuario = txtusuario.Text;
            Gl.clave = txtclave.Text;
            try
            {
                ClsAcceso.ValidarUsuario(Gl);
                Biblioteca formPrincipal = new Biblioteca();
                formPrincipal.Show();

                // Cierra el formulario de acceso (FormAcceso)
                this.Hide();
            }
            catch (Exception) { MessageBox.Show("Usuario no encontrado"); }
            txtusuario.Text = Gl.idusuario;
            txtclave.Text = Gl.clave;
        }
    }
}
