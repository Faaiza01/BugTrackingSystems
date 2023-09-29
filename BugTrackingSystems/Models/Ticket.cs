using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackingSystems.Models
{
    [Table("Ticket")]
    public class Ticket
    {
        [Key]
        public int? TicketId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int? AssignedTo { get; set; }
    }
}
