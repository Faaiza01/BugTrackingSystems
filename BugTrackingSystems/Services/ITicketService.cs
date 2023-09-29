using BugTrackingSystems.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackingSystems.Services
{
    public interface ITicketService
    {
        void CreateTicket(Ticket model);
        IEnumerable<Ticket> GetStatusOfTicket();
        void ChangeStatus(int id, string status);
        void CreateUser(App_User user);
        IEnumerable<App_User> GetAllUsers();
        void CloseTicket(int id);
        void AssignTicket(int id, int assignTo);

    }
}
