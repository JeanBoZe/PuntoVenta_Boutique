
namespace Punto_VentaRG
{
    partial class Venta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_carrito = new System.Windows.Forms.DataGridView();
            this.txt_nomArticulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_metPago = new System.Windows.Forms.ComboBox();
            this.txt_pagoCon = new System.Windows.Forms.TextBox();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.btn_guardarVenta = new System.Windows.Forms.Button();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscarProducto = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.btn_quitarProducto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.ep_validaciones = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg_carrito)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_validaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_carrito
            // 
            this.dg_carrito.AllowUserToAddRows = false;
            this.dg_carrito.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            this.dg_carrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_carrito.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_carrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_carrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_carrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_carrito.DefaultCellStyle = dataGridViewCellStyle6;
            this.dg_carrito.EnableHeadersVisualStyles = false;
            this.dg_carrito.Location = new System.Drawing.Point(37, 41);
            this.dg_carrito.Margin = new System.Windows.Forms.Padding(4);
            this.dg_carrito.Name = "dg_carrito";
            this.dg_carrito.ReadOnly = true;
            this.dg_carrito.RowHeadersVisible = false;
            this.dg_carrito.Size = new System.Drawing.Size(571, 437);
            this.dg_carrito.TabIndex = 0;
            this.dg_carrito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_carrito_CellClick);
            // 
            // txt_nomArticulo
            // 
            this.txt_nomArticulo.Location = new System.Drawing.Point(115, 104);
            this.txt_nomArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nomArticulo.Name = "txt_nomArticulo";
            this.txt_nomArticulo.Size = new System.Drawing.Size(345, 24);
            this.txt_nomArticulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(34, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Articulo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_metPago);
            this.groupBox1.Controls.Add(this.txt_pagoCon);
            this.groupBox1.Controls.Add(this.txt_subtotal);
            this.groupBox1.Controls.Add(this.btn_guardarVenta);
            this.groupBox1.Controls.Add(this.lbl_cantidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(24, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 263);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(109, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Pago Con:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(427, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Metodo de Pago";
            // 
            // cb_metPago
            // 
            this.cb_metPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_metPago.FormattingEnabled = true;
            this.cb_metPago.Location = new System.Drawing.Point(365, 64);
            this.cb_metPago.Name = "cb_metPago";
            this.cb_metPago.Size = new System.Drawing.Size(247, 27);
            this.cb_metPago.TabIndex = 27;
            this.cb_metPago.SelectedIndexChanged += new System.EventHandler(this.cb_metPago_SelectedIndexChanged);
            // 
            // txt_pagoCon
            // 
            this.txt_pagoCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_pagoCon.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pagoCon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_pagoCon.Location = new System.Drawing.Point(38, 197);
            this.txt_pagoCon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pagoCon.Name = "txt_pagoCon";
            this.txt_pagoCon.Size = new System.Drawing.Size(247, 34);
            this.txt_pagoCon.TabIndex = 1;
            this.txt_pagoCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pagoCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pagoCon_KeyPress);
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.BackColor = System.Drawing.SystemColors.InfoText;
            this.txt_subtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_subtotal.Enabled = false;
            this.txt_subtotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subtotal.ForeColor = System.Drawing.Color.LawnGreen;
            this.txt_subtotal.Location = new System.Drawing.Point(38, 82);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(247, 61);
            this.txt_subtotal.TabIndex = 26;
            this.txt_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_guardarVenta
            // 
            this.btn_guardarVenta.Location = new System.Drawing.Point(412, 149);
            this.btn_guardarVenta.Name = "btn_guardarVenta";
            this.btn_guardarVenta.Size = new System.Drawing.Size(161, 82);
            this.btn_guardarVenta.TabIndex = 8;
            this.btn_guardarVenta.Text = "&Guardar Venta";
            this.btn_guardarVenta.UseVisualStyleBackColor = true;
            this.btn_guardarVenta.Click += new System.EventHandler(this.btn_guardarVenta_Click);
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cantidad.Location = new System.Drawing.Point(197, 42);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(19, 21);
            this.lbl_cantidad.TabIndex = 22;
            this.lbl_cantidad.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(69, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cantidad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dg_carrito);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(703, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 510);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carrito de Compra";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txt_nomArticulo);
            this.groupBox4.Controls.Add(this.btn_buscarProducto);
            this.groupBox4.Controls.Add(this.txt_codigo);
            this.groupBox4.Controls.Add(this.btn_quitarProducto);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(24, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(645, 219);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(34, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Codigo:";
            // 
            // btn_buscarProducto
            // 
            this.btn_buscarProducto.BackgroundImage = global::Punto_VentaRG.Properties.Resources.lupa;
            this.btn_buscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarProducto.Location = new System.Drawing.Point(553, 41);
            this.btn_buscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscarProducto.Name = "btn_buscarProducto";
            this.btn_buscarProducto.Size = new System.Drawing.Size(59, 57);
            this.btn_buscarProducto.TabIndex = 5;
            this.btn_buscarProducto.UseVisualStyleBackColor = true;
            this.btn_buscarProducto.Click += new System.EventHandler(this.btn_buscarProducto_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(115, 57);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(345, 24);
            this.txt_codigo.TabIndex = 0;
            this.txt_codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_codigo_KeyDown);
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // btn_quitarProducto
            // 
            this.btn_quitarProducto.BackgroundImage = global::Punto_VentaRG.Properties.Resources.cancelar;
            this.btn_quitarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_quitarProducto.Location = new System.Drawing.Point(553, 106);
            this.btn_quitarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_quitarProducto.Name = "btn_quitarProducto";
            this.btn_quitarProducto.Size = new System.Drawing.Size(59, 57);
            this.btn_quitarProducto.TabIndex = 7;
            this.btn_quitarProducto.UseVisualStyleBackColor = true;
            this.btn_quitarProducto.Click += new System.EventHandler(this.btn_quitarProducto_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Punto_VentaRG.Properties.Resources.minimizar;
            this.button1.Location = new System.Drawing.Point(1244, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 45);
            this.button1.TabIndex = 29;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = global::Punto_VentaRG.Properties.Resources.arrow_left;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(1315, 13);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(47, 45);
            this.btn_salir.TabIndex = 24;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // ep_validaciones
            // 
            this.ep_validaciones.ContainerControl = this;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1375, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Venta";
            this.Activated += new System.EventHandler(this.Venta_Activated);
            this.Load += new System.EventHandler(this.Venta_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dg_carrito)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_validaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_carrito;
        private System.Windows.Forms.TextBox txt_nomArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_quitarProducto;
        private System.Windows.Forms.Button btn_buscarProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_guardarVenta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_metPago;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pagoCon;
        private System.Windows.Forms.ErrorProvider ep_validaciones;
    }
}