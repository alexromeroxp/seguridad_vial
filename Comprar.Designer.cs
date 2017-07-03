namespace SeguridadVialInventario
{
    partial class Comprar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvComprar = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_filtrar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_comprar
            // 
            this.btn_comprar.BackColor = System.Drawing.Color.Green;
            this.btn_comprar.FlatAppearance.BorderSize = 3;
            this.btn_comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprar.Image = ((System.Drawing.Image)(resources.GetObject("btn_comprar.Image")));
            this.btn_comprar.Location = new System.Drawing.Point(472, 282);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(74, 65);
            this.btn_comprar.TabIndex = 5;
            this.btn_comprar.UseVisualStyleBackColor = false;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_Cancelar.FlatAppearance.BorderSize = 3;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.Location = new System.Drawing.Point(392, 282);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(74, 65);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 37;
            this.label1.Text = "Comprar";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.Color.Blue;
            this.btn_Calcular.FlatAppearance.BorderSize = 3;
            this.btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Image = ((System.Drawing.Image)(resources.GetObject("btn_Calcular.Image")));
            this.btn_Calcular.Location = new System.Drawing.Point(469, 114);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(74, 80);
            this.btn_Calcular.TabIndex = 3;
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(449, 248);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(62, 18);
            this.lbl_total.TabIndex = 33;
            this.lbl_total.Text = "______";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(392, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Total:";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cantidad.Location = new System.Drawing.Point(392, 84);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(151, 24);
            this.txt_Cantidad.TabIndex = 2;
            this.txt_Cantidad.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(389, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cantidad:";
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
            this.button1.TabIndex = 41;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvComprar
            // 
            this.dgvComprar.AllowUserToAddRows = false;
            this.dgvComprar.AllowUserToDeleteRows = false;
            this.dgvComprar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComprar.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComprar.Location = new System.Drawing.Point(12, 47);
            this.dgvComprar.MultiSelect = false;
            this.dgvComprar.Name = "dgvComprar";
            this.dgvComprar.ReadOnly = true;
            this.dgvComprar.Size = new System.Drawing.Size(374, 309);
            this.dgvComprar.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(522, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // txt_filtrar
            // 
            this.txt_filtrar.BackColor = System.Drawing.Color.White;
            this.txt_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtrar.Location = new System.Drawing.Point(392, 21);
            this.txt_filtrar.Name = "txt_filtrar";
            this.txt_filtrar.Size = new System.Drawing.Size(130, 22);
            this.txt_filtrar.TabIndex = 43;
            this.txt_filtrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_filtrar_KeyDown);
            // 
            // Comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(558, 359);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_filtrar);
            this.Controls.Add(this.dgvComprar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.label4);
            this.Name = "Comprar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar";
            this.Load += new System.EventHandler(this.Comprar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvComprar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_filtrar;
    }
}