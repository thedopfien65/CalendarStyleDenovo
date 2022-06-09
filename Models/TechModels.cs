using System;
using System.Collections.Generic;

namespace Duty.Models
{
    //this would be an entity later methinks
    public class TechAppointment
    {
        public int Id { get; set; }
        public string Assignee { get; set; }
        public bool NeedsReassignment { get; set; }
        public DateTime Timeslot { get; set; }
        public string ClientName { get; set; }
        public string ClientAddr { get; set; }
        public string[] Equipment { get; set; }
        public string Note { get; set; }
    }
  
    public class TechDashViewModel
    {
        //public List<Appointment> Appointments { get; set; }
        public string CalendarAppointments { get; set; }
        public List<Appointment> TodaysAppts { get; set; }
        public List<Appointment> UpcomingAppts { get; set; }
    }

    public class UpdateApptViewModel
    {
        public Appointment TimeSlot { get; set; }
    }
}