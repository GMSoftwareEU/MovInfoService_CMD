using MQTTnet;
using MQTTnet.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovInfoService_CMD.CLASSI
{
    public class MqttAdapterEx
    {
        private string brokerHostName;
        private int brokerPort;
        private string usernameMQTT;
        private string passwordMQTT;
        private string topicPrefix;

        public MqttAdapterEx()
        {
            var appSettings = ConfigurationManager.AppSettings;
            brokerHostName = appSettings["HOST_BROKER"];
            brokerPort = int.Parse(appSettings["PORT_BROKER"]);
            usernameMQTT = appSettings["USER_BROKER"];
            passwordMQTT = appSettings["PWD_BROKER"];
            topicPrefix = "MIS";
        }

        public bool ConnectToMQTTClient(IMqttClient mqttClient)
        {
            try
            {
                if ((mqttClient == null || (mqttClient != null && !mqttClient.IsConnected))
                    && !string.IsNullOrEmpty(brokerHostName))
                {

                    string clientid = "MIS" + Guid.NewGuid().ToString();

                    //Configure options 
                    var options = new MqttClientOptionsBuilder()
                        .WithClientId(clientid)
                        .WithTcpServer(brokerHostName, brokerPort) 
                        .WithCredentials(usernameMQTT, passwordMQTT)
                        .WithCleanSession()
                        .WithKeepAlivePeriod(new TimeSpan(0, 0, 0, 5))
                        .Build();

                    mqttClient.ConnectAsync(options).Wait();
                    SendTopic(mqttClient, "STATE", $"MovInfoService connesso a MQTT");
                }
                else
                {
                    mqttClient.PingAsync();
                }

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }

        }

        public void CloseMQTTConnection(IMqttClient mqttClient)
        {
            try
            {
                if (mqttClient != null && mqttClient.IsConnected)
                {
                    SendTopic(mqttClient, "STATE", $"{DateTime.Now} - MovInfoService disconnesso da MQTT");
                    SendTopic(mqttClient, "STATE", $"{DateTime.Now} - Servizio MovInfoService arrestato");
                }
                mqttClient.DisconnectAsync();
                mqttClient.Dispose();
            }
            catch (Exception)
            {

            }
        }

        public void SendTopic(IMqttClient mqttClient,string topic, string message)
        {
            //message = $"{DateTime.Now} - {message}";
            try
            {
                if (!mqttClient.IsConnected)
                {
                    ConnectToMQTTClient(mqttClient);
                }
            }
            catch
            {

            }
            MqttApplicationMessage msg = new MqttApplicationMessage() { Retain = false, Topic = topicPrefix+"\\"+ topic, Payload = Encoding.UTF8.GetBytes(message) };
            mqttClient.PublishAsync(msg);
        }

    }
}
