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
        public string nombre_proveedor { get; set; }
        List<string> proveedor   = new List<string>();
        public int cantidad { get; set; }
        public int stock_minimo { get; set; }
        public int stock_maximo { get; set; }
       

        public float totalcompra { get; set;}
       // public int id_proveedor { get; set; }


        public DAOProductos()
        {

        }
        public DAOProductos(int Id,string Nombre,float Precio_Compra,float Precio_Venta,string estatus,string nombre_proveedor, int Cantidad,int stock_minimo,int stock_maximo,float TotalCompra,int id_proveedor)
        {
            this.id = Id;
            this.nombre = Nombre;
            this.precio_compra = Precio_Compra;
            this.precio_venta = Precio_Venta;
            this.estatus = estatus;
            this.nombre_proveedor = nombre_proveedor;
            this.cantidad = Cantidad;
            this.stock_minimo = stock_minimo;
            this.totalcompra = TotalCompra;
            this.stock_minimo = stock_maximo;
           // this.id_proveedor = id_proveedor;


        }
        public static IList<DAOProductos> Buscar(MySqlConnection con, string Nombre)
        {

            List<DAOProductos> lista = new List<DAOProductos>();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT productos.id_producto, productos.nombre,productos.precio_compra, productos.precio_venta,productos.estatus,proveedores.nombre,productos.cantidad,productos.stock_minimo,productos.stock_maximo,productos.precio_compra * productos.cantidad as 'TotalCompra',productos.id_proveedor from productos,proveedores where productos.nombre LIKE ('%{0}%') and productos.id_proveedor=proveedores.id_proveedor", Nombre),con);
            MySqlDataReader reader = comando.ExecuteReader();
            
            while (reader.Read())
            {
                DAOProductos Producto = new DAOProductos();
                Producto.id = reader.GetInt32(0);
                Producto.nombre = reader.GetString(1);
                Producto.precio_compra = reader.GetFloat(2);
                Producto.precio_venta = reader.GetFloat(3);
                Producto.estatus = reader.GetString(4);
                Producto.nombre_proveedor = reader.GetString(5);
                Producto.cantidad = reader.GetInt32(6);
                Producto.stock_minimo = reader.GetInt32(7);
                Producto.stock_maximo = reader.GetInt32(8);
                Producto.totalcompra = reader.GetFloat(9);
               // Producto.id_proveedor = reader.GetInt32(10);

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
        public static float BuscarPrecio(MySqlConnection con,DAOProductos Precio)
        {
            
            MySqlCommand comando = new MySqlCommand(string.Format("select precio_venta from productos where nombre='{0}'",Precio.nombre), con);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Precio.precio_venta = reader.GetFloat(0);
            }
            return Precio.precio_venta;
            
            
        }
        public static float BuscarPrecioCompra(MySqlConnection con, DAOProductos Precio)
        {

            MySqlCommand comando = new MySqlCommand(string.Format("select precio_compra from productos where nombre='{0}'", Precio.nombre), con);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Precio.precio_compra = reader.GetFloat(0);
            }
            return Precio.precio_compra;


        }
        public static int Agregar(MySqlConnection con, DAOProductos Productos,DAOProveedores nombre_proveedor)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO productos (id_producto,nombre,precio_compra,precio_venta,id_proveedor,cantidad,stock_minimo,stock_maximo) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", Productos.id, Productos.nombre, Productos.precio_compra,Productos.precio_venta, nombre_proveedor.id,Productos.cantidad,Productos.stock_minimo,Productos.stock_maximo), con);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        internal static int Modificar(MySqlConnection con, DAOProductos Productos,DAOProveedores nombre_proveedor)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE productos SET nombre='{0}',precio_compra='{1}',precio_venta='{2}',estatus='{3}',id_proveedor='{4}',cantidad='{5}',stock_minimo='{6}',stock_maximo='{7}' where id_producto='{8}' " , Productos.nombre, Productos.precio_compra, Productos.precio_venta,Productos.estatus,nombre_proveedor.id, Productos.cantidad, Productos.stock_minimo, Productos.stock_maximo,Productos.id), con);
            retorno = comando.ExecuteNonQuery();


            return retorno;
        }
        public static string Buscarid(MySqlConnection con, string nombre)
        {
            string retorno="";
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT proveedores.nombre from proveedores,productos where productos.id_proveedor=proveedores.id_proveedor and productos.nombre='{0}';", nombre), con);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                retorno = reader.GetString(0);
            }
            return retorno;
        }
            
    }
}
