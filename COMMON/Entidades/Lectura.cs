using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Entidades
{
    public class Lectura
    {
        public string IdDispositivos { get; set; }
        public string Temperatura { get; set; }
        public string Humedad { get; set; }
        public string Luminosidad { get; set; }
        public string EstatusRele1 { get; set; }
        public string EstatusRele2 { get; set; }
        public string EstatusRele3 { get; set; }
        public string EstatusRele4 { get; set; }
    }
}
