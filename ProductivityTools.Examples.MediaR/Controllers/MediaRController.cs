using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProductivityTools.Examples.MediaR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaRController : ControllerBase
    {
        [HttpGet("Test")]
        public ActionResult<string> Test()
        {
            return DateTime.Now.ToString();
        }
    }
}
