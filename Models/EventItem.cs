using System;

namespace dotnet_enterprise.Models
{
    public class EventItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsFavorite { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Location { get; set; }
        public string EventUrl { get; set; }
        public long UserId { get; set; }
        public DateTime Date { get; set; }

    }
}