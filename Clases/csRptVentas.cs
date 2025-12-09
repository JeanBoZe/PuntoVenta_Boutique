using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Punto_VentaRG.Clases
{
    public class csRptVentas
    {
        Conexion conexion = new Conexion();

        public List<Entidad.Rep_Venta> ObtenerRpt_Ventas(int condicional)
        {
            List<Entidad.Rep_Venta> lista = new List<Entidad.Rep_Venta>();
            string condicion = "";
            switch (condicional)
            {
                case 1: //Hoy
                    condicion = "WHERE [Fecha y Hora] >= CAST(GETDATE() AS DATE) AND[Fecha y Hora] < CAST(DATEADD(day, 1, GETDATE()) AS DATE)";
                    break;
                case 2: // Semana
                    condicion = "WHERE [Fecha y Hora] >= DATEADD(week, DATEDIFF(week, 0, GETDATE()), 0) AND[Fecha y Hora] < DATEADD(week, DATEDIFF(week, 0, GETDATE()) + 1, 0)";
                    break;
                case 3: // Mes
                    condicion = "WHERE [Fecha y Hora] >= DATEADD(month, DATEDIFF(month, 0, GETDATE()), 0) AND[Fecha y Hora] < DATEADD(month, DATEDIFF(month, 0, GETDATE()) + 1, 0)";
                    break;
                case 4: // Anio
                    condicion = "WHERE [Fecha y Hora] >= DATEADD(year, DATEDIFF(year, 0, GETDATE()), 0) AND[Fecha y Hora] < DATEADD(year, DATEDIFF(year, 0, GETDATE()) + 1, 0)";
                    break;
                default:
                    condicion = "";
                    break;
            }
                

            using (SqlConnection con = conexion.Conectar())
            {
                con.Open();
                string query = "SELECT * FROM VW_REPORTE_VENTAS " + condicion;

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Entidad.Rep_Venta p = new Entidad.Rep_Venta{
                            folio = Convert.ToInt32(dr["Folio"]),
                            fechaHora = dr["Fecha y Hora"].ToString(),
                            vendedor = dr["Vendedor"].ToString(),
                            ProdVendidos = dr["Productos Vendidos"].ToString(),
                            metodoPag = dr["Metodo de Pago"].ToString(),
                            subtotal = Convert.ToDecimal(dr["Monto Total"])
                        };
                        lista.Add(p);
                    }
                }
            }

            return lista;
        }

        public List<Entidad.Rep_Venta> ObtenerRpt_Manual(string inicio, string fin)
        {
            List<Entidad.Rep_Venta> lista = new List<Entidad.Rep_Venta>();

            using (SqlConnection con = conexion.Conectar())
            {
                con.Open();
                string query = "SELECT * FROM VW_REPORTE_VENTAS WHERE [Fecha y Hora] >= @FechaInicio AND [Fecha y Hora] < @FechaFin";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FechaInicio", inicio);
                    cmd.Parameters.AddWithValue("@FechaFin", fin);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Entidad.Rep_Venta p = new Entidad.Rep_Venta
                            {
                                folio = Convert.ToInt32(dr["Folio"]),
                                fechaHora = dr["Fecha y Hora"].ToString(),
                                vendedor = dr["Vendedor"].ToString(),
                                ProdVendidos = dr["Productos Vendidos"].ToString(),
                                metodoPag = dr["Metodo de Pago"].ToString(),
                                subtotal = Convert.ToDecimal(dr["Monto Total"])
                            };
                            lista.Add(p);
                        }
                    }
                }                
            }

            return lista;
        }
    }
}
