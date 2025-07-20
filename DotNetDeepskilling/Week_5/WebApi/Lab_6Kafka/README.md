# Lab 6: Kafka Integration using C#

## Objective

The objective of this lab is to integrate Apache Kafka with a .NET application using C#. The lab involves creating a Kafka **producer** to send messages and a **consumer** to receive those messages from a Kafka topic.

---

## Method Used

- Used C# with .NET 6
- Used `Confluent.Kafka` NuGet package for Kafka integration
- Kafka and Zookeeper run locally
- Messages are exchanged using a topic called `test-topic`

---

## Explanation

Kafka is a distributed event streaming platform used for high-performance data pipelines. In this lab:

- The **producer** allows the user to input messages from the console and sends them to the Kafka topic.
- The **consumer** continuously listens to the Kafka topic and prints any new messages it receives.
- Both use the `Confluent.Kafka` library to interact with Kafka brokers.

---

## How to Run

### Prerequisites:
- Apache Kafka and Zookeeper running locally
- .NET 6 SDK installed
- Kafka topic `test-topic` created

### 1. Install the required NuGet package:

dotnet add package Confluent.Kafka

### 2. Run the Kafka Producer:

dotnet run --project KafkaProducer_program.cs

### 3. Run the Kafka Consumer:

dotnet run --project KafkaConsumer_program.cs

### Output
<img width="800" height="449" alt="image" src="https://github.com/user-attachments/assets/7fb2cf2b-6cdf-487b-8d64-5a9ec3cd1ba4" />
<img width="1280" height="719" alt="image" src="https://github.com/user-attachments/assets/7fd915a0-c4d4-4d8b-b543-1e07a0e69aa3" />

### Conclusion
This lab demonstrates how to produce and consume messages using Apache Kafka in a .NET application using C#. It is a foundational example of real-time message streaming and event-driven systems.

