using MasstransitRabbitMQ.Consumer.API.Abstracttions.Message;
using MasstransitRabbitMQ.Contract.IntergrationEvents;
using MediatR;

namespace MasstransitRabbitMQ.Consumer.API.MessageBus.Cosumers.Events
{
    public class SendEmailWhenReceivedSmsEventConsumer : Consumer<DomainEvent.EmailNotifycation>
    {
        public SendEmailWhenReceivedSmsEventConsumer(ISender sender) : base(sender)
        {
        }
    }
}
