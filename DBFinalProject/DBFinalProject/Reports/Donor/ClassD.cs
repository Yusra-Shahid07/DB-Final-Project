using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProject.Reports.Donor
{
    public class ClassD
    {
        public int DonorID { get; set; }
        public string DonorName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Decimal Amount { get; set; }
        
        public ClassD(int donorID, string donorName, string email, string phone, Decimal amount)
        {
            DonorID = donorID;
            DonorName = donorName;
            Email = email;
            Phone = phone;
            Amount = amount;
        }
    }
}
