
namespace Punto_VentaRG.Forms
{
    partial class CatMar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gb_categoria = new System.Windows.Forms.GroupBox();
            this.txt_catId = new System.Windows.Forms.TextBox();
            this.btn_guardarCategoria = new System.Windows.Forms.Button();
            this.dg_categoria = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_desCategoria = new System.Windows.Forms.TextBox();
            this.check_estadoCategoria = new System.Windows.Forms.CheckBox();
            this.gb_marca = new System.Windows.Forms.GroupBox();
            this.txt_marId = new System.Windows.Forms.TextBox();
            this.btn_guardarMarca = new System.Windows.Forms.Button();
            this.dg_marca = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_desMarca = new System.Windows.Forms.TextBox();
            this.check_estadoMarca = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_categoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_categoria)).BeginInit();
            this.gb_marca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_marca)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::Punto_VentaRG.Properties.Resources.arrow_left;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(1016, 4);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(47, 45);
            this.btn_cancelar.TabIndex = 31;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // gb_categoria
            // 
            this.gb_categoria.Controls.Add(this.txt_catId);
            this.gb_categoria.Controls.Add(this.btn_guardarCategoria);
            this.gb_categoria.Controls.Add(this.dg_categoria);
            this.gb_categoria.Controls.Add(this.label1);
            this.gb_categoria.Controls.Add(this.txt_desCategoria);
            this.gb_categoria.Controls.Add(this.check_estadoCategoria);
            this.gb_categoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_categoria.Location = new System.Drawing.Point(52, 45);
            this.gb_categoria.Name = "gb_categoria";
            this.gb_categoria.Size = new System.Drawing.Size(414, 534);
            this.gb_categoria.TabIndex = 33;
            this.gb_categoria.TabStop = false;
            this.gb_categoria.Text = "Categoria";
            // 
            // txt_catId
            // 
            this.txt_catId.Location = new System.Drawing.Point(16, 103);
            this.txt_catId.Name = "txt_catId";
            this.txt_catId.Size = new System.Drawing.Size(100, 24);
            this.txt_catId.TabIndex = 35;
            this.txt_catId.Visible = false;
            // 
            // btn_guardarCategoria
            // 
            this.btn_guardarCategoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_guardarCategoria.Location = new System.Drawing.Point(160, 94);
            this.btn_guardarCategoria.Name = "btn_guardarCategoria";
            this.btn_guardarCategoria.Size = new System.Drawing.Size(95, 42);
            this.btn_guardarCategoria.TabIndex = 34;
            this.btn_guardarCategoria.Text = "Guardar";
            this.btn_guardarCategoria.UseVisualStyleBackColor = true;
            this.btn_guardarCategoria.Click += new System.EventHandler(this.btn_guardarCategoria_Click);
            // 
            // dg_categoria
            // 
            this.dg_categoria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_categoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_categoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_categoria.Location = new System.Drawing.Point(16, 163);
            this.dg_categoria.Name = "dg_categoria";
            this.dg_categoria.ReadOnly = true;
            this.dg_categoria.RowHeadersVisible = false;
            this.dg_categoria.Size = new System.Drawing.Size(381, 330);
            this.dg_categoria.TabIndex = 3;
            this.dg_categoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_categoria_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descripcion";
            // 
            // txt_desCategoria
            // 
            this.txt_desCategoria.Location = new System.Drawing.Point(99, 55);
            this.txt_desCategoria.Name = "txt_desCategoria";
            this.txt_desCategoria.Size = new System.Drawing.Size(232, 24);
            this.txt_desCategoria.TabIndex = 1;
            // 
            // check_estadoCategoria
            // 
            this.check_estadoCategoria.Appearance = System.Windows.Forms.Appearance.Button;
            this.check_estadoCategoria.AutoSize = true;
            this.check_estadoCategoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_estadoCategoria.ForeColor = System.Drawing.SystemColors.InfoText;
            this.check_estadoCategoria.Location = new System.Drawing.Point(337, 53);
            this.check_estadoCategoria.Name = "check_estadoCategoria";
            this.check_estadoCategoria.Size = new System.Drawing.Size(60, 29);
            this.check_estadoCategoria.TabIndex = 0;
            this.check_estadoCategoria.Text = "Estado";
            this.check_estadoCategoria.UseVisualStyleBackColor = true;
            this.check_estadoCategoria.CheckedChanged += new System.EventHandler(this.check_estadoCategoria_CheckedChanged);
            // 
            // gb_marca
            // 
            this.gb_marca.Controls.Add(this.txt_marId);
            this.gb_marca.Controls.Add(this.btn_guardarMarca);
            this.gb_marca.Controls.Add(this.dg_marca);
            this.gb_marca.Controls.Add(this.label2);
            this.gb_marca.Controls.Add(this.txt_desMarca);
            this.gb_marca.Controls.Add(this.check_estadoMarca);
            this.gb_marca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_marca.Location = new System.Drawing.Point(543, 45);
            this.gb_marca.Name = "gb_marca";
            this.gb_marca.Size = new System.Drawing.Size(414, 534);
            this.gb_marca.TabIndex = 33;
            this.gb_marca.TabStop = false;
            this.gb_marca.Text = "Marca";
            // 
            // txt_marId
            // 
            this.txt_marId.Location = new System.Drawing.Point(16, 103);
            this.txt_marId.Name = "txt_marId";
            this.txt_marId.Size = new System.Drawing.Size(100, 24);
            this.txt_marId.TabIndex = 35;
            this.txt_marId.Visible = false;
            // 
            // btn_guardarMarca
            // 
            this.btn_guardarMarca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_guardarMarca.Location = new System.Drawing.Point(160, 94);
            this.btn_guardarMarca.Name = "btn_guardarMarca";
            this.btn_guardarMarca.Size = new System.Drawing.Size(95, 42);
            this.btn_guardarMarca.TabIndex = 34;
            this.btn_guardarMarca.Text = "Guardar";
            this.btn_guardarMarca.UseVisualStyleBackColor = true;
            this.btn_guardarMarca.Click += new System.EventHandler(this.btn_guardarMarca_Click);
            // 
            // dg_marca
            // 
            this.dg_marca.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_marca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_marca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_marca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_marca.Location = new System.Drawing.Point(16, 163);
            this.dg_marca.Name = "dg_marca";
            this.dg_marca.ReadOnly = true;
            this.dg_marca.RowHeadersVisible = false;
            this.dg_marca.Size = new System.Drawing.Size(381, 330);
            this.dg_marca.TabIndex = 3;
            this.dg_marca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_marca_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // txt_desMarca
            // 
            this.txt_desMarca.Location = new System.Drawing.Point(99, 55);
            this.txt_desMarca.Name = "txt_desMarca";
            this.txt_desMarca.Size = new System.Drawing.Size(232, 24);
            this.txt_desMarca.TabIndex = 1;
            // 
            // check_estadoMarca
            // 
            this.check_estadoMarca.Appearance = System.Windows.Forms.Appearance.Button;
            this.check_estadoMarca.AutoSize = true;
            this.check_estadoMarca.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_estadoMarca.ForeColor = System.Drawing.SystemColors.InfoText;
            this.check_estadoMarca.Location = new System.Drawing.Point(337, 53);
            this.check_estadoMarca.Name = "check_estadoMarca";
            this.check_estadoMarca.Size = new System.Drawing.Size(60, 29);
            this.check_estadoMarca.TabIndex = 0;
            this.check_estadoMarca.Text = "estado";
            this.check_estadoMarca.UseVisualStyleBackColor = true;
            this.check_estadoMarca.CheckedChanged += new System.EventHandler(this.check_estadoMarca_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gb_categoria);
            this.panel1.Controls.Add(this.gb_marca);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 658);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CatMar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CatMar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CatMar";
            this.Load += new System.EventHandler(this.CatMar_Load);
            this.gb_categoria.ResumeLayout(false);
            this.gb_categoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_categoria)).EndInit();
            this.gb_marca.ResumeLayout(false);
            this.gb_marca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_marca)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox gb_categoria;
        private System.Windows.Forms.DataGridView dg_categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_desCategoria;
        private System.Windows.Forms.CheckBox check_estadoCategoria;
        private System.Windows.Forms.Button btn_guardarCategoria;
        private System.Windows.Forms.GroupBox gb_marca;
        private System.Windows.Forms.Button btn_guardarMarca;
        private System.Windows.Forms.DataGridView dg_marca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_desMarca;
        private System.Windows.Forms.CheckBox check_estadoMarca;
        private System.Windows.Forms.TextBox txt_catId;
        private System.Windows.Forms.TextBox txt_marId;
        private System.Windows.Forms.Panel panel1;
    }
}