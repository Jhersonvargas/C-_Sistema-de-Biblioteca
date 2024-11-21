using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Biblioteca.Capa_Datos;


namespace Biblioteca.Capa_Logica
{
    class CLsLibros
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;

        public static DataTable dt;


        public static void InsertarLibros(Metodo_libros c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "insertar_libros";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idlibro", SqlDbType.VarChar));
            Cm.Parameters["@idlibro"].Value = c.idlibro;
            Cm.Parameters.Add(new SqlParameter("@titulolibro", SqlDbType.VarChar)); 
            Cm.Parameters["@titulolibro"].Value = c.titulolibro;
            Cm.Parameters.Add(new SqlParameter("@editorial", SqlDbType.VarChar));
            Cm.Parameters["@editorial"].Value = c.editorial;
            Cm.Parameters.Add(new SqlParameter("@pais", SqlDbType.VarChar));
            Cm.Parameters["@pais"].Value = c.pais;
            Cm.Parameters.Add(new SqlParameter("@año", SqlDbType.Int));
            Cm.Parameters["@año"].Value = c.año;
            Cm.Parameters.Add(new SqlParameter("@nPag", SqlDbType.Int));
            Cm.Parameters["@nPag"].Value = c.nPag;
            Cm.Parameters.Add(new SqlParameter("@existencia", SqlDbType.Int));
            Cm.Parameters["@existencia"].Value = c.existencia;
            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }
        

        public static void ActualizarLibros(Metodo_libros c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Actualizar_libros";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idlibro", SqlDbType.VarChar));
            Cm.Parameters["@idlibro"].Value = c.idlibro;
            Cm.Parameters.Add(new SqlParameter("@titulolibro", SqlDbType.VarChar));
            Cm.Parameters["@titulolibro"].Value = c.titulolibro;
            Cm.Parameters.Add(new SqlParameter("@editorial", SqlDbType.VarChar));
            Cm.Parameters["@editorial"].Value = c.editorial;
            Cm.Parameters.Add(new SqlParameter("@pais", SqlDbType.VarChar));
            Cm.Parameters["@pais"].Value = c.pais;
            Cm.Parameters.Add(new SqlParameter("@año", SqlDbType.Int));
            Cm.Parameters["@año"].Value = c.año;
            Cm.Parameters.Add(new SqlParameter("@nPag", SqlDbType.Int));
            Cm.Parameters["@nPag"].Value = c.nPag;
            Cm.Parameters.Add(new SqlParameter("@existencia", SqlDbType.Int));
            Cm.Parameters["@existencia"].Value = c.existencia;
            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }


        public static void BuscarLibros(Metodo_libros c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cn.Open() ;
            Cm.CommandText = "Consultar_Libros_Idlibros";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.AddWithValue("@idlibro", c.idlibro);
            dr = Cm.ExecuteReader();
            if (dr.HasRows==false)
            {
                throw new Exception("Libro no encontrado");     
            }

            while (dr.Read())
            {
                c.idlibro= dr[0].ToString();
                c.titulolibro= dr[1].ToString();
                c.editorial= dr[2].ToString();
                c.pais = dr[3].ToString();
                c.año = int.Parse(dr[4].ToString());
                c.nPag = int.Parse(dr[5].ToString());
                c.existencia = int.Parse(dr[6].ToString());
            }
            Cn.Close();
        }


        public static void ListarLibros()
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "listar_libros";

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds,"Cargar Libros");

            Cn.Close();
        }

        public static void ColsultarLibrosTitulo(Metodo_libros c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "VConsultar_libros_Titulo";
            da.SelectCommand.Parameters.AddWithValue("@titulolibro", c.titulolibro);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "Cargar Titulos");

            Cn.Close();
        }


        public static void ColsultarLibrosPais(Metodo_libros c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "VConsultar_libros_Pais";
            da.SelectCommand.Parameters.AddWithValue("@pais", c.pais);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "Cargar Pais");

            Cn.Close();
        }


        public static void ColsultarLibrosEditorial(Metodo_libros c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "VConsultar_libros_Editorial";
            da.SelectCommand.Parameters.AddWithValue("@editorial", c.editorial);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "Cargar Editorial");

            Cn.Close();
        }

        public static void ColsultarLibrosPorAño(Metodo_libros c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "Consultar_Libros_PorAños";
            da.SelectCommand.Parameters.AddWithValue("@añodesde", c.añodesde);
            da.SelectCommand.Parameters.AddWithValue("@añohasta", c.añohasta);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "Cargar Libros Por Año");

            Cn.Close();
        }

        public static void ColsultarLibrosPrestamos(Metodo_libros c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "VConsultar_libros_Prestamos";
            da.SelectCommand.Parameters.AddWithValue("@librosP", c.librosP);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "Cargar LPrestamos");

            Cn.Close();
        }

        public static void ActualizarLibrosExis(Metodo_libros c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Actualizar_LibrosExis";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idlibro", SqlDbType.VarChar));
            Cm.Parameters["@idlibro"].Value = c.idlibro;
            Cm.Parameters.Add(new SqlParameter("@existencia", SqlDbType.Int));
            Cm.Parameters["@existencia"].Value = c.existencia;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

    }
}
