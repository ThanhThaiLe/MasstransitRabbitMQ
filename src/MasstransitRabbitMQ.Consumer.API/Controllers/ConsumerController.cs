using Microsoft.AspNetCore.Mvc;

namespace MasstransitRabbitMQ.Consumer.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsumerController : ControllerBase
    {


        public ConsumerController(ILogger<ConsumerController> logger)
        {
        }
    }
}