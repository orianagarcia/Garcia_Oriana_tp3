﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Voucher
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public bool estado { get; set; }
        public int idCliente { get; set; }
        public int idProducto { get; set; }
    }
}
