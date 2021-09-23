using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_enterprise.Interfaces;

namespace dotnet_enterprise.Models
{
    public class EventItemRepository : IEventItemRepository
    {
        private readonly EventContext _context;
        public EventItemRepository(EventContext context)
        {
            _context = context;
        }
        public async Task<EventItem> Delete(long id)
        {
            var eventItem = await _context.EventItems.FindAsync(id);
            _context.EventItems.Remove(eventItem);
            await _context.SaveChangesAsync();
            return eventItem;
        }

        public bool EventItemExists(long id)
        {
            return _context.EventItems.Any(e => e.Id == id);
        }

        public async Task<IEnumerable<EventItem>> GetAllEventItems()
        {
            return await _context.EventItems.ToListAsync();
        }

        public async Task<IEnumerable<EventItem>> GetCategoryEventItems(string filterType, string keyword)
        {
            return await _context.EventItems
                .Where(item => filterType.Equals("category") ? item.Category == keyword : item.City == keyword)
                .ToListAsync();
        }

        public async Task<EventItem> GetEventItem(long id)
        {
            
            return await _context.EventItems.FindAsync(id);
        }

        public async Task<IEnumerable<EventItem>> GetEventItemByName(string name)
        {
            return await _context.EventItems.Where(item => item.Name.ToLower().Contains(name.ToLower())).ToListAsync();
        }

        public async Task<IEnumerable<EventItem>> GetFavorites()
        {
            return await _context.EventItems.Where(item => item.IsFavorite).ToListAsync();
        }

        public async Task<EventItem> Post(EventItem item)
        {
            _context.EventItems.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<EventItem> Put(EventItem item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return item;
        }
    }
}