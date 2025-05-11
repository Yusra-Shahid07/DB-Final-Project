using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProject.bl
{
    public class EventBL
    {
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public int EditionID { get; set; }
        public string Location { get; set; }
        public int CategoryID { get; set; }
        
        public EventBL(string eventName, DateTime eventDate,int editionId, string location, int categoryID)
        {
            EventName = eventName;
            EventDate = eventDate;
            EditionID = editionId;
            Location = location;
            CategoryID = categoryID;
        }
        public static bool IsAllAlphabetsOrSpace(string input)
        {
            foreach (char c in input)
            {
                if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c == ' '))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
