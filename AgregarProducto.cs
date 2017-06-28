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
    public partial class AgregarProducto : Form
    {
        conexion con = new conexion();
        DAOProveedores nombre_proveedor = new DAOProveedores();
        public AgregarProducto()
        {
            InitializeComponent();
            Catalogos.formulario.AgregarProducto = this;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AgregarProducto_Load(object sender, EventArgs e)
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

                ;
            }
            con.Cerrarconexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Catalogos.formulario.Productos.Show();
        }

        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Seguro que desea Agregar?", "Confirmación Agregar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {


                    try
                    {
                        if (con.Abrirconexion() == true)
                        {

                            DAOProductos Producto = new DAOProductos();
                            Producto.nombre = txt_nombre.Text;
                            nombre_proveedor.nombre = cb_proveedor.Text;
                            DAOProveedores.Buscarid(con.con, nombre_proveedor);
                            Producto.id_proveedor = nombre_proveedor.id;
                            Producto.precio_compra =float.Parse( txt_precio_compra.Text);
                            Producto.precio_venta = float.Parse(txt_precio_venta.Text);
                            Producto.stock_minimo = int.Parse(txt_stock_minimo.Text);
                            Producto.stock_maximo = int.Parse(txt_stock_maximo.Text);

                            Producto.cantidad = int.Parse(txt_cantidad.Text);



                            int resultado = DAOProductos.Agregar(con.con, Producto);

                            if (resultado > 0)
                            {
                                txt_nombre.Clear();
                                txt_precio_compra.Clear();
                                txt_precio_venta.Clear();
                                txt_stock_maximo.Clear();
                                txt_stock_minimo.Clear();
                                txt_cantidad.Clear();

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
                   // Catalogos.formulario.Productos.Show();

                    //Catalogos.formulario.Productos.ListarProductos(con.con, "");
                    
                    
                    con.Cerrarconexion();
                }
            }
        }
    }
}
