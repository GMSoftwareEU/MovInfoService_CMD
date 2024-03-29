using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovInfoService.CLASSI.NGTEC.JSON_MODEL
{
    class Error  //classe generica per segnalazione di errori
    {
        public string Messaggio { get; set; }
        public bool Bloccante { get; set; }
    }
}
