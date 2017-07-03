namespace SeguridadVialInventario
{
    partial class AgregarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProveedor));
            this.label8 = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_AgregarProveedor = new System.Windows.Forms.Button();
            this.cb_estatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(76, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 24);
            this.label8.TabIndex = 46;
            this.label8.Text = "Agregar Proveedor";
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.Gray;
            this.btn_regresar.FlatAppearance.BorderSize = 3;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_regresar.Image")));
            this.btn_regresar.Location = new System.Drawing.Point(27, 19);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(35, 29);
            this.btn_regresar.TabIndex = 5;
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_AgregarProveedor
            // 
            this.btn_AgregarProveedor.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_AgregarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_AgregarProveedor.FlatAppearance.BorderSize = 3;
            this.btn_AgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarProveedor.Image")));
            this.btn_AgregarProveedor.Location = new System.Drawing.Point(271, 190);
            this.btn_AgregarProveedor.Name = "btn_AgregarProveedor";
            this.btn_AgregarProveedor.Size = new System.Drawing.Size(71, 62);
            this.btn_AgregarProveedor.TabIndex = 4;
            this.btn_AgregarProveedor.UseVisualStyleBackColor = false;
            this.btn_AgregarProveedor.Click += new System.EventHandler(this.btn_AgregarProveedor_Click);
            // 
            // cb_estatus
            // 
            this.cb_estatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estatus.FormattingEnabled = true;
            this.cb_estatus.Items.AddRange(new object[] {
            "A"});
            this.cb_estatus.Location = new System.Drawing.Point(207, 89);
            this.cb_estatus.Name = "cb_estatus";
            this.cb_estatus.Size = new System.Drawing.Size(136, 24);
            this.cb_estatus.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(203, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Estatus";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "RFC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(203, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nombre";
            // 
            // txt_rfc
            // 
            this.txt_rfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rfc.Location = new System.Drawing.Point(27, 157);
            this.txt_rfc.Multiline = true;
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(159, 28);
            this.txt_rfc.TabIndex = 2;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(206, 157);
            this.txt_telefono.Multiline = true;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(136, 27);
            this.txt_telefono.TabIndex = 3;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(27, 90);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(159, 27);
            this.txt_nombre.TabIndex = 0;
            // 
            // AgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(367, 271);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_AgregarProveedor);
            this.Controls.Add(this.cb_estatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_rfc);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_nombre);
            this.Name = "AgregarProveedor";
            this.Text = "AgregarProveedor";
            this.Load += new System.EventHandler(this.AgregarProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_AgregarProveedor;
        private System.Windows.Forms.ComboBox cb_estatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_nombre;
    }
}