using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class ingrediente_hamburguesa
    {
        public int id_hamburguesa { get; set; }
        public int id_ingrediente { get; set; }
        public int cantidad { get; set; }
        public hamburguesa hamburguesas { get; set; }
        public ingredientes ingredientes { get; set; }
    }
}
