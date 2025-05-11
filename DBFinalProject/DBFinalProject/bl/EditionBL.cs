using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProject.bl
{
    public class EditionsBL
    {
        public int EditionID { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }

     
        public EditionsBL(int year, string description)
        {
            Year = year;
            Description = description;
        }
    }
}
