using Domain.Services;
using Domain.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;
        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet(Name = "GetAllEvents")]
        public IEnumerable<EventViewModel> Get()
        {
            var results = _eventService.GetEvents();

            return results;
        }

        [HttpGet(Name = "GetEventById")]
        public EventViewModel Get(Guid id) 
        { 
            return _eventService.GetEventById(id);
        }
    }
}
