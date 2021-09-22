using dotnet_enterprise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_enterprise.Models
{
    public class DatabaseEventItemRepository : IEventItemRepository
    {
        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public bool EventItemExists(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EventItem>> GetAllEventItems()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EventItem>> GetCategoryEventItems(string filterType, string keyword)
        {
            throw new NotImplementedException();
        }

        public Task<EventItem> GetEventItem(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EventItem>> GetEventItemByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EventItem>> GetFavorites()
        {
            throw new NotImplementedException();
        }

        public Task<EventItem> Post(EventItem eventItem)
        {
            throw new NotImplementedException();
        }

        public Task<EventItem> Put(EventItem eventItem)
        {
            throw new NotImplementedException();
        }
    }
}
