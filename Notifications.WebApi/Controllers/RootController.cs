using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Notifications.WebApi.Controllers
{
    [Route("/")]
    [ApiController]
    public class RootController : ControllerBase
    {
        [HttpGet(Name = nameof(GetRoot))]
        public IActionResult GetRoot()
        {
            var result = new
            {
                href = Url.Link(nameof(GetRoot), null),
                notifications = new
                {
                    href = Url.Link(
                       nameof(NotificationsController.GetAll), null )
                }
            };
            return Ok(result);
        }

    }
}