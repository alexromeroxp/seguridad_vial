using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace SeguridadVialInventario
{
    public class DAOMovimientos
    {
        public int id { get; set; }
        public string nombre_movimiento { get; set; }
        public string fecha { get; set; }
        public int cantidad { get; set; }
        public string id_cliente { get; set; }
        public string id_proveedor { get; set; }
        
        public float total { get; set; }
        public DAOMovimientos()
        {

        }
        public DAOMovimientos(int id, string nombre_movimiento, string fecha, int cantidad, string id_cliente, string id_proveedor, float total)
        {
            this.id = id;
            this.nombre_movimiento = nombre_movimiento;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.id_cliente = id_cliente;
            this.id_proveedor = id_proveedor;
    
            this.total = total;

        }

        public static IList<DAOMovimientos> Buscar(MySqlConnection con, string nombre)
        {
            List<DAOMovimientos> lista = new List<DAOMovimientos>();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT id_movimiento,nombre_movimiento,fecha_movimiento,cantidad,id_cliente,id_proveedor,total from movimientos where nombre_movimiento LIKE ('%{0}%')", nombre), con);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                DAOMovimientos Movimiento = new DAOMovimientos();
                Movimiento.id = reader.GetInt32(0);
                Movimiento.nombre_movimiento = reader.GetString(1);
                Movimiento.fecha = reader.GetString(2);
                Movimiento.cantidad = reader.GetInt32(3);
                Movimiento.id_cliente = reader.GetString(4);
                Movimiento.id_proveedor = reader.GetString(5);
                Movimiento.total = reader.GetFloat(6);
                


                lista.Add(Movimiento);
            }
            return lista;
        }

    }
}
