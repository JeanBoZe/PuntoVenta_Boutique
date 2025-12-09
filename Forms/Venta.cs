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
    public partial class Venta : Form
    {
        private int userId;

        List<Entidad.csCarrito> carrito = new List<Entidad.csCarrito>();

        public Venta(int _userId)
        {
            InitializeComponent();

            userId = _userId;

            txt_codigo.Focus();
        }


        private void btn_buscarProducto_Click(object sender, EventArgs e)
        {
            Busqueda_Producto busqueda = new Busqueda_Producto();
            busqueda.Owner = this;
            busqueda.ShowDialog();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Clases.csVenta csVenta = new Clases.csVenta();
        decimal pagoCon = 0;

        private void btn_guardarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (carrito.Count == 0)
                {
                    MessageBox.Show("El carrito está vacío.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    return;
                }

                if (cb_metPago.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un método de pago.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_pagoCon.Text))
                {
                    ep_validaciones.SetError(txt_pagoCon, "Debe ingresar con cuánto paga el cliente.");

                    txt_pagoCon.Focus();

                    return;
                }
                else
                {
                    ep_validaciones.SetError(txt_pagoCon, "");
                }

                List<Entidad.DetalleVenta> detalles = csVenta.ObtenerDetalleDesdeCarrito(dg_carrito);

                decimal subtotal = detalles.Sum(x => x.Cantidad * x.PrecioUnitario);
                decimal descuento = 0m;
                decimal impuesto = subtotal * 0;
                string metodoPago = cb_metPago.SelectedItem.ToString();

                int ventaId = csVenta.RegistrarVenta(userId, subtotal, descuento, impuesto, metodoPago, detalles);
                pagoCon = decimal.Parse(txt_pagoCon.Text);
                MessageBox.Show($"FOLIO: {ventaId}\nGRACIAS POR SU COMPRA ❤️\nCambio: {pagoCon - subtotal}", "VENTA REALIZADA",MessageBoxButtons.OK,MessageBoxIcon.Information);

                carrito.Clear();
                CargarCarritoEnGrid();
                txt_codigo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Llamar a el autor!\nError: " + ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void AgregarProductoCarrito(Entidad.csCarrito item)
        {
            // Buscar si ya está en el carrito
            var existente = carrito.FirstOrDefault(x => x.var_id == item.var_id);

            // Obtener stock actual desde la base de datos
            int stockActual = ventacs.ObtenerStock(item.var_id);

            // Determinar cantidad que tendría si se agrega
            int cantidadFinal = (existente != null ? existente.cantidad : 0) + item.cantidad;

            // Validar stock
            if (cantidadFinal > stockActual)
            {
                MessageBox.Show($"No hay suficiente stock.\nStock disponible: {stockActual}",
                                "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si existe en el carrito, solo sumar
            if (existente != null)
            {
                existente.cantidad += item.cantidad;
            }
            else
            {
                carrito.Add(item);
            }

            CargarCarritoEnGrid();
        }

        private void CargarCarritoEnGrid()
        {
            dg_carrito.DataSource = null;
            dg_carrito.DataSource = carrito;

            txt_subtotal.Text = carrito.Sum(x => x.cantidad * x.precio).ToString("C2");
            btn_guardarVenta.Enabled = carrito.Count > 0;

            // Ocultar columnas que no quieres mostrar
            if (dg_carrito.Columns["var_id"] != null)
                dg_carrito.Columns["var_id"].Visible = false;

            // Cambiar encabezados de columnas
            if (dg_carrito.Columns["prod_nombre"] != null)
                dg_carrito.Columns["prod_nombre"].HeaderText = "Producto";

            if (dg_carrito.Columns["cantidad"] != null)
                dg_carrito.Columns["cantidad"].HeaderText = "Cantidad";

            if (dg_carrito.Columns["precio"] != null)
                dg_carrito.Columns["precio"].HeaderText = "Precio";

            // Ajustar ancho a tu gusto
            dg_carrito.Columns["prod_nombre"].Width = 300;
            dg_carrito.Columns["cantidad"].Width = 120;
            dg_carrito.Columns["precio"].Width = 150;

            lbl_cantidad.Text = $"{carrito.Sum(x => x.cantidad)}";

        }

        Clases.csVenta ventacs = new Clases.csVenta();

        private void txt_codigo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string codigo = txt_codigo.Text.Trim();

                    Entidad.csCarrito item = ventacs.BuscarVariantePorCodigo(codigo);

                    if (item != null)
                    {
                        AgregarProductoCarrito(item);
                    }
                    else
                    {
                        MessageBox.Show("El producto no existe o está inactivo.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    txt_codigo.Clear();
                    txt_codigo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Llamar a el autor!\nError: " + ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Venta_Load_1(object sender, EventArgs e)
        {
            try
            {
                cb_metPago.Items.AddRange(new string[] { "EFECTIVO", "TARJETA", "TRANSFERENCIA" });
                cb_metPago.SelectedIndex = 0; // Por defecto EFECTIVO

                txt_codigo.Focus();
                this.ActiveControl = txt_codigo;

                txt_subtotal.ForeColor = Color.LimeGreen;

                //// Forzar colores legibles
                //dg_carrito.DefaultCellStyle.BackColor = Color.White;
                dg_carrito.DefaultCellStyle.ForeColor = Color.Black;

                //// Color alterno de filas (opcional, para distinguirlas)
                //dg_carrito.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

                // Color del encabezado
                dg_carrito.EnableHeadersVisualStyles = false;

                dg_carrito.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dg_carrito.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dg_carrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dg_carrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dg_carrito.MultiSelect = false;

                txt_subtotal.Text = carrito.Sum(x => x.cantidad * x.precio).ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Llamar a el autor!\nError: " + ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y tecla Enter
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Enter && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Venta_Activated(object sender, EventArgs e)
        {
            txt_codigo.Focus();
        }

        private void btn_quitarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que haya una fila seleccionada
                if (dg_carrito.CurrentRow == null)
                {
                    MessageBox.Show("Selecciona un artículo del carrito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmación
                DialogResult confirmacion = MessageBox.Show(
                    "¿Deseas eliminar este artículo del carrito?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    // Obtener índice de la fila seleccionada
                    int index = dg_carrito.CurrentRow.Index;

                    // Remover del carrito (lista)
                    carrito.RemoveAt(index);

                    // Refrescar el DataGridView y subtotal
                    CargarCarritoEnGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Llamar a el autor!\nError: " + ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dg_carrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dg_carrito.Rows[e.RowIndex];

                    txt_nomArticulo.Text = row.Cells["prod_nombre"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Llamar a el autor!\nError: " + ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txt_pagoCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Si no es nada de eso, ignorar la tecla
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cb_metPago_SelectedIndexChanged(object sender, EventArgs e)
        {

            string metodo = cb_metPago.Text;

            if (metodo == "TARJETA" || metodo == "TRANSFERENCIA")
            {
                string totalLimpio = txt_subtotal.Text.Replace("$", "").Trim();

                txt_pagoCon.Text = totalLimpio;

                txt_pagoCon.Enabled = false;

                ep_validaciones.SetError(txt_pagoCon, "");
            }
            else if (metodo == "EFECTIVO")
            {
                txt_pagoCon.Enabled = true;
                txt_pagoCon.Text = "";
                txt_pagoCon.Focus();
            }
        }
    }
}
