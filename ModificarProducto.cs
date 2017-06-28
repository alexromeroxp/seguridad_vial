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
    public partial class ModificarProducto : Form
    {
        public string cantidad;
        public string estatus;
        public string id;
        public string id_proveedor;
        public string nombre;
        public string precio_compra;
        public string precio_venta;
        public string stock_maximo;
        public string stock_minimo;
        conexion con = new conexion();
        DAOProveedores nombre_proveedor = new DAOProveedores();

        public ModificarProducto()
        {
            InitializeComponent();
            Catalogos.formulario.ModificarProducto = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Catalogos.formulario.Productos.Show();
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {
            {
                if (con.Abrirconexion() == true)
                {
                    MySqlCommand cmd = new MySqlCommand("Select * from proveedores where estatus='A'", con.con);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    cb_proveedor.ValueMember = "nombre";

                    cb_proveedor.DisplayMember = "nombre";
                    cb_proveedor.DataSource = dt;
                    cb_estatus.SelectedIndex = 0
                    ;
                }
                txt_nombre.Text = nombre;
                txt_cantidad.Text = cantidad;
                txt_precio_compra.Text = precio_compra;
                txt_precio_venta.Text = precio_venta;
                txt_stock_maximo.Text = stock_maximo;
                txt_stock_minimo.Text = stock_minimo;

                con.Cerrarconexion();
            }
        }

        private void btn_modificarproducto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Modificar?", "Confirmación Modificar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (con.Abrirconexion() == true)
                    {

                        DAOProductos Productos = new DAOProductos();

                        Productos.nombre = txt_nombre.Text;
                        Productos.cantidad = Convert.ToInt32(txt_cantidad.Text);
                        Productos.stock_minimo = Convert.ToInt32(txt_stock_minimo.Text);
                        Productos.stock_maximo = Convert.ToInt32(txt_stock_maximo.Text);

                        Productos.precio_compra = float.Parse(txt_precio_compra.Text);
                        Productos.precio_venta = float.Parse(txt_precio_venta.Text);
                        Productos.id = Convert.ToInt32(id);
                        nombre_proveedor.nombre = cb_proveedor.Text;
                        DAOProveedores.Buscarid(con.con, nombre_proveedor);
                        Productos.id_proveedor = nombre_proveedor.id;
                        Productos.estatus = Convert.ToString(cb_estatus.Text);


                        int resultado = DAOProductos.Modificar(con.con, Productos);

                        if (resultado > 0)
                        {
                            cb_estatus.Text = "";
                            cb_proveedor.Text = "";
                            txt_precio_venta.Clear();
                            txt_precio_compra.Clear();
                            txt_cantidad.Clear();
                            txt_stock_minimo.Clear();
                            txt_nombre.Clear();
                            txt_stock_maximo.Clear();
                        }


                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {

                    MessageBox.Show(ex.Message);
                }

                this.Close();
                Catalogos.formulario.Productos.Show();
                Catalogos.formulario.Productos.ListarProductos(con.con, "");

                Catalogos.formulario.AgregarProducto = null;
                con.Cerrarconexion();
            }
        }

        private void cb_estatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
