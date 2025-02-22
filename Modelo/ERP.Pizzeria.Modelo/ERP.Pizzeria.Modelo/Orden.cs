using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Pizzeria.Modelo
{
    public class Orden
    {
        public int IdOrden { get; set; }
        public List<Producto> Productos { get; set; }
        public Cliente Cliente { get; set; }
        public Empleado Cajero { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaPedido { get; set; }
        public Paquete Paquete { get; set; }
        public Empleado Repartidor { get; set; }
        public Estatus Estatus { get; set; }
        public bool Eliminado { get; set; }

    }
}
