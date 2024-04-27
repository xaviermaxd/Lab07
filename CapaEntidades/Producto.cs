using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        public int product_id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int stock { get; set; }
    }
}
