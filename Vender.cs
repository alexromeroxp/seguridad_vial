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
        DAOProductos producto = new DAOProductos();
        DAOClientes cliente = new DAOClientes();
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


                cb_cliente.ValueMember = "nombre";

                cb_cliente.DisplayMember = "nombre";
                cb_cliente.DataSource = dt;
                MySqlCommand cmd1 = new MySqlCommand("Select * from productos where estatus='A' and cantidad>0", con.con);
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);


                cb_Producto.ValueMember = "nombre";

                cb_Producto.DisplayMember = "nombre";
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
            if (txt_Cantidad.Text == "" || txt_Cantidad.Text == "0")
            {
                MessageBox.Show("Ingrese una cantidad valida!");
                txt_Cantidad.Focus();
            }
            else if (txt_Total.Text == "")
            {
                MessageBox.Show("Presione enter en el campo de 'Cantidad' para ver la cantidad en almacen..");
                txt_Cantidad.Focus();
            }
            else if (int.Parse(txt_Cantidad.Text) > int.Parse(txt_Total.Text))
            {
                MessageBox.Show("No hay suficiente en almacen..");
            }
            else
            {
                {
                    id_producto.Add(cb_Producto.Text);
                    id_cliente.Add(cb_cliente.Text);
                    DateTime localDate = DateTime.Now;
                    fecha_venta.Add(localDate.ToString());
                    cantidad.Add(txt_Cantidad.Text);
                    precio_vent.nombre = cb_Producto.Text;
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
                    dgv_vender.Rows.Add(cb_cliente.Text, cb_Producto.Text, txt_Cantidad.Text, totalll);
                    lbl_total.Text = totalll.ToString();
                }
            }
        }
        private void btn_Vender_Click(object sender, EventArgs e)
        {
            if (dgv_vender.RowCount < 2)
            {
                MessageBox.Show("Inserte un Producto");
                txt_Cantidad.Focus();
            }else
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
                                MessageBox.Show(id_producto[i]);
                                if (i == 1)
                                {
                                    id_venta.id = DAOVender.Buscarid(con.con);
                                    Vender.id = id_venta.id;
                                    id_venta.id_movimiento = DAOMovimientos.Buscarid(con.con);
                                    Vender.id_movimiento = id_venta.id_movimiento;
                                }
                                Vender.cliente = id_cliente[i];
                                Vender.producto = id_producto[i];
                                Vender.cantidad = int.Parse(cantidad[i]);
                                if (total[i] == total.Count - 1)
                                {
                                    Vender.total = totalll;
                                }
                                else
                                {
                                    Vender.total = total[i];
                                }
                                Vender.fecha_venta = fecha_venta[i];
                                int resultado = DAOVender.Agregar(con.con, Vender);
                                MessageBox.Show("Venta Almacenada!");
                                txt_Cantidad.Text = "1";
                                txt_Total.Clear();
                                dgv_vender.Rows.Clear();
                            }
                        }
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    con.Cerrarconexion();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarTotal()
        {
            try
            {
                if (con.Abrirconexion() == true)
                {
                    txt_Total.Text = DAOVender.BuscarCantidad(con.con, cb_Producto.Text).ToString();
                    con.Cerrarconexion();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txt_Cantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarTotal();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Catalogos.formulario.Vender = null;
        }
    }
}

