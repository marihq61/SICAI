using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICAI.DATA
{
    public class Contacto_Tel
    {
        public int PKContactoTel { get; set; }

        public int Telefono { get; set; }

        public int Movil { get; set; }

        public int FKContacto { get; set; }
    }
}
