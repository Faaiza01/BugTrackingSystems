using BugTrackingSystems.DAL;
using BugTrackingSystems.Models;
using BugTrackingSystems.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackingSystems.Controllers
{
    //[ApiController]
    [Route("api/[controller]/[action]")]

    public class UserController : Controller
    {
        private readonly ApplicationDBContext _context;
        public ITicketService _ticketService;


        public UserController(ApplicationDBContext context, ITicketService ticketService)
        {
            _context = context;
            _ticketService = ticketService;
        }


        // GET: Tickets


        [HttpPost]
        public IActionResult CreateUser(UserDTO userDto)
        {
            var user = new App_User
            {
                Name = userDto.Name,
                Role = userDto.Role
            };
            _ticketService.CreateUser(user);
            return Ok(new { message = "User created" });
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _ticketService.GetAllUsers();
            return Ok(users);
        }
    }
}
