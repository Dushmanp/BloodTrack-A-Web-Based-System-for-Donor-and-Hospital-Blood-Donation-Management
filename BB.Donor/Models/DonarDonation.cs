﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Donor.Models
{
    public class DonarDonation
    {
        #region Data

        [Key]
        [Display(Name = "Donation ID")]
        public string DonotionID { get; set; }

        [Display(Name = "Donor ID")]
        public string DonorID { get; set; }

        [Display(Name = "Blood Bank Centre")]
        public string BloodBankCentreID { get; set; }

        [Display(Name = "Donation Date")]
        [DisplayFormat(DataFormatString = "{0:dddd, dd MMMM yyyy}")]
        public DateTime? DonationDate { get; set; }

        [Display(Name = "Questionnaire")]
        public string QuestionnaireID { get; set; }

        [Display(Name = "Doctor ID")]
        public string DoctorID { get; set; }

        [Display(Name = "DoctorName")]
        public string DoctorName { get; set; }

        [Display(Name = "Specialty")]
        public string Specialty { get; set; }
        
        [Display(Name = "Examination")]
        [Required(ErrorMessage = "Examination is required ")]
        public string Examination { get; set; }

        [Display(Name = "Pulse")]
        [Required(ErrorMessage = "Pulse is required ")]
        public float? Pulse { get; set; }

        [Display(Name = "Blood Pressure")]
        [Required(ErrorMessage = "Blood Pressure is required ")]
        [RegularExpression(@"^\d{2,3}/\d{2,3}$", ErrorMessage = "Blood Pressure should be entered in format like 120/80")]
        public string BP { get; set; }

      

        [Display(Name = "Hemoglobin Level")]
        [Required(ErrorMessage = "Hemoglobin level is required ")]
        public float HBLevel { get; set; }

        [Display(Name = "Weight")]
        [Required(ErrorMessage = "Weight is required ")]
        public float? Weight { get; set; }

        [Display(Name = "Remark")]
        [Required(ErrorMessage = "Remark is required ")]
        [DataType(DataType.MultilineText)]
        public string Remark { get; set; }

        [Display(Name = "Next Donation Date")]
        [DisplayFormat(DataFormatString = "{0:dddd, dd MMMM yyyy}")]
        public DateTime? NextDonationDate { get; set; }

        [Display(Name = "Blood Bag No")]
        public string BloodBagNo { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }

        [Display(Name = "Rejected Remark")]
        public string RemarkRejected { get; set; }

        [Display(Name = "FeedBack")]
        [DataType(DataType.MultilineText)]
        public string FeedBack { get; set; }


        

        #endregion


        #region Supporting

        public string ReturnURL { get; set; } = "Donor/DonarDonation/Index";

        [Display(Name = "Blood Bank")]
        public string BloodBankCentre { get; set; }


        [Display(Name = "Donor")]
        public string Name { get; set; }

        [Display(Name = "Contact")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Blood Type")]
        public string BloodType { get; set; }

        [Display(Name = "NIC")]
        public string NIC { get; set; }

        [Display(Name = "Donor")]
        public string Age { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Date Of Birth")]
        [DisplayFormat(DataFormatString = "{0:dddd, dd MMMM yyyy}")]
        public DateTime DateOfBirth { get; set; }
        
        [Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Occupation")]
        public string Occupation { get; set; }

        public string TestRecordPdfFile { get; set; }

        public DonorQuestionnaire questionnaire { get; set;}


        #endregion


        #region Display

        [Display(Name = "Status")]
        public string SpecialtyText
        {
            get
            {
                string retVal = "";
                switch (Specialty)
                {
                    case "AN":
                        retVal = "Anesthesiology";
                        break;


                    case "PA":
                        retVal = "Pathology";
                        break;

                    case "EM":
                        retVal = "Emergency Medicine";
                        break;

                    case "IM":
                        retVal = "Internal Medicine";
                        break;

                    case "OB":
                        retVal = "Obstetrics and Gynecology";
                        break;

                    case "OP":
                        retVal = "Ophthalmology";
                        break;

                    case "OS":
                        retVal = "Orthopedic Surgery";
                        break;

                    case "PS":
                        retVal = "Plastic Surgery";
                        break;

                    case "RA":
                        retVal = "Radiology";
                        break;

                    case "SU":
                        retVal = "Surgery";
                        break;

                    case "OT":
                        retVal = "Other";
                        break;

                    default:
                        retVal = "";
                        break;
                }
                return retVal;
            }
        }

        public string StatusClass
        {
            get
            {
                string retVal = "";
                switch (Status)
                {
                    case "E":
                        retVal = "warning";
                        break;

                    case "NE":
                        retVal = "danger";
                        break;
                    case "AD":
                        retVal = "secondary";
                        break;

                    case "DV":
                        retVal = "primary";
                        break;
                    case "DD":
                        retVal = "danger";
                        break;

                    case "D":
                        retVal = "info";
                        break;

                    case "C":
                        retVal = "success";
                        break;
                    case "T":
                        retVal = "dark";
                        break;

                    case "R":
                        retVal = "alert";
                        break;
                    default:
                        retVal = "";
                        break;
                }
                return retVal;
            }
        }


        public string StatusText
        {
            get
            {
                string retVal = "";
                switch (Status)
                {
                    case "E":
                        retVal = "Eligible";
                        break;

                    case "AD":
                        retVal = "Doctor Appointed";
                        break;
                    case "NE":
                        retVal = "Not Eligible";
                        break;

                    case "DV":
                        retVal = "Doctor Verified";
                        break;
                    case "DD":
                        retVal = "Doctor Declined";
                        break;
                    case "D":
                        retVal = "Donated";
                        break;

                    case "C":
                        retVal = "Completed";
                        break;

                    case "T":
                        retVal = "Transfusion";
                        break;

                     

                    default:
                        retVal = "";
                        break;
                }
                return retVal;
            }
        }

        [Display(Name = "Gender")]
        public string GenderText
        {
            get
            {
                string retVal = "";
                switch (Gender)
                {
                    case "M":
                        retVal = "Male";
                        break;

                    case "F":
                        retVal = "Female";
                        break;

                    case "NB":
                        retVal = "Non-binary";
                        break;

                    case "T":
                        retVal = "Transgender";
                        break;

                    case "O":
                        retVal = "Other";
                        break;

                    default:
                        retVal = "";
                        break;
                }
                return retVal;
            }
        }

        [Display(Name = "MaritalStatus")]
        public string MaritalStatusText
        {
            get
            {
                string retVal = "";
                switch (MaritalStatus)
                {
                    case "S":
                        retVal = "Single";
                        break;
                    case "M":
                        retVal = "Married";
                        break;
                    case "D":
                        retVal = "Divorced";
                        break;
                    case "SP":
                        retVal = "Separated";
                        break;
                    case "DP":
                        retVal = "Domestic Partnership";
                        break;
                    default:
                        retVal = "";
                        break;
                }
                return retVal;
            }
        }


        [Display(Name = "Occupation")]
        public string OccupationText
        {
            get
            {
                string retVal = "";
                switch (Occupation)
                {
                    case "SA":
                        retVal = "Sales";
                        break;
                    case "FN":
                        retVal = "Finance";
                        break;
                    case "EN":
                        retVal = "Engineering";
                        break;
                    case "HR":
                        retVal = "Human Resources";
                        break;
                    case "MK":
                        retVal = "Marketing";
                        break;
                    case "IT":
                        retVal = "Information Technology";
                        break;
                    case "OW":
                        retVal = "Office Worker";
                        break;
                    case "MD":
                        retVal = "Medicine";
                        break;
                    case "ED":
                        retVal = "Education";
                        break;
                    case "LG":
                        retVal = "Legal";
                        break;
                    case "AG":
                        retVal = "Agriculture";
                        break;
                    case "OT":
                        retVal = "Other";
                        break;
                    default:
                        break;
                }
                return retVal;
            }
        }

        public string ExaminationText 
        {
            get {

                string retVal = "";
                switch (Examination)
                {
                    case "NA":
                        retVal = "No any symptoms";
                        break;
                    case "FW":
                        retVal = "Feeling Unwell";
                        break;
                    case "NS":
                        retVal = "Not Sleeped 6 hrs";
                        break;
                    case "NM":
                        retVal = "Last meal not eaten <4hr>";
                        break;
                    case "HR":
                        retVal = "High Risk Behaviour";
                        break;
                    case "PL":
                        retVal = "looking or Pallor";
                        break;
                    case "LT":
                        retVal = "Lcterus";
                        break;
                    case "AC":
                        retVal = "Alcohol Smell";
                        break;
                    case "IW":
                        retVal = "Infectecd Wound";
                        break;
                    case "VL":
                        retVal = "Venepuncture Site Lesions";
                        break;
                    default:
                        retVal = "";
                        break;
                }
                return retVal;
            }
         
        }



        #endregion
      
    }

    public class DonarDonationSearchView
    {
        public string KeyW { get; set; } = "";
        public string DonorID { get; set; } = "";
        public string NIC { get; set; } = "";

        public string DonationDate { get; set; } = "";

        public string BloodBankCentreID { get; set; } = "";

        public string DoctorID { get; set; } = "";
        public string Status { get; set; } = "";

        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public int RecordCount { get; set; } = 0;

        public List<int> PaginationList = new List<int>();
    }
}
