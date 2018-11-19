using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICAI.DATA
{
    public class Horario_Atencion
    {
        public int PK_Horario { get; set; }

        public DateTime DiaInicio { get; set; }

        public DateTime DiaFin { get; set; }

        public int HoraInicio { get; set; }

        public int HoraFin { get; set; }

        public int FKOrganizacion { get; set; }
    }
}
