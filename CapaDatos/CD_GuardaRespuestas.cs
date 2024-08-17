using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaSesion;
using CapaServicios;

namespace CapaDatos
{
    public class CD_GuardaRespuestas : Conexion
    {

        //int id_usuario = CS_Usuario.Id_Usuario;

        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();
        public void GuardarRespuestas()
        {
            string[] respuesta = new string[3];
            for (int i = 0; i <=1; i++)
            {
                respuesta[0] = CS_GuardaPreguntasRespuestas.respuesta1;
                respuesta[1] = CS_GuardaPreguntasRespuestas.respuesta2;
                respuesta[2] = CS_GuardaPreguntasRespuestas.respuesta3;
            }
            int[] id_preg = new int[3];
            for (int i = 0; i <= 2; i++)
            {
                id_preg[0] = CS_GuardaPreguntasRespuestas.id_preg1;
                id_preg[1] = CS_GuardaPreguntasRespuestas.id_preg2;
                id_preg[2] = CS_GuardaPreguntasRespuestas.id_preg3;
            }

            for (int i = 0; i <= 2; i++)
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "GuardarRespuestas";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Usuario", CS_Usuario.Id_Usuario);
                cmd.Parameters.AddWithValue("@Respuesta", respuesta[i]);
                cmd.Parameters.AddWithValue("@Id_Preg", id_preg[i]);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexion.CerrarConexion();
            }
            
        }
    }
}

