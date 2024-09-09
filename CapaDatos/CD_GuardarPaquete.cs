using CapaSesion;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_GuardarPaquete : Conexion
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();

<<<<<<< HEAD
        /*public void GuardarPaqueteD(Paquete paquete)
=======
        public void GuardarPaqueteD(CS_Paquete paquete)
>>>>>>> 99cambios
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "GuardarPaquete";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaSalida", paquete.FechaSalida);
                cmd.Parameters.AddWithValue("@FechaRegreso", paquete.FechaRegreso);
                cmd.Parameters.AddWithValue("@Destino", paquete.Destino);
                cmd.Parameters.AddWithValue("@CantidadDias", paquete.CantidadDias);
                cmd.Parameters.AddWithValue("@CantidadNoches", paquete.CantidadNoches);
                cmd.Parameters.AddWithValue("@Regimen", paquete.Regimen);
                cmd.Parameters.AddWithValue("@ProveedorHotel", paquete.ProveedorHotel);
                cmd.Parameters.AddWithValue("@Single", paquete.Single);
                cmd.Parameters.AddWithValue("@Doble", paquete.Doble);
                cmd.Parameters.AddWithValue("@Triple", paquete.Triple);
                cmd.Parameters.AddWithValue("@Cuadruple", paquete.Cuadruple);
                cmd.Parameters.AddWithValue("@ProveedorBus", paquete.ProveedorBus);
                cmd.Parameters.AddWithValue("@Semicamas", paquete.Semicamas);
                cmd.Parameters.AddWithValue("@Camas", paquete.Camas);
                cmd.Parameters.AddWithValue("@GastosAdministrativos", paquete.GastosAdministrativos);
                cmd.Parameters.AddWithValue("@PrecioLista", paquete.PrecioLista);
                cmd.Parameters.AddWithValue("@PrecioEfectivo", paquete.PrecioEfectivo);
                cmd.Parameters.AddWithValue("@Descuento", paquete.Descuento);
                cmd.Parameters.AddWithValue("@Disponibilidad", paquete.Disponibilidad);
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
        }*/
    }
}
