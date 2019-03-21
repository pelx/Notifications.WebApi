using Microsoft.AspNetCore.Mvc;
using Notifications.WebApi.Data;
using Notifications.WebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace Notifications.WebApi.Services
{
    public class NotificationService : INotificationService
    {
        public IEnumerable<Notification> QueryAll()
        {
            //return new List<Notification>();
            using (var context = new AppDbContext())
            {
                return context.Notifications.ToList();
            }
        }

        public int SaveNotification(Notification notification)
        {
            using (var context = new AppDbContext())
            {
                context.Notifications.Add(notification);
                return context.SaveChanges();
            }

        }
    }
}