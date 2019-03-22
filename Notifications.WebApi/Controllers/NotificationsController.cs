using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Notifications.WebApi.Data;
using Notifications.WebApi.Models;
using Notifications.WebApi.Services;

namespace Notifications.WebApi.Controllers
{
    // [Route("api/[controller]")]
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        readonly INotificationService _service;
        public NotificationsController(INotificationService service)
        {
            _service = service;
        }

        //GET api/notifications
        [HttpGet(Name = nameof(GetAll))]
        public IActionResult GetAll()
        {
            try
            {
                var result = _service.QueryAll();
                return Ok(result);
            }
            catch
            {
                return new StatusCodeResult((int)HttpStatusCode.ServiceUnavailable);
            }

        }

        // POST api/notifications
        [HttpPost]
        public ActionResult SaveNotification([FromBody]Notification notification)
        {
           
            try
            {
                if (TryValidateModel(notification) &&
                    (_service.SaveNotification(notification) > 0))
                        return Ok(notification);
                return BadRequest();
            }
            catch
            {
                return BadRequest();

            }

        }


        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}
        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
