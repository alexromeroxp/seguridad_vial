namespace SeguridadVialInventario
{
    partial class AgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_precio_compra = new System.Windows.Forms.TextBox();
            this.txt_precio_venta = new System.Windows.Forms.TextBox();
            this.txt_stock_maximo = new System.Windows.Forms.TextBox();
            this.txt_stock_minimo = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_proveedor = new System.Windows.Forms.ComboBox();
            this.btn_AgregarProducto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // txt_precio_compra
            // 
            this.txt_precio_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_compra.Location = new System.Drawing.Point(191, 150);
            this.txt_precio_compra.Multiline = true;
            this.txt_precio_compra.Name = "txt_precio_compra";
            this.txt_precio_compra.Size = new System.Drawing.Size(136, 27);
            this.txt_precio_compra.TabIndex = 1;
            this.txt_precio_compra.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_precio_venta
            // 
            this.txt_precio_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_venta.Location = new System.Drawing.Point(12, 150);
            this.txt_precio_venta.Multiline = true;
            this.txt_precio_venta.Name = "txt_precio_venta";
            this.txt_precio_venta.Size = new System.Drawing.Size(159, 28);
            this.txt_precio_venta.TabIndex = 3;
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
            // txt_stock_minimo
            // 
            this.txt_stock_minimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock_minimo.Location = new System.Drawing.Point(191, 224);
            this.txt_stock_minimo.Multiline = true;
            this.txt_stock_minimo.Name = "txt_stock_minimo";
            this.txt_stock_minimo.Size = new System.Drawing.Size(136, 29);
            this.txt_stock_minimo.TabIndex = 5;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Precio de Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio de Venta";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stock Minimo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Stock Maximo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cb_proveedor
            // 
            this.cb_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_proveedor.FormattingEnabled = true;
            this.cb_proveedor.Location = new System.Drawing.Point(192, 82);
            this.cb_proveedor.Name = "cb_proveedor";
            this.cb_proveedor.Size = new System.Drawing.Size(136, 24);
            this.cb_proveedor.TabIndex = 15;
            // 
            // btn_AgregarProducto
            // 
            this.btn_AgregarProducto.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_AgregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_AgregarProducto.FlatAppearance.BorderSize = 3;
            this.btn_AgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarProducto.Image")));
            this.btn_AgregarProducto.Location = new System.Drawing.Point(192, 278);
            this.btn_AgregarProducto.Name = "btn_AgregarProducto";
            this.btn_AgregarProducto.Size = new System.Drawing.Size(56, 46);
            this.btn_AgregarProducto.TabIndex = 16;
            this.btn_AgregarProducto.UseVisualStyleBackColor = false;
            this.btn_AgregarProducto.Click += new System.EventHandler(this.btn_AgregarProducto_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 29);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Agregar Producto";
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 382);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_AgregarProducto);
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
            this.Name = "AgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarProducto";
            this.Load += new System.EventHandler(this.AgregarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_precio_compra;
        private System.Windows.Forms.TextBox txt_precio_venta;
        private System.Windows.Forms.TextBox txt_stock_maximo;
        private System.Windows.Forms.TextBox txt_stock_minimo;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_proveedor;
        private System.Windows.Forms.Button btn_AgregarProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}