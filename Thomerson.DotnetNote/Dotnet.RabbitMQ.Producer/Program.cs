using RabbitMQ.Client;
using System;

namespace Dotnet.RabbitMQ.Producer
{
    /// <summary>
    /// 生产者
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //1.1.实例化连接工厂
            var factory = new ConnectionFactory() { HostName = "localhost" };
            //2. 建立连接
            using (var connection = factory.CreateConnection())
            {
                //3. 创建信道
                using (var channel = connection.CreateModel())
                {
                    //4. 申明队列
                    //将消息标记为持久性 - 将IBasicProperties.SetPersistent设置为true
                    //通过指定durable: true，并指定Persistent = true，来告知RabbitMQ将消息持久化。
                    channel.QueueDeclare(queue: "hello", durable: false, exclusive: false, autoDelete: false, arguments: null);

                    //var properties = channel.CreateBasicProperties();
                    //properties.Persistent = true;

                    //设置prefetchCount : 1来告知RabbitMQ，在未收到消费端的消息确认时，不再分发消息，也就确保了当消费端处于忙碌状态时
                    channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);

                    //5. 构建byte消息数据包
                    string message = args.Length > 0 ? args[0] : "Hello RabbitMQ!";
                    var body = System.Text.Encoding.UTF8.GetBytes(message);
                    //6. 发送数据包
                    channel.BasicPublish(exchange: "", routingKey: "hello", basicProperties: null, body: body);
                    Console.WriteLine(" [x] Sent {0}", message);
                }
            }
            //Console.WriteLine("Hello World!");
        }
    }
}

/* ************
 * Exchange
 * RabbitMQ提供了Exchange，它类似于路由器的功能，它用于对消息进行路由，将消息发送到多个队列上。
 * Exchange一方面从生产者接收消息，另一方面将消息推送到队列。
 * 但exchange必须知道如何处理接收到的消息，是将其附加到特定队列还是附加到多个队列，还是直接忽略。而这些规则由exchange type
 * 常见的exchange type 有以下几种：
    fanout （消息广播，将消息分发到exchange上绑定的所有队列上）
    direct（明确的路由规则：消费端绑定的队列名称必须和消息发布时指定的路由名称一致）
    topic （模式匹配的路由规则：支持通配符）
 *
        Publisher：生产者，消息的发送方。
        Connection：网络连接。
        Channel：信道，多路复用连接中的一条独立的双向数据流通道。
        Exchange：交换器（路由器），负责消息的路由到相应队列。
        Binding：队列与交换器间的关联绑定。消费者将关注的队列绑定到指定交换器上，以便Exchange能准确分发消息到指定队列。
        Queue：队列，消息的缓冲存储区。
        Virtual Host：虚拟主机，虚拟主机提供资源的逻辑分组和分离。包含连接，交换，队列，绑定，用户权限，策略等。
        Broker：消息队列的服务器实体。
        Consumer：消费者，消息的接收方。

*    */
