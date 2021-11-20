using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Hotelz.Models
{
    public class AccomodationContext : DbContext
    {
        public DbSet<Accomodation> Accomodations { set; get; }

        public AccomodationContext(DbContextOptions<AccomodationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
