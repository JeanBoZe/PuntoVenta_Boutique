using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_VentaRG
{
    public partial class Busqueda_Producto : Form
    {
        public Busqueda_Producto()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<Entidad.ProductoVariante> listaProductos = new List<Entidad.ProductoVariante>();

        private void Busqueda_Producto_Load(object sender, EventArgs e)
        {
            Clases.Producto csProd = new Clases.Producto();
            listaProductos = csProd.ObtenerProductos(); // GUARDAMOS

            dg_productos.DataSource = listaProductos;

            // Ocultar columnas que no quieres mostrar
            dg_productos.Columns["IdVariante"].Visible = false;
            dg_productos.Columns["IdProducto"].Visible = false;
            dg_productos.Columns["PrecioCompra"].Visible = false;
            dg_productos.Columns["Estado"].Visible = false;

            // Cambiar encabezados visibles
            dg_productos.Columns["NombreProducto"].HeaderText = "Producto";
            dg_productos.Columns["PrecioVenta"].HeaderText = "Precio";

            dg_productos.Columns["SKU"].Width = 150;
            dg_productos.Columns["NombreProducto"].Width = 200;
            dg_productos.Columns["Color"].Width = 80;
            dg_productos.Columns["Talla"].Width = 70;
            dg_productos.Columns["PrecioVenta"].Width = 80;
            dg_productos.Columns["Stock"].Width = 60;
            dg_productos.Columns["Categoria"].Width = 110;
            dg_productos.Columns["Marca"].Width = 90;

            //centrar
            dg_productos.Columns["Talla"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_productos.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_productos.Columns["Marca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_productos.Columns["PrecioVenta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Forzar colores legibles
            dg_productos.DefaultCellStyle.BackColor = Color.White;
            dg_productos.DefaultCellStyle.ForeColor = Color.Black;

            // Color alterno de filas (opcional, para distinguirlas)
            dg_productos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            // Color del encabezado
            dg_productos.EnableHeadersVisualStyles = false;

            dg_productos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dg_productos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg_productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dg_productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int varID = Convert.ToInt32(dg_productos.Rows[e.RowIndex].Cells["IdVariante"].Value);
                string nombre = dg_productos.Rows[e.RowIndex].Cells["NombreProducto"].Value.ToString();
                decimal precio = Convert.ToDecimal(dg_productos.Rows[e.RowIndex].Cells["PrecioVenta"].Value);

                // Por defecto se agrega 1 unidad (puedes modificar luego)
                Entidad.csCarrito item = new Entidad.csCarrito()
                {
                    var_id = varID,
                    prod_nombre = nombre,
                    cantidad = 1,
                    precio = precio
                };

                // Recuperamos el FormVenta
                Venta venta = this.Owner as Venta;

                if (venta != null)
                {
                    venta.AgregarProductoCarrito(item);
                }
                else
                {
                    MessageBox.Show("Error: el formulario padre no se estableció correctamente.");
                }

                this.Close();
            }
        }

        private void txt_buscador_TextChanged(object sender, EventArgs e)
        {
            string b = txt_buscador.Text.Trim().ToUpper();

            var filtrados = listaProductos.Where(x =>
                (x.SKU?.ToUpper().Contains(b) ?? false) ||
                (x.NombreProducto?.ToUpper().Contains(b) ?? false) ||
                (x.Categoria?.ToUpper().Contains(b) ?? false) ||
                (x.Marca?.ToUpper().Contains(b) ?? false) ||
                (x.Color?.ToUpper().Contains(b) ?? false) ||
                (x.Talla?.ToUpper().Contains(b) ?? false)
            ).ToList();

            dg_productos.DataSource = filtrados;
        }
    }
}
