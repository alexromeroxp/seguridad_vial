using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SeguridadVialInventario
{
    public class DAOAlertas
    {
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public float cantidad { get; set; }
        public int stock_minimo { get; set; }
        public int stock_maximo { get; set; }
        public DAOAlertas()
        {

        }
        public DAOAlertas (int id_producto,string nombre,float cantidad, int stock_minimo,int stock_maximo)
        {
            this.id_producto = id_producto;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.stock_maximo = stock_maximo;
            this.stock_minimo = stock_minimo;
        }
        public static IList<DAOAlertas> Buscar(MySqlConnection con)
        {
            List<DAOAlertas> lista = new List<DAOAlertas>();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT id_producto,nombre,cantidad,stock_minimo,stock_maximo from productos where cantidad<stock_minimo and estatus='A'"), con);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                DAOAlertas alerta = new DAOAlertas();
                alerta.id_producto = reader.GetInt32(0);
                alerta.nombre = reader.GetString(1);
                alerta.cantidad = reader.GetFloat(2);
                alerta.stock_maximo = reader.GetInt32(3);
                alerta.stock_minimo = reader.GetInt32(4);
                lista.Add(alerta);
            }
            return lista;
        }
    }
}
