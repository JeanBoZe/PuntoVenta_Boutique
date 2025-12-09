
namespace Punto_VentaRG.Forms
{
    partial class Rpt_Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_buscador = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dg_rptVentas = new System.Windows.Forms.DataGridView();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_custom = new System.Windows.Forms.GroupBox();
            this.btn_aplicar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.btn_esteMes = new System.Windows.Forms.Button();
            this.btn_manual = new System.Windows.Forms.Button();
            this.btn_ult7dias = new System.Windows.Forms.Button();
            this.btn_esteAnio = new System.Windows.Forms.Button();
            this.btn_hoy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rptVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.gb_custom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_buscador
            // 
            this.txt_buscador.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscador.Location = new System.Drawing.Point(156, 72);
            this.txt_buscador.Name = "txt_buscador";
            this.txt_buscador.Size = new System.Drawing.Size(249, 32);
            this.txt_buscador.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dg_rptVentas);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(48, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1033, 480);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reportes de Ventas";
            // 
            // dg_rptVentas
            // 
            this.dg_rptVentas.AllowUserToAddRows = false;
            this.dg_rptVentas.AllowUserToResizeColumns = false;
            this.dg_rptVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_rptVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_rptVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_rptVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_rptVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dg_rptVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_rptVentas.DefaultCellStyle = dataGridViewCellStyle10;
            this.dg_rptVentas.Location = new System.Drawing.Point(32, 43);
            this.dg_rptVentas.Margin = new System.Windows.Forms.Padding(4);
            this.dg_rptVentas.Name = "dg_rptVentas";
            this.dg_rptVentas.ReadOnly = true;
            this.dg_rptVentas.RowHeadersVisible = false;
            this.dg_rptVentas.Size = new System.Drawing.Size(969, 406);
            this.dg_rptVentas.TabIndex = 1;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimizar.Image = global::Punto_VentaRG.Properties.Resources.minimizar;
            this.btn_minimizar.Location = new System.Drawing.Point(1006, 13);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(64, 45);
            this.btn_minimizar.TabIndex = 36;
            this.btn_minimizar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Punto_VentaRG.Properties.Resources.magnifying_glass_solid_full;
            this.pictureBox2.Location = new System.Drawing.Point(106, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::Punto_VentaRG.Properties.Resources.arrow_left;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(1077, 13);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(47, 45);
            this.btn_cancelar.TabIndex = 32;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.gb_custom);
            this.panel1.Controls.Add(this.btn_esteMes);
            this.panel1.Controls.Add(this.btn_manual);
            this.panel1.Controls.Add(this.btn_ult7dias);
            this.panel1.Controls.Add(this.btn_esteAnio);
            this.panel1.Controls.Add(this.btn_hoy);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1131, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 642);
            this.panel1.TabIndex = 38;
            // 
            // gb_custom
            // 
            this.gb_custom.Controls.Add(this.btn_aplicar);
            this.gb_custom.Controls.Add(this.label2);
            this.gb_custom.Controls.Add(this.label1);
            this.gb_custom.Controls.Add(this.dtp_hasta);
            this.gb_custom.Controls.Add(this.dtp_desde);
            this.gb_custom.Location = new System.Drawing.Point(15, 403);
            this.gb_custom.Name = "gb_custom";
            this.gb_custom.Size = new System.Drawing.Size(217, 196);
            this.gb_custom.TabIndex = 38;
            this.gb_custom.TabStop = false;
            this.gb_custom.Visible = false;
            // 
            // btn_aplicar
            // 
            this.btn_aplicar.Location = new System.Drawing.Point(50, 130);
            this.btn_aplicar.Name = "btn_aplicar";
            this.btn_aplicar.Size = new System.Drawing.Size(114, 45);
            this.btn_aplicar.TabIndex = 38;
            this.btn_aplicar.Text = "&Aplicar";
            this.btn_aplicar.UseVisualStyleBackColor = true;
            this.btn_aplicar.Click += new System.EventHandler(this.btn_aplicar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Desde";
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.CustomFormat = "";
            this.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_hasta.Location = new System.Drawing.Point(9, 100);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(200, 24);
            this.dtp_hasta.TabIndex = 38;
            // 
            // dtp_desde
            // 
            this.dtp_desde.CustomFormat = "";
            this.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_desde.Location = new System.Drawing.Point(9, 51);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(200, 24);
            this.dtp_desde.TabIndex = 38;
            // 
            // btn_esteMes
            // 
            this.btn_esteMes.Location = new System.Drawing.Point(0, 235);
            this.btn_esteMes.Name = "btn_esteMes";
            this.btn_esteMes.Size = new System.Drawing.Size(244, 44);
            this.btn_esteMes.TabIndex = 38;
            this.btn_esteMes.Text = "Este mes";
            this.btn_esteMes.UseVisualStyleBackColor = true;
            this.btn_esteMes.Click += new System.EventHandler(this.btn_esteMes_Click);
            // 
            // btn_manual
            // 
            this.btn_manual.Location = new System.Drawing.Point(0, 335);
            this.btn_manual.Name = "btn_manual";
            this.btn_manual.Size = new System.Drawing.Size(244, 44);
            this.btn_manual.TabIndex = 38;
            this.btn_manual.Text = "Manual";
            this.btn_manual.UseVisualStyleBackColor = true;
            this.btn_manual.Click += new System.EventHandler(this.btn_manual_Click);
            // 
            // btn_ult7dias
            // 
            this.btn_ult7dias.Location = new System.Drawing.Point(0, 185);
            this.btn_ult7dias.Name = "btn_ult7dias";
            this.btn_ult7dias.Size = new System.Drawing.Size(244, 44);
            this.btn_ult7dias.TabIndex = 38;
            this.btn_ult7dias.Text = "Ultimos 7 dias";
            this.btn_ult7dias.UseVisualStyleBackColor = true;
            this.btn_ult7dias.Click += new System.EventHandler(this.btn_ult7dias_Click);
            // 
            // btn_esteAnio
            // 
            this.btn_esteAnio.Location = new System.Drawing.Point(0, 285);
            this.btn_esteAnio.Name = "btn_esteAnio";
            this.btn_esteAnio.Size = new System.Drawing.Size(244, 44);
            this.btn_esteAnio.TabIndex = 38;
            this.btn_esteAnio.Text = "Este año";
            this.btn_esteAnio.UseVisualStyleBackColor = true;
            this.btn_esteAnio.Click += new System.EventHandler(this.btn_esteAnio_Click);
            // 
            // btn_hoy
            // 
            this.btn_hoy.Location = new System.Drawing.Point(0, 135);
            this.btn_hoy.Name = "btn_hoy";
            this.btn_hoy.Size = new System.Drawing.Size(244, 44);
            this.btn_hoy.TabIndex = 38;
            this.btn_hoy.Text = "Hoy";
            this.btn_hoy.UseVisualStyleBackColor = true;
            this.btn_hoy.Click += new System.EventHandler(this.btn_hoy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Punto_VentaRG.Properties.Resources.boutique;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // Rpt_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1375, 642);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.txt_buscador);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Rpt_Ventas";
            this.Text = "Rpt_Ventas";
            this.Load += new System.EventHandler(this.Rpt_Ventas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_rptVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gb_custom.ResumeLayout(false);
            this.gb_custom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.TextBox txt_buscador;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dg_rptVentas;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gb_custom;
        private System.Windows.Forms.Button btn_aplicar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.Button btn_esteMes;
        private System.Windows.Forms.Button btn_manual;
        private System.Windows.Forms.Button btn_ult7dias;
        private System.Windows.Forms.Button btn_esteAnio;
        private System.Windows.Forms.Button btn_hoy;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}