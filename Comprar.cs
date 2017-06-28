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
    public partial class Comprar : Form
    {
        conexion con = new conexion();
        DAOProductos precio_comp = new DAOProductos();
        public float total;


        public Comprar()
        {
            InitializeComponent();
            Catalogos.formulario.Comprar = this;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Comprar_Load(object sender, EventArgs e)
        {
            if (con.Abrirconexion() == true)
            {
                MySqlCommand cmd = new MySqlCommand("Select * from proveedores", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);


                cb_proveedor.ValueMember = "nombre";

                cb_proveedor.DisplayMember = "nombre";
                cb_proveedor.DataSource = dt;
                MySqlCommand cmd1 = new MySqlCommand("Select * from productos", con.con);
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
            precio_comp.nombre = cb_Producto.Text;
            try
            {
                if (con.Abrirconexion() == true)
                {
                    DAOProductos.BuscarPrecioCompra(con.con, precio_comp);
                    con.Cerrarconexion();

                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            total = int.Parse(txt_Cantidad.Text) * precio_comp.precio_compra;
            lbl_total.Text = total.ToString();
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Agregar?", "Confirmación Agregar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                try
                {
                    if (con.Abrirconexion() == true)
                    {

                        DAOComprar Comprar = new DAOComprar();
                        Comprar.proveedor = cb_proveedor.Text;
                        Comprar.producto = cb_Producto.Text;
                        Comprar.cantidad = int.Parse(txt_Cantidad.Text);
                        DateTime localDate = DateTime.Now;
                        Comprar.fecha_compra = localDate.ToString();
                        Comprar.total = total;

                        int resultado = DAOComprar.Agregar(con.con, Comprar);

                        if (resultado > 0)
                        {
                            txt_Cantidad.Clear();
                            lbl_total.Text="______";
                           
                            cb_Producto.Text = "";
                            cb_proveedor.Text = "";


                        }


                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {

                    MessageBox.Show(ex.Message);
                }

                this.Close();
                Catalogos.formulario.Comprar = null;
                con.Cerrarconexion();
            }
        }
    }
}
