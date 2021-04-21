
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketsMNG.Contexts;
using TicketsMNG.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketsMNG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public TicketsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Ticket>> Get()
        {
            return context.Tickets.ToList();
        }

        [HttpGet("{id}", Name = "ObtenerTicket")]
        public ActionResult<Ticket> Get(int id)
        {
            var autor = context.Tickets.FirstOrDefault(x => x.Id == id);

            if (autor == null)
            {
                return NotFound();
            }

            return autor;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Ticket ticket)
        {
            // Esto no es necesario en asp.net core 2.1 en adelante
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            context.Tickets.Add(ticket);
            context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerAutor", new { id = ticket.Id }, ticket);

        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Ticket value)
        {
            // Esto no es necesario en asp.net core 2.1
            // if (ModelState.IsValid){

            // }

            if (id != value.Id)
            {
                return BadRequest();
            }

            context.Entry(value).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Ticket> Delete(int id)
        {
            var autor = context.Tickets.FirstOrDefault(x => x.Id == id);

            if (autor == null)
            {
                return NotFound();
            }

            context.Tickets.Remove(autor);
            context.SaveChanges();
            return autor;
        }
    }
}