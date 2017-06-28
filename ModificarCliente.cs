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
    public partial class ModificarCliente : Form
    {
        public string nombre;
        public string tipo_persona;
        public string telefono;
        public string id;
        conexion con = new conexion();
        public ModificarCliente()
        {
            InitializeComponent();
            Catalogos.formulario.ModificarCliente = this;
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            txt_nombre.Text = nombre;
            txt_telefono.Text = telefono;
            cb_tipopersona.SelectedIndex = 0;
        }

        private void btn_modificarcliente_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Modificar?", "Confirmación Modificar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (con.Abrirconexion() == true)
                    {

                        DAOClientes Cliente = new DAOClientes();

                        Cliente.nombre = txt_nombre.Text;
                        Cliente.tipo_persona = cb_tipopersona.Text;
                        Cliente.telefono = txt_telefono.Text;
                        

                        Cliente.id = Convert.ToInt32(id);
                        


                        int resultado = DAOClientes.Modificar(con.con, Cliente);

                        if (resultado > 0)
                        {
                            cb_tipopersona.Text = "";
                            txt_telefono.Clear();
                            txt_nombre.Clear();

                        }

                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {

                    MessageBox.Show(ex.Message);
                }

                this.Close();
                Catalogos.formulario.Clientes.Show();
                Catalogos.formulario.Clientes.ListarClientes(con.con, "");

                Catalogos.formulario.AgregarCliente = null;
                con.Cerrarconexion();
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Catalogos.formulario.Clientes.Show();
        }

       
    }
}
