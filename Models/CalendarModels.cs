using System.Collections.Generic;

namespace CalendarTest.Models
{
    public class CalendarModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Start { get; set; }
    }

    public class CalendarEvents
    {
        public List<CalendarModel> Events { get; set; }
    }
}
