using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia;

namespace Servicios.Implementacion
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoHandler productoHandler;
        public ProductoService(IProductoHandler productoHandler)
        {
            this.productoHandler = productoHandler;
        }
        public bool CrearProducto(Producto producto)
        {
            return true;
        }
    }    
}


