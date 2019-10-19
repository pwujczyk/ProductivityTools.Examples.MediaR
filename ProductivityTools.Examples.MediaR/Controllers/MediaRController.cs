using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductivityTools.Examples.MediaR.Notification;
using ProductivityTools.Examples.MediaR.RequestResponse;

namespace ProductivityTools.Examples.MediaR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaRController : ControllerBase
    {
        IMediator Mediator;
        public MediaRController(IMediator mediator)
        {
            this.Mediator = mediator;
        }

        [HttpGet("Test")]
        public ActionResult<string> Test()
        {
            return DateTime.Now.ToString();
        }

        [HttpGet("RequestResponse")]
        public async Task<ActionResult<string>> RequestResponse()
        {
            var response = await Mediator.Send(new Ping());
            return response;
        }

        [HttpGet("Notify")]
        public string Notify()
        {
            Mediator.Publish(new Notify()).ConfigureAwait(false);
            return "s";
        }
    }
}
