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
    public partial class Movimientos : Form
    {
        conexion con = new conexion();
        public Movimientos()
        {
            InitializeComponent();
        }

        private void Movimientos_Load(object sender, EventArgs e)
        {
            try
            {
                if (con.Abrirconexion() == true)
                {
                    ListarMovimientos(con.con, txt_filtrar.Text);
                    con.Cerrarconexion();

                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ListarMovimientos(MySqlConnection con, string Nombre)
        {
            dgvMovimientos.DataSource = DAOMovimientos.Buscar(con, Nombre);
        }
        private void txt_filtrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (con.Abrirconexion() == true)
                    {
                        ListarMovimientos(con.con, txt_filtrar.Text);
                        con.Cerrarconexion();
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
