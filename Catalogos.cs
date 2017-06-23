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
    public partial class Catalogos : Form
    {
        public Catalogos()
        {
            InitializeComponent();
            Catalogos.formulario.Catalogos = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Productos p = new Productos();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btn_Vender_Click(object sender, EventArgs e)
        {
            Vender V = new Vender();
            V.Show();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            Clientes client = new Clientes();
            client.Show();
        }

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Proveedores prov = new Proveedores();
            prov.Show();
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            Comprar ven = new Comprar();
            ven.Show();
        }

        private void btn_Movimientos_Click(object sender, EventArgs e)
        {
            Movimientos mov = new Movimientos();
            mov.Show();
        }

        private void Catalogos_Load(object sender, EventArgs e)
        {

        }
        public static class formulario
        {
            public static Catalogos Catalogos;
            public static Clientes Clientes;
            public static Comprar Comprar;
            public static AgregarProducto AgregarProducto;
            public static ModificarProducto ModificarProducto;
            public static Movimientos Movimientos;
            public static Productos Productos;
            public static Proveedores Proveedores;
            public static Vender Vender;
            public static AgregarCliente AgregarCliente;
            public static ModificarCliente ModificarCliente;
            public static ModificarProveedor ModificarProveedor;
            public static AgregarProveedor AgregarProveedor;


        }
    }
}
