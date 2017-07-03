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
        DAOProveedores proveedor= new DAOProveedores();
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
        public void ListarProductos(MySqlConnection con, string Nombre)
        {
            dgvComprar.DataSource = DAOProductos.Buscar(con, Nombre);
            dgvComprar.AutoResizeColumns();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
            dgvComprar.Rows.GetRowCount(DataGridViewElementStates.Selected);
            precio_comp.id= int.Parse(dgvComprar.CurrentRow.Cells[0].Value.ToString());
            precio_comp.nombre = dgvComprar.CurrentRow.Cells[1].Value.ToString();
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
            if (precio_comp.id != int.Parse(dgvComprar.CurrentRow.Cells[0].Value.ToString()))
            {

                MessageBox.Show("Calcule el total del nuevo producto");

            }
            else if (txt_Cantidad.Text == "0" || txt_Cantidad.Text == "")
            {
                MessageBox.Show("Ingrese una cantidad valida..");
            }
            else
            {
                if (MessageBox.Show("Seguro que desea Agregar?", "Confirmación Agregar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {


                    try
                    {
                        if (con.Abrirconexion() == true)
                        {

                            DAOComprar Comprar = new DAOComprar();
                            Comprar.proveedor = dgvComprar.CurrentRow.Cells[5].Value.ToString();

                            Comprar.producto = dgvComprar.CurrentRow.Cells[1].Value.ToString();
                            Comprar.cantidad = int.Parse(txt_Cantidad.Text);
                            DateTime localDate = DateTime.Now;
                            Comprar.fecha_compra = localDate.ToString();
                            Comprar.total = total;

                            int resultado = DAOComprar.Agregar(con.con, Comprar);

                            if (resultado > 0)
                            {
                                txt_Cantidad.Clear();
                                lbl_total.Text = "______";
                                MessageBox.Show("Compra Almacenada!");
                                txt_Cantidad.Text = "1";
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Catalogos.formulario.Comprar = null;
        }

        private void cb_Producto_KeyDown(object sender, KeyEventArgs e)
        {
           

            

        }
      
    }
}