using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SeguridadVialInventario
{
    public class DAOComprar
    {
        public int id { get; set; }
        public int id_proveedor { get; set; }
        public int cantidad { get; set; }

        public int id_producto { get; set; }
        public string fecha_compra { get; set; }

        public float total { get; set; }




        public DAOComprar()
        {

        }
        public DAOComprar(int id, int id_producto, int cantidad, int id_proveedor, string fecha_venta, float total)
        {
            this.id = id;
            this.id_proveedor = id_proveedor;
            this.cantidad = cantidad;

            this.id_producto = id_producto;
            this.fecha_compra = fecha_compra;
            this.total = total;




        }

        public static int Agregar(MySqlConnection con, DAOComprar Comprar)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO Compras (id_compra,id_proveedor,cantidad,id_producto,fecha_compra,total) values ('{0}','{1}','{2}','{3}','{4}','{5}')",Comprar.id,Comprar.id_proveedor,Comprar.cantidad,Comprar.id_producto,Comprar.fecha_compra,Comprar.total), con);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        //public static int Buscarid(MySqlConnection con)
        //{
        //    int v = new int();
        //    MySqlCommand comando = new MySqlCommand(string.Format("SELECT MAX(id_venta) FROM bd_seguridad_vial.ventas;"), con);
        //    MySqlDataReader reader = comando.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        v = reader.GetInt32(0);
        //    }
        //    reader.Close();
        //    return v;
        //}
    }
}
