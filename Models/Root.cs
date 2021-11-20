using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Hotelz.Models;

namespace Hotelz.Models
{
    public class Root
    {
        [Key]
        public int Id { get; set; }
        public double Cost { get; set; }

        public Ticket Ticket_id { get; set; } // ссылка на связанную модель Ticket
        public Ticket Ticket { get; set; }
        public Accomodation Accomodation_id { get; set; } // ссылка на связанную модель Accomodation
        public Accomodation Accomodation { get; set; }

    }
}
