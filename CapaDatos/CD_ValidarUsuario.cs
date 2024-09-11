using CapaSesion;
using System;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class CD_ValidarUsuario : Conexion
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();

        public bool ValidarUsuarioD(string username)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "ValidarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", username);
            SqlDataReader leer = cmd.ExecuteReader();
            try
            {
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        CS_Usuario.Id_Usuario = leer.GetInt32(leer.GetOrdinal("Id_Usuario"));
                        CS_Usuario.Username = leer["Username"].ToString();
                        CS_Usuario.password = leer["Pass"].ToString();
                        CS_Usuario.email = leer["Email"].ToString();
                        //CS_Usuario.intentos = leer.GetInt32(leer.GetOrdinal("IntentosFallidos"));
                        /*if (leer.IsDBNull(leer.GetOrdinal("IntentosFallidos")))

                        {
                            CS_Usuario.intentos = 0;
                        }*/
                       /* if (leer.IsDBNull(leer.GetOrdinal("FechaUltimoCambio")))
                        {
                            CS_Usuario.fechaUltimoCambio = DateTime.Now;
                        }
                        else
                        {
                            CS_Usuario.fechaUltimoCambio = leer.GetDateTime(leer.GetOrdinal("FechaUltimoCambio"));
                        }*/
                       // CS_Usuario.venceCada = leer.GetInt32(leer.GetOrdinal("VenceCada"));
                        if (leer.IsDBNull(leer.GetOrdinal("FechaPrimerIngreso")))
                        {
                            CS_Usuario.fechaPrimerIngreso = DateTime.Now;
                        }
                        else
                        {
                            CS_Usuario.fechaPrimerIngreso = leer.GetDateTime(leer.GetOrdinal("FechaPrimerIngreso"));
                        }

                    }
                    leer.Close();
                    cmd.Parameters.Clear();
                    conexion.CerrarConexion();
                    return true;
                }
                else
                {
                    leer.Close();
                    cmd.Parameters.Clear();
                    conexion.CerrarConexion();
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
    }
}
