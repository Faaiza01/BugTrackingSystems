using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackingSystems.Models
{

    [Table("App_User")]

    public class App_User
    {
        [Key]
        public int? UserId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

    }
}
