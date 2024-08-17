using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_ValidarPassword : Conexion
    {
        SqlCommand cmd=new SqlCommand();
        Conexion conexion= new Conexion();
        public bool ValidarContraseña(string password)
        {
            // Acá debo poner la consulta sql del store procedure

            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "ValidarContraseña";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Password", password);
            SqlDataReader leer = cmd.ExecuteReader();
            try
            {
                if (leer.HasRows)
                {
                    CS_Usuario.password = leer["Pass"].ToString();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
            finally
            {
                leer.Close();
                conexion.CerrarConexion();

            }
        }
    }
}
