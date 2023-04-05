using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class detalle_combo
    {
        public int id { get; set; }
        public acompañamiento Acompañamiento { get; set; }
        public hamburguesa hamburguesa { get; set; }
        public bebida bebida { get; set; }
    }
}
