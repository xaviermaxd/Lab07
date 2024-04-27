using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductBusiness
    {

        public List<Producto> get()
        {
            EProducto eProducto = new EProducto();

            var products = eProducto.ListarProductos();
            

            return products;
        }
        public List<Producto> getByName(string nombre)
        { 
            EProducto eProducto = new EProducto();

            var products = eProducto.ListarProductos();
            //var result = products.Where(x => x.name == nombre).ToList();
            var result = products.Where(x => x.name.Contains(nombre, StringComparison.OrdinalIgnoreCase)).ToList();

            return result;
        }
    }
}
