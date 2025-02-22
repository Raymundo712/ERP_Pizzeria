using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Pizzeria.Modelo
{
    public class Cliente : Persona
    {
        public int IdCliente { get; set; }
        public string NumeroCliente { get; set; }
        public Contacto Contacto { get; set; }
    }
}
