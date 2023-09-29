using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BugTrackingSystems.DAL;
using BugTrackingSystems.Models;
using BugTrackingSystems.Services;

namespace BugTrackingSystems.Controllers
{
    [Route("api/[controller]/[action]")]

    public class TicketsController : Controller
    {
        private readonly ApplicationDBContext _context;
        public ITicketService _ticketService;


        public TicketsController(ApplicationDBContext context, ITicketService ticketService)
        {
            _context = context;
            _ticketService = ticketService;
        }

        [HttpPost]
        public IActionResult CreateTicket(TicketDTO model)
        {
            var ticekt = new Ticket
            {
                Name = model.Name,
                Description = model.Description,
                Status = "new"

            };
            _ticketService.CreateTicket(ticekt);
            return Ok(new { message = "Ticket created" });
        }

        [HttpGet]
        public IActionResult GetStatusOfTicket()
        {
            var users = _ticketService.GetStatusOfTicket();
            return Ok(users);
        }

        [HttpPut("{id}")]
        public IActionResult CloseTicket(int id)
        {
            _ticketService.CloseTicket(id);
            return Ok(new { message = "Ticket closed" });
        }

        [HttpPut("{id}")]
        public IActionResult AssignTicket(int id, int assignTo)
        {
            _ticketService.AssignTicket(id, assignTo);
            return Ok(new { message = "Ticket Assigned" });
        }

        [HttpPut("{id}")]
        public IActionResult ChangeStatus(int id, string status)
        {
            _ticketService.ChangeStatus(id, status);
            return Ok(new { message = "User updated" });
        }

   

    

    }
}
