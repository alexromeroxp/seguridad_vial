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
        public string apellidos { get; set; }
        public string credito { get; set; }
        public string telefono { get; set; }
        public DAOClientes()
        {

        }
        public DAOClientes(int id, string nombre, string apellido, string credito,string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.credito = credito;
            this.telefono = telefono;
        }

        public static IList<DAOClientes> Buscar(MySqlConnection con, string nombre)
        {
            List<DAOClientes> lista = new List<DAOClientes>();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT id_cliente,nombre,apellidos,credito,telefono from clientes where nombre LIKE ('%{0}%')", nombre), con);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                DAOClientes Cliente = new DAOClientes();
                Cliente.id = reader.GetInt32(0);
                Cliente.nombre = reader.GetString(1);
                Cliente.apellidos = reader.GetString(2);
                Cliente.credito = reader.GetString(3);
                Cliente.telefono = reader.GetString(4);
                lista.Add(Cliente);
            }
            return lista;
        }

        public static int Agregar(MySqlConnection con, DAOClientes Cliente)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO clientes (id_cliente,nombre,apellidos,credito,telefono) values ('{0}','{1}','{2}','{3}','{4}')",Cliente.id,Cliente.nombre,Cliente.apellidos,Cliente.credito,Cliente.telefono), con);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int Modificar(MySqlConnection con, DAOClientes Cliente)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE clientes SET nombre='{0}',apellidos='{1}',credito='{2}',telefono='{3}' where id_cliente='{4}' ", Cliente.nombre, Cliente.apellidos, Cliente.credito, Cliente.telefono, Cliente.id), con);
            retorno = comando.ExecuteNonQuery();


            return retorno;
        }
    }
}