using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Biblioteca.Capa_Datos;

namespace Biblioteca.Capa_Presentacion
{
    internal class ClsAcceso
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public static void ValidarUsuario(Metodo_Acceso c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cn.Open();
            Cm.CommandText = "validar_usuario";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.AddWithValue("@idusuario", c.idusuario);
            Cm.Parameters.AddWithValue("@clave", c.clave);
            dr = Cm.ExecuteReader();
            if (dr.HasRows == false)
            {
                throw new Exception("Usuario no encontrado");
            }

            while (dr.Read())
            {
                c.idusuario = dr[0].ToString();
                c.clave = dr[1].ToString();

            }
            Cn.Close();

        }

    }
}
