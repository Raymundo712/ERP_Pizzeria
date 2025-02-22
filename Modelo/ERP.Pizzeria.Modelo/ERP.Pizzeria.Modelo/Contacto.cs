namespace ERP.Pizzeria.Modelo
{
    public class Contacto
    {
        public int IdContacto { get; set; }
        public Direccion Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Eliminado { get; set; }
    }
}