using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Notifications.WebApi.Models
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        public string UserName { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Notification> Notifications { get; set; }
    }
}
