using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBFinalProject.bl;

namespace DBFinalProject.DL
{
    public class BeneficiaryDL
    {
        public static void AddBeneficiary(BeneficiaryBL beneficiary)
        {
            string query = $"Insert into Beneficiaries (FullName, DOB, Gender, Phone, Address) Values('{beneficiary.FullName}','{beneficiary.DOB}','{beneficiary.Gender}','{beneficiary.Phone}','{beneficiary.Address}') ;";
            SQL_Helper.ExecuteQuery(query);
        }

        public static void DeleteBeneficiary(int id)
        {
            string query = $"DELETE FROM Beneficiaries WHERE BeneficiaryID = {id};";
            SQL_Helper.ExecuteQuery(query);
        }
        public static void UpdateBeneficiary(int id, BeneficiaryBL b)
        {
            string query = $@"
        UPDATE Beneficiaries
        SET FullName = '{b.FullName}', 
            DOB = '{b.DOB:yyyy-MM-dd}', 
            Gender = '{b.Gender}', 
            Phone = '{b.Phone}', 
            Address = '{b.Address}' WHERE BeneficiaryID = {id};";

            SQL_Helper.ExecuteQuery(query);
        }
        //public static void UpdateBeneficiary(BeneficiaryBL beneficiary)
        //{
        //    string query = $"UPDATE Beneficiaries SET DOB = '{beneficiary.DOB}', Gender = '{beneficiary.Gender}', Phone = '{beneficiary.Phone}', Address = '{beneficiary.Address}' WHERE FullName = '{beneficiary.FullName}';";
        //    SQL_Helper.ExecuteQuery(query);
        //}
        public static DataTable ShowAllBeneficiaries()
        {
            string query = "Select * from Beneficiaries";
            DataTable dt = SQL_Helper.view(query);
            return dt;
        }
        public static DataTable GetAllBeneficiaryIDs()
        {
            string query = "SELECT BeneficiaryID FROM Beneficiaries"; 
            return SQL_Helper.view(query);
        }

    }
}
