using Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.EventRepository
{
    public interface IEventRepository
    {
        IEnumerable<EventEntity> GetAllEvents();
        EventEntity GetById(Guid id);
    }
}
