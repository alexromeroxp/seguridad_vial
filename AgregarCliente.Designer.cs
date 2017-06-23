namespace SeguridadVialInventario
{
    partial class AgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCliente));
            this.label8 = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_AgregarCliente = new System.Windows.Forms.Button();
            this.cb_credito = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 24);
            this.label8.TabIndex = 35;
            this.label8.Text = "Agregar Cliente";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.Gray;
            this.btn_regresar.FlatAppearance.BorderSize = 3;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_regresar.Image")));
            this.btn_regresar.Location = new System.Drawing.Point(11, 10);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(35, 29);
            this.btn_regresar.TabIndex = 34;
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_AgregarCliente
            // 
            this.btn_AgregarCliente.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_AgregarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_AgregarCliente.FlatAppearance.BorderSize = 3;
            this.btn_AgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarCliente.Image")));
            this.btn_AgregarCliente.Location = new System.Drawing.Point(270, 197);
            this.btn_AgregarCliente.Name = "btn_AgregarCliente";
            this.btn_AgregarCliente.Size = new System.Drawing.Size(56, 46);
            this.btn_AgregarCliente.TabIndex = 33;
            this.btn_AgregarCliente.UseVisualStyleBackColor = false;
            this.btn_AgregarCliente.Click += new System.EventHandler(this.btn_AgregarCliente_Click);
            // 
            // cb_credito
            // 
            this.cb_credito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_credito.FormattingEnabled = true;
            this.cb_credito.Location = new System.Drawing.Point(191, 80);
            this.cb_credito.Name = "cb_credito";
            this.cb_credito.Size = new System.Drawing.Size(136, 24);
            this.cb_credito.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Credito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Telefono";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nombre";
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidos.Location = new System.Drawing.Point(11, 148);
            this.txt_apellidos.Multiline = true;
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(159, 28);
            this.txt_apellidos.TabIndex = 21;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(190, 148);
            this.txt_telefono.Multiline = true;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(136, 27);
            this.txt_telefono.TabIndex = 20;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(11, 81);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(159, 27);
            this.txt_nombre.TabIndex = 19;
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 257);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_AgregarCliente);
            this.Controls.Add(this.cb_credito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_apellidos);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_nombre);
            this.Name = "AgregarCliente";
            this.Text = "AgregarCliente";
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_AgregarCliente;
        private System.Windows.Forms.ComboBox cb_credito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_nombre;
    }
}