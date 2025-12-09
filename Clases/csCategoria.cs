using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Punto_VentaRG.Clases
{
    public class csCategoria
    {
        Conexion conexion = new Conexion();

        public List<Entidad.csCategoria> ObtenerCategorias()
        {
            List<Entidad.csCategoria> lista = new List<Entidad.csCategoria>();

            string query = "SELECT * FROM CATEGORIA";

            using(SqlConnection con = conexion.Conectar())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query,con))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Entidad.csCategoria p = new Entidad.csCategoria()
                        {
                            cat_id = Convert.ToInt32(dr["CAT_ID"]),
                            cat_descripcion = dr["CAT_DESCRIPCION"].ToString(),
                            cat_estado = Convert.ToBoolean(dr["CAT_ESTADO"])
                    };
                        lista.Add(p);
                    }
                }
            }
            return lista;
        }

        public bool GuardarCategoria(int id, string descripcion, bool estado, out string mensaje)
        {
            bool exito = false;

            try
            {
                using (SqlConnection con = conexion.Conectar())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_GUARDAR_CATEGORIA", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CAT_ID", id);
                        cmd.Parameters.AddWithValue("@CAT_DESCRIPCION", descripcion);
                        cmd.Parameters.AddWithValue("@CAT_ESTADO", estado);

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
            catch(Exception ex)
            {
                mensaje = "Error C#: " + ex.Message;
                exito = false;
            }

            return exito;
        }
    }
}
