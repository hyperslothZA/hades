using System.Collections;

namespace Domain.ViewModels
{
    public class EventViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Venue { get; set; }
        public string ResponsiblePerson { get; set; }
        public string EventType { get; set; }
        public IEnumerable Vehicles { get; set; }
    }
}
