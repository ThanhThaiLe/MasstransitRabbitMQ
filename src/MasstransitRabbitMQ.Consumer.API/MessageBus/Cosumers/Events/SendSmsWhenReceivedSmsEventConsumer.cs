using MasstransitRabbitMQ.Consumer.API.Abstracttions.Message;
using MasstransitRabbitMQ.Contract.IntergrationEvents;
using MediatR;

namespace MasstransitRabbitMQ.Consumer.API.MessageBus.Cosumers.Events
{

    public class SendSmsWhenReceivedSmsEventConsumer : Consumer<DomainEvent.SmsNotifycationEvent>
    {
        public SendSmsWhenReceivedSmsEventConsumer(ISender sender) : base(sender)
        {
        }
    }
}
