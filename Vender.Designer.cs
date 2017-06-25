namespace SeguridadVialInventario
{
    partial class Vender
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Producto = new System.Windows.Forms.ComboBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Vender = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.dgv_vender = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vender)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "______";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total:";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cantidad.Location = new System.Drawing.Point(357, 106);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(140, 24);
            this.txt_Cantidad.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Producto:";
            // 
            // cb_Producto
            // 
            this.cb_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Producto.FormattingEnabled = true;
            this.cb_Producto.Location = new System.Drawing.Point(179, 104);
            this.cb_Producto.Name = "cb_Producto";
            this.cb_Producto.Size = new System.Drawing.Size(140, 26);
            this.cb_Producto.TabIndex = 11;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.Color.Blue;
            this.btn_Calcular.FlatAppearance.BorderSize = 3;
            this.btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(143, 255);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(140, 35);
            this.btn_Calcular.TabIndex = 22;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Comprar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Vender";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_Cancelar.FlatAppearance.BorderSize = 3;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(292, 255);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(99, 35);
            this.btn_Cancelar.TabIndex = 24;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click_1);
            // 
            // btn_Vender
            // 
            this.btn_Vender.BackColor = System.Drawing.Color.Green;
            this.btn_Vender.FlatAppearance.BorderSize = 3;
            this.btn_Vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Vender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vender.Location = new System.Drawing.Point(397, 255);
            this.btn_Vender.Name = "btn_Vender";
            this.btn_Vender.Size = new System.Drawing.Size(99, 35);
            this.btn_Vender.TabIndex = 25;
            this.btn_Vender.Text = "Vender";
            this.btn_Vender.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cliente:";
            // 
            // cb_cliente
            // 
            this.cb_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.Location = new System.Drawing.Point(18, 104);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(140, 26);
            this.cb_cliente.TabIndex = 27;
            // 
            // dgv_vender
            // 
            this.dgv_vender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vender.Location = new System.Drawing.Point(8, 139);
            this.dgv_vender.Name = "dgv_vender";
            this.dgv_vender.Size = new System.Drawing.Size(489, 70);
            this.dgv_vender.TabIndex = 28;
            // 
            // Vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 299);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_vender);
            this.Controls.Add(this.cb_cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Vender);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Producto);
            this.Name = "Vender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vender";
            this.Load += new System.EventHandler(this.Vender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Producto;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Vender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_cliente;
        private System.Windows.Forms.DataGridView dgv_vender;
    }
}