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
    public partial class Productos : Form
    {
        conexion con = new conexion();
        public Productos()
        {
            InitializeComponent();
            Catalogos.formulario.Productos = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Catalogos.formulario.Catalogos.Enabled = true;
            Catalogos.formulario.Catalogos.Show();
            Catalogos.formulario.Productos.Hide();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            try
            {
                if (con.Abrirconexion() == true)
                {
                    ListarProductos(con.con, txt_filtrar.Text);
                    con.Cerrarconexion();
                    Cargartotales();
                }
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ListarProductos(MySqlConnection con, string Nombre)
        {
            dgvProductos.DataSource = DAOProductos.Buscar(con,Nombre);
        }

        private void txt_filtrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                try
                {
                    if (con.Abrirconexion() == true)
                    {
                        ListarProductos(con.con, txt_filtrar.Text);
                        con.Cerrarconexion();
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Cargartotales()
        {
             try
            {
                if (con.Abrirconexion() == true)
                {
                    lbl_tc.Text = DAOProductos.TotalCompra(con.con)+" $".ToString();
                    con.Cerrarconexion();
                }
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            if (Catalogos.formulario.AgregarProducto == null)
            {
                
                AgregarProducto ac = new AgregarProducto();
                ac.Show();

            }
            else
            {
                Catalogos.formulario.AgregarProducto.Show();
            }
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Int32 selectedRowCount =
            dgvProductos.Rows.GetRowCount(DataGridViewElementStates.Selected);

            String Identificador = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            string Nombre = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            string precio_compra = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            String precio_venta = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            String estatus = dgvProductos.CurrentRow.Cells[4].Value.ToString();
            String id_proveedor = dgvProductos.CurrentRow.Cells[5].Value.ToString();
            String cantidad = dgvProductos.CurrentRow.Cells[6].Value.ToString();
            String stock_minimo = dgvProductos.CurrentRow.Cells[7].Value.ToString();
            String stock_maximo = dgvProductos.CurrentRow.Cells[8].Value.ToString();



            if (selectedRowCount > 0)
                MessageBox.Show(Nombre);
            if (Catalogos.formulario.Productos == null)
            {
                ModificarProducto mp = new ModificarProducto();
                mp.id = Identificador;
                mp.nombre = Nombre;
                mp.precio_compra = precio_compra;
                mp.precio_venta = precio_venta;
                mp.estatus = estatus;
                mp.id_proveedor = id_proveedor;
                mp.cantidad = cantidad;
                mp.stock_minimo = stock_minimo;
                mp.stock_maximo = stock_maximo;
                mp.Show();
            }
            else
            {
                ModificarProducto mp = new ModificarProducto();
                mp.id = Identificador;
                mp.nombre = Nombre;
                mp.precio_compra = precio_compra;
                mp.precio_venta = precio_venta;
                mp.estatus = estatus;
                mp.id_proveedor = id_proveedor;
                mp.cantidad = cantidad;
                mp.stock_minimo = stock_minimo;
                mp.stock_maximo = stock_maximo;
                mp.Show();
            }
            this.Hide();
        }

        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
