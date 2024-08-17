using CapaServicios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaSesion;

namespace CapaDatos
{
    public class CD_GuardaDigito : Conexion
    {
        int idUsuario = CS_Usuario.Id_Usuario;        
        SqlCommand cmd = new SqlCommand();
        Conexion conexion= new Conexion();

        public void GuardarDigito(int digito)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "GuardarDigito";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Usuario", idUsuario);
                cmd.Parameters.AddWithValue("@Digito", digito);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
            finally
            {               
                cmd.Parameters.Clear();
                conexion.CerrarConexion();
            }
        }
    }
    
}
