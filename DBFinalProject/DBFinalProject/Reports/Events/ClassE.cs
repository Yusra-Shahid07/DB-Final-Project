using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProject.Reports.Events
{
    public class ClassE
    {
        //Event.EventID, Event.EventName, Event.EventDate, Event.Location, EventCategory.CategoryName, Edition.Year
        public string EventName {  get; set; }
        public string EventDate { get; set; }
        public string Location { get; set; }
        public string CategoryName { get; set; }
        public int Year { get; set; }

        public ClassE(string eventName, string eventDate, string location, string categoryName, int year)
        {
            EventName = eventName;
            EventDate = eventDate;
            Location = location;
            CategoryName = categoryName;
            Year = year;
        }
    }
}
