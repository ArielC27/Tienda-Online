using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Factura
    {
        public int FacturaId { get; set; }
        public int NumFactura { get; set; }
        public decimal MontoTotal { get; set; }
        public Cliente ClienteID { get; set; }
        public List<Item> Items { get; set; }
    }
}
