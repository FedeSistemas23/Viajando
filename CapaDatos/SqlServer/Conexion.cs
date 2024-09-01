using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace CapaDatos
{
    public class Conexion
    {

        private SqlConnection ConexionBd = new SqlConnection("Server =FAMILIA; DataBase = Viajando; integrated security = true");
        public SqlConnection AbrirConexion()
        {
            if (ConexionBd.State == ConnectionState.Closed)
                ConexionBd.Open();
            return ConexionBd;
        }
        public SqlConnection CerrarConexion()
        {
            if (ConexionBd.State == ConnectionState.Open)
                ConexionBd.Close();
            return ConexionBd;
        }
    }
}
    /*  private readonly string cadenaConexion = "Server =(local); DataBase = login; integrated security = true";

        public DataTable ConectarBD()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            { 

                conn.Open();

            }

            return dt;
        } 


    }
}
*/


/*namespace DATOS
{
    // Esta clase, al ser las mas alta en la cadena conceptual, y solo ser heredada (y no instanciada)
    // sera del tipo Abstracta

    public abstract class EjecutarQuerys
    {
        // Cadena de Conexion de Access con la Base de Datos alojada en la carpeta Bin/Debug de la capa de Vista
        // de la solucion, dado que esta capa es el Proyecto de Inicio del programa

        private readonly string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Personas.accdb";

        // Este metodo recibe dos parametros mas un tercero opcional: el primero recibe el string SQL parametrizado,
        // el segundo recibe un array de parametros que se adosaran al objeto Command para "cargar" los parametros de
        // la instruccion SQL (el empleo de esta manera de trabajo evita la "Inyeccion SQL", y el tercero, opcional, es 
        // a los efectos de informar al metodo si se trata de una consulta donde debera traer datos o de una instruccion
        // que solamente agregara, modificara  o elimina uno o varios datos de la base de datos
     
            public DataTable Ejecutar(string sSQL, OleDbParameter[] lista, bool consulta = false)
            {
            DataTable dt = new DataTable(); // creo un objeto DataTable fuera del bloque Using

            // Los bloques Using son muy utiles en las conexiones a BD dado que liberan los recursos utilizados
            // por los objetos una vez finalizada su utilizacion, sin hacer fatla cerrar las conexiones ni ningun
            // otro tipo de operacion al respecto

            using (OleDbConnection conn = new OleDbConnection(cadena))
            {
                conn.Open(); // abro la conexion establecida en el bloque Using

                // Instancio el objeto OleDbCommand pasandole el string SQL y el objeto OleDbConnection
                OleDbCommand command = new OleDbCommand(sSQL, conn);

                // Si la lista de parametros no se encuentra vacia la adoso al objeto OleDbCommand
                if (lista != null) command.Parameters.AddRange(lista);

                // Si la variable opcional de consulta se encuentra en true traigo los datos, caso contrario
                // ejecuto la instruccion SQL que impactara sobre la base de datos
                if (consulta) 
                {
                    dt.Load(command.ExecuteReader());
                }
                else
                {
                    command.ExecuteNonQuery();
                }
                command.Parameters.Clear(); // Limpio la lista de parametros
            }
            // Retorno el objeto DataTable (en caso de encontrarse vacio por haber ejecutado
            // el "ExecuteNonQuery" al no haber puesto la variable "consulta" en true, es porque no lo utilizare, pero
            // al tratarse de un metodo que debe devolver un tipo DataTable debo colocarlo de todas maneras)
            return dt; 
        }
    }
}

*/
/*
 * 

    /// <summary>
    /// ///////////////////////////////
    /// </summary>
    private SqlConnection ConexionBd = new SqlConnection("Server =(local); DataBase = login; integrated security = true");
    public SqlConnection AbrirConexion()
    {
        if (ConexionBd.State == ConnectionState.Closed)
            ConexionBd.Open();
        return ConexionBd;
    }
    public SqlConnection CerrarConexion()
    {
        if (ConexionBd.State == ConnectionState.Open)
            ConexionBd.Close();
        return ConexionBd;
    }
}

}

*/


/* public DataTable Ejecutar()
     {
         DataTable dt = new DataTable(); 
         using(SqlConnection conn = new SqlConnection(cadenaConexion))
         {
             conn.Open();

             SqlCommand cmd = new SqlCommand();

             return dt;
         }
     }
 }
}
*/

