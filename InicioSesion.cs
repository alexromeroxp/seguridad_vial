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
using System.Management;

namespace SeguridadVialInventario
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            Catalogos.formulario.Inicio = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DateTimePicker factual = new DateTimePicker();
            string theDate = factual.Value.ToShortDateString();
            MessageBox.Show("El Sistema no lo dejara Entrar a partir del 01/09/2017");
            if (txt_User.Text=="Admin" && txt_Pass.Text=="123" && factual.Value.Month<9 && factual.Value.Year==2017)
            {
                GetComponent("Win32_BaseBoard", "SerialNumber");
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta..");
            }

            
        }
        public static void GetComponent(string hwclass, string syntax)
        {
            string serial;
            ManagementObjectSearcher nos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementObject nj in nos.Get())
            {
                serial=(nj[syntax].ToString());
                if (serial == ".8DJ6K22.CN1296648P0550.")
                {
                    Catalogos c = new Catalogos();
                    c.Show();
                    Catalogos.formulario.Inicio.Hide();
                }
                else
                {
                    MessageBox.Show("Este equipo no tiene acceso al sistema..");
                }
            }
            
            
        }
    }
}
