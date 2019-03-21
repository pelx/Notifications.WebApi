using Notifications.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notifications.WebApi.Services
{
    public interface INotificationService
    {
        IEnumerable<Notification> QueryAll();
    }
}
