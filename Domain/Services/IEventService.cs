using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IEventService
    {
        IEnumerable<EventViewModel> GetEvents();
        EventViewModel GetEventById(Guid id);
    }
}
