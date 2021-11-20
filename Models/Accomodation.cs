using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Hotelz.Models
{
    public class Accomodation
    {
        [Key]
        public int Id { get; set; }
        public string Location { get; set; }
        public string Hotel { get; set; }
        public double Term { get; set; }
        public double Cost { get; set; }
    }
}
