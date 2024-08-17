using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaSesion;
using CapaServicios;
using System.Data;

namespace CapaDatos
{
    public class CD_GuardarPrimerIngreso
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();
        public void GuardarPrimerIngreso()
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "RegistrarPrimerIngreso";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Usuario", CS_Usuario.Id_Usuario);
            cmd.Parameters.AddWithValue("@FechaPrimerIngreso", CS_Usuario.fechaPrimerIngreso);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
