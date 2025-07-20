using System;
using Confluent.Kafka;
using System.Threading.Tasks;

class Program
{
    public static async Task Main(string[] args)
    {
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        Console.WriteLine("Enter messages to send to Kafka (type 'exit' to quit):");

        string? input;
        while ((input = Console.ReadLine()) != null && input.ToLower() != "exit")
        {
            try
            {
                var deliveryResult = await producer.ProduceAsync(
                    "test-topic",
                    new Message<Null, string> { Value = input });

                Console.WriteLine($"Delivered: '{deliveryResult.Value}' to '{deliveryResult.TopicPartitionOffset}'");
            }
            catch (ProduceException<Null, string> ex)
            {
                Console.WriteLine($"Error: {ex.Error.Reason}");
            }
        }
    }
}
