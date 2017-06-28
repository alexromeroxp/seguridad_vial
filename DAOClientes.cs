using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace SeguridadVialInventario
{
    public class DAOClientes
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string tipo_persona { get; set; }
        public string telefono { get; set; }
        public DAOClientes()
        {

        }
        public DAOClientes(int id, string nombre, string apellido,string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.tipo_persona = tipo_persona;
            this.telefono = telefono;
        }

        public static IList<DAOClientes> Buscar(MySqlConnection con, string nombre)
        {
            List<DAOClientes> lista = new List<DAOClientes>();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT id_cliente,nombre,tipo_persona,telefono from clientes where nombre LIKE ('%{0}%')", nombre), con);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                DAOClientes Cliente = new DAOClientes();
                Cliente.id = reader.GetInt32(0);
                Cliente.nombre = reader.GetString(1);
                Cliente.tipo_persona = reader.GetString(2);
                Cliente.telefono = reader.GetString(3);
                lista.Add(Cliente);
            }
            return lista;
        }

        public static int Agregar(MySqlConnection con, DAOClientes Cliente)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO clientes (id_cliente,nombre,tipo_persona,telefono) values ('{0}','{1}','{2}','{3}')",Cliente.id,Cliente.nombre,Cliente.tipo_persona,Cliente.telefono), con);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int Modificar(MySqlConnection con, DAOClientes Cliente)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE clientes SET nombre='{0}',tipo_persona='{1}',telefono='{2}' where id_cliente='{3}' ", Cliente.nombre, Cliente.tipo_persona, Cliente.telefono, Cliente.id), con);
            retorno = comando.ExecuteNonQuery();


            return retorno;
        }
    }
}