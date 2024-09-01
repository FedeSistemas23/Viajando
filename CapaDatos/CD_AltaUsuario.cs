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
using CapaSesion;



namespace CapaDatos
{
    public class CD_AltaUsuario : Conexion
    {
        Conexion conexion = new Conexion();
        SqlCommand cmd = new SqlCommand();

<<<<<<< HEAD
<<<<<<< HEAD
        public void AltaUsuarioD (AtributosUsuario usuario)
=======
        public void AltaUsuarioD (CN_Nuevo_Usuario usuario)
>>>>>>> 07b1e3b662095515a706efd4e52b4d56a011117a
=======
        public void AltaUsuarioD (AtributosUsuario usuario)
>>>>>>> Alta Usuario
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
                cmd.Parameters.AddWithValue("@Tipo_Doc", usuario.TipoDocumento);
                cmd.Parameters.AddWithValue("@Num_iden", usuario.NumDocumento);
                cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                cmd.Parameters.AddWithValue("@Celular", usuario.Celular);
                cmd.Parameters.AddWithValue("@Calle", usuario.Calle);
                cmd.Parameters.AddWithValue("@Num", usuario.NumCalle);
                //cmd.Parameters.AddWithValue("@Barrio", usuario.Barrio);
                cmd.Parameters.AddWithValue("@Pass", usuario.password);
                cmd.Parameters.AddWithValue("@Digito", usuario.digito);
                cmd.Parameters.AddWithValue("@Id_Flia", usuario.id_flia);
                cmd.Parameters.AddWithValue("@IntentosFallidos", usuario.intentos);
                cmd.Parameters.AddWithValue("@VenceCada", usuario.venceCada);
                cmd.Parameters.AddWithValue("@BloqueadoHasta", usuario.Bloqueado);
                
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
