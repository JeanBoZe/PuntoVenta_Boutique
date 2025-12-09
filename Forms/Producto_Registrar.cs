using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Punto_VentaRG.Forms
{
    public partial class Producto_Registrar : Form
    {
        Clases.Producto csProd = new Clases.Producto();
        Clases.Conexion conex = new Clases.Conexion();

        public Producto_Registrar()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Producto_Registrar_Load(object sender, EventArgs e)
        {
            txt_codigo.Focus();
            //cargar categorias
            cb_categoria.DataSource = csProd.CargarCategorias();
            cb_categoria.DisplayMember = "CAT_DESCRIPCION";
            cb_categoria.ValueMember = "CAT_ID";
            //cargar marcas
            cb_marca.DataSource = csProd.CargarMarcas();
            cb_marca.DisplayMember = "MAR_DESCRIPCION";
            cb_marca.ValueMember = "MAR_ID";

            // Evento para detectar cambio en el SKU
            //txt_codigo.KeyDown += txt_codigo_KeyDown;
        }


        int varId = 0;
        int prodId = 0;
        string skuOriginal = "";

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                return;
            }
            int resultado = csProd.GuardarProductoYVariante(
                prodId,
                txt_nombre.Text,
                Convert.ToInt32(cb_categoria.SelectedValue),
                Convert.ToInt32(cb_marca.SelectedValue),
                varId,
                txt_codigo.Text,
                txt_color.Text,
                cb_talla.Text,
                0,
                Convert.ToDecimal(txt_precioVenta.Text),
                Convert.ToInt32(txt_stock.Text)
                );

            switch (resultado)
            {
                case 0:
                    MessageBox.Show("Guardado correctamente","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LimpiarCampos();
                    break;
                case 1:
                    MessageBox.Show("Ya existe un producto con ese nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_nombre.Clear();
                    txt_nombre.Focus();
                    break;
                case 2:
                    MessageBox.Show("El SKU ya existe, elige otro", "Verifica el codigo de barras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_codigo.Clear();
                    txt_codigo.Focus();
                    break;
                case 3:
                    MessageBox.Show("Error interno, llame a el autor del programa","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;
            }
        }

        void LimpiarCampos()
        {
            prodId = 0;
            varId = 0;
            skuOriginal = "";
            txt_codigo.Clear();
            txt_nombre.Clear();
            txt_color.Clear();
            cb_talla.SelectedIndex = -1;
            txt_precioCompra.Clear();
            txt_precioVenta.Clear();
            txt_stock.Clear();
            cb_categoria.SelectedIndex = 0;
            cb_marca.SelectedIndex = 0;
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // evita salto de línea

                CargarDatosProducto(txt_codigo.Text.Trim());
                txt_codigo.Focus();
            }
        }


        private void CargarDatosProducto(string codigo)
        {
            using (SqlConnection con = conex.Conectar())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(@"
                    SELECT VAR_ID, PROD_ID, SKU, NOMBRE_PRODUCTO,
                           CATEGORIA, MARCA, COLOR, TALLA, 
                           PRECIO_VENTA, PRECIO_COMPRA, STOCK
                    FROM VW_PRODUCTO_VARIANTE_DETALLE
                    WHERE SKU = @codigo", con);


                cmd.Parameters.AddWithValue("@codigo", codigo);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    varId = Convert.ToInt32(dr["VAR_ID"]);
                    prodId = Convert.ToInt32(dr["PROD_ID"]);
                    skuOriginal = dr["SKU"].ToString();

                    txt_codigo.Text = skuOriginal;
                    txt_nombre.Text = dr["NOMBRE_PRODUCTO"].ToString();
                    cb_categoria.Text = dr["CATEGORIA"].ToString();
                    cb_marca.Text = dr["MARCA"].ToString();
                    txt_color.Text = dr["COLOR"].ToString();

                    CargarTallasPorCategoria(cb_categoria.Text);
                    cb_talla.Text = dr["TALLA"].ToString();

                    txt_precioVenta.Text = dr["PRECIO_VENTA"].ToString();
                    txt_precioCompra.Text = dr["PRECIO_COMPRA"].ToString();
                    txt_stock.Text = dr["STOCK"].ToString();
                }


                dr.Close();
            }
        }

        private void CargarTallasPorCategoria(string categoria)
        {
            cb_talla.Items.Clear();

            // Normalizamos para evitar errores de escritura
            string cat = categoria.Trim().ToUpper();

            switch (cat)
            {
                // ---------------------------------------------------------
                // 1. CALZADO MASCULINO
                // ---------------------------------------------------------
                case "TENIS":
                case "ZAPATOS":
                case "BOTAS":
                case "MOCASINES":
                case "SANDALIAS":
                case "CHANCLAS":
                case "ALPARGATAS":
                    // El calzado de hombre suele ir del 25 al 30 o 31 (MX)
                    // Incluimos medios números (.5)
                    for (double i = 24; i <= 31; i += 0.5)
                    {
                        cb_talla.Items.Add(i.ToString());
                    }
                    break;

                // ---------------------------------------------------------
                // 2. ROPA SUPERIOR (XS - 3XL)
                // ---------------------------------------------------------
                case "PLAYERA":
                case "CAMISA":
                case "POLO":
                case "SUDADERA":
                case "CHAQUETA":
                case "CHAMARRA":
                case "SUETER":
                case "CHALECO":
                case "CONJUNTO":
                case "DEPORTIVO":
                case "JERSEY":
                case "SACO":   // Si manejas sacos casuales por letra
                case "BLAZER":
                case "ABRIGO":
                    cb_talla.Items.AddRange(new string[] { "XS", "S", "M", "L", "XL", "XXL", "3XL" });
                    break;

                // ---------------------------------------------------------
                // 4. ROPA INFERIOR (Tallas por cintura en Pulgadas)
                // ---------------------------------------------------------
                case "PANTALON":
                case "JEANS":
                case "BERMUDA":
                case "SHORT":
                case "JOGGER":
                case "PANTS":
                case "CARGO":
                case "TRAJE DE BAÑO": // Shorts de baño
                                      // Tallas de la 28 a la 44 (o 46/48 si manejas tallas extra)
                    for (int i = 28; i <= 44; i++)
                    {
                        cb_talla.Items.Add(i.ToString());
                    }
                    break;

                // ---------------------------------------------------------
                // 5. CINTURONES (Misma lógica que pantalones)
                // ---------------------------------------------------------
                case "CINTURON":
                    cb_talla.Items.AddRange(new string[] { "28", "30", "32", "34", "36", "38", "40", "42", "44", "UNITALLA" });
                    break;

                // ---------------------------------------------------------
                // 6. ROPA INTERIOR (Boxers)
                // ---------------------------------------------------------
                case "BOXER":
                case "TRUSA":
                case "CALCETINES":
                case "ROPA INTERIOR":
                    cb_talla.Items.AddRange(new string[] { "CH", "M", "G", "XG" });
                    break;

                // ---------------------------------------------------------
                // 7. ACCESORIOS
                // ---------------------------------------------------------
                case "GORRA":
                case "SOMBRERO": // Podrías poner tallas 7, 7 1/8, etc, pero S/M/L es más fácil
                case "BUFANDA":
                case "GUANTES":
                case "LENTES":
                case "RELOJ":
                case "CADENA":
                case "PULSERA":
                case "MOCHILA":
                case "CARTERA":
                case "CORBATA":
                case "ACCESORIO":
                    cb_talla.Items.AddRange(new string[] { "ÚNICA", "CH", "M", "G" });
                    break;

                // ---------------------------------------------------------
                // DEFAULT
                // ---------------------------------------------------------
                default:
                    cb_talla.Items.Add("ÚNICA");
                    cb_talla.Items.AddRange(new string[] { "S", "M", "L", "XL" });
                    break;
            }
        }

        private void cb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTallasPorCategoria(cb_categoria.Text);
        }

        private void txt_codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                string codigo = txt_codigo.Text.Trim();

                if (codigo == "")
                    return;

                // Buscar si existe el producto
                DataTable dt = csProd.BuscarVariantesPorSKU(codigo);

                if (dt.Rows.Count == 0)
                {
                    // SKU NO EXISTE → Crear variante nueva de un producto nuevo o ya existente
                    varId = 0;
                    prodId = 0;
                    skuOriginal = "";
                    return;
                }

                DialogResult resp = MessageBox.Show(
                    "El SKU ya existe.\n\n¿Deseas EDITAR este producto?\n\n" +
                    "Sí = Editar\nNo = Crear uno nuevo",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resp == DialogResult.Yes)
                {
                    CargarDatosProducto(codigo);
                    skuOriginal = codigo;
                }
                else
                {
                    varId = 0;
                    prodId = 0;
                    skuOriginal = "";
                    txt_nombre.Focus();
                }
            }
        }

        private void btn_editarCatMar_Click(object sender, EventArgs e)
        {
            Forms.CatMar catmar = new CatMar();
            catmar.ShowDialog();

            //cargar categorias
            cb_categoria.DataSource = csProd.CargarCategorias();
            cb_categoria.DisplayMember = "CAT_DESCRIPCION";
            cb_categoria.ValueMember = "CAT_ID";
            //cargar marcas
            cb_marca.DataSource = csProd.CargarMarcas();
            cb_marca.DisplayMember = "MAR_DESCRIPCION";
            cb_marca.ValueMember = "MAR_ID";
        }

        private void txt_precioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números, tecla de borrar, y un solo punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Ignora la tecla
            }

            // Solo permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true; // Ignora el segundo punto
            }
        }

        private void txt_precioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números, tecla de borrar, y un solo punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Ignora la tecla
            }

            // Solo permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true; // Ignora el segundo punto
            }
        }

        private void txt_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números y tecla de borrar
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora la tecla
            }
        }

        public void PonerSKU(string sku)
        {
            txt_codigo.Text = sku;
            txt_codigo.Focus();
        }

        private bool ValidarFormulario()
        {
            // Limpia errores anteriores
            errorValidaciones.Clear();
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txt_codigo.Text))
            {
                errorValidaciones.SetError(txt_codigo, "El SKU es obligatorio");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txt_nombre.Text))
            {
                errorValidaciones.SetError(txt_nombre, "El Nombre es obligatorio");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txt_color.Text))
            {
                errorValidaciones.SetError(txt_color, "El Nombre es obligatorio");
                esValido = false;
            }

            if (!decimal.TryParse(txt_precioVenta.Text, out decimal precioVenta))
            {
                errorValidaciones.SetError(txt_precioVenta, "El precio no es un número válido");
                esValido = false;
            }

            return esValido;
        }
    }
}
