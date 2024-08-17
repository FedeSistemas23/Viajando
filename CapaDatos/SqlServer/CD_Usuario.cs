using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;
using CapaSesion;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Runtime.CompilerServices;
using System.Diagnostics.Eventing.Reader;
using System.Collections.Specialized;

namespace CapaDatos
    //
{
    public class CD_Usuario : Conexion
    {
        private Conexion conexion = new Conexion();
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();
        public bool Login(string username, string password)
        {
            // Acá debo poner la consulta sql del store procedure

            cmd.Connection = conexion.AbrirConexion();
            //cmd.CommandText = "ValidarUsuario";
            cmd.CommandText = "InicioSesion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", username); 
            cmd.Parameters.AddWithValue("@Password", password);           
            SqlDataReader leer = cmd.ExecuteReader();                        
            try
            {
                if (leer.Read())
                {                                          
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
                cmd.Parameters.Clear();
                leer.Close();                                 
                conexion.CerrarConexion();
            }            
        }

        public void GuardarFechaPrimerIngreso( int id_usuario)
        {            
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "RegistrarPrimerIngreso";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FechaPrimerIngreso", CS_Usuario.fechaPrimerIngreso);        
            cmd.Parameters.AddWithValue("@Id_Usuario", id_usuario);            
            try
            {                  
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


    
        public void VerificarIngresos(string username, string password)
        {            
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "ValidarIngreso";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            SqlDataReader leer = cmd.ExecuteReader();
            try
            {
                if (leer.HasRows)
                {
                    while (leer.Read()) // Método para cargar el nombre, apellido y rol en pictureBox panellateral al iniciar sesion.
                    {
                       
                        CS_Usuario.intentos = leer.GetInt32(leer.GetOrdinal("IntentosFallidos"));
                        CS_Usuario.bloqueadoHasta = leer.GetDateTime(leer.GetOrdinal("BloqueadoHasta"));
                        //CS_Usuario.FechaPrimerIngreso = leer.GetDateTime(leer.GetOrdinal("FechaPrimerIngreso"));
                    }
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
                
        public void ResetearIntentosFallidos(int id_usuario)
        {           
            try
            {   conexion.AbrirConexion();
                cmd.CommandText="ResetearIntentosFallidos";
                cmd.CommandType= CommandType.Text;
                cmd.Parameters.AddWithValue("@Id_Usuario", id_usuario);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            
        }

        public void RegistrarIntentoFallido(int id_Usuario, int intentosFallidos)
        {           
                cmd.Connection=conexion.AbrirConexion();
                try
                {
                    intentosFallidos++;
                    if (intentosFallidos >= 3)
                    {
                        DateTime bloqueadoHasta = DateTime.Now.AddHours(24);
                        cmd = new SqlCommand("UPDATE Usuarios SET IntentosFallidos = @IntentosFallidos, BloqueadoHasta = @BloqueadoHasta WHERE Id_USuario= @UsuarioID");
                        cmd.Parameters.AddWithValue("@BloqueadoHasta", bloqueadoHasta);

                    }
                    else
                    {
                        cmd = new SqlCommand("UPDATE Usuarios SET IntentosFallidos = @IntentosFallidos WHERE UsuarioID = @UsuarioID");

                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
                }
                finally
                {
                    conexion.CerrarConexion();
                }              
                cmd.Parameters.AddWithValue("@IntentosFallidos", intentosFallidos);
                cmd.Parameters.AddWithValue("@UsuarioID", id_Usuario);
                cmd.ExecuteNonQuery();            
        }
        

        public bool ValidarMail(string correo)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "ValidacionesMail";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", correo);
            SqlDataReader leer = cmd.ExecuteReader();
            try
            {
                if (leer.HasRows)
                {
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
        public string recuperoPassword(string email, string aleatorio)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "ValidarEmail";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", email);
            SqlDataReader leer = cmd.ExecuteReader();
            try
            {
                string mensaje = "Hola, su peticion para cambiar la contraseña se há generado. \n" + "Verifique su correo electrónico";
                if (leer.Read())
                {
                    // string userMail = leer.GetString(0);

                    var mailService = new Servicios_Mail.SystemSupportMail();
                    mailService.sendMail(
                    subject: "SYSTEMA  VIAJANDO: Cambio de Password",
                    body: "Hola ya puedes cambiar tu contraseña,TE LLEGO FEDE??" + aleatorio,
                    recipientMail: email);
                }
                return mensaje;
            }
            catch (Exception ex)
            {
                throw new Exception("Lo siento, usted no posee una cuenta con ese mail." + ex.Message);
            }
            finally
            {
                leer.Close();
                conexion.CerrarConexion();
            }
        }

        // el "admin" ingresa su uswuario y contraseña en el formulario,se invoca el hasheo, se invoca el editar password y entonces el usuario y el pass el userpass. ahora el unico
        // problema 
        

        public string[] PreguntasUser(int idUsuario)
        {
           
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "TraerPreguntas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue ("@idUsuario", idUsuario);
            SqlDataReader leer = cmd.ExecuteReader();
            string[] preguntasUser = new string[3];
            //int[] id_preguntas = new int[3];
            try
            {
                if (leer.HasRows)
                {
                    int contador = 1;
                    while (leer.Read() && contador <= 3)
                    {
                        if (contador == 1)
                        {
                            preguntasUser[0] = leer["Pregunta"].ToString();
                           // id_preguntas[0] = leer.GetInt32(leer.GetOrdinal("Id_Preg"));

                        }
                        else if (contador == 2)
                        {
                            preguntasUser[1] = leer["Pregunta"].ToString();
                          // id_preguntas[1] = leer.GetInt32(leer.GetOrdinal("Id_Preg"));
                        }
                        else if (contador == 3)
                        {
                            preguntasUser[2] = leer["Pregunta"].ToString();
                           // id_preguntas[2] = leer.GetInt32(leer.GetOrdinal("Id_Preg"));
                        }
                        contador++;
                    }
                }
                return preguntasUser;
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
        public string[] PreguntasAleatorias()
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "PreguntasAleatorias";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader leer = cmd.ExecuteReader();
            string[] preguntasAleatorias = new string[3];
            //int[] id_preguntas = new int[3];
           // List<Respuestas> listarespuesta = new List<Respuestas>();
            try
            {
                if (leer.HasRows)
                {
                    int contador = 1;
                    while (leer.Read() && contador <= 3)
                    {
                        if (contador == 1)
                        {
                            preguntasAleatorias[0] = leer["Pregunta"].ToString();
                            CS_GuardaPreguntasRespuestas.id_preg1= leer.GetInt32(leer.GetOrdinal("Id_Preg")) ;
                            
                        }
                        else if (contador == 2)
                        {
                            preguntasAleatorias[1] = leer["Pregunta"].ToString();
                            CS_GuardaPreguntasRespuestas.id_preg2= leer.GetInt32(leer.GetOrdinal("Id_Preg"));
                        }
                        else if (contador == 3)
                        {
                            preguntasAleatorias[2] = leer["Pregunta"].ToString();
                            CS_GuardaPreguntasRespuestas.id_preg3= leer.GetInt32(leer.GetOrdinal("Id_Preg"));
                        }
                        contador++;
                    }                                        
                }
                return preguntasAleatorias;
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



        

        public void AltaUsuario(string nombre, string apellido, string usuario, string email, string password)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "AltaUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@Apellido", apellido);
            cmd.Parameters.AddWithValue("@Username", usuario);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Pass", password);
            SqlDataReader leer = cmd.ExecuteReader();
            try
            {
                if (leer == null)
                {
                    cmd.ExecuteNonQuery();
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
    
       

