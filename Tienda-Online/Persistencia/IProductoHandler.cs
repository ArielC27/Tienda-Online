using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Persistencia
{
    public interface IProductoHandler : ICRUD<Producto>
    {
        bool Create(Producto producto);
        bool Delete(int id);
    }
}
