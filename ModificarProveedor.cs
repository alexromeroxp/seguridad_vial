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
    public partial class ModificarProveedor : Form
    {
        public string estatus;
        public string id;
        public string nombre;
        public string rfc;
        public string telefono;
        conexion con = new conexion();


        public ModificarProveedor()
        {
            InitializeComponent();
            Catalogos.formulario.ModificarProveedor = this;
        }

        private void ModificarProveedor_Load(object sender, EventArgs e)
        {
            txt_nombre.Text = nombre;
            txt_rfc.Text = rfc;
            txt_telefono.Text = telefono;
            cb_estatus.SelectedIndex = 0;

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Catalogos.formulario.Proveedores.Show();
        }

        private void btn_AgregarProveedor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Modificar?", "Confirmación Modificar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (con.Abrirconexion() == true)
                    {

                        DAOProveedores Proveedor = new DAOProveedores();

                        Proveedor.nombre = txt_nombre.Text;
                        Proveedor.rfc = txt_rfc.Text;
                        Proveedor.telefono = txt_telefono.Text;
                        Proveedor.estatus = cb_estatus.Text;

                        Proveedor.id = Convert.ToInt32(id);



                        int resultado = DAOProveedores.Modificar(con.con, Proveedor);

                        if (resultado > 0)
                        {
                            cb_estatus.Text = "";
                            txt_telefono.Clear();
                            txt_nombre.Clear();
                            txt_rfc.Clear();

                        }

                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {

                    MessageBox.Show(ex.Message);
                }

                this.Close();
                Catalogos.formulario.Proveedores.Show();
                Catalogos.formulario.Proveedores.ListarProveedores(con.con, "");

                Catalogos.formulario.ModificarProveedor = null;
                con.Cerrarconexion();
            }
        }
    }
}
