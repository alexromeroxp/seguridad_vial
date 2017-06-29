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
        public string producto { get; set; }
        public int id_movimiento { get; set; }
        public string cliente { get; set; }
        public int cantidad { get; set; }
        public float total { get; set; }
        public string fecha_venta { get; set; }
       
        
    
        public DAOVender()
        {

        }
        public DAOVender(int id, string producto, int id_movimiento, string cliente,int cantidad, float total, string fecha_venta)
        {
            this.id =id;
            this.producto = producto;
            this.id_movimiento = id_movimiento;
            this.cliente = cliente;
            this.cantidad = cantidad;
            this.total = total;
            this.fecha_venta = fecha_venta;
       


        }

        public static int Agregar(MySqlConnection con, DAOVender vender)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO ventas (id_venta,producto,cliente,cantidad,total,fecha_venta) values ('{0}','{1}','{2}','{3}','{4}','{5}')", vender.id,vender.producto,vender.cliente,vender.cantidad,vender.total,vender.fecha_venta), con);
            retorno = comando.ExecuteNonQuery();
            MySqlCommand comando2 = new MySqlCommand(string.Format("INSERT INTO movimientos (id_movimiento,nombre_movimiento,fecha_movimiento,cantidad,cliente,proveedor,total) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", vender.id_movimiento,"venta", vender.fecha_venta, vender.cantidad, vender.cliente,"sin proveedor", vender.total), con);
            retorno = comando2.ExecuteNonQuery();
            MySqlCommand comando3 = new MySqlCommand(string.Format("update productos set cantidad=cantidad-'{0}' where nombre='{1}'",vender.cantidad, vender.producto), con);
            retorno = comando3.ExecuteNonQuery();
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
        public static int BuscarCantidad(MySqlConnection con,string nombre)
        {
            int v = new int();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT cantidad FROM productos where nombre='{0}'",nombre),con);
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
