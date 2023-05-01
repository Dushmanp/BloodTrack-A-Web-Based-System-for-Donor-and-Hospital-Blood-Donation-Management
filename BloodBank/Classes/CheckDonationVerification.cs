using Donor.Models;
using DropDown;
using Microsoft.AspNetCore.Hosting;
using System.Linq;
using System.Text.RegularExpressions;

namespace BloodBank.Classes
{
    public class CheckDonationVerification
    {
       

        public string CheckResults(DonorQuestionnaire obj)
        {
            if (obj.Q1Prob == 0 && obj.Q1Doctor == 0 && obj.Q1Health == 1 && obj.Q2medCond == 0 && obj.Q3Medication == 0 && obj.Q4Surgery == 0 && obj.Q5Heavywork == 0 && obj.Q6Pregnant == 0 && obj.Q7YellowFever == 0 && obj.Q7TbTyphoid == 0 && obj.Q7Treated == 0 && obj.Q8Immunization == 0 && obj.Q8TattooAcupuncture == 0 && obj.Q8Abroad == 0 && obj.Q8Prison == 0 && obj.Q8Blood == 0 && obj.Q8Malaria == 0 && obj.Q9Dengue == 0 && obj.Q9Fever == 0 && obj.Q9Teeth == 0 && obj.Q10Categories == 0 && obj.Q11PartnerCategory == 0 && obj.Q12Symptoms == 0)
            {
                return "E";
            }
            else
            {
                return "NE";
            }
        }


        public  string ValidateDonation(DonationAddEdit obj)
        {
            var rejectedRemark = "";

            // Validate pulse
            if (obj.donarDonation.Pulse < 50 || obj.donarDonation.Pulse > 100 )
            {
                rejectedRemark += "Donation rejected due to Pulse rate is not in between 50 and 100 beats per minute. ";
            }
          

            // Validate blood pressure
            if (!ValidateBloodPressure(obj.donarDonation.BP))
            {
                rejectedRemark += "Donation rejected due to Blood pressure not  below 180 systolic and 100 diastolic. ";
            }

            // Validate hemoglobin level
            if (!ValidateHemoglobinLevel(obj.donarDonation.HBLevel, obj.donarDonation.Gender))
            {
                rejectedRemark += "Donation rejected due to Hemoglobin level (minimum 12.5 g/dL for women and 13.0 g/dL for men, maximum 20 g/dL). ";
            }

            // Validate weight
            if (obj.donarDonation.Weight < 50 )
            {
                rejectedRemark += "Donation rejected due to Weight should be at least 50 kg. ";
            }
            if (obj.donarDonation.Examination != "NA")
            {
                rejectedRemark += "Donation rejected due to Doctor Examination: ";
                switch (obj.donarDonation.Examination)
                {
                    case "RD":
                        rejectedRemark += "Rejected because of doctor recommandation";
                        break;

                    case "FW":
                        rejectedRemark += "Feeling Unwell";
                        break;
                    case "NS":
                        rejectedRemark += "Not Sleeped 6 hrs";
                        break;
                    case "NM":
                        rejectedRemark += "Last meal not eaten <4hr>";
                        break;
                    case "HR":
                        rejectedRemark += "High Risk Behaviour";
                        break;
                    case "PL":
                        rejectedRemark += "looking or Pallor";
                        break;
                    case "LT":
                        rejectedRemark += "Lcterus";
                        break;
                    case "AC":
                        rejectedRemark += "Alcohol Smell";
                        break;
                    case "IW":
                        rejectedRemark += "Infectecd Wound";
                        break;
                    case "VL":
                        rejectedRemark += "Venepuncture Site Lesions";
                        break;
                    default:
                        rejectedRemark += "Unknown reason";
                        break;
                }
            }
            return rejectedRemark;
        }

        // Helper function to validate blood pressure
        private bool ValidateBloodPressure(string bloodPressure)
        {
            var pattern = new Regex(@"^\d{1,3}\/\d{1,3}$");
            if (pattern.IsMatch(bloodPressure))
            {
                var systolic = int.Parse(bloodPressure.Split('/')[0]);
                var diastolic = int.Parse(bloodPressure.Split('/')[1]);
                if (systolic < 180 && diastolic < 100)
                {
                    return true;
                }
            }
            return false;
        }

        // Helper function to validate hemoglobin level
        private bool ValidateHemoglobinLevel(float hemoglobinLevel, string gender)
        {
            if (gender == "M" && hemoglobinLevel >= 13.0 && hemoglobinLevel <= 20.0)
            {
                return true;
            }
            else if (gender == "F" && hemoglobinLevel >= 12.5 && hemoglobinLevel <= 20.0)
            {
                return true;
            }
            return false;
        }


    }
}
