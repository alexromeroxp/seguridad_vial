using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SeguridadVialInventario
{
    public partial class Vender : Form
    {
        conexion con = new conexion();
        List<string> id_producto = new List<string>();
        List<string> id_cliente = new List<string>();
        List<string> cantidad = new List<string>();
        List<float> total = new List<float>();
        List<string> fecha_venta = new List<string>();
        DAOProductos precio_vent = new DAOProductos();
        DAOVender id_venta = new DAOVender();
        public float totall;
        public float totalll;
        public int bandera = 1;

        public Vender()
        {
            InitializeComponent();
        }

        private void Vender_Load(object sender, EventArgs e)
        {
            if (con.Abrirconexion() == true)
            {
                MySqlCommand cmd = new MySqlCommand("Select * from clientes", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);


                cb_cliente.ValueMember = "id_cliente";

                cb_cliente.DisplayMember = "id_cliente";
                cb_cliente.DataSource = dt;
                MySqlCommand cmd1 = new MySqlCommand("Select * from productos", con.con);
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);


                cb_Producto.ValueMember = "id_producto";

                cb_Producto.DisplayMember = "id_producto";
                cb_Producto.DataSource = dt1;
                

            }
            con.Cerrarconexion();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            id_producto.Add(cb_Producto.Text);
            id_cliente.Add(cb_cliente.Text);
            DateTime localDate = DateTime.Now;
            fecha_venta.Add(localDate.ToString());
            id_producto.Add(cb_Producto.Text);
            cantidad.Add(txt_Cantidad.Text);
            precio_vent.precio_venta = float.Parse(cb_Producto.Text);
            try
            {
                if (con.Abrirconexion() == true)
                {
                   DAOProductos.BuscarPrecio(con.con, precio_vent);
                    con.Cerrarconexion();

                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            totall = precio_vent.precio_venta * int.Parse(txt_Cantidad.Text);
            total.Add(totall);
            totalll = totalll + totall;
            dgv_vender.Rows.Add(cb_cliente.Text, cb_Producto.Text,txt_Cantidad.Text,totalll);
            lbl_total.Text = totalll.ToString();
            
        }

        private void btn_Vender_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seguro que desea realizar la venta?", "Confirmación Venta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                try
                {
                    if (con.Abrirconexion() == true)
                    {
                        DAOVender Vender = new DAOVender();

                        for (int i = 0; i < id_cliente.Count; i++)
                        {

                            if (i == 1)
                            {
                                id_venta.id = DAOVender.Buscarid(con.con);
                                Vender.id = id_venta.id;


                            }



                            Vender.id_cliente = int.Parse(id_cliente[i]);
                            Vender.id_producto = int.Parse(id_producto[i]);
                            Vender.cantidad = int.Parse(cantidad[i]);
                            if (total[i] == total.Count-1)
                            {
                                Vender.total = totalll;

                            }else
                            {
                                Vender.total = total[i];
                            }
                            Vender.fecha_venta =fecha_venta[i] ;
                            int resultado = DAOVender.Agregar(con.con, Vender);

                        }






                    }
                   
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {

                    MessageBox.Show(ex.Message);
                }

                this.Close();
              

                Catalogos.formulario.Vender = null;
                con.Cerrarconexion();
            }
        }
    }
}
