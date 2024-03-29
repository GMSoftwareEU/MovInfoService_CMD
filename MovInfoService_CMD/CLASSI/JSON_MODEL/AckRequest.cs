using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovInfoService.CLASSI.NGTEC.JSON_MODEL
{
    public class AckRequest
    {
        public string TipoMessaggio { get; set; }
        public string Ack { get; set; }
        public string TrackingCode { get; set; }
    }

    public class RootAckRequest
    {
        public AckRequest ack_request { get; set; }
    }
}
