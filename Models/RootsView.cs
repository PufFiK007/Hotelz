using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotelz.Models
{
    public class RootsView
    {
        public IEnumerable<Ticket> Tickets { get; set; }
        public IEnumerable<Accomodation> Accomodation { get; set; }
    }
}
