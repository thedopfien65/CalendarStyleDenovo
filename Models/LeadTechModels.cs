using Newtonsoft.Json;
using System;
using System.Collections.Generic;

    //this would be an entity later methinks
    public class Appointment
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

    public class Timeslot
    {
        public DateTime Time { get; set; }
        public List<Appointment> Appointments { get; set; }
    }

    public class DayAppointments
    {
        public DateTime Day { get; set; }
        public List<Timeslot> Timeslots { get; set; }
    }
    
    public class TechTeamMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumAppts { get; set; }
    }

    public class LeadTechDashViewModel
    {
        //public List<Appointment> Appointments { get; set; }
        public string CalendarAppointments { get; set; }
        public List<TechTeamMember> TechTeam { get; set; }
        public List<Appointment> PendingAppts { get; set; }
    }

    public class ReassignViewModel
    {
        public Appointment TimeSlot { get; set; }
        public List<TechTeamMember> AvailableTechs { get; set; }
    }

    public class CalendarAppointment
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("start")]
        public string Start { get; set; }
    }