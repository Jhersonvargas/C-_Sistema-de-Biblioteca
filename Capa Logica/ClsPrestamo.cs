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
    class ClsPrestamo
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;

        public static void InsertarPrestamo(Metodo_Prestamo c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Insertar_Prestamo";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idlibro", SqlDbType.VarChar));
            Cm.Parameters["@idlibro"].Value = c.idlibro;
            Cm.Parameters.Add(new SqlParameter("@fechaP", SqlDbType.Date));
            Cm.Parameters["@fechaP"].Value = c.fechaP;
            Cm.Parameters.Add(new SqlParameter("@fechaD", SqlDbType.Date));
            Cm.Parameters["@fechaD"].Value = c.fechaD;
            Cm.Parameters.Add(new SqlParameter("@Anulado", SqlDbType.VarChar));
            Cm.Parameters["@Anulado"].Value = c.Anulado;
            
            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        public static void AnularPrestamo(Metodo_Prestamo c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Anular_Prestamo";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idlibro", SqlDbType.VarChar));
            Cm.Parameters["@idlibro"].Value = c.idlibro;
            Cm.Parameters.Add(new SqlParameter("@Anulado", SqlDbType.VarChar));
            Cm.Parameters["@Anulado"].Value = c.Anulado;
            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }


        public static void buscarLibrosP(Metodo_Prestamo c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "buscar_libroP";
            da.SelectCommand.Parameters.AddWithValue("@fechaP", c.fechaP);
            da.SelectCommand.Parameters.AddWithValue("@fechaD", c.fechaD);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "Cargar LibrosP");

            Cn.Close();
        }

        public static void buscarLibrosD(Metodo_Prestamo c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "buscar_libroD";
            da.SelectCommand.Parameters.AddWithValue("@fechaP", c.fechaP);
            da.SelectCommand.Parameters.AddWithValue("@fechaD", c.fechaD);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "Cargar LibrosD");

            Cn.Close();
        }

















    }
}
