using Domain.ViewModels;
using Repository.Model;
using Repository.Repositories.EventRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;
        public EventService(IEventRepository eventRepository)
        {

            _eventRepository = eventRepository;
        }

        public IEnumerable<EventViewModel> GetEvents()
        {
            var result = _eventRepository.GetAllEvents();

            var eventView = CreateEventView(result);

            return eventView;
        }

        public EventViewModel GetEventById(Guid id)
        { 
            var result = _eventRepository.GetById(id);

            var eventView = new EventViewModel
            {
                Id = result.Id,
                Name = result.Name,
                Description = result.Description,
                Venue = result.Venue,
                ResponsiblePerson = result.ResponsiblePerson,
                EventType = result.EventType,
            };

            return eventView;
        }

        private IEnumerable<EventViewModel> CreateEventView(IEnumerable<EventEntity> events)
        {
            return events.Select(e => new EventViewModel
            {
                Id = e.Id,
                Name = e.Name,
                Description = e.Description,
                Venue = e.Venue,
                ResponsiblePerson = e.ResponsiblePerson,
                EventType = e.EventType,
            });
        }
    }
}
