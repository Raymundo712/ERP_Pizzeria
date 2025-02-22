using System;

namespace ERP.Pizzeria.Modelo
{
    public class Sesion
    {
        public int IdSesion { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaSesion { get; set; }
        public DateTime InicioSesion { get; set; }
        public DateTime CierreSesion { get; set; }
    }
}