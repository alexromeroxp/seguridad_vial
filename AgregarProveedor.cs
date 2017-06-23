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
    public partial class AgregarProveedor : Form
    {
        conexion con = new conexion();

        public AgregarProveedor()
        {
            InitializeComponent();
            Catalogos.formulario.AgregarProveedor = this;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AgregarProveedor_Load(object sender, EventArgs e)
        {
            cb_estatus.SelectedIndex = 0;

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Catalogos.formulario.Proveedores.Show();
        }

        private void btn_AgregarProveedor_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seguro que desea Agregar?", "Confirmación Agregar", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                        int resultado = DAOProveedores.Agregar(con.con, Proveedor);

                        if (resultado > 0)
                        {
                            txt_nombre.Clear();
                            txt_rfc.Clear();
                            txt_telefono.Clear();
                            cb_estatus.Text = "";

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

                Catalogos.formulario.AgregarProveedor = null;
                con.Cerrarconexion();
            }
        }
    }
}
