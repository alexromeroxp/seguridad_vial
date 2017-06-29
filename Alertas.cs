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
    public partial class Alertas : Form
    {
        conexion con = new conexion();
        public Alertas()
        {
            InitializeComponent();
        }

        private void Alertas_Load(object sender, EventArgs e)
        {
            try
            {
                if (con.Abrirconexion() == true)
                {
                    Listar(con.con);
                    con.Cerrarconexion();

                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Listar(MySqlConnection con)
        {
            dgvAlerta.DataSource = DAOAlertas.Buscar(con);
            dgvAlerta.AutoResizeColumns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
