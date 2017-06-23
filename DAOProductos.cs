using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SeguridadVialInventario
{
   public class DAOProductos
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public float precio_compra { get; set; }
        public float precio_venta { get; set; }
        public string estatus { get; set; }
        public int id_proveedor { get; set; }
        public int cantidad { get; set; }
        public int stock_minimo { get; set; }
        public int stock_maximo { get; set; }
       

        public float totalcompra { get; set;}

        public DAOProductos()
        {

        }
        public DAOProductos(int Id,string Nombre,float Precio_Compra,float Precio_Venta,string estatus,int id_proveedor, int Cantidad,int stock_minimo,int stock_maximo,float TotalCompra)
        {
            this.id = Id;
            this.nombre = Nombre;
            this.precio_compra = Precio_Compra;
            this.precio_venta = Precio_Venta;
            this.estatus = estatus;
            this.id_proveedor = id_proveedor;
            this.cantidad = Cantidad;
            this.stock_minimo = stock_minimo;
            this.totalcompra = TotalCompra;
            this.stock_minimo = stock_maximo;
         
            
        }
        public static IList<DAOProductos> Buscar(MySqlConnection con, string Nombre)
        {

            List<DAOProductos> lista = new List<DAOProductos>();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT id_producto, nombre,precio_compra, precio_venta,estatus,id_proveedor,cantidad,stock_minimo,stock_maximo,precio_compra * cantidad as 'TotalCompra' from productos where nombre LIKE ('%{0}%')", Nombre),con);
            MySqlDataReader reader = comando.ExecuteReader();
            
            while (reader.Read())
            {
                DAOProductos Producto = new DAOProductos();
                Producto.id = reader.GetInt32(0);
                Producto.nombre = reader.GetString(1);
                Producto.precio_compra = reader.GetFloat(2);
                Producto.precio_venta = reader.GetFloat(3);
                Producto.estatus = reader.GetString(4);
                Producto.id_proveedor = reader.GetInt32(5);
                Producto.cantidad = reader.GetInt32(6);
                Producto.stock_minimo = reader.GetInt32(7);
                Producto.stock_maximo = reader.GetInt32(8);
                Producto.totalcompra = reader.GetFloat(9);

                lista.Add(Producto);
            }
            return lista;
        }
       
        public static float TotalCompra(MySqlConnection con)
        {
            float v= new float();
            MySqlCommand comando = new MySqlCommand(string.Format("select sum(cantidad*precio_compra) from productos"),con);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                v= reader.GetFloat(0);
            }
            return v;
        }
        public static int Agregar(MySqlConnection con, DAOProductos Productos)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO productos (id_producto,nombre,precio_compra,precio_venta,id_proveedor,cantidad,stock_minimo,stock_maximo) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", Productos.id, Productos.nombre, Productos.precio_compra,Productos.precio_venta, Productos.id_proveedor,Productos.cantidad,Productos.stock_minimo,Productos.stock_maximo), con);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        internal static int Modificar(MySqlConnection con, DAOProductos Productos)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE productos SET nombre='{0}',precio_compra='{1}',precio_venta='{2}',estatus='{3}',id_proveedor='{4}',cantidad='{5}',stock_minimo='{6}',stock_maximo='{7}' where id_producto='{8}' " , Productos.nombre, Productos.precio_compra, Productos.precio_venta,Productos.estatus, Productos.id_proveedor, Productos.cantidad, Productos.stock_minimo, Productos.stock_maximo,Productos.id), con);
            retorno = comando.ExecuteNonQuery();


            return retorno;
        }
    }
}
