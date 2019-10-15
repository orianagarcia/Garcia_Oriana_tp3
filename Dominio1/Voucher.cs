using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio1
{
    public class Vouchers
    {
        public long id { get; set; }
        public string codigo { get; set; }
        public bool estado { get; set; }
        public int idCliente { get; set; }
        public long idProducto { get; set; }
        public DateTime fechaRegistro { get; set; }
    }
}
