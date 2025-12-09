using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_VentaRG.Forms
{
    public partial class Rpt_Ventas : Form
    {
        public Rpt_Ventas()
        {
            InitializeComponent();
        }

        List<Entidad.Rep_Venta> rptV_list = new List<Entidad.Rep_Venta>();
        Clases.csRptVentas csRptVentas = new Clases.csRptVentas();

        private void Rpt_Ventas_Load(object sender, EventArgs e)
        {
            rptV_list = csRptVentas.ObtenerRpt_Ventas(0);
            dg_rptVentas.DataSource = rptV_list;

            // Forzar colores legibles
            dg_rptVentas.DefaultCellStyle.BackColor = Color.White;
            dg_rptVentas.DefaultCellStyle.ForeColor = Color.Black;
            // Color alterno de filas (opcional, para distinguirlas)
            dg_rptVentas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            // Color del encabezado
            dg_rptVentas.EnableHeadersVisualStyles = false;

            dg_rptVentas.Columns["folio"].HeaderText = "Folio";
            dg_rptVentas.Columns["fechaHora"].HeaderText = "Fecha y Hora";
            dg_rptVentas.Columns["vendedor"].HeaderText = "Vendedor";
            dg_rptVentas.Columns["ProdVendidos"].HeaderText = "Productos Vendidos";
            dg_rptVentas.Columns["metodoPag"].HeaderText = "Metodo de Pago";
            dg_rptVentas.Columns["subtotal"].HeaderText = "Monto Total";

            dg_rptVentas.Columns["ProdVendidos"].Width = 430;
            dg_rptVentas.Columns["folio"].Width = 50;
            dg_rptVentas.Columns["fechaHora"].Width = 200;

            dg_rptVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dg_rptVentas.Columns["ProdVendidos"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dg_rptVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_hoy_Click(object sender, EventArgs e)
        {
            gb_custom.Visible = false;
            rptV_list = csRptVentas.ObtenerRpt_Ventas(1);
            dg_rptVentas.DataSource = rptV_list;
        }

        private void btn_ult7dias_Click(object sender, EventArgs e)
        {
            gb_custom.Visible = false;
            rptV_list = csRptVentas.ObtenerRpt_Ventas(2);
            dg_rptVentas.DataSource = rptV_list;
        }

        private void btn_esteMes_Click(object sender, EventArgs e)
        {
            gb_custom.Visible = false;
            rptV_list = csRptVentas.ObtenerRpt_Ventas(3);
            dg_rptVentas.DataSource = rptV_list;
        }

        private void btn_esteAnio_Click(object sender, EventArgs e)
        {
            gb_custom.Visible = false;
            rptV_list = csRptVentas.ObtenerRpt_Ventas(4);
            dg_rptVentas.DataSource = rptV_list;
        }

        private void btn_manual_Click(object sender, EventArgs e)
        {
            gb_custom.Visible = true;
        }

        private void btn_aplicar_Click(object sender, EventArgs e)
        {
            rptV_list = csRptVentas.ObtenerRpt_Manual(dtp_desde.Text, dtp_hasta.Text);
            dg_rptVentas.DataSource = rptV_list;
        }
    }
}
