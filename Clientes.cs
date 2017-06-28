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
    public partial class Clientes : Form
    {
        conexion con = new conexion();
        public Clientes()
        {
            InitializeComponent();
            Catalogos.formulario.Clientes = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            try
            {
                if (con.Abrirconexion() == true)
                {
                    ListarClientes(con.con, txt_filtrar.Text);
                    con.Cerrarconexion();

                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ListarClientes(MySqlConnection con, string Nombre)
        {
            dgvClientes.DataSource = DAOClientes.Buscar(con, Nombre);
            dgvClientes.AutoResizeColumns();
        }
        private void txt_filtrar_KeyDown(object sender, KeyEventArgs e)
        {

        }
        
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            if (Catalogos.formulario.AgregarCliente == null)
            {

                AgregarCliente ac = new AgregarCliente();
                ac.Show();


            }
            else
            {
                Catalogos.formulario.AgregarCliente.Show();
            }
            this.Hide();
            
        }

        private void txt_filtrar_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (con.Abrirconexion() == true)
                    {
                        ListarClientes(con.con, txt_filtrar.Text);
                        con.Cerrarconexion();
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Catalogos.formulario.Catalogos.Enabled = true;
            Catalogos.formulario.Catalogos.Show();
            Catalogos.formulario.Clientes.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
            dgvClientes.Rows.GetRowCount(DataGridViewElementStates.Selected);

            String Identificador = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            string Nombre = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            string tipo_persona = dgvClientes.CurrentRow.Cells[2].Value.ToString();

            String telefono = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            if (selectedRowCount > 0)
                MessageBox.Show(Nombre);
            if (Catalogos.formulario.Clientes == null)
            {
                ModificarCliente mc = new ModificarCliente();
                mc.id = Identificador;
                mc.nombre = Nombre;
                mc.telefono = telefono;
                mc.tipo_persona = tipo_persona;

                mc.Show();
            }
            else
            {
                ModificarCliente mc = new ModificarCliente();
                mc.id = Identificador;
                mc.nombre = Nombre;
                mc.telefono = telefono;
                mc.tipo_persona = tipo_persona;

                mc.Show();
            }
            this.Hide();
        
         }
    }
}
