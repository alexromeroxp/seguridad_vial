using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeguridadVialInventario
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_User.Text=="Admin" && txt_Pass.Text=="123")
            {
                Catalogos c = new Catalogos();
                c.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta..");
            }
        }
    }
}
