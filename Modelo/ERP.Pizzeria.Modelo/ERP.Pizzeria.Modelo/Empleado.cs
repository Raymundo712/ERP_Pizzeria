using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Pizzeria.Modelo
{
    public class Empleado : Persona
    {
        public int IdEmpleado { get; set; }
        public Contacto Contacto { get; set; }
        public Rol Rol { get; set; }
        public decimal Sueldo { get; set; }
        public string Numero { get; set; }
    }
}
