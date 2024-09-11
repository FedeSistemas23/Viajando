using System;
<<<<<<< HEAD
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
=======
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_IntentosFallidos : Conexion
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
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
<<<<<<< HEAD
            } catch (Exception ex) 
=======
            }
            catch (Exception ex)
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
            {
                Console.WriteLine("Error CD_IntentosFallidos lina 36 : Error al ejecutar procedimiento almacenado por : " + ex.ToString());
                return false;
            }
<<<<<<< HEAD
            finally 
            {
                     conexion.CerrarConexion();
                     cmd.Dispose();
=======
            finally
            {
                conexion.CerrarConexion();
                cmd.Dispose();
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
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
