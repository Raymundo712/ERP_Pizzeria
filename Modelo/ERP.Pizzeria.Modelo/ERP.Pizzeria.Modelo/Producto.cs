using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Pizzeria.Modelo
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public Receta Receta { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Presentacion { get; set; }
        public string Descuento { get; set; }
        public bool Eliminado { get; set; }
    }
}
