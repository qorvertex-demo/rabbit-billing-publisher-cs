using RabbitMQ.Client;
namespace Acme.Billing
{
    class InvoicePublisher
    {
        public void Send(IModel channel, byte[] body)
        {
            channel.BasicPublish(exchange: "", routingKey: "billing-tasks", basicProperties: null, body: body);
        }
    }
}
