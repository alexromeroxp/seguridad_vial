using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SeguridadVialInventario
{
   public class conexion
    {
        public MySqlConnection con;
        public conexion()
        {
            //commit Baldenebro
            con = new MySqlConnection("server=127.0.0.1; port=3306; database=bd_seguridad_vial; Uid=root; pwd=12345;");
        }
        public bool Abrirconexion()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }
        }
        public bool Cerrarconexion()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }
        }
    }
}
