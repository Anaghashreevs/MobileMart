using MobileMart.Enums;
using MobileMart.Interface;
using Confluent.Kafka;
using Newtonsoft.Json;

namespace MobileMart.Service
{
    public class ProducerConfigDetails : IConfigProvider
    {

        public void GetConfigDetails(ConfigType configType)
        {

          
            string bootStrapServer = "localhost:9092";
            string topicName = "ProductsMart";


            
            switch (configType)
            {
                case ConfigType.ProducerConfig:
                    var producerConfig = new ProducerConfig
                    {
                        BootstrapServers = bootStrapServer,
                        Acks = Acks.All
                    };
                    break;
                case ConfigType.ConsumerConfig:

                    var config = new ConsumerConfig()
                    {
                        GroupId = "ProductDemo",
                        BootstrapServers = "localhost:9092",
                        AutoOffsetReset = AutoOffsetReset.Latest
                    };

                    break;
                default:
                    break;
            }
           
        }
    }
}
