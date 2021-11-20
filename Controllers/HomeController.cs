using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Hotelz.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Hotelz.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TicketContext ticket_db;
        private readonly AccomodationContext accomodation_db;

        public HomeController(ILogger<HomeController> logger, AccomodationContext a_db, TicketContext t_db)
        {
            _logger = logger;
            ticket_db = t_db;
            accomodation_db = a_db;
        }

        [HttpPost]
        public async Task<IActionResult> Sort(string type)
        {
            System.Threading.Thread.Sleep(200);
            IEnumerable<Ticket> tickets = await ticket_db.Tickets.ToListAsync();
            IEnumerable<Accomodation> accomodations = await accomodation_db.Accomodations.ToListAsync();

            IEnumerable<Ticket> s_tickets = new List<Ticket>();
            IEnumerable<Accomodation> s_accomodations = new List<Accomodation>();

            var RootsView = new RootsView();

            RootsView.Tickets = tickets.Where(ticket => ticket.Destination == GlobalVariables.Destination);
            RootsView.Accomodation = accomodations.Where(accomodation => accomodation.Location == GlobalVariables.Destination);

            if (type == "Economic")
            {
                s_tickets = RootsView.Tickets.OrderBy(t => t.Cost);
                s_accomodations = RootsView.Accomodation.OrderBy(a => a.Cost);

            }
            else if (type == "Luxury")
            {
                s_tickets = RootsView.Tickets.OrderByDescending(t => t.Cost);
                s_accomodations = RootsView.Accomodation.OrderByDescending(a => a.Cost);
            }
            else if (type == "Long Term")
            {
                s_tickets = RootsView.Tickets;
                s_accomodations = RootsView.Accomodation.OrderByDescending(a => a.Term);
            }
            else
            {
                return View("SystemError");
            }

            RootsView.Tickets = s_tickets;
            RootsView.Accomodation = s_accomodations;

            return View(RootsView);

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SystemError()
        {
            return View();
        }
        public IActionResult NoRoots()
        {
            return View();
        }
        public IActionResult EmptyField()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RootsList(string dest)
        {
            if (dest == null)
                return RedirectToAction("EmptyField");

            GlobalVariables.Destination = dest;
            System.Threading.Thread.Sleep(450);
            IEnumerable<Ticket> tickets = await ticket_db.Tickets.ToListAsync();
            IEnumerable<Accomodation> accomodations = await accomodation_db.Accomodations.ToListAsync();

            var RootsView = new RootsView();
            RootsView.Tickets = tickets.Where(ticket => ticket.Destination == dest);
            RootsView.Accomodation = accomodations.Where(accomodation => accomodation.Location == dest);

            if (RootsView.Tickets.Count() == 0 && RootsView.Accomodation.Count() == 0)
                return RedirectToAction("NoRoots");

            return View(RootsView);
        }
        public async Task<IActionResult> RootsList()
        {
            IEnumerable<Ticket> tickets = await ticket_db.Tickets.ToListAsync();
            IEnumerable<Accomodation> accomodations = await accomodation_db.Accomodations.ToListAsync();

            var RootsView = new RootsView();
            RootsView.Tickets = tickets;
            RootsView.Accomodation = accomodations;

            return View(RootsView);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AddAccomodation()
        {
            return View();
        }
        public IActionResult AddTickets()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTickets(Ticket ticket)
        {
            ticket_db.Tickets.Add(ticket);
            // сохраняем в бд все изменения
            if (ticket != null)
                ticket_db.SaveChanges();

            return RedirectToAction("RootsList");
        }
        [HttpPost]
        public IActionResult AddAccomodation(Accomodation accomodation)
        {
            accomodation_db.Accomodations.Add(accomodation);
            // сохраняем в бд все изменения
            if (accomodation != null)
                accomodation_db.SaveChanges();

            return RedirectToAction("RootsList");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
