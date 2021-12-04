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
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Hotelz.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TicketContext ticket_db;
        private readonly AccomodationContext accomodation_db;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ILogger<HomeController> logger, AccomodationContext a_db, TicketContext t_db, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            ticket_db = t_db;
            accomodation_db = a_db;
            _userManager = userManager;
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
            else if (type == "Hot Tours")
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
            if (GlobalVariables.Destination == null)
                ViewBag.text = "dont leave me empty =(";
            else
                ViewBag.text = "Enter your trip destination";

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CompileRoot(int t_id, int a_id, int t_length)
        {
            DateTime raw_date = DateTime.Now;
            DateTime date = raw_date.AddDays(1);
            ViewBag.date = date.ToString("dd-MM hh:mm");

            GlobalVariables.TicketId = t_id;
            GlobalVariables.AccomodationId = a_id;


            if (t_id == 0 || a_id == 0)
            {
                return RedirectToAction("RootsList");
            }

            System.Threading.Thread.Sleep(450);
            IEnumerable<Ticket> tickets = await ticket_db.Tickets.ToListAsync();
            IEnumerable<Accomodation> accomodations = await accomodation_db.Accomodations.ToListAsync();

            var RootsView = new RootsView();
            RootsView.Tickets = tickets.Where(ticket => ticket.Id == t_id);
            RootsView.Accomodation = accomodations.Where(accomodation => accomodation.Id == a_id);

            Accomodation a = RootsView.Accomodation.First();
            Ticket t = RootsView.Tickets.First();


            if (a.Term > 1 && t_length != 0)
                return RedirectToAction("RootsList");

            if (a.Term > 1)
            {
                GlobalVariables.TotalCost = a.Cost + t.Cost;
                ViewBag.Term = a.Term;
                ViewBag.Cost = a.Cost;
            }
            else
            {
                GlobalVariables.TotalCost = t_length * a.Cost + t.Cost;
                ViewBag.Term = t_length;
                ViewBag.Cost = t_length * a.Cost;
            }

            double to_add = t.TripLength / 2;
            DateTime a_date = date.AddHours(to_add);
            ViewBag.a_date = a_date.ToString("dd-MM hh:mm");

            if (a.Term > 1)
            {
                DateTime back_date = date.AddDays(a.Term);
                ViewBag.back_date = back_date.ToString("dd-MM hh:mm");

                DateTime a_back_date = back_date.AddHours(to_add);
                ViewBag.a_back_date = a_back_date.ToString("dd-MM hh:mm");
            }
            else
            {
                DateTime back_date = date.AddDays(t_length);
                ViewBag.back_date = back_date.ToString("dd-MM hh:mm");

                DateTime a_back_date = back_date.AddHours(to_add);
                ViewBag.a_back_date = a_back_date.ToString("dd-MM hh:mm");
            }


            return View(RootsView);
        }
        public IActionResult SystemError()
        {
            return View();
        }
        public async Task<IActionResult> BuyRoot()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            ViewBag.email = user.UserName;
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
            DateTime date = DateTime.Now.AddDays(1);
            ViewBag.date = date.ToString("dd-MM hh:mm");

            GlobalVariables.Destination = dest;

            if (dest == null)
            {
                return RedirectToAction("Index");
            }
            if (GlobalVariables.AccomodationId == 0 || GlobalVariables.TicketId == 0)
                ViewBag.Error = "You didnt choose tickets and accomodation";

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
            DateTime date = DateTime.Now.AddDays(1);
            ViewBag.date = date.ToString("dd-MM hh:mm");

            string dest = GlobalVariables.Destination;

            if (GlobalVariables.AccomodationId == 0 || GlobalVariables.TicketId == 0)
                ViewBag.Error = "You didnt choose tickets and accomodation!";

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
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AdminPanel()
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
