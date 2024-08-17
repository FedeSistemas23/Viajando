using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_EditarPassword : Conexion
    {
        SqlCommand cmd =new SqlCommand();
        Conexion conexion = new Conexion();
        public void EditarPassword(string pass, string username)

        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "EditarPassword";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Password", pass);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }

    }
}
