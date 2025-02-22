using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Pizzeria.Modelo
{
    public class Inventario
    {
        public int IdInventario { get; set; }
        public Ingrediente Ingrediente { get; set; }
        public double Existencia { get; set; }
        public Proveedor Proveedor { get; set; }
        public DateTime FechaSurtido { get; set; }
        public Estatus Estatus { get; set; }
    }
}
