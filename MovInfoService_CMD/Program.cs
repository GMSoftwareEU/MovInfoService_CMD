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
using System.Threading;
using System.Threading.Tasks;

//Chiamata TIPO 0  singolarizzatore
//Chiamata TIPO 1  fondo rulliera 1C / CSM
//Chiamata TIPO 2  carico da magazzino (xxxCSMxxx)
//Chiamata TIPO 3  imballo automatico
//Chiamata TIPO 4  isola produttiva 2


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
                mqttClient.SubscribeAsync("MIS\\Request\\Type0");
                mqttClient.SubscribeAsync("MIS\\Request\\Type1");
                mqttClient.SubscribeAsync("MIS\\Request\\Type2");
                mqttClient.SubscribeAsync("MIS\\Request\\Type3");
                mqttClient.SubscribeAsync("MIS\\Request\\Type4");
                mqttClient.SubscribeAsync("MIS\\AckRequest");
                //mqtt.SendTopic(mqttClient, "AckRequest", "Sottoscritto topic AckRequest");               
                Console.WriteLine($"{DateTime.Now} - Sottoscrizione ai topic riuscita.");
            }
            else
            {
                Console.WriteLine($"{DateTime.Now} - Connessione a MQTT fallita.");
            }

            //  task parallelo che fa ping al server ogni 10 secondi per mantenere attivo il client
            Task.Run(() =>
            {
                while (true)
                {
                    MqttAdapterEx.Ping_Server(mqttClient);
                    Thread.Sleep(10000);
                }
            });


            Console.WriteLine($"");
            Console.WriteLine($"------------------------------------------------");
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
                RootRequest rootReq;
                Program program = new Program();

                if (!string.IsNullOrEmpty(jsonText) && !jsonText.Contains("Sottoscritto topic"))
                {
                    if (topic == topicPrefix + @"\Request")
                    {
                        rootReq = program.DeserializeJson(jsonText,"Request");

                        (string json, bool fl_PrintLabel, bool error) res = ("", false, false);
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
                            else
                            if (request.IdRequest == 2)   //CHIAMATA DI TIPO 2
                            {
                                res = BusinessLogic.ExecRequest2(request);
                            }
                            else if (request.IdRequest == 3)   //CHIAMATA DI TIPO 3
                            {
                                res = BusinessLogic.ExecRequest3(request);
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
                                        program.PrintLabel(res.json);
                                    }
                                }
                            }
                        }
                    }

                    else if (topic == topicPrefix + @"\Request\Type0")
                    {
                        rootReq = program.DeserializeJson(jsonText, "Type0");

                        (string json, bool fl_PrintLabel, bool error) res = ("", false, false);
                        if (rootReq != null)
                        {
                            var request = rootReq.request;
                            if (request.IdRequest == 0) // CHIAMATA DI TIPO 0
                            {
                                res = BusinessLogic.ExecRequest0(request);
                            }

                            if (res.error)
                            {
                                mqtt.SendTopic(mqttClient, "Error", res.json);
                            }
                            else
                            {
                                if (!String.IsNullOrEmpty(res.json))
                                {
                                    mqtt.SendTopic(mqttClient, "Response\\Type0", res.json);
                                    if (res.fl_PrintLabel)
                                    {
                                        program.PrintLabel(res.json);
                                    }
                                }
                            }

                        }
                    }

                    else if (topic == topicPrefix + @"\Request\Type1")
                    {
                        rootReq = program.DeserializeJson(jsonText, "Type1"); // CHIAMATA DI TIPO 1 

                        (string json, bool fl_PrintLabel, bool error) res = ("", false, false);
                        if (rootReq != null)
                        {
                            var request = rootReq.request;
                            if (request.IdRequest == 1) 
                            {
                                res = BusinessLogic.ExecRequest1(request);
                            }

                            if (res.error)
                            {
                                mqtt.SendTopic(mqttClient, "Error", res.json);
                            }
                            else
                            {
                                if (!String.IsNullOrEmpty(res.json))
                                {
                                    mqtt.SendTopic(mqttClient, "Response\\Type1", res.json);
                                    if (res.fl_PrintLabel)
                                    {
                                        program.PrintLabel(res.json);
                                    }
                                }
                            }

                        }
                    }

                    else if (topic == topicPrefix + @"\Request\Type2")
                    {
                        rootReq = program.DeserializeJson(jsonText, "Type2"); // CHIAMATA DI TIPO 2 

                        (string json, bool fl_PrintLabel, bool error) res = ("", false, false);
                        if (rootReq != null)
                        {
                            var request = rootReq.request;
                            if (request.IdRequest == 2)
                            {
                                res = BusinessLogic.ExecRequest2(request);
                            }

                            if (res.error)
                            {
                                mqtt.SendTopic(mqttClient, "Error", res.json);
                            }
                            else
                            {
                                if (!String.IsNullOrEmpty(res.json))
                                {
                                    mqtt.SendTopic(mqttClient, "Response\\Type2", res.json);
                                    if (res.fl_PrintLabel)
                                    {
                                        program.PrintLabel(res.json);
                                    }
                                }
                            }

                        }
                    }

                    else if (topic == topicPrefix + @"\Request\Type3")
                    {
                        rootReq = program.DeserializeJson(jsonText, "Type3"); // CHIAMATA DI TIPO 3 

                        (string json, bool fl_PrintLabel, bool error) res = ("", false, false);
                        if (rootReq != null)
                        {
                            var request = rootReq.request;
                            if (request.IdRequest == 3)
                            {
                                res = BusinessLogic.ExecRequest3(request);
                            }

                            if (res.error)
                            {
                                mqtt.SendTopic(mqttClient, "Error", res.json);
                            }
                            else
                            {
                                if (!String.IsNullOrEmpty(res.json))
                                {
                                    mqtt.SendTopic(mqttClient, "Response\\Type3", res.json);
                                    if (res.fl_PrintLabel)
                                    {
                                        program.PrintLabel(res.json);
                                    }
                                }
                            }

                        }
                    }

                    else if (topic == topicPrefix + @"\Request\Type4")
                    {
                        rootReq = program.DeserializeJson(jsonText, "Type4"); // CHIAMATA DI TIPO 4

                        (string json, bool fl_PrintLabel, bool error) res = ("", false, false);
                        if (rootReq != null)
                        {
                            var request = rootReq.request;
                            if (request.IdRequest == 4)
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
                                    mqtt.SendTopic(mqttClient, "Response\\Type4", res.json);
                                    if (res.fl_PrintLabel)
                                    {
                                        program.PrintLabel(res.json);
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
                            Console.WriteLine($"AckRequest - Errore deserializzazione JSON Request4. Errore: {ex.Message}");
                            req = null;
                        }
                        if (req != null)
                        {
                            var ackReq = req.ack_request;
                            if (ackReq.TipoMessaggio.ToUpper() == "TIPO1" || ackReq.TipoMessaggio.ToUpper() == "TIPO2")
                            {
                                dbo.Exec_mov_sp_check_udcDetail(ackReq.TrackingCode);  //eseguo store procedure mov_sp_check_udcDetail per contrassegnare il record di mov_UDCDetail come processato
                            }
                            if (ackReq.TipoMessaggio.ToUpper() == "TIPO3" || ackReq.TipoMessaggio.ToUpper() == "TIPO4")
                            {
                                dbo.Exec_mov_sp_check_AckReceived(ackReq.TrackingCode);  //eseguo store procedure mov_sp_check_AckReceived 
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore deserializzazione JSON. Errore: {ex.Message}");
            }

            return Task.CompletedTask;
        }


        private RootRequest DeserializeJson(string jsonText, string messageType)
        {
            RootRequest rootReq = new RootRequest();
            try
            {
                rootReq = JsonConvert.DeserializeObject<RootRequest>(jsonText);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore deserializzazione JSON {messageType}. Errore: {ex.Message}");
                rootReq = null;
            }
            return rootReq;
        }

        private void PrintLabel(string jsonText)
        {
            string printerName = "";
            var resp = JsonConvert.DeserializeObject<Response>(jsonText);
            using (var db = new ItaltonContext())
            {
                printerName = db.vw_mov_DestinationPrinter.FirstOrDefault(z => z.DestinationCode == resp.DestScarico).PrinterName;
            }
            var result = dbo.Exec_sp_LabelPrinterRequest(resp.UDC, printerName);
            if (result.Item2 != "")
            {
                Error err = new Error();
                err.Messaggio = result.Item2;
                err.Bloccante = true;
                string jsonError = JsonConvert.SerializeObject(err);
                mqtt.SendTopic(mqttClient, "Error", jsonError);
            }
        }




    }
}
