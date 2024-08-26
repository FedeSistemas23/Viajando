using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaServicios;
using CapaSesion;

namespace CapaDatos
{
    public class CD_TraePreguntasYRespuestas : Conexion
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();

        public void TraerPreguntasyRespuestas()
        {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "TraerPreguntas";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Usuario", CS_Usuario.Id_Usuario);                
                SqlDataReader leer = cmd.ExecuteReader();                                      
                try
                {
                    if (leer.HasRows)
                    {
                        int contador = 1;
                        while (leer.Read() && contador <= 3)
                        {
                            if (contador == 1)
                            {
                                CS_PregRespSeg.Pregunta1 = leer["Pregunta"].ToString();
                                CS_PregRespSeg.Respuesta1 = leer["Resp"].ToString();
                            }
                            else if (contador == 2)
                            {
                                CS_PregRespSeg.Pregunta2 = leer["Pregunta"].ToString();
                                CS_PregRespSeg.Respuesta2 = leer["Resp"].ToString();
                            }
                            else if (contador == 3)
                            {
                                CS_PregRespSeg.Pregunta3 = leer["Pregunta"].ToString();
                                CS_PregRespSeg.Respuesta3 = leer["Resp"].ToString();
                            }
                            contador++;
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
                    cmd.Parameters.Clear();
                    conexion.CerrarConexion();
                }
            
        }                       
    }
}
