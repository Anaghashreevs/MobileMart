using Confluent.Kafka;
using MobileMart.Interface;
using MobileMart.Models;
using Newtonsoft.Json;

namespace MobileMart.Service
{
    public class KafkaService : IKafkaService
    {
        public async Task GetResponse(MobileDEtails mobileDEtails)
        {
           // using (var producer = new ProducerBuilder<string, string>(producerConfig)
           //.Build())
           // {
           //     while (true)
           //     {
           //         var value = JsonConvert.SerializeObject(mobileDEtails);
           //         var message = new Message<string, string>
           //         {
           //             Key = "ProductDemo",
           //             Value = value
           //         };



           //         await producer.ProduceAsync(topicName, message)
           //         .ContinueWith(task =>
           //         {
           //             if (!task.IsFaulted)
           //             {
           //                 Console.WriteLine($"produced to: {task.Result.TopicPartitionOffset}");
           //                 return;
           //             }



           //             Console.WriteLine($"error producing message: {task.Exception.InnerException}");
           //         });



           //     }
           // }
        }
    }
}
