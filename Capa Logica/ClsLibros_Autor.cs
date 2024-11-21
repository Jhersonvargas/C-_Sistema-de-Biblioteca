using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca.Capa_Datos;


namespace Biblioteca.Capa_Logica
{
    class ClsLibros_Autor
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;

        public static void IsentarLibrosAutor(Metodo_Libro_Autor la) 
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "IsentarLibro_Autor";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idlibro", SqlDbType.VarChar));
            Cm.Parameters["@idlibro"].Value = la.ididlibro;
            Cm.Parameters.Add(new SqlParameter("@idAutor", SqlDbType.VarChar));
            Cm.Parameters["@idAutor"].Value = la.idAutor;

            Cn.Open();  
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        public static void ActualizarLibrosAutores(Metodo_Libro_Autor la)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "ActualizarLibros_Autor";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idlibro", SqlDbType.VarChar));
            Cm.Parameters["@idlibro"].Value = la.ididlibro;
            Cm.Parameters.Add(new SqlParameter("@idAutor", SqlDbType.Char));
            Cm.Parameters["@idAutor"].Value = la.idAutor;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }


        public static void BuscarLibrosAutores(Metodo_Libro_Autor la)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cn.Open();
            Cm.CommandText = "VConsultar_Libros_Autor";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.AddWithValue("@idlibro", la.ididlibro);
            dr = Cm.ExecuteReader();
            if (dr.HasRows == false )
            {
                throw new Exception("libro no Encontrado");
            }

            while (dr.Read()) 
            {
                la.ididlibro = dr[0].ToString();
                la.nomAutor = dr[1].ToString();
            }
            Cn.Close();
            
        }


    }
}
