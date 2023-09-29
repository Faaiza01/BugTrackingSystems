using BugTrackingSystems.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackingSystems.DAL
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<App_User> App_User { get; set; }

        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }

    }
}
