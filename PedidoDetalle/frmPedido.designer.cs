namespace PedidoDetalle
{
    partial class frmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_buscar_cliente = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.txt_n_clientes = new System.Windows.Forms.TextBox();
            this.txt_id_clientes = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.txt_total = new System.Windows.Forms.MaskedTextBox();
            this.txt_decuento = new System.Windows.Forms.MaskedTextBox();
            this.txt_sub_total = new System.Windows.Forms.MaskedTextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_agregar_grilla = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.txt_Subtotal = new System.Windows.Forms.MaskedTextBox();
            this.txt_precio = new System.Windows.Forms.MaskedTextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txt_pedido = new System.Windows.Forms.MaskedTextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscar_cliente
            // 
            this.btn_buscar_cliente.Location = new System.Drawing.Point(383, 53);
            this.btn_buscar_cliente.Name = "btn_buscar_cliente";
            this.btn_buscar_cliente.Size = new System.Drawing.Size(32, 23);
            this.btn_buscar_cliente.TabIndex = 29;
            this.btn_buscar_cliente.Text = ". . .";
            this.btn_buscar_cliente.UseVisualStyleBackColor = true;
            this.btn_buscar_cliente.Click += new System.EventHandler(this.btn_buscar_cliente_Click);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(57, 58);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(44, 13);
            this.Label11.TabIndex = 28;
            this.Label11.Text = "Clientes";
            // 
            // txt_n_clientes
            // 
            this.txt_n_clientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_n_clientes.Enabled = false;
            this.txt_n_clientes.Location = new System.Drawing.Point(170, 55);
            this.txt_n_clientes.Name = "txt_n_clientes";
            this.txt_n_clientes.Size = new System.Drawing.Size(207, 20);
            this.txt_n_clientes.TabIndex = 4;
            // 
            // txt_id_clientes
            // 
            this.txt_id_clientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_clientes.Location = new System.Drawing.Point(106, 55);
            this.txt_id_clientes.Name = "txt_id_clientes";
            this.txt_id_clientes.Size = new System.Drawing.Size(58, 20);
            this.txt_id_clientes.TabIndex = 3;
            this.txt_id_clientes.TextChanged += new System.EventHandler(this.txt_id_clientes_TextChanged);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btn_salir);
            this.GroupBox2.Controls.Add(this.btn_grabar);
            this.GroupBox2.Controls.Add(this.btn_nuevo);
            this.GroupBox2.Location = new System.Drawing.Point(6, 375);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(371, 54);
            this.GroupBox2.TabIndex = 22;
            this.GroupBox2.TabStop = false;
            // 
            // btn_salir
            // 
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.Location = new System.Drawing.Point(327, 13);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(35, 35);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_grabar
            // 
            this.btn_grabar.Image = ((System.Drawing.Image)(resources.GetObject("btn_grabar.Image")));
            this.btn_grabar.Location = new System.Drawing.Point(49, 13);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(35, 35);
            this.btn_grabar.TabIndex = 1;
            this.btn_grabar.UseVisualStyleBackColor = true;
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.Image")));
            this.btn_nuevo.Location = new System.Drawing.Point(10, 13);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(35, 35);
            this.btn_nuevo.TabIndex = 0;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // txt_total
            // 
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total.Location = new System.Drawing.Point(450, 409);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(58, 20);
            this.txt_total.TabIndex = 25;
            this.txt_total.Text = "0";
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_decuento
            // 
            this.txt_decuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_decuento.Location = new System.Drawing.Point(450, 386);
            this.txt_decuento.Name = "txt_decuento";
            this.txt_decuento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_decuento.Size = new System.Drawing.Size(58, 20);
            this.txt_decuento.TabIndex = 24;
            this.txt_decuento.Text = "0";
            this.txt_decuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_decuento.TextChanged += new System.EventHandler(this.txt_decuento_TextChanged);
            // 
            // txt_sub_total
            // 
            this.txt_sub_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sub_total.Location = new System.Drawing.Point(450, 363);
            this.txt_sub_total.Name = "txt_sub_total";
            this.txt_sub_total.ReadOnly = true;
            this.txt_sub_total.Size = new System.Drawing.Size(58, 20);
            this.txt_sub_total.TabIndex = 23;
            this.txt_sub_total.Text = "0";
            this.txt_sub_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.comboBox1);
            this.GroupBox1.Controls.Add(this.txt_cantidad);
            this.GroupBox1.Controls.Add(this.grdDetalle);
            this.GroupBox1.Controls.Add(this.btn_agregar_grilla);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.lbl_1);
            this.GroupBox1.Controls.Add(this.txt_Subtotal);
            this.GroupBox1.Controls.Add(this.txt_precio);
            this.GroupBox1.Enabled = false;
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GroupBox1.Location = new System.Drawing.Point(6, 83);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(504, 272);
            this.GroupBox1.TabIndex = 21;
            this.GroupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cantidad.Location = new System.Drawing.Point(100, 44);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(58, 20);
            this.txt_cantidad.TabIndex = 9;
            this.txt_cantidad.TextChanged += new System.EventHandler(this.txt_cantidad_TextChanged);
            // 
            // grdDetalle
            // 
            this.grdDetalle.AllowUserToAddRows = false;
            this.grdDetalle.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grdDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.grdDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Id,
            this.Articulo,
            this.Precio,
            this.Subtotal});
            this.grdDetalle.Location = new System.Drawing.Point(7, 70);
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.RowHeadersWidth = 20;
            this.grdDetalle.Size = new System.Drawing.Size(490, 190);
            this.grdDetalle.TabIndex = 7;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle12;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 70;
            // 
            // Id
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Id.DefaultCellStyle = dataGridViewCellStyle13;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Artículo";
            this.Articulo.Name = "Articulo";
            this.Articulo.Width = 200;
            // 
            // Precio
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle14;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 62;
            // 
            // Subtotal
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = null;
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle15;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Width = 70;
            // 
            // btn_agregar_grilla
            // 
            this.btn_agregar_grilla.Location = new System.Drawing.Point(423, 41);
            this.btn_agregar_grilla.Name = "btn_agregar_grilla";
            this.btn_agregar_grilla.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar_grilla.TabIndex = 6;
            this.btn_agregar_grilla.Text = "Agregar";
            this.btn_agregar_grilla.UseVisualStyleBackColor = true;
            this.btn_agregar_grilla.Click += new System.EventHandler(this.btn_agregar_grilla_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(51, 22);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(44, 13);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Artículo";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(294, 46);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(31, 13);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Total";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(176, 46);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(37, 13);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Precio";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(46, 46);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(49, 13);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "Cantidad";
            // 
            // txt_Subtotal
            // 
            this.txt_Subtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Subtotal.Enabled = false;
            this.txt_Subtotal.Location = new System.Drawing.Point(337, 44);
            this.txt_Subtotal.Name = "txt_Subtotal";
            this.txt_Subtotal.Size = new System.Drawing.Size(58, 20);
            this.txt_Subtotal.TabIndex = 5;
            this.txt_Subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_precio
            // 
            this.txt_precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_precio.Location = new System.Drawing.Point(219, 44);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(58, 20);
            this.txt_precio.TabIndex = 4;
            this.txt_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(407, 411);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(31, 13);
            this.Label10.TabIndex = 17;
            this.Label10.Text = "Total";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(384, 388);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(54, 13);
            this.Label9.TabIndex = 16;
            this.Label9.Text = "Decuento";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(388, 365);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(50, 13);
            this.Label8.TabIndex = 15;
            this.Label8.Text = "SubTotal";
            // 
            // txt_pedido
            // 
            this.txt_pedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pedido.Enabled = false;
            this.txt_pedido.Location = new System.Drawing.Point(106, 16);
            this.txt_pedido.Name = "txt_pedido";
            this.txt_pedido.Size = new System.Drawing.Size(58, 20);
            this.txt_pedido.TabIndex = 2;
            this.txt_pedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(40, 20);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(60, 13);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "Nro Pedido";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(370, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(37, 13);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(413, 16);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(95, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(421, 52);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 30;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 440);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btn_buscar_cliente);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.txt_n_clientes);
            this.Controls.Add(this.txt_id_clientes);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_decuento);
            this.Controls.Add(this.txt_sub_total);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txt_pedido);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Name = "frmPedido";
            this.Text = "Orden de pedido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPedido_FormClosing);
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_buscar_cliente;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txt_n_clientes;
        internal System.Windows.Forms.TextBox txt_id_clientes;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btn_salir;
        internal System.Windows.Forms.Button btn_grabar;
        internal System.Windows.Forms.Button btn_nuevo;
        internal System.Windows.Forms.MaskedTextBox txt_total;
        internal System.Windows.Forms.MaskedTextBox txt_decuento;
        internal System.Windows.Forms.MaskedTextBox txt_sub_total;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DataGridView grdDetalle;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Id;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        internal System.Windows.Forms.Button btn_agregar_grilla;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label lbl_1;
        internal System.Windows.Forms.MaskedTextBox txt_Subtotal;
        internal System.Windows.Forms.MaskedTextBox txt_precio;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.MaskedTextBox txt_pedido;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        internal System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnConfirmar;
    }
}

