using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Hotelz.Models
{
    public class TicketContext : DbContext
    {
        public DbSet<Ticket> Tickets { set; get; }

        public TicketContext(DbContextOptions<TicketContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
