using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_VentaRG.Entidad
{
    public class Rep_Venta
    {
        public int folio { get; set; }
        public string fechaHora { get; set; }
        public string vendedor{ get; set; }
        public string ProdVendidos { get; set; }
        public string metodoPag { get; set; }
        public decimal subtotal { get; set; }

    }
}
