﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Pizzeria.Modelo
{
    public class Proveedor : Persona
    {
        public int IdProveedor { get; set; }
        public Contacto Contacto { get; set; }
        public Estatus Estatus { get; set; }

    }
}
