using System.Collections.Generic;

namespace ERP.Pizzeria.Modelo
{
    public class GrupoPermiso
    {
        public int IdGrupoPermiso { get; set; }
        public string NombrePermiso { get; set; }
        public List<Permiso> Permisos { get; set; }
        public bool Eliminado { get; set; }
    }
}