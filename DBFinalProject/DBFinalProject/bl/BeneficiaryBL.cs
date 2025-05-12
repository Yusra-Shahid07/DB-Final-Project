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
        public string DOB { get; set; }
        public string Gender { get; set; } 
        public string Phone { get; set; }
        public string Address { get; set; }

        public BeneficiaryBL(int beneficiaryID, string fullName, string dob, string gender, string phone, string address)
        {
            BeneficiaryID = beneficiaryID;
            FullName = fullName;
            DOB = dob;
            Gender = gender;
            Phone = phone;
            Address = address;
        }
        public BeneficiaryBL(string fullName, string dob, string gender, string phone, string address)
        {
            FullName = fullName;
            DOB = dob;
            Gender = gender;
            Phone = phone;
            Address = address;
        }
    }
}
