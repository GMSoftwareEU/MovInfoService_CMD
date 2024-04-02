using MovInfoService.CLASSI.NGTEC.BS;
using MovInfoService.CLASSI.NGTEC.JSON_MODEL;
using MovInfoService_CMD.CLASSI;
using MovInfoService_CMD.CLASSI.JSON_MODEL;
using MovInfoService_CMD.MODEL;
using MQTTnet;
using MQTTnet.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovInfoService_CMD
{
    class Program
    {
        public static string Destination;
        public static string ForceDownload;
        public static IMqttClient mqttClient = null;
        public static MqttAdapterEx mqtt = new MqttAdapterEx();
        public static DbOperation dbo = new DbOperation();
        public static string topicPrefix;
        static void Main(string[] args)
        {
            var appSettings = ConfigurationManager.AppSettings;
            Destination = appSettings["DESTINATION"];
            ForceDownload = appSettings["FORZA_SCARICO_MAGAZZINO"];

            //Connessione server MQTT
            topicPrefix = "MIS";
            var factory = new MqttFactory();
            mqttClient = factory.CreateMqttClient();

            if (mqtt.ConnectToMQTTClient(mqttClient))
            {
                Console.WriteLine($"{DateTime.Now} - Connessione a MQTT riuscita.");
                mqttClient.ApplicationMessageReceivedAsync += MqttClient_ApplicationMessageReceivedAsync;
                mqttClient.Options.KeepAlivePeriod = new TimeSpan(0, 0, 3);
                mqttClient.SubscribeAsync("MIS\\Request");
                mqttClient.SubscribeAsync("MIS\\AckRequest");
                //mqtt.SendTopic(mqttClient, "AckRequest", "Sottoscritto topic AckRequest");               
                Console.WriteLine($"{DateTime.Now} - Sottoscrizione ai topic riuscita.");
            }
            else
            {
                Console.WriteLine($"{DateTime.Now} - Connessione a MQTT fallita.");
            }

            Console.WriteLine($"");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"Premere il tasto ESC per chiudere l'applicazione");
            //Console.ReadKey();
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey();
                
            } while (cki.Key != ConsoleKey.Escape);

            mqtt.CloseMQTTConnection(mqttClient);
            return;
        }

        private static Task MqttClient_ApplicationMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs arg)
        {
            try
            {
                string topic = arg.ApplicationMessage.Topic;
                string jsonText = arg.ApplicationMessage.ConvertPayloadToString();

                if (!string.IsNullOrEmpty(jsonText) && !jsonText.Contains("Sottoscritto topic"))
                {
                    if (topic == topicPrefix + @"\Request")
                    {
                        RootRequest rootReq = new RootRequest();
                        try
                        {
                            rootReq = JsonConvert.DeserializeObject<RootRequest>(jsonText);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Errore deserializzazione JSON Request. Errore: {ex.Message}");
                            rootReq = null;
                        }
                        
                        (string json, bool fl_PrintLabel, bool error) res = ("",false,false);
                        if (rootReq != null)
                        {
                            var request = rootReq.request;
                            if (request.IdRequest == 0) // CHIAMATA DI TIPO 0
                            {
                                res = BusinessLogic.ExecRequest0(request);
                            }
                            else if (request.IdRequest == 1) // CHIAMATA DI TIPO 1
                            {
                                res = BusinessLogic.ExecRequest1(request);
                            }
                            else if (request.IdRequest == 2)   //CHIAMATA DI TIPO 2
                            {
                                res = BusinessLogic.ExecRequest2(request);
                            }
                            else if (request.IdRequest == 4)   //CHIAMATA DI TIPO 4
                            {
                                res = BusinessLogic.ExecRequest4(request);
                            }



                            if (res.error)
                            {
                                mqtt.SendTopic(mqttClient, "Error", res.json);
                            }
                            else
                            {
                                if (!String.IsNullOrEmpty(res.json))
                                {
                                    mqtt.SendTopic(mqttClient, "Response", res.json);
                                    if (res.fl_PrintLabel)
                                    {
                                        string param = "1";
                                        string printer = "xx";  // leggere da vista [vw_mov_Destinaziongroupdestinationstatus] il campo PrinterName fitrata per DestinationCode
                                        var result = dbo.Exec_sp_LabelPrinterRequest(param, printer);
                                        if (result.Item2 != "")
                                        {
                                            Error err = new Error();
                                            err.Messaggio = result.Item2;
                                            err.Bloccante = true;
                                            jsonText = JsonConvert.SerializeObject(err);
                                            mqtt.SendTopic(mqttClient, "Error", jsonText);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    else if (topic == topicPrefix + @"\AckRequest")
                    {
                        RootAckRequest req = new RootAckRequest();
                        try
                        {
                            req = JsonConvert.DeserializeObject<RootAckRequest>(jsonText);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Errore deserializzazione JSON Request4. Errore: {ex.Message}");
                            req = null;
                        }
                        if (req != null)
                        {
                            var ackReq = req.ack_request;
                            if (ackReq.TipoMessaggio.ToUpper() == "TIPO1" || ackReq.TipoMessaggio.ToUpper() == "TIPO2")
                            {
                                dbo.Exec_mov_sp_check_udcDetail(ackReq.TrackingCode);  //eseguo store procedure mov_sp_check_udcDetail per contrassegnare il record di mov_UDCDetail come processato
                            }
                            if (ackReq.TipoMessaggio.ToUpper() == "TIPO4")
                            {
                                dbo.Exec_mov_sp_check_AckReceived(ackReq.TrackingCode);  //eseguo store procedure mov_sp_check_udcDetail per contrassegnare il record di mov_UDCDetail come processato
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore deserializzazione JSON. Errore: {ex.Message}");
            }

            return null;
        }
    }
}
