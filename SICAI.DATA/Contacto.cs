using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICAI.DATA
{
    public class Contacto
    {
        public int PKContacto { get; set; }

        public string Nombre { get; set; }

        public string Correo { get; set; }

        public string Sexo { get; set; }

        public Boolean Estado { get; set; }

        public int FKOrganizacion { get; set; }
    }
}
