using System;
using System.Collections.Generic;

namespace ERP.Pizzeria.Modelo
{
    public class Paquete
    {
        public int IdPaquete { get; set; }
        public List<Producto> Productos { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaAlta { get; set; }
        public Estatus Estatus { get; set; }
        public bool Eliminado { get; set; }
    }
}