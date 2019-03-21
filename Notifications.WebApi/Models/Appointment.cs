using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Notifications.WebApi.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        [Required]
        public DateTime AppointmentDate { get; set; }
        [Required]
        public bool Canceled { get; set; }
        public string OrganisationName { get; set; }
        public string Reason { get; set; }

        [ForeignKey("User")]
        public Guid UserRefId { get; set; }
        public User User { get; set; }
    }
}