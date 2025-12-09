using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration; // <-- IMPORTANTE AGREGAR ESTO

namespace Punto_VentaRG.Clases
{
    class Conexion
    {
        // Ahora leemos la cadena desde el archivo App.config
        private readonly string cadenaConexion =
            ConfigurationManager.ConnectionStrings["CadenaBoutique"].ConnectionString;

        public SqlConnection Conectar()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
