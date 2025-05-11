using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProject.bl
{
    public class DonorBL
    {
        public int DonorID { get; set; }
        public string DonorName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime JoinDate { get; set; }
        //public DonorBL(int donorID, string donorName, string email, string phone, DateTime joinDate)
        //{
        //    DonorID = donorID;
        //    DonorName = donorName;
        //    Email = email;
        //    Phone = phone;
        //    JoinDate = joinDate;
        //}
        public DonorBL(string donorName, string email, string phone, DateTime joinDate)
        {
            DonorName = donorName;
            Email = email;
            Phone = phone;
            JoinDate = joinDate;
        }
    }
}
