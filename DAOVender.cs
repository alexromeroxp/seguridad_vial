using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SeguridadVialInventario
{
   public class DAOVender
    {
        public int id { get; set; }
        public int id_producto { get; set; }
        public int id_cliente { get; set; }
        public int cantidad { get; set; }
        public float total { get; set; }

        public string fecha_venta { get; set; }
       
        
    
        public DAOVender()
        {

        }
        public DAOVender(int id, int id_producto, int id_cliente,int cantidad, float total, string fecha_venta)
        {
            this.id =id;
            this.id_producto = id_producto;
            this.id_cliente = id_cliente;
            this.cantidad = cantidad;
            this.total = total;
            this.fecha_venta = fecha_venta;
       


        }
    }
}
