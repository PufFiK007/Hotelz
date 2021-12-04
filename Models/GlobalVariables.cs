using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Hotelz.Models
{
    public class GlobalVariables
    {
        public static string Destination { get; set; } = "q";
        public static int TicketId { get; set; } = 1;
        public static int AccomodationId { get; set; } = 1;
        public static double TotalCost { get; set; }
    }
}
