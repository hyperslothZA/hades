using Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.EventRepository
{
    public class EventRepository : IEventRepository
    {
        private readonly CheckInDbContext _context;

        public EventRepository(CheckInDbContext context)
        {
            _context = context;
        }

        public IEnumerable<EventEntity> GetAllEvents()
        {
            return _context.Events.ToList();
        }

        public EventEntity GetById(Guid id)
        {
            return  _context.Events.Find((EventEntity e) => e.Id == id);
        }
    }
}
