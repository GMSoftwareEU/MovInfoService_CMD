using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovInfoService_CMD.CLASSI.JSON_MODEL
{
    public class RootRequest
    {
        public Request request { get; set; }
    }

    public class Request
    {
        public int IdRequest { get; set; }
        public int IdMissione { get; set; }
        public string PosizioneAttuale { get; set; }
        public string IngressoUscita { get; set; }
        public ContenutoNav1A ContenutoNav1A { get; set; }
        public ContenutoPila ContenutoPila { get; set; }
    }

    public class ContenutoNav1A
    {
        public string KeyGeneral { get; set; }
        public int Riga { get; set; }
        public int Colonna { get; set; }
        public string TrackingCode { get; set; }
        public int ErpOrderId { get; set; }
        public int NumPezzi { get; set; }
        public string RFID { get; set; }
    }

    public class ContenutoPila
    {
        public string KeyGeneral { get; set; }
        public int Riga { get; set; }
        public int Col { get; set; }
        public string TrackingCode { get; set; }
        public int ErpOrderId { get; set; }
        public int NumPezzi { get; set; }
        public string RFID { get; set; }
    }

}
