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
    public partial class Proveedores : Form
    {
        conexion con = new conexion();
        public Proveedores()
        {
            InitializeComponent();
            Catalogos.formulario.Proveedores = this;
        }

        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Catalogos.formulario.Catalogos.Enabled = true;
            Catalogos.formulario.Catalogos.Show();
            Catalogos.formulario.Proveedores.Hide();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            try
            {
                if (con.Abrirconexion() == true)
                {
                    
                    ListarProveedores(con.con, txt_filtrar.Text);
                    con.Cerrarconexion();

                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ListarProveedores(MySqlConnection con, string Nombre)
        {
            dgvProveedores.DataSource = DAOProveedores.Buscar(con, Nombre);
        }
        private void txt_filtrar_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (con.Abrirconexion() == true)
                    {
                        ListarProveedores(con.con, txt_filtrar.Text);
                        con.Cerrarconexion();
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            if (Catalogos.formulario.AgregarProveedor == null)
            {

                AgregarProveedor ap = new AgregarProveedor();
                ap.Show();


            }
            else
            {
                Catalogos.formulario.AgregarProveedor.Show();
            }
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
              Int32 selectedRowCount =
            dgvProveedores.Rows.GetRowCount(DataGridViewElementStates.Selected);

            String Identificador = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
            string Nombre = dgvProveedores.CurrentRow.Cells[1].Value.ToString();
            string rfc = dgvProveedores.CurrentRow.Cells[2].Value.ToString();
            String estatus = dgvProveedores.CurrentRow.Cells[4].Value.ToString();

            String telefono = dgvProveedores.CurrentRow.Cells[3].Value.ToString();
            if (selectedRowCount > 0)
                MessageBox.Show(Nombre);
            if (Catalogos.formulario.Proveedores == null)
            {
                ModificarProveedor mp = new ModificarProveedor();
                mp.id = Identificador;
                mp.nombre = Nombre;
                mp.rfc = rfc;
                mp.telefono = telefono;
                mp.estatus = estatus;

                mp.Show();
            }
            else
            {
                ModificarProveedor mp = new ModificarProveedor();
                mp.id = Identificador;
                mp.nombre = Nombre;
                mp.rfc = rfc;
                mp.telefono = telefono;
                mp.estatus = estatus;

                mp.Show();
            }
            this.Hide();
        
        }
    }
}
