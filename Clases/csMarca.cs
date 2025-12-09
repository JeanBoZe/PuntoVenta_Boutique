using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Punto_VentaRG.Clases
{
    public class csMarca
    {
        Conexion conexion = new Conexion();

        public List<Entidad.csMarca> ObtenerMarcas()
        {
            List<Entidad.csMarca> lista = new List<Entidad.csMarca>();
            using (SqlConnection con = conexion.Conectar())
            {
                con.Open();
                string query = "SELECT * FROM MARCA";

                using (SqlCommand cmd = new SqlCommand(query,con))
                using(SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Entidad.csMarca p = new Entidad.csMarca()
                        {
                            mar_id = Convert.ToInt32(dr["MAR_ID"]),
                            mar_descripcion = dr["MAR_DESCRIPCION"].ToString(),
                            mar_estado = Convert.ToBoolean(dr["MAR_ESTADO"])
                        };
                        lista.Add(p);
                    }
                }
            }
            return lista;
        }

        public bool GuardarMarca(int id, string descripcion, bool estado, out string mensaje)
        {
            bool exito = false;

            try
            {
                using (SqlConnection con = conexion.Conectar())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_GUARDAR_MARCA", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MAR_ID", id);
                        cmd.Parameters.AddWithValue("@MAR_DESCRIPCION", descripcion);
                        cmd.Parameters.AddWithValue("@MAR_ESTADO", estado);

                        SqlParameter pResultado = new SqlParameter("@RESULTADO", SqlDbType.VarChar, 100);
                        pResultado.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(pResultado);

                        cmd.ExecuteNonQuery();
                        mensaje = pResultado.Value.ToString();

                        if (mensaje.Contains("Correctamente"))
                        {
                            exito = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error C#: " + ex.Message;
                exito = false;
            }

            return exito;
        }
    }
}
