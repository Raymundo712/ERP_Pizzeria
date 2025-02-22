using System;

namespace ERP.Pizzeria.Modelo
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public TipoPersona TipoPersona { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIns { get; set; }
        public DateTime FechaMod { get; set; }
        public Sesion SesionIns { get; set; }
        public Sesion SesionMod { get; set; }
        public bool Eliminado { get; set; }

    }
}
