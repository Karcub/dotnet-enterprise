using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_enterprise.Models;

namespace dotnet_enterprise.Interfaces
{
    public interface IEventItemRepository
    {
        Task<IEnumerable<EventItem>> GetAllEventItems();
        Task<IEnumerable<EventItem>> GetFavorites();
        Task<IEnumerable<EventItem>> GetCategoryEventItems(string filterType, string keyword);
        Task<IEnumerable<EventItem>> GetEventItemByName(string name);
        Task<EventItem> GetEventItem(long id);
        Task<EventItem> Put(EventItem eventItem);
        Task<EventItem> Post(EventItem eventItem);
        void Delete(long id);
        bool EventItemExists(long id);
    }
}