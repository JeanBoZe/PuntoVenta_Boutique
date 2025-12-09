using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Punto_VentaRG.Clases
{
    class Producto
    {
        Conexion conexion = new Conexion();
        public List<Entidad.ProductoVariante> ObtenerProductos()
        {
            List<Entidad.ProductoVariante> lista = new List<Entidad.ProductoVariante>();

            using (SqlConnection con = conexion.Conectar())
            {
                con.Open();
                string query = "SELECT * FROM VW_PRODUCTO_VARIANTE_DETALLE";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Entidad.ProductoVariante p = new Entidad.ProductoVariante
                        {
                            IdVariante = Convert.ToInt32(dr["VAR_ID"]),
                            SKU = dr["SKU"].ToString(),
                            IdProducto = Convert.ToInt32(dr["PROD_ID"]),
                            NombreProducto = dr["NOMBRE_PRODUCTO"].ToString(),
                            Categoria = dr["CATEGORIA"].ToString(),
                            Marca = dr["MARCA"].ToString(),
                            Color = dr["COLOR"].ToString(),
                            Talla = dr["TALLA"].ToString(),
                            PrecioCompra = Convert.ToDecimal(dr["PRECIO_COMPRA"]),
                            PrecioVenta = Convert.ToDecimal(dr["PRECIO_VENTA"]),
                            Stock = Convert.ToInt32(dr["STOCK"]),
                            Estado = Convert.ToBoolean(dr["VAR_ESTADO"])
                        };
                        lista.Add(p);
                    }
                }
            }

            return lista;
        }

        public List<Entidad.ProductoVariante> BuscarCodigo(string sku)
        {
            List<Entidad.ProductoVariante> lista = new List<Entidad.ProductoVariante>();

            using (SqlConnection con = conexion.Conectar())
            {
                con.Open();
                string query = "SELECT * FROM VW_PRODUCTO_VARIANTE_DETALLE WHERE SKU = @sku";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@sku", sku);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Entidad.ProductoVariante p = new Entidad.ProductoVariante
                            {
                                IdVariante = Convert.ToInt32(dr["VAR_ID"]),
                                SKU = dr["SKU"].ToString(),
                                IdProducto = Convert.ToInt32(dr["PROD_ID"]),
                                NombreProducto = dr["NOMBRE_PRODUCTO"].ToString(),
                                Categoria = dr["CATEGORIA"].ToString(),
                                Marca = dr["MARCA"].ToString(),
                                Color = dr["COLOR"].ToString(),
                                Talla = dr["TALLA"].ToString(),
                                PrecioCompra = Convert.ToDecimal(dr["PRECIO_COMPRA"]),
                                PrecioVenta = Convert.ToDecimal(dr["PRECIO_VENTA"]),
                                Stock = Convert.ToInt32(dr["STOCK"]),
                                Estado = Convert.ToBoolean(dr["VAR_ESTADO"])
                            };
                            lista.Add(p);
                        }
                    }
                }
                
            }

            return lista;
        }

        public DataTable CargarCategorias()
        {
            using (SqlConnection con = conexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT CAT_ID, CAT_DESCRIPCION FROM CATEGORIA WHERE CAT_ESTADO = 1",con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable CargarMarcas()
        {
            using (SqlConnection con = conexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT MAR_ID, MAR_DESCRIPCION FROM MARCA WHERE MAR_ESTADO = 1", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int GuardarProductoYVariante(
            int prodId,
            string nombre,
            int idCategoria,
            int idMarca,
            int varId,
            string sku,
            string color,
            string talla,
            decimal precioCompra,
            decimal precioVenta,
            int stock)
        {
            int resultado = -1;

            using (SqlConnection con = conexion.Conectar())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SP_GUARDAR_PRODUCTO_Y_VARIANTE", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@PROD_ID", prodId);
                    cmd.Parameters.AddWithValue("@PROD_NOMBRE", nombre);
                    cmd.Parameters.AddWithValue("@PROD_CAT_ID", idCategoria);
                    cmd.Parameters.AddWithValue("@PROD_MAR_ID", idMarca);

                    cmd.Parameters.AddWithValue("@VAR_ID", varId);
                    cmd.Parameters.AddWithValue("@VAR_CODIGO", sku);
                    cmd.Parameters.AddWithValue("@COLOR", color);
                    cmd.Parameters.AddWithValue("@TALLA", talla);
                    cmd.Parameters.AddWithValue("@PRECIO_COMPRA", precioCompra);
                    cmd.Parameters.AddWithValue("@PRECIO_VENTA", precioVenta);
                    cmd.Parameters.AddWithValue("@STOCK", stock);

                    SqlParameter pResultado = new SqlParameter("@RESULTADO", SqlDbType.Int);
                    pResultado.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(pResultado);

                    cmd.ExecuteNonQuery();
                    resultado = Convert.ToInt32(pResultado.Value);
                }
            }

            return resultado;
        }

        public DataTable BuscarVariantesPorSKU(string sku)
        {
            using (SqlConnection con = conexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM PRODUCTO_VARIANTE WHERE VAR_CODIGO = @sku", con);
                cmd.Parameters.AddWithValue("@sku", sku);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


    }
}
