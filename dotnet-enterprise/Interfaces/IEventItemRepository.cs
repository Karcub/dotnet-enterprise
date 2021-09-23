using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_enterprise.Models;

namespace dotnet_enterprise.Interfaces
{
    public interface IEventItemRepository
    {
        Task<IEnumerable<EventItem>> GetAllEventItemsAsync();
        Task<IEnumerable<EventItem>> GetFavoritesAsync();
        Task<IEnumerable<EventItem>> GetCategoryEventItemsAsync(string filterType, string keyword);
        Task<IEnumerable<EventItem>> GetEventItemByNameAsync(string name);
        Task<EventItem> GetEventItemAsync(long id);
        Task<EventItem> PutAsync(EventItem eventItem);
        Task<EventItem> PostAsync(EventItem eventItem);
        Task<EventItem> DeleteAsync(long id);
        bool EventItemExists(long id);
    }
}