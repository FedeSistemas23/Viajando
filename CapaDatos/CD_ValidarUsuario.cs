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
                        CS_Usuario.intentos = int.Parse(leer["IntentosFallidos"].ToString());                                                                                               
                        if (leer.IsDBNull(leer.GetOrdinal("FechaUltimoCambio")))
                        {
                            CS_Usuario.fechaUltimoCambio = DateTime.Now;
                        }else
                        {
                            CS_Usuario.fechaUltimoCambio= leer.GetDateTime(leer.GetOrdinal("FechaUltimoCambio"));
                        }
                        CS_Usuario.venceCada = int.Parse(leer["VenceCada"].ToString());
                        CS_Usuario.bloqueadoHasta = leer.GetBoolean(leer.GetOrdinal("BloqueadoHasta"));
                        
                        if (leer.IsDBNull(leer.GetOrdinal("FechaPrimerIngreso")))
                        {
                            CS_Usuario.fechaPrimerIngreso = DateTime.Now;
                        }
                        else
                        {
                            CS_Usuario.fechaPrimerIngreso= leer.GetDateTime(leer.GetOrdinal("FechaPrimerIngreso"));
                        }
                        //CS_Usuario.digito = int.Parse(leer["Digito"].ToString());
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
    /*public class CD_ValidarUsuario : Conexion
    {
        public bool ValidarUsuarioD(string username)
        {
            Conexion conexion = new Conexion();
            SqlCommand cmd = new SqlCommand("ValidarUsuario");
            {
                cmd.Connection=conexion.AbrirConexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);



                using (var leer = cmd.ExecuteReader())
                {
                    if (leer.HasRows)
                    {
                        while (leer.Read())
                        {
                            CS_Usuario.Id_Usuario = leer.GetInt32(leer.GetOrdinal("Id_Usuario"));
                            CS_Usuario.Username = leer["Username"].ToString();
                            CS_Usuario.password = leer["Pass"].ToString();
                            CS_Usuario.email = leer["Email"].ToString();
                            CS_Usuario.intentos = leer.GetInt32(leer.GetOrdinal("IntentosFallidos"));

                            CS_Usuario.fechaUltimoCambio = leer.IsDBNull(leer.GetOrdinal("FechaUltimoCambio"))
                                ? DateTime.Now
                                : leer.GetDateTime(leer.GetOrdinal("FechaUltimoCambio"));

                            CS_Usuario.venceCada = int.Parse(leer["VenceCada"].ToString());
                            CS_Usuario.bloqueadoHasta = leer.GetBoolean(leer.GetOrdinal("BloqueadoHasta"));

                            CS_Usuario.fechaPrimerIngreso = leer.IsDBNull(leer.GetOrdinal("FechaPrimerIngreso"))
                                ? DateTime.Now
                                : leer.GetDateTime(leer.GetOrdinal("FechaPrimerIngreso"));

                            CS_Usuario.digito = leer.GetInt32(leer.GetOrdinal("Digito"));
                        }
                        return true;
                    }
                    return false;
                }
            }
        }
    }*/
}
