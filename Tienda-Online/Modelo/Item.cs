using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Item
    {
        public int ItemId { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public Producto ProductoID { get; set; }
        
    }
}
