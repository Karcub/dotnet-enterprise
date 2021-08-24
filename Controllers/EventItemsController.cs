using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnet_enterprise.Models;

namespace dotnet_enterprise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventItemsController : ControllerBase
    {
        private readonly EventContext _context;

        public EventItemsController(EventContext context)
        {
            _context = context;
        }

        // GET: api/EventItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventItem>>> GetEventItems()
        {
            return await _context.EventItems.ToListAsync();
        }

        // GET: api/EventItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventItem>> GetEventItem(long id)
        {
            var eventItem = await _context.EventItems.FindAsync(id);

            if (eventItem == null)
            {
                return NotFound();
            }

            return eventItem;
        }

        // PUT: api/EventItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEventItem(long id, EventItem eventItem)
        {
            if (id != eventItem.EventId)
            {
                return BadRequest();
            }

            _context.Entry(eventItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/EventItems
        [HttpPost]
        public async Task<ActionResult<EventItem>> PostEventItem(EventItem eventItem)
        {
            _context.EventItems.Add(eventItem);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetEventItem", new { id = eventItem.Id }, eventItem);
            return CreatedAtAction(nameof(GetEventItem), new { id = eventItem.EventId }, eventItem);
        }

        // DELETE: api/EventItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEventItem(long id)
        {
            var eventItem = await _context.EventItems.FindAsync(id);
            if (eventItem == null)
            {
                return NotFound();
            }

            _context.EventItems.Remove(eventItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EventItemExists(long id)
        {
            return _context.EventItems.Any(e => e.EventId == id);
        }
    }
}
