using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_VentaRG.Entidad
{
    public class VentaCS
    {
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Impuesto { get; set; }
        public int UsuarioId { get; set; }
        public string MetodoPago { get; set; }
    }
}
