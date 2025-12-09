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
    public partial class CatMar : Form
    {
        public CatMar()
        {
            InitializeComponent();
        }

        List<Entidad.csCategoria> listaCategorias = new List<Entidad.csCategoria>();
        Clases.csCategoria csCategoria = new Clases.csCategoria();

        List<Entidad.csMarca> listaMarca = new List<Entidad.csMarca>();
        Clases.csMarca csMarca = new Clases.csMarca();
        private void CatMar_Load(object sender, EventArgs e)
        {
            try
            {
                check_estadoMarca.Checked = true;
                check_estadoCategoria.Checked = true;
                //CATEGORIA
                listaCategorias = csCategoria.ObtenerCategorias();
                dg_categoria.DataSource = listaCategorias;
                dg_categoria.EnableHeadersVisualStyles = false;
                dg_categoria.Columns["CAT_ID"].Visible = false;
                dg_categoria.Columns["CAT_DESCRIPCION"].HeaderText = "Descripcion";
                dg_categoria.Columns["CAT_DESCRIPCION"].Width = 246;
                dg_categoria.Columns["CAT_DESCRIPCION"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dg_categoria.Columns["CAT_ESTADO"].HeaderText = "Estado";
                dg_categoria.DefaultCellStyle.ForeColor = Color.Black;
                dg_categoria.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                dg_categoria.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(65, 105, 225); 
                dg_categoria.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dg_categoria.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //MARCA
                listaMarca = csMarca.ObtenerMarcas();
                dg_marca.DataSource = listaMarca;
                dg_marca.EnableHeadersVisualStyles = false;
                dg_marca.Columns["MAR_ID"].Visible = false;
                dg_marca.Columns["MAR_DESCRIPCION"].HeaderText = "Descripcion";
                dg_marca.Columns["MAR_DESCRIPCION"].Width = 246;
                dg_marca.Columns["MAR_DESCRIPCION"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dg_marca.Columns["MAR_ESTADO"].HeaderText = "Estado";
                dg_marca.DefaultCellStyle.ForeColor = Color.Black;
                dg_marca.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                dg_marca.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(65, 105, 225);
                dg_marca.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dg_marca.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Llamar a el autor!\nError: " + ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                string mensajeSalida;

                int id = 0;
                if (!string.IsNullOrEmpty(txt_catId.Text))
                {
                    id = Convert.ToInt32(txt_catId.Text);
                }

                string descripcion = txt_desCategoria.Text;
                bool estado = check_estadoCategoria.Checked;

                bool guardadoConExito = csCategoria.GuardarCategoria(id, descripcion, estado, out mensajeSalida);
                MessageBox.Show(mensajeSalida, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(guardadoConExito == true)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Llamar a el autor!\nError: " + ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dg_categoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dg_categoria.Rows[e.RowIndex];

                    txt_catId.Text = row.Cells["CAT_ID"].Value.ToString();
                    txt_desCategoria.Text = row.Cells["CAT_DESCRIPCION"].Value.ToString();
                    check_estadoCategoria.Checked = Convert.ToBoolean(row.Cells["CAT_ESTADO"].Value);
                    ActualizarColorEstado(check_estadoCategoria);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Llamar a el autor!\nError: " + ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_guardarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                string mensajeSalida;

                int id = 0;
                if (!string.IsNullOrEmpty(txt_marId.Text))
                {
                    id = Convert.ToInt32(txt_marId.Text);
                }

                string descripcion = txt_desMarca.Text;
                bool estado = check_estadoMarca.Checked;

                bool guardadoConExito = csMarca.GuardarMarca(id, descripcion, estado, out mensajeSalida);
                MessageBox.Show(mensajeSalida, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (guardadoConExito == true)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Llamar a el autor!\nError: " + ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dg_marca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dg_marca.Rows[e.RowIndex];

                    txt_marId.Text = row.Cells["MAR_ID"].Value.ToString();
                    txt_desMarca.Text = row.Cells["MAR_DESCRIPCION"].Value.ToString();
                    check_estadoMarca.Checked = Convert.ToBoolean(row.Cells["MAR_ESTADO"].Value);
                    ActualizarColorEstado(check_estadoMarca);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Llamar a el autor!\nError: " + ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarColorEstado(CheckBox chk)
        {
            if (chk.Checked)
            {
                // Verdadero 
                chk.BackColor = Color.LightGreen;
                chk.ForeColor = Color.Black;

                chk.Text = "Activo"; 
            }
            else
            {
                // Falso 
                chk.BackColor = Color.LightCoral;
                chk.ForeColor = Color.Black;

                chk.Text = "Inactivo";
            }
        }

        private void check_estadoCategoria_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarColorEstado(check_estadoCategoria);
        }

        private void check_estadoMarca_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarColorEstado(check_estadoMarca);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
