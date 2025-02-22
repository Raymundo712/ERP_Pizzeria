namespace ERP.Pizzeria.Modelo
{
    public class Rol
    {
        public int idRol { get; set; }
        public string Nombre { get; set; }
        public GrupoPermiso GrupoPermiso { get; set; }
    }
}