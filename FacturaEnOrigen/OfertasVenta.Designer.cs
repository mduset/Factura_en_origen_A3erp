namespace FacturaEnOrigen
{
    partial class OfertasVenta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.debug_label = new System.Windows.Forms.Label();
            this.entorn_label = new System.Windows.Forms.Label();
            this.referencia = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ultimo_año = new System.Windows.Forms.CheckBox();
            this.ultimo_mes = new System.Windows.Forms.CheckBox();
            this.ultima_semana = new System.Windows.Forms.CheckBox();
            this.hoy = new System.Windows.Forms.CheckBox();
            this.text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.llistatComandesVentaGrid = new System.Windows.Forms.DataGridView();
            this.todo = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.llistatComandesVentaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.debug_label);
            this.groupBox1.Controls.Add(this.entorn_label);
            this.groupBox1.Controls.Add(this.referencia);
            this.groupBox1.Controls.Add(this.numero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buscar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.text);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(993, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // debug_label
            // 
            this.debug_label.AutoSize = true;
            this.debug_label.BackColor = System.Drawing.SystemColors.Info;
            this.debug_label.ForeColor = System.Drawing.Color.Red;
            this.debug_label.Location = new System.Drawing.Point(702, 26);
            this.debug_label.Name = "debug_label";
            this.debug_label.Size = new System.Drawing.Size(45, 13);
            this.debug_label.TabIndex = 11;
            this.debug_label.Text = "DEBUG";
            this.debug_label.Visible = false;
            // 
            // entorn_label
            // 
            this.entorn_label.AutoSize = true;
            this.entorn_label.BackColor = System.Drawing.SystemColors.Info;
            this.entorn_label.ForeColor = System.Drawing.Color.Red;
            this.entorn_label.Location = new System.Drawing.Point(558, 26);
            this.entorn_label.Name = "entorn_label";
            this.entorn_label.Size = new System.Drawing.Size(118, 13);
            this.entorn_label.TabIndex = 10;
            this.entorn_label.Text = "DESENVOLUPAMENT";
            this.entorn_label.Visible = false;
            // 
            // referencia
            // 
            this.referencia.AccessibleName = "referencia";
            this.referencia.Location = new System.Drawing.Point(269, 47);
            this.referencia.Name = "referencia";
            this.referencia.Size = new System.Drawing.Size(100, 20);
            this.referencia.TabIndex = 4;
            // 
            // numero
            // 
            this.numero.AccessibleName = "numero";
            this.numero.Location = new System.Drawing.Point(73, 47);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(100, 20);
            this.numero.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Referencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Número";
            // 
            // buscar
            // 
            this.buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buscar.ImageKey = "(ninguno)";
            this.buscar.Location = new System.Drawing.Point(385, 80);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 9;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.todo);
            this.groupBox2.Controls.Add(this.ultimo_año);
            this.groupBox2.Controls.Add(this.ultimo_mes);
            this.groupBox2.Controls.Add(this.ultima_semana);
            this.groupBox2.Controls.Add(this.hoy);
            this.groupBox2.Location = new System.Drawing.Point(22, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 45);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fechas";
            // 
            // ultimo_año
            // 
            this.ultimo_año.AutoSize = true;
            this.ultimo_año.Location = new System.Drawing.Point(218, 20);
            this.ultimo_año.Name = "ultimo_año";
            this.ultimo_año.Size = new System.Drawing.Size(64, 17);
            this.ultimo_año.TabIndex = 8;
            this.ultimo_año.Text = "Ult. Año";
            this.ultimo_año.UseVisualStyleBackColor = true;
            this.ultimo_año.CheckedChanged += new System.EventHandler(this.ultimo_año_CheckedChanged);
            // 
            // ultimo_mes
            // 
            this.ultimo_mes.AutoSize = true;
            this.ultimo_mes.Location = new System.Drawing.Point(147, 20);
            this.ultimo_mes.Name = "ultimo_mes";
            this.ultimo_mes.Size = new System.Drawing.Size(65, 17);
            this.ultimo_mes.TabIndex = 7;
            this.ultimo_mes.Text = "Últ. Mes";
            this.ultimo_mes.UseVisualStyleBackColor = true;
            this.ultimo_mes.CheckedChanged += new System.EventHandler(this.ultimo_mes_CheckedChanged);
            // 
            // ultima_semana
            // 
            this.ultima_semana.AutoSize = true;
            this.ultima_semana.Location = new System.Drawing.Point(59, 20);
            this.ultima_semana.Name = "ultima_semana";
            this.ultima_semana.Size = new System.Drawing.Size(82, 17);
            this.ultima_semana.TabIndex = 6;
            this.ultima_semana.Text = "Últ. semana";
            this.ultima_semana.UseVisualStyleBackColor = true;
            this.ultima_semana.CheckedChanged += new System.EventHandler(this.ultima_semana_CheckedChanged_1);
            // 
            // hoy
            // 
            this.hoy.AutoSize = true;
            this.hoy.Checked = true;
            this.hoy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hoy.Location = new System.Drawing.Point(7, 20);
            this.hoy.Name = "hoy";
            this.hoy.Size = new System.Drawing.Size(45, 17);
            this.hoy.TabIndex = 5;
            this.hoy.Text = "Hoy";
            this.hoy.UseVisualStyleBackColor = true;
            this.hoy.CheckedChanged += new System.EventHandler(this.hoy_CheckedChanged_1);
            // 
            // text
            // 
            this.text.AccessibleName = "texto";
            this.text.Location = new System.Drawing.Point(269, 17);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(100, 20);
            this.text.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Texto";
            // 
            // cliente
            // 
            this.cliente.AccessibleName = "cliente";
            this.cliente.Location = new System.Drawing.Point(73, 20);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(100, 20);
            this.cliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // llistatComandesVentaGrid
            // 
            this.llistatComandesVentaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.llistatComandesVentaGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.llistatComandesVentaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.llistatComandesVentaGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llistatComandesVentaGrid.Location = new System.Drawing.Point(0, 130);
            this.llistatComandesVentaGrid.Name = "llistatComandesVentaGrid";
            this.llistatComandesVentaGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.llistatComandesVentaGrid.Size = new System.Drawing.Size(993, 320);
            this.llistatComandesVentaGrid.TabIndex = 2;
            this.llistatComandesVentaGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.llistatComandesVentaGrid_CellContentClick);
            // 
            // todo
            // 
            this.todo.AutoSize = true;
            this.todo.Location = new System.Drawing.Point(283, 18);
            this.todo.Name = "todo";
            this.todo.Size = new System.Drawing.Size(51, 17);
            this.todo.TabIndex = 9;
            this.todo.Text = "Todo";
            this.todo.UseVisualStyleBackColor = true;
            // 
            // OfertasVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 450);
            this.Controls.Add(this.llistatComandesVentaGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "OfertasVenta";
            this.Text = "Ofertas de venta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.llistatComandesVentaGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label debug_label;
        private System.Windows.Forms.Label entorn_label;
        private System.Windows.Forms.TextBox referencia;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ultimo_año;
        private System.Windows.Forms.CheckBox ultimo_mes;
        private System.Windows.Forms.CheckBox ultima_semana;
        private System.Windows.Forms.CheckBox hoy;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView llistatComandesVentaGrid;
        private System.Windows.Forms.CheckBox todo;
    }
}

