using BugTrackingSystems.DAL;
using BugTrackingSystems.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackingSystems.Services
{
    public class TicketsService : ITicketService
    {
        private ApplicationDBContext _context;

        public TicketsService(ApplicationDBContext context)
        {
            _context = context;
        }
        public void CreateTicket(Ticket model)
        {          
          // save ticket
            _context.Ticket.Add(model);
            _context.SaveChanges();
        }

        public IEnumerable<Ticket> GetStatusOfTicket()
        {
            return _context.Ticket;
        }

        public void ChangeStatus(int id, string status)
        {

            var ticket = _context.Ticket.Where(x => x.TicketId == id).FirstOrDefault();
            ticket.Status = status;

            // copy model to user and save
            _context.Ticket.Update(ticket);
            _context.SaveChanges();
        }

        public void AssignTicket(int id, int assignTo)
        {

            var ticket = _context.Ticket.Where(x => x.TicketId == id).FirstOrDefault();
            ticket.AssignedTo = assignTo;

            // copy model to user and save
            _context.Ticket.Update(ticket);
            _context.SaveChanges();
        }
        public void CloseTicket(int id)

        {

            var ticket = _context.Ticket.Where(x => x.TicketId == id).FirstOrDefault();
            ticket.Status = "closed";

            // copy model to user and save
            _context.Ticket.Update(ticket);
            _context.SaveChanges();
        }


        public void CreateUser(App_User user)
        {
            // save ticket
            _context.App_User.Add(user);
            _context.SaveChanges();
        }

        public IEnumerable<App_User> GetAllUsers()
        {
            return _context.App_User;
        }

    }
}
