using ACB.Api;
using ACB.Base.Services;
using ACB.Base.Web.Controllers;
using ACB.Common.Models;
using ACB.Common.Models.Api.Duty;
using ACB.Identity.Infrastructure.Attributes;
using Duty.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Duty.Controllers
{
    [Authorize]
    public class AppController : DutyController
    {
        private readonly ILogger<AppController> _logger;
        private readonly IApiClient _apiClient;
        public AppController(ILogger<AppController> logger, 
            IACBService acbService, IApiClient apiClient) : base(logger, acbService, apiClient)
        {
            _logger = logger;
            _apiClient = apiClient;
        }

        public async Task<IActionResult> MyInstalls()
        {
            var model = new MyInstallViewModel
            {
                //MyCurrentStatus = "Unavailable"                
            };           

            return View(model);
        }

        [AuthorizePermission("AssignInstall")]
        public IActionResult Queue()
        {
            return View();
        }

        [AuthorizePermission("AreaEdit")]
        public IActionResult TechAdmin()
        {
            return View();
        }

        [AuthorizePermission("AreaEdit")]
        public IActionResult ManageInstallArea()
        {
            //_apiClient.


            return View();
        }

        [HttpGet]
        [AuthorizePermission("AssignInstall")]
        public IActionResult AssignTech(int id)
        {
            return View(new AssignInstallViewModel { AccountId = id, TechnicianUserId = 0});
        }

        [HttpPost]
        [AuthorizePermission("AssignInstall")]
        public async Task<IActionResult> AssignTech(AssignInstallInputModel model)
        {
            await _apiClient.AssignTechnician(model.AccountId, model.TechnicianUserId);


            return Json(new Resp<bool>());
        }

        [HttpPost]
        public async Task<IActionResult> SetTechStatus(SetTechStatusModel model)
        {
            var response = new Resp<bool>();
            response.Data = (await _apiClient.SetTechStatus(model, GetUserId())).Data;
            return Json(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetTechStatus()
        {
            var result = await _apiClient.GetTechStatus(GetUserId());
            var response = new Resp<SetTechStatusModel>();
            response.Data = result.Data;
            response.AddError(result.Errors);
            return Json(response);
        }
        public IActionResult RepScheduleDash()
        {
            return View();
        }
        public IActionResult RepScheduleDetail()
        {
            return View();
        }

        public IActionResult RepScheduleSelect()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> MyId()
        {
            

            return View(new MyIdViewModel { Id = await GetAccessToken() });
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
        public IActionResult GetCalendarData()
        {
            var eventsList = new List<CalendarAppointment>
            {
                new CalendarAppointment{Id = 1, Title = "3 Appointments", Start = "2022-06-11T10:00:00"},
                new CalendarAppointment{Id = 2, Title = "1 Appointments", Start = "2022-06-12T10:00:00"},
                new CalendarAppointment{Id = 3, Title = "4 Appointments", Start = "2022-06-12T11:00:00"},
                new CalendarAppointment{Id = 4, Title = "1 Appointments", Start = "2022-06-12T13:00:00"},
                new CalendarAppointment{Id = 5, Title = "1 Appointments", Start = "2022-06-12T14:00:00"},
                new CalendarAppointment{Id = 6, Title = "2 Appointments", Start = "2022-06-12T16:00:00"},
                new CalendarAppointment{Id = 7, Title = "1 Appointments", Start = "2022-06-13T12:00:00"}
            };

            return Json(eventsList);
        }
        [HttpGet]
        public IActionResult GetAppointmentData(int id)
        {
            if (id == 1) { 
            var appt = new Appointment { Id = 1, Assignee = "Amanda Rodgrigez", NeedsReassignment = true, ClientAddr = "123 Fake Street, Nowhere, AK", ClientName = "Bryan Burnham", Equipment = new string[] { "Equipment 1", "Equipment 2", "Equipment 3" }, Note = "House Smells Terrible", Timeslot = new DateTime(2022, 06, 06, 11, 0, 0) };
                return Json(appt);
            } else {
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