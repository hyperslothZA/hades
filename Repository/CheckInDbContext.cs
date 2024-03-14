using Microsoft.EntityFrameworkCore;
using Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CheckInDbContext : DbContext
    {
        public CheckInDbContext(DbContextOptions<CheckInDbContext> options) : base(options)
        {
            
        }

        public DbSet<EventEntity> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=localhost;Port=32768;Username=myUser;Password=myPassword;Database=checkin");
        }
    }
}
