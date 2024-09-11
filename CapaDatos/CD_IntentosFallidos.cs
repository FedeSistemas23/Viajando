using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_IntentosFallidos: Conexion
    {
        Conexion conexion = new Conexion();
        SqlCommand cmd = new SqlCommand();


        public bool ActualizaIntentosFallidos(string Username)
        {
            try
            {

                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "RegistrarIntentosFallidos";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Username", Username);

                SqlDataReader reader = cmd.ExecuteReader();

                cmd.Parameters.Clear();
                conexion.CerrarConexion();

                return true;
            } catch (Exception ex) 
            {
                Console.WriteLine("Error CD_IntentosFallidos lina 36 : Error al ejecutar procedimiento almacenado por : " + ex.ToString());
                return false;
            }
            finally 
            {
                     conexion.CerrarConexion();
                     cmd.Dispose();
            }




            /*cmd.Connection = conexion.AbrirConexion();
            //cmd.CommandText = "ValidarUsuario";
            cmd.CommandText = "InicioSesion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            SqlDataReader leer = cmd.ExecuteReader();
            try*/


        }
    }
}
