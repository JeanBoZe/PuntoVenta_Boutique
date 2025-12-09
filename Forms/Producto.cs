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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Forms.Producto_Registrar producto_Registrar = new Forms.Producto_Registrar();
            producto_Registrar.ShowDialog();
            listaProductos = csProd.ObtenerProductos(); // GUARDAMOS
            dg_productos.DataSource = listaProductos;
            txt_buscador_TextChanged(null, null);
        }

        List<Entidad.ProductoVariante> listaProductos = new List<Entidad.ProductoVariante>();
        Clases.Producto csProd = new Clases.Producto();

        private void Producto_Load(object sender, EventArgs e)
        {
            listaProductos = csProd.ObtenerProductos(); // GUARDAMOS

            dg_productos.DataSource = listaProductos;

            // Ocultar columnas que no quieres mostrar
            dg_productos.Columns["IdVariante"].Visible = false;
            dg_productos.Columns["IdProducto"].Visible = false;
            dg_productos.Columns["PrecioCompra"].Visible = false;

            // Cambiar encabezados visibles
            dg_productos.Columns["NombreProducto"].HeaderText = "Producto";
            dg_productos.Columns["PrecioVenta"].HeaderText = "Precio";

            dg_productos.Columns["SKU"].Width = 120;
            dg_productos.Columns["NombreProducto"].Width = 200;
            dg_productos.Columns["Color"].Width = 80;
            dg_productos.Columns["Talla"].Width = 50;
            dg_productos.Columns["PrecioVenta"].Width = 80;
            dg_productos.Columns["Stock"].Width = 60;
            dg_productos.Columns["Categoria"].Width = 110;
            dg_productos.Columns["Marca"].Width = 90;


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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dg_productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string skuSeleccionado = dg_productos.Rows[e.RowIndex].Cells["SKU"].Value.ToString();

                Forms.Producto_Registrar formEditar = new Forms.Producto_Registrar();
                formEditar.PonerSKU(skuSeleccionado);
                DialogResult resultado = formEditar.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    listaProductos = csProd.ObtenerProductos();
                    txt_buscador_TextChanged(null, null);
                }
            }
        }
    }
}
