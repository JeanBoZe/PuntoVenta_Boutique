using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_VentaRG.Entidad
{
    class ProductoVariante
    {
        public int IdVariante { get; set; }
        public string SKU { get; set; }
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public string Talla { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public bool Estado { get; set; }
    }
}
