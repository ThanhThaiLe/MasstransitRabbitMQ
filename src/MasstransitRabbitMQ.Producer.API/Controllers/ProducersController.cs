using MassTransit;
using MasstransitRabbitMQ.Contract.Enumerations;
using Microsoft.AspNetCore.Mvc;
using static MasstransitRabbitMQ.Contract.IntergrationEvents.DomainEvent;

namespace MasstransitRabbitMQ.Producer.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProducersController : ControllerBase
    {
        private readonly IPublishEndpoint _publishEndpoint;
        public ProducersController(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        [HttpPost(Name = "publish-sms-notification")]
        public async Task<IActionResult> PublishSmsNotificationEvent()
        {
            await _publishEndpoint.Publish(new SmsNotifycationEvent()
            {
                Id = Guid.NewGuid(),
                Description = "Sms Description",
                Name = "Sms notifycation",
                TimeStamp = DateTime.Now,
                TransactionId = Guid.NewGuid(),
                Type = NotificationType.sms
            });
            return Accepted();
        }

    }
}