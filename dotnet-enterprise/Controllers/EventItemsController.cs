using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_enterprise.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnet_enterprise.Models;

namespace dotnet_enterprise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventItemsController : ControllerBase
    {
        private readonly IEventItemRepository _repository;

        public EventItemsController(IEventItemRepository repository)
        {
            _repository = repository;
        }

        // GET: api/EventItems
        [HttpGet]
        public Task<IEnumerable<EventItem>> GetEventItems()
        {
            return _repository.GetAllEventItems();
        }

        // GET: api/EventItems/favorites
        [HttpGet("favorites")]
        public Task<IEnumerable<EventItem>> GetFavoriteEventItems()
        {
            return _repository.GetFavorites();
        }
        
        // GET: api/EventItems/category/THEATER
        [HttpGet("filter/{filterType}/{keyword}")]
        public Task<IEnumerable<EventItem>> GetCategoryEventItems(string filterType, string keyword)
        {
            return _repository.GetCategoryEventItems(filterType, keyword);
        }

        //GET: api/EventItems/event/Semmi
        [HttpGet("event/{name}")]
        public Task<IEnumerable<EventItem>> GetEventItemByName(string name)
        {
            return _repository.GetEventItemByName(name);
        }


        // GET: api/EventItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventItem>> GetEventItem(long id)
        {
            var eventItem = await _repository.GetEventItem(id);

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
            if (id != eventItem.Id)
            {
                return BadRequest();
            }

            try
            {
                await _repository.Put(eventItem);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_repository.EventItemExists(id))
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
            await _repository.Post(eventItem);

            return CreatedAtAction(nameof(GetEventItem), new { id = eventItem.Id }, eventItem);
        }

        // DELETE: api/EventItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEventItem(long id)
        {
            var eventItem = await _repository.GetEventItem(id);
            if (eventItem == null)
            {
                return NotFound();
            }

            _repository.Delete(id);

            return NoContent();
        }
    }
}
