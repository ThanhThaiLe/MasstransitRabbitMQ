using MasstransitRabbitMQ.Contract.IntergrationEvents;
using MediatR;

namespace MasstransitRabbitMQ.Consumer.API.UseCase.Events
{
    public class SendSmsEventConsumerHandler : IRequestHandler<DomainEvent.SmsNotifycationEvent>
    {
        private readonly ILogger<SendSmsEventConsumerHandler> _logger;
        public SendSmsEventConsumerHandler(ILogger<SendSmsEventConsumerHandler> logger)
        {
            _logger = logger;
        }
        public async Task Handle(DomainEvent.SmsNotifycationEvent request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Message received: {messasge}", request);
        }
    }
}
