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
        public string cliente { get; set; }
        public string proveedor { get; set; }
        
        public float total { get; set; }
        public DAOMovimientos()
        {

        }
        public DAOMovimientos(int id, string nombre_movimiento, string fecha, int cantidad, string cliente, string proveedor, float total)
        {
            this.id = id;
            this.nombre_movimiento = nombre_movimiento;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.cliente = cliente;
            this.proveedor = proveedor;
    
            this.total = total;

        }

        public static IList<DAOMovimientos> Buscar(MySqlConnection con, string nombre)
        {
            List<DAOMovimientos> lista = new List<DAOMovimientos>();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT id_movimiento,nombre_movimiento,fecha_movimiento,cantidad,cliente,proveedor,total from movimientos where nombre_movimiento LIKE ('%{0}%')", nombre), con);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                DAOMovimientos Movimiento = new DAOMovimientos();
                Movimiento.id = reader.GetInt32(0);
                Movimiento.nombre_movimiento = reader.GetString(1);
                Movimiento.fecha = reader.GetString(2);
                Movimiento.cantidad = reader.GetInt32(3);
                Movimiento.cliente = reader.GetString(4);
                Movimiento.proveedor = reader.GetString(5);
                Movimiento.total = reader.GetFloat(6);
                


                lista.Add(Movimiento);
            }
            return lista;
        }
        public static int Buscarid(MySqlConnection con)
        {
            int v = new int();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT MAX(id_movimiento) FROM bd_seguridad_vial.movimientos;"), con);
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
