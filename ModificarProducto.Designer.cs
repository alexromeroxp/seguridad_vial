namespace SeguridadVialInventario
{
    partial class ModificarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarProducto));
            this.label8 = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_modificarproducto = new System.Windows.Forms.Button();
            this.cb_proveedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_stock_minimo = new System.Windows.Forms.TextBox();
            this.txt_stock_maximo = new System.Windows.Forms.TextBox();
            this.txt_precio_venta = new System.Windows.Forms.TextBox();
            this.txt_precio_compra = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_estatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(61, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 24);
            this.label8.TabIndex = 35;
            this.label8.Text = "Modificar Producto";
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.Gray;
            this.btn_regresar.FlatAppearance.BorderSize = 3;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_regresar.Image")));
            this.btn_regresar.Location = new System.Drawing.Point(12, 12);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(35, 29);
            this.btn_regresar.TabIndex = 9;
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_modificarproducto
            // 
            this.btn_modificarproducto.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_modificarproducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_modificarproducto.FlatAppearance.BorderSize = 3;
            this.btn_modificarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificarproducto.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificarproducto.Image")));
            this.btn_modificarproducto.Location = new System.Drawing.Point(288, 322);
            this.btn_modificarproducto.Name = "btn_modificarproducto";
            this.btn_modificarproducto.Size = new System.Drawing.Size(61, 60);
            this.btn_modificarproducto.TabIndex = 8;
            this.btn_modificarproducto.UseVisualStyleBackColor = false;
            this.btn_modificarproducto.Click += new System.EventHandler(this.btn_modificarproducto_Click);
            // 
            // cb_proveedor
            // 
            this.cb_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_proveedor.FormattingEnabled = true;
            this.cb_proveedor.Location = new System.Drawing.Point(192, 82);
            this.cb_proveedor.Name = "cb_proveedor";
            this.cb_proveedor.Size = new System.Drawing.Size(158, 24);
            this.cb_proveedor.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Stock Maximo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(188, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Stock Minimo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(188, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Precio de Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(188, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Precio de Compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nombre";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(12, 292);
            this.txt_cantidad.Multiline = true;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(159, 29);
            this.txt_cantidad.TabIndex = 6;
            // 
            // txt_stock_minimo
            // 
            this.txt_stock_minimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock_minimo.Location = new System.Drawing.Point(191, 224);
            this.txt_stock_minimo.Multiline = true;
            this.txt_stock_minimo.Name = "txt_stock_minimo";
            this.txt_stock_minimo.Size = new System.Drawing.Size(159, 29);
            this.txt_stock_minimo.TabIndex = 5;
            // 
            // txt_stock_maximo
            // 
            this.txt_stock_maximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock_maximo.Location = new System.Drawing.Point(12, 227);
            this.txt_stock_maximo.Multiline = true;
            this.txt_stock_maximo.Name = "txt_stock_maximo";
            this.txt_stock_maximo.Size = new System.Drawing.Size(159, 27);
            this.txt_stock_maximo.TabIndex = 4;
            // 
            // txt_precio_venta
            // 
            this.txt_precio_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_venta.Location = new System.Drawing.Point(12, 150);
            this.txt_precio_venta.Multiline = true;
            this.txt_precio_venta.Name = "txt_precio_venta";
            this.txt_precio_venta.Size = new System.Drawing.Size(120, 28);
            this.txt_precio_venta.TabIndex = 2;
            // 
            // txt_precio_compra
            // 
            this.txt_precio_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_compra.Location = new System.Drawing.Point(191, 150);
            this.txt_precio_compra.Multiline = true;
            this.txt_precio_compra.Name = "txt_precio_compra";
            this.txt_precio_compra.Size = new System.Drawing.Size(113, 27);
            this.txt_precio_compra.TabIndex = 3;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(12, 83);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(159, 27);
            this.txt_nombre.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(191, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Status";
            // 
            // cb_estatus
            // 
            this.cb_estatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estatus.FormattingEnabled = true;
            this.cb_estatus.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cb_estatus.Location = new System.Drawing.Point(191, 292);
            this.cb_estatus.Name = "cb_estatus";
            this.cb_estatus.Size = new System.Drawing.Size(158, 24);
            this.cb_estatus.TabIndex = 7;
            this.cb_estatus.SelectedIndexChanged += new System.EventHandler(this.cb_estatus_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(310, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 24);
            this.label11.TabIndex = 39;
            this.label11.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(138, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 24);
            this.label10.TabIndex = 39;
            this.label10.Text = "$";
            // 
            // ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(371, 389);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cb_estatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_modificarproducto);
            this.Controls.Add(this.cb_proveedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_stock_minimo);
            this.Controls.Add(this.txt_stock_maximo);
            this.Controls.Add(this.txt_precio_venta);
            this.Controls.Add(this.txt_precio_compra);
            this.Controls.Add(this.txt_nombre);
            this.Name = "ModificarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarProducto";
            this.Load += new System.EventHandler(this.ModificarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_modificarproducto;
        private System.Windows.Forms.ComboBox cb_proveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_stock_minimo;
        private System.Windows.Forms.TextBox txt_stock_maximo;
        private System.Windows.Forms.TextBox txt_precio_venta;
        private System.Windows.Forms.TextBox txt_precio_compra;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_estatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}