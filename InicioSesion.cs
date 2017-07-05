using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
            DateTimePicker factual = new DateTimePicker();
            string theDate = factual.Value.ToShortDateString();
            MessageBox.Show("El Sistema no lo dejara Entrar a partir del 01/09/2017");
            var macAddr =
            (
            from nic in NetworkInterface.GetAllNetworkInterfaces()
            where nic.OperationalStatus == OperationalStatus.Up
            select nic.GetPhysicalAddress().ToString()
            ).FirstOrDefault();
            if (txt_User.Text=="Admin" && txt_Pass.Text=="123" && macAddr == "303A6499AE8A" && factual.Value.Month<9 && factual.Value.Year==2017)
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
