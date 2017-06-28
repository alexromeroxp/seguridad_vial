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
    public partial class AgregarCliente : Form
    {
        conexion con = new conexion();

        public AgregarCliente()
        {
            InitializeComponent();
            Catalogos.formulario.AgregarCliente = this;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            cb_tipopersona.SelectedIndex = 0;

        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("Seguro que desea Agregar?", "Confirmación Agregar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {


                    try
                    {
                        if (con.Abrirconexion() == true)
                        {

                            DAOClientes Cliente = new DAOClientes();
                            Cliente.nombre = txt_nombre.Text;
                            Cliente.tipo_persona = cb_tipopersona.Text;
                            Cliente.telefono = txt_telefono.Text;
                            int resultado = DAOClientes.Agregar(con.con, Cliente);

                            if (resultado > 0)
                            {
                                txt_nombre.Clear();
                                txt_telefono.Clear();
                                cb_tipopersona.Text = "";

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
