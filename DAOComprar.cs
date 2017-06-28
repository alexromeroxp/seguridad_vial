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
        public string proveedor { get; set; }
        public int id_movimiento { get; set; }

        public int cantidad { get; set; }

        public string producto { get; set; }
        public string fecha_compra { get; set; }

        public float total { get; set; }




        public DAOComprar()
        {

        }
        public DAOComprar(int id, string producto,int id_movimiento, int cantidad, string proveedor, string fecha_venta, float total)
        {
            this.id = id;
            this.proveedor = proveedor;
            this.id_movimiento = id_movimiento;
            this.cantidad = cantidad;

            this.producto = producto;
            this.fecha_compra = fecha_compra;
            this.total = total;




        }

        public static int Agregar(MySqlConnection con, DAOComprar Comprar)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO Compras (id_compra,proveedor,cantidad,producto,fecha_compra,total) values ('{0}','{1}','{2}','{3}','{4}','{5}')",Comprar.id,Comprar.proveedor,Comprar.cantidad,Comprar.producto,Comprar.fecha_compra,Comprar.total), con);
            retorno = comando.ExecuteNonQuery();
            MySqlCommand comando2 = new MySqlCommand(string.Format("INSERT INTO movimientos (id_movimiento,nombre_movimiento,fecha_movimiento,cantidad,cliente,proveedor,total) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", Comprar.id, "compra", Comprar.fecha_compra, Comprar.cantidad, "sin cliente", Comprar.proveedor, Comprar.total), con);
            retorno = comando2.ExecuteNonQuery();
            MySqlCommand comando3 = new MySqlCommand(string.Format("update productos set cantidad=cantidad+'{0}' where nombre='{1}'", Comprar.cantidad, Comprar.producto), con);
            retorno = comando3.ExecuteNonQuery();

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
