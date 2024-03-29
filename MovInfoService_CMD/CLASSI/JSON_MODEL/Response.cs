using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovInfoService_CMD.CLASSI.JSON_MODEL
{
    public class RootResponse
    {
        public Response response { get; set; }
    }
    public class Response
    {
        public int IdResponse { get; set; }
        public int IdMissione { get; set; }
        public int TipoIncarico { get; set; }
        public string DestCarico { get; set; }
        public string DestScarico { get; set; }
        public string CDLOrigine { get; set; }
        public string CDLDestinazione { get; set; }
        public string OrdineDiLav { get; set; }
        public int? ErpOrderId { get; set; }
        public int? NumPezzi { get; set; }
        public float? Larghezza { get; set; }
        public float? Lunghezza { get; set; }
        public float? SpessorePezzo { get; set; }
        public float? Peso { get; set; }
        public string UDC { get; set; }
        public string RFID { get; set; }
        public string TrackingCode { get; set; }
        public int? PalletQty { get; set; }
        public string ErpCodicePallet { get; set; }
        public bool Transfer { get; set; }
        public object Errore { get; set; }
    }


}
