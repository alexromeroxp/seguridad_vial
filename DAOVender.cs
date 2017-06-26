using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SeguridadVialInventario
{
   public class DAOVender
    {
        public int id { get; set; }
        public int id_producto { get; set; }
        public int id_cliente { get; set; }
        public int cantidad { get; set; }
        public float total { get; set; }

        public string fecha_venta { get; set; }
       
        
    
        public DAOVender()
        {

        }
        public DAOVender(int id, int id_producto, int id_cliente,int cantidad, float total, string fecha_venta)
        {
            this.id =id;
            this.id_producto = id_producto;
            this.id_cliente = id_cliente;
            this.cantidad = cantidad;
            this.total = total;
            this.fecha_venta = fecha_venta;
       


        }

        public static int Agregar(MySqlConnection con, DAOVender vender)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO ventas (id_venta,id_producto,id_cliente,cantidad,total,fecha_venta) values ('{0}','{1}','{2}','{3}','{4}','{5}')", vender.id,vender.id_producto,vender.id_cliente,vender.cantidad,vender.total,vender.fecha_venta), con);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int Buscarid(MySqlConnection con)
        {
            int v = new int();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT MAX(id_venta) FROM bd_seguridad_vial.ventas;"), con);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                v = reader.GetInt32(0);
            }
            reader.Close();
            return v;
        }
    }
}
