<<<<<<< HEAD
﻿using System;
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
using System.Data.Common;
=======
﻿using CapaSesion;
using System;
using System.Data;
using System.Data.SqlClient;
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c


namespace CapaDatos
{
<<<<<<< HEAD
    public class CD_AltaUsuario  
=======
    public class CD_AltaUsuario : Conexion
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
    {
        Conexion conexion = new Conexion();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter;
<<<<<<< HEAD
       

        //public void AltaUsuarioD (AtributosUsuario usuario)

        public DataTable AltaUsuarioD (CS_AtributosNuevoUsuario usuario)
=======


        //public void AltaUsuarioD (AtributosUsuario usuario)

        public DataTable AltaUsuarioD(AtributosUsuario usuario)
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c

        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "AltaUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", usuario.Username);
                cmd.Parameters.AddWithValue("@Pass", usuario.password);
<<<<<<< HEAD
               // cmd.Parameters.AddWithValue("@Id_Flia", usuario.Id_flia);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", usuario.Apellidos);
                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                //cmd.Parameters.AddWithValue("@VenceCada", usuario.VenceCada);
                cmd.Parameters.AddWithValue("@TipoDoc", usuario.TipoDocumento);
                cmd.Parameters.AddWithValue("@IntentosFallidos", usuario.intentos);
                cmd.Parameters.AddWithValue("@Bloqueado", usuario.Bloqueado);
               // cmd.Parameters.AddWithValue("@FechaUltimoCambio", usuario.FechaUltimoCambio);
               
               // cmd.Parameters.AddWithValue("@BloqueadoHasta", usuario.Bloqueado);
                //cmd.Parameters.AddWithValue("@FechaPrimerIngreso", usuario.Fecha);
                //cmd.Parameters.AddWithValue("@Digito", usuario.digito);
               
=======
                // cmd.Parameters.AddWithValue("@Id_Flia", usuario.Id_flia);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", usuario.Apellidos);
                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                cmd.Parameters.AddWithValue("@VenceCada", usuario.VenceCada);
                cmd.Parameters.AddWithValue("@TipoDoc", usuario.TipoDocumento);
                cmd.Parameters.AddWithValue("@IntentosFallidos", usuario.intentos);
                cmd.Parameters.AddWithValue("@Bloqueado", usuario.Bloqueado);
                // cmd.Parameters.AddWithValue("@FechaUltimoCambio", usuario.FechaUltimoCambio);

                // cmd.Parameters.AddWithValue("@BloqueadoHasta", usuario.Bloqueado);
                //cmd.Parameters.AddWithValue("@FechaPrimerIngreso", usuario.Fecha);
                cmd.Parameters.AddWithValue("@Digito", usuario.digito);

>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
                cmd.Parameters.AddWithValue("@NumeroDocumento", usuario.NumDocumento);
                cmd.Parameters.AddWithValue("@telefono", usuario.Telefono);
                cmd.Parameters.AddWithValue("@Celular", usuario.Celular);
                cmd.Parameters.AddWithValue("@Calle", usuario.Calle);
                cmd.Parameters.AddWithValue("@NumCalle", usuario.NumCalle);
                cmd.Parameters.AddWithValue("@Localidad", usuario.Localidad);
                cmd.Parameters.AddWithValue("@UsuarioTemporal", usuario.UsuarioTemporal);
                //cmd.Parameters.AddWithValue("@Familia", usuario.familia);
                //cmd.Parameters.AddWithValue("@VencimientoPass", usuario.VencimientoPass);
                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);


                cmd.ExecuteNonQuery();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
<<<<<<< HEAD
               // return dt;
=======
                // return dt;
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
            }
            finally
            {
                cmd.Parameters.Clear();
                conexion.CerrarConexion();
            }
<<<<<<< HEAD
           
=======

>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
        }
    }
}
