using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class producto
    {
        public string nombre { get; set; }
        public double precio { get; set; }
        public string tamaño { get; set; }
        public int id { get; set; }
        public int recargo { get; set; }
    }
}
