namespace ERP.Pizzeria.Modelo
{
    public class Ingrediente
    {
        public int IdIngrediente { get; set; }
        public string NombreIngrediente { get; set; }
        public double Cantidad { get; set; }
        public string Descripcion { get; set; }
        public UnidadPeso UnidadPeso { get; set; }
        public bool Eliminado { get; set; }
    }
}