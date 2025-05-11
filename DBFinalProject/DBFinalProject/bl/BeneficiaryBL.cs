using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProject.bl
{
    public class BeneficiaryBL
    {
        public int BeneficiaryID { get; set; }
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }  // Can also be replaced with a C# enum
        public string Phone { get; set; }
        public string Address { get; set; }

        public BeneficiaryBL(int beneficiaryID, string fullName, DateTime dob, string gender, string phone, string address)
        {
            BeneficiaryID = beneficiaryID;
            FullName = fullName;
            DOB = dob;
            Gender = gender;
            Phone = phone;
            Address = address;
        }
        public BeneficiaryBL(string fullName, DateTime dob, string gender, string phone, string address)
        {
            FullName = fullName;
            DOB = dob;
            Gender = gender;
            Phone = phone;
            Address = address;
        }
    }
}
