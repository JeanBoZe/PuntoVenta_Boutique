using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Punto_VentaRG.Clases
{
    public class csVenta
    {
        Clases.Conexion conex = new Conexion();
        public int RegistrarVenta(int usuId, decimal subtotal, decimal descuento, decimal impuesto,string metodoPago, List<Entidad.DetalleVenta> detalleVenta)
        {
            int ventaId = 0;

            // Crear un tipo de datos tabla para los detalles de la venta
            DataTable dtDetalle = new DataTable();
            dtDetalle.Columns.Add("VAR_ID", typeof(int));
            dtDetalle.Columns.Add("CANTIDAD", typeof(int));
            dtDetalle.Columns.Add("PRECIOUNITARIO", typeof(decimal));

            // Llenar el DataTable con los detalles de la venta
            foreach (var item in detalleVenta)
            {
                dtDetalle.Rows.Add(item.VarId, item.Cantidad, item.PrecioUnitario);
            }

            using (SqlConnection con = conex.Conectar())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SP_REGISTRAR_VENTA", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@USU_ID", usuId);
                    cmd.Parameters.AddWithValue("@SUBTOTAL", subtotal);
                    cmd.Parameters.AddWithValue("@DESCUENTO", descuento);
                    cmd.Parameters.AddWithValue("@IMPUESTO", impuesto);
                    cmd.Parameters.AddWithValue("@METODOPAGO", metodoPago);

                    // Pasar el DataTable como parámetro de tipo tabla
                    SqlParameter tvpDetalleVenta = cmd.Parameters.AddWithValue("@DETALLE_VENTAS", dtDetalle);
                    tvpDetalleVenta.SqlDbType = SqlDbType.Structured;
                    tvpDetalleVenta.TypeName = "DetalleVentaTipo";  // Nombre del tipo de datos tabla en SQL

                    // Parámetro de salida para obtener el ID de la venta insertada
                    SqlParameter paramVentaId = new SqlParameter("@VENTA_ID", SqlDbType.Int);
                    paramVentaId.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramVentaId);

                    cmd.ExecuteNonQuery();

                    // Obtener el ID de la venta recién registrada
                    ventaId = Convert.ToInt32(paramVentaId.Value);
                }
            }

            return ventaId;
        }

        public List<Entidad.DetalleVenta> ObtenerDetalleDesdeCarrito(DataGridView dg)
        {
            List<Entidad.DetalleVenta> lista = new List<Entidad.DetalleVenta>();

            foreach (DataGridViewRow row in dg.Rows)
            {
                // Evita filas vacías (última fila en modo edición)
                if (row.IsNewRow) continue;

                lista.Add(new Entidad.DetalleVenta
                {
                    VarId = Convert.ToInt32(row.Cells["var_id"].Value),
                    Cantidad = Convert.ToInt32(row.Cells["cantidad"].Value),
                    PrecioUnitario = Convert.ToDecimal(row.Cells["precio"].Value)
                });
            }

            return lista;
        }

        public Entidad.csCarrito BuscarVariantePorCodigo(string codigo)
        {
            Entidad.csCarrito item = null;

            using (SqlConnection con = conex.Conectar())
            {
                string query = @"
                    SELECT 
                        pv.VAR_ID,
                        p.PROD_NOMBRE,
                        pv.PRECIO_VENTA
                    FROM PRODUCTO_VARIANTE pv
                    INNER JOIN PRODUCTO p ON pv.PROD_ID = p.PROD_ID
                    WHERE pv.VAR_CODIGO = @codigo AND pv.VAR_ESTADO = 1 AND p.PROD_ESTADO = 1";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    item = new Entidad.csCarrito()
                    {
                        var_id = Convert.ToInt32(dr["VAR_ID"]),
                        prod_nombre = dr["PROD_NOMBRE"].ToString(),
                        cantidad = 1, // Por defecto una unidad
                        precio = Convert.ToDecimal(dr["PRECIO_VENTA"])
                    };
                }
            }

            return item;
        }

        public int ObtenerStock(int varId)
        {
            using (SqlConnection con = conex.Conectar())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT STOCK FROM PRODUCTO_VARIANTE WHERE VAR_ID = @id", con);
                cmd.Parameters.AddWithValue("@id", varId);

                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

    }
}
