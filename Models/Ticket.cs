using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Hotelz.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public string Transport { get; set; }
        public double TripLength { get; set; }
        public double Cost { get; set; }
    }
}
