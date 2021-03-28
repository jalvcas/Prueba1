using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplication7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        [HttpGet]
        public string Ticket()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
