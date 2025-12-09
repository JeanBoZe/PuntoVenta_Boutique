using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Punto_VentaRG.Entidad
{
    public class csCategoria
    {
        public int cat_id { get; set; }
        public string cat_descripcion { get; set; }
        public bool cat_estado { get; set; }
    }
}
