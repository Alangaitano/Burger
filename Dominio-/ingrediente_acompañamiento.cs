using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class ingrediente_acompañamiento
    {
        public int id_acompañamiento { get; set; }
        public int id_ingrediente { get; set; }
        public int cantidad { get; set; }
        public acompañamiento acompañamiento { get; set; }
        public ingredientes ingredientes { get; set; }
    }
}
