using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace SeguridadVialInventario
{
    public class DAOProveedores
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string rfc { get; set; }
        public string telefono { get; set; }
        public string estatus { get; set; }

        public DAOProveedores()
        {

        }
        public DAOProveedores(int id, string Nombre, string RFC, string telefono,string estatus)
        {
            this.id = id;
            this.nombre = Nombre;
            this.rfc = RFC;
            this.telefono = telefono;
        }

        public static IList<DAOProveedores> Buscar(MySqlConnection con, string Nombre)
        {
            List<DAOProveedores> lista = new List<DAOProveedores>();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT id_proveedor,nombre,rfc,telefono,estatus from proveedores where nombre LIKE ('%{0}%')", Nombre), con);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                DAOProveedores Proveedor = new DAOProveedores();
                Proveedor.id = reader.GetInt32(0);
                Proveedor.nombre = reader.GetString(1);
                Proveedor.rfc = reader.GetString(2);
                Proveedor.telefono = reader.GetString(3);
                Proveedor.estatus = reader.GetString(4);


                lista.Add(Proveedor);
            }
            return lista;
        }

        internal static int Agregar(MySqlConnection con, DAOProveedores proveedor)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO proveedores (id_proveedor,nombre,rfc,telefono,estatus) values ('{0}','{1}','{2}','{3}','{4}')", proveedor.id, proveedor.nombre, proveedor.rfc, proveedor.telefono, proveedor.estatus), con);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        internal static int Modificar(MySqlConnection con, DAOProveedores proveedor)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE proveedores SET nombre='{0}',rfc='{1}',telefono='{2}',estatus='{3}' where id_proveedor='{4}' ", proveedor.nombre, proveedor.rfc, proveedor.telefono, proveedor.estatus, proveedor.id), con);
            retorno = comando.ExecuteNonQuery();


            return retorno;
        }
        public static int Buscarid(MySqlConnection con,DAOProveedores nombre)
        {
            
            MySqlCommand comando = new MySqlCommand(string.Format("select id_proveedor from proveedores where nombre ='{0}';",nombre.nombre), con);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                nombre.id = reader.GetInt32(0);
            }
            reader.Close();
            return nombre.id;
        }
    }
}

