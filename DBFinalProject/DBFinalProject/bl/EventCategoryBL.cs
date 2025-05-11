using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProject.bl
{
    public class EventCategoryBL
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public EventCategoryBL(int categoryID, string categoryName, string description)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
            Description = description;
        }
        public EventCategoryBL(string categoryName, string description)
        {
            CategoryName = categoryName;
            Description = description;
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
