using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Notifications.WebApi.Models
{
    public class Notification
    {
        [Required]
        public int NotificationId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public DateTime AppointmentDateTime { get; set; }
        [Required]
        public string OrganisationName { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Reason { get; set; }

        [ForeignKey("User")]
        public Guid UserRefId { get; set; }
        public User User { get; set; }
    }
}
