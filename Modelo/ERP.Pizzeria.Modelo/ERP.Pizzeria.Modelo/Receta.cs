using System.Collections.Generic;

namespace ERP.Pizzeria.Modelo
{
    public class Receta
    {
        public int IdReceta { get; set; }
        public string NombreReceta { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }
        public string Descripcion { get; set; }
        public bool Eliminado { get; set; }
    }
}