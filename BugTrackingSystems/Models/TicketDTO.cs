using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackingSystems.Models
{
    public class TicketDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class UserDTO
    {
        public string Name { get; set; }
        public string Role { get; set; }
    }
}
