using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICAI.DATA
{
    public class Organizacion
    {
        public int PKOrganizacion { get; set; }

        public string Nombre { get; set; }

        public string Pais { get; set; }

        public string Linea_Negocio { get; set; }
        
        public string Direccion_Fisica { get; set; }

        public int Telefono { get; set; }

        public string Url { get; set; }
    }
}
