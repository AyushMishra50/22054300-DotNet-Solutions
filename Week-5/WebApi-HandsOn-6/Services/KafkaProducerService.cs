using Confluent.Kafka;
using System.Text.Json;

namespace MyFirstWebApi.Services
{
    public class KafkaProducerService
    {
        private readonly string _topic = "employee-topic";
        private readonly IProducer<Null, string> _producer;

        public KafkaProducerService()
        {
            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"
            };

            _producer = new ProducerBuilder<Null, string>(config).Build();
        }

        public async Task ProduceMessageAsync<T>(T data)
        {
            var json = JsonSerializer.Serialize(data);
            await _producer.ProduceAsync(_topic, new Message<Null, string> { Value = json });
        }
    }
}
