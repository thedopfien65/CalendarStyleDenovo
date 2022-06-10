using CalendarTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarTest.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Calendar()
        {
            return View();
        }

        public JsonResult GetCalendarData()
        {
            var eventData = new List<CalendarModel>{
                new CalendarModel{Id = 1, Title = "3 Appointments", Start = "2022-06-11T10:00:00"},
                new CalendarModel{Id = 2, Title = "1 Appointments", Start = "2022-06-12T10:00:00"},
                new CalendarModel{Id = 3, Title = "4 Appointments", Start = "2022-06-12T11:00:00"},
                new CalendarModel{Id = 4, Title = "1 Appointments", Start = "2022-06-12T13:00:00"},
                new CalendarModel{Id = 5, Title = "1 Appointments", Start = "2022-06-12T14:00:00"},
                new CalendarModel{Id = 6, Title = "2 Appointments", Start = "2022-06-12T16:00:00"},
                new CalendarModel{Id = 7, Title = "1 Appointments", Start = "2022-06-13T12:00:00"}
            };
            return Json(eventData);
        }

        public IActionResult LeadTechSchedule()
        {
            var data = new LeadTechDashViewModel();
            data.TechTeam = new List<TechTeamMember>
            {
                new TechTeamMember{Id = 1, Name="Judd Klemaus", NumAppts = 0},
                new TechTeamMember{Id = 2, Name="Amanda Rodrigez", NumAppts = 4},
                new TechTeamMember{Id = 3, Name="Chad Wyatt", NumAppts = 6},
                new TechTeamMember{Id = 4, Name="Lizzie Brown", NumAppts = 7},
                new TechTeamMember{Id = 5, Name="Zach Wilson", NumAppts = 2},
            };

            data.PendingAppts = new List<Appointment>
            {
                new Appointment{Id = 1, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)},
                new Appointment{Id = 2, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)},
                new Appointment{Id = 3, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)},
                new Appointment{Id = 4, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)},
                new Appointment{Id = 5, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)}
            };

            data.CalendarAppointments = " ";

            //calendar appointments

            return View(data);
        }

        public IActionResult TechReassignmentForm(int id)
        {
            var data = new ReassignViewModel();
            if (id == 1)
            {
                data.TimeSlot = new Appointment { Id = 1, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr = "123 Fake Street, Nowhere, AK", ClientName = "Bryan Burnham", Equipment = new string[] { "Equipment 1", "Equipment 2", "Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0) };
            }
            else if (id == 2)
            {
                data.TimeSlot = new Appointment { Id = 2, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr = "123 Fake Street, Nowhere, AK", ClientName = "Bryan Burnham", Equipment = new string[] { "Equipment 1", "Equipment 2", "Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0) };
            }
            else
            {
                data.TimeSlot = new Appointment { Id = 0, Assignee = "Assigned Tech", NeedsReassignment = true, ClientAddr = "123 Fake Street, Nowhere, AK", ClientName = "Client Name", Equipment = new string[] { "Equipment 1", "Equipment 2", "Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0) };
            }

            data.AvailableTechs = new List<TechTeamMember>
            {
                new TechTeamMember{Id = 1, Name="Judd Klemaus", NumAppts = 0},
                new TechTeamMember{Id = 2, Name="Amanda Rodrigez", NumAppts = 4},
                new TechTeamMember{Id = 3, Name="Chad Wyatt", NumAppts = 6},
                new TechTeamMember{Id = 4, Name="Lizzie Brown", NumAppts = 7},
                new TechTeamMember{Id = 5, Name="Zach Wilson", NumAppts = 2},
            };

            return View(data);
        }

        public IActionResult TechSchedule(int id)
        {
            var data = new TechDashViewModel();
            if (id == 1)
            {
                data.UpcomingAppts = new List<Appointment>
            {
                new Appointment{Id = 1, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)},
                new Appointment{Id = 2, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)},
                new Appointment{Id = 3, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)},
                new Appointment{Id = 4, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)},
                new Appointment{Id = 5, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)}
            };

                data.TodaysAppts = new List<Appointment>
            {
                new Appointment{Id = 1, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)},
                new Appointment{Id = 2, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)},
                new Appointment{Id = 3, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)},
                new Appointment{Id = 4, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)},
                new Appointment{Id = 5, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)}
            };
            }
            else
            {
                data.UpcomingAppts = new List<Appointment>
            {
                new Appointment{Id = 1, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)},
                new Appointment{Id = 2, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)},
                new Appointment{Id = 3, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)},
                new Appointment{Id = 4, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)},
                new Appointment{Id = 5, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)}
            };

                data.TodaysAppts = new List<Appointment>
            {
                new Appointment{Id = 1, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)},
                new Appointment{Id = 2, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)},
                new Appointment{Id = 3, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)},
                new Appointment{Id = 4, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)},
                new Appointment{Id = 5, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr="123 Fake Street, Nowhere, AK", ClientName="Bryan Burnham", Equipment = new string[]{"Equipment 1","Equipment 2","Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0)}
            };
            }
            return View(data);
        }

        public IActionResult TechUpdateStatus(int id)
        {
            var data = new UpdateApptViewModel();
            if (id == 1)
            {
                data.TimeSlot = new Appointment { Id = 1, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr = "123 Fake Street, Nowhere, AK", ClientName = "Bryan Burnham", Equipment = new string[] { "Equipment 1", "Equipment 2", "Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0) };
            }
            else
            {
                data.TimeSlot = new Appointment { Id = 1, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr = "123 Fake Street, Nowhere, AK", ClientName = "Bryan Burnham", Equipment = new string[] { "Equipment 1", "Equipment 2", "Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0) };
            }
            return View(data);
        }

        [HttpGet]
        public IActionResult GetAppointmentData(int id)
        {
            if (id == 1)
            {
                var appt = new Appointment { Id = 1, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr = "123 Fake Street, Nowhere, AK", ClientName = "Bryan Burnham", Equipment = new string[] { "Equipment 1", "Equipment 2", "Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0) };
                return Json(appt);
            }
            else
            {
                var appt = new Appointment { Id = 2, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr = "123 Fake Street, Nowhere, AK", ClientName = "Bryan Burnham", Equipment = new string[] { "Equipment 1", "Equipment 2", "Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0) };
                return Json(appt);
            }
        }
        [HttpGet]
        public IActionResult GetDateAppointments()
        {
            var dayTimeslot = new List<Timeslot>
            {
                new Timeslot{Time = new DateTime(2022, 06, 06, 11, 0, 0),
                             Appointments = new List<Appointment>
                                            {
                                            new Appointment { Id = 1, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr = "123 Fake Street, Nowhere, AK", ClientName = "Bryan Burnham", Equipment = new string[] { "Equipment 1", "Equipment 2", "Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0) },
                                            new Appointment { Id = 2, Assignee = "Judd Klemaus", NeedsReassignment = true, ClientAddr = "123 Fake Street, Nowhere, AK", ClientName = "Bryan Burnham", Equipment = new string[] { "Equipment 1", "Equipment 2", "Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0) },
                                            new Appointment { Id = 3, Assignee = "Lizzie Brown", NeedsReassignment = true, ClientAddr = "123 Fake Street, Nowhere, AK", ClientName = "Bryan Burnham", Equipment = new string[] { "Equipment 1", "Equipment 2", "Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0) },
                                            }
                },
                new Timeslot{Time = new DateTime(2022, 06, 06, 13, 0, 0),
                             Appointments = new List<Appointment>
                                            {
                                            new Appointment { Id = 1, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr = "123 Fake Street, Nowhere, AK", ClientName = "Bryan Burnham", Equipment = new string[] { "Equipment 1", "Equipment 2", "Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0) },
                                            new Appointment { Id = 2, Assignee = "Judd Klemaus", NeedsReassignment = true, ClientAddr = "123 Fake Street, Nowhere, AK", ClientName = "Bryan Burnham", Equipment = new string[] { "Equipment 1", "Equipment 2", "Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0) },
                                            new Appointment { Id = 3, Assignee = "Lizzie Brown", NeedsReassignment = true, ClientAddr = "123 Fake Street, Nowhere, AK", ClientName = "Bryan Burnham", Equipment = new string[] { "Equipment 1", "Equipment 2", "Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0) },
                                            }
                },
            };
            var dayAppts = new DayAppointments();
            dayAppts.Day = DateTime.Now;
            dayAppts.Timeslots = dayTimeslot;
            return Json(dayAppts);
        }
    }
}
