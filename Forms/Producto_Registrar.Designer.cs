
namespace Punto_VentaRG.Forms
{
    partial class Producto_Registrar
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
            this.label7 = new System.Windows.Forms.Label();
            this.txt_precioVenta = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_precioCompra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_editarCatMar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_talla = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorValidaciones = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "PRECIO VENTA:";
            // 
            // txt_precioVenta
            // 
            this.txt_precioVenta.BackColor = System.Drawing.Color.Silver;
            this.txt_precioVenta.Location = new System.Drawing.Point(21, 235);
            this.txt_precioVenta.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_precioVenta.Name = "txt_precioVenta";
            this.txt_precioVenta.Size = new System.Drawing.Size(142, 24);
            this.txt_precioVenta.TabIndex = 4;
            this.txt_precioVenta.Text = "0";
            this.txt_precioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precioVenta_KeyPress);
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.Silver;
            this.txt_codigo.Location = new System.Drawing.Point(21, 65);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(204, 24);
            this.txt_codigo.TabIndex = 0;
            this.txt_codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_codigo_KeyDown);
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.Silver;
            this.txt_nombre.Location = new System.Drawing.Point(233, 65);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(264, 24);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_stock
            // 
            this.txt_stock.BackColor = System.Drawing.Color.Silver;
            this.txt_stock.Location = new System.Drawing.Point(341, 235);
            this.txt_stock.Margin = new System.Windows.Forms.Padding(4);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(132, 24);
            this.txt_stock.TabIndex = 8;
            this.txt_stock.Text = "0";
            this.txt_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stock_KeyPress);
            // 
            // txt_precioCompra
            // 
            this.txt_precioCompra.BackColor = System.Drawing.Color.Silver;
            this.txt_precioCompra.Enabled = false;
            this.txt_precioCompra.Location = new System.Drawing.Point(185, 235);
            this.txt_precioCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precioCompra.Name = "txt_precioCompra";
            this.txt_precioCompra.Size = new System.Drawing.Size(140, 24);
            this.txt_precioCompra.TabIndex = 6;
            this.txt_precioCompra.Text = "0";
            this.txt_precioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precioCompra_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "CODIGO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "NOMBRE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "STOCK:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "PRECIO COMPRA:";
            // 
            // cb_categoria
            // 
            this.cb_categoria.BackColor = System.Drawing.Color.Silver;
            this.cb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(21, 175);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(314, 27);
            this.cb_categoria.TabIndex = 3;
            this.cb_categoria.SelectedIndexChanged += new System.EventHandler(this.cb_categoria_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 153);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "CATEGORIA:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_editarCatMar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cb_talla);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_borrar);
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.txt_stock);
            this.groupBox1.Controls.Add(this.cb_marca);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_categoria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_precioCompra);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.txt_color);
            this.groupBox1.Controls.Add(this.txt_precioVenta);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(56, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Producto";
            // 
            // btn_editarCatMar
            // 
            this.btn_editarCatMar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_editarCatMar.Location = new System.Drawing.Point(345, 138);
            this.btn_editarCatMar.Name = "btn_editarCatMar";
            this.btn_editarCatMar.Size = new System.Drawing.Size(128, 49);
            this.btn_editarCatMar.TabIndex = 11;
            this.btn_editarCatMar.Text = "Editar Marca-Categoria";
            this.btn_editarCatMar.UseVisualStyleBackColor = true;
            this.btn_editarCatMar.Click += new System.EventHandler(this.btn_editarCatMar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(279, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 19);
            this.label9.TabIndex = 42;
            this.label9.Text = "TALLA:";
            // 
            // cb_talla
            // 
            this.cb_talla.BackColor = System.Drawing.Color.Silver;
            this.cb_talla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_talla.FormattingEnabled = true;
            this.cb_talla.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.cb_talla.Location = new System.Drawing.Point(245, 303);
            this.cb_talla.Name = "cb_talla";
            this.cb_talla.Size = new System.Drawing.Size(117, 27);
            this.cb_talla.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Punto_VentaRG.Properties.Resources.paquete_o_empaquetar;
            this.pictureBox1.Location = new System.Drawing.Point(475, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "MARCA:";
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackgroundImage = global::Punto_VentaRG.Properties.Resources.trash_can_solid_full;
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_borrar.Location = new System.Drawing.Point(544, 287);
            this.btn_borrar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(63, 57);
            this.btn_borrar.TabIndex = 10;
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Visible = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::Punto_VentaRG.Properties.Resources.download_solid_full;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_guardar.Location = new System.Drawing.Point(421, 287);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(63, 57);
            this.btn_guardar.TabIndex = 9;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // cb_marca
            // 
            this.cb_marca.BackColor = System.Drawing.Color.Silver;
            this.cb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_marca.FormattingEnabled = true;
            this.cb_marca.Location = new System.Drawing.Point(21, 117);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(314, 27);
            this.cb_marca.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 278);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 19);
            this.label10.TabIndex = 33;
            this.label10.Text = "COLOR:";
            // 
            // txt_color
            // 
            this.txt_color.BackColor = System.Drawing.Color.Silver;
            this.txt_color.Location = new System.Drawing.Point(21, 303);
            this.txt_color.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(184, 24);
            this.txt_color.TabIndex = 5;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::Punto_VentaRG.Properties.Resources.arrow_left;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancelar.Location = new System.Drawing.Point(726, 13);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(47, 49);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 524);
            this.panel1.TabIndex = 1;
            // 
            // errorValidaciones
            // 
            this.errorValidaciones.ContainerControl = this;
            // 
            // Producto_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(786, 524);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Producto_Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Producto_Registrar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorValidaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_precioVenta;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_precioCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_marca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_talla;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.Button btn_editarCatMar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorValidaciones;
    }
}