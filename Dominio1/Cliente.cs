﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio1
{
    public class Cliente
    {
        public long id { get; set; }
        public int dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public string cp { get; set; }
        public string ciudad { get; set; }
        public DateTime fechaRegistro {get; set; }
    }
}
