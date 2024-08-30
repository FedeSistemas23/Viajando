using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaServicios;
using System.Security.Policy;
using System.Threading;


namespace CapaDatos
{
    public class CD_AltaUsuario : Conexion
    {
        Conexion conexion = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public void AltaUsuarioD (AtributosUsuario usuario)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "AltaUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", usuario.Username);
                cmd.Parameters.AddWithValue("@Nombre", usuario.nombre);
                cmd.Parameters.AddWithValue("@Apellido", usuario.Apellidos);
                cmd.Parameters.AddWithValue("@Email", usuario.email);
                cmd.Parameters.AddWithValue("@TipoDocumento", usuario.TipoDocumento);
                cmd.Parameters.AddWithValue("@NumDocumento", usuario.NumDocumento);
                cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                cmd.Parameters.AddWithValue("@Celular", usuario.Celular);
                cmd.Parameters.AddWithValue("@Calle", usuario.Calle);
                cmd.Parameters.AddWithValue("@NumCalle", usuario.NumCalle);
                cmd.Parameters.AddWithValue("@Barrio", usuario.Barrio);
                cmd.Parameters.AddWithValue("@password", usuario.password);
                cmd.Parameters.AddWithValue("@digito", usuario.digito);
                cmd.Parameters.AddWithValue("@familia", usuario.familia);
                cmd.Parameters.AddWithValue("@intentos", usuario.intentos);
                cmd.Parameters.AddWithValue("@venceCada", usuario.VenceCAda);
                cmd.Parameters.AddWithValue("@Bloqueado", usuario.Bloqueado);
                
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
