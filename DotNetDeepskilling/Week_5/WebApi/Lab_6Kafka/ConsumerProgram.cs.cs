using System;
using Confluent.Kafka;

class KafkaConsumerProgram
{
    static void Main(string[] args)
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "chat-consumer-group",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
        consumer.Subscribe("chatroom");

        Console.WriteLine("Listening to messages from Kafka (Ctrl+C to quit):");

        try
        {
            while (true)
            {
                var result = consumer.Consume();
                Console.WriteLine($"Received: {result.Message.Value}");
            }
        }
        catch (OperationCanceledException)
        {
            consumer.Close();
        }
    }
}
