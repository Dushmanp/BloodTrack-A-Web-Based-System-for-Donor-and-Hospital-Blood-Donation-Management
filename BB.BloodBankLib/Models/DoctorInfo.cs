using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BloodBankL.Models
{
    public class DoctorInfo
    {

        #region Data
        [Key]
        [Display(Name = "ID")]
        public string DoctorID { get; set; }

        [Display(Name = "Doctor Name")]
        public string FullName { get; set; }

        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "Contact no.")]
        [RegularExpression(@"^(\+?\d{8,15})$", ErrorMessage = "Invalid Contact Number. Please enter a valid phone number in the format +[country code][phone number] or [phone number] with no spaces.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Blood bank centre ID")]
        public string BloodBankCentreID { get; set; }

        [Display(Name = "Specialty")]
        public string Specialty { get; set; }

        [Display(Name = "License no.")]
        public string LicenseNumber { get; set; }

        [Display(Name = "License expiration date")]
        [DataType(DataType.Date)]
        public DateTime? LicenseExpirationDate { get; set; }

        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        #endregion

        #region Supporting

        public string ReturnURL { get; set; } = "/Doctor/Index";

        [Display(Name = "Blood bank")]
        public string BloodBankCentre { get; set; }
        #endregion


        #region Display

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


        [Display(Name = "Specialty")]
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

                    #endregion

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
    }

        public class DoctorInfoSearchView
    {
        public string KeyW { get; set; } = "";
        public string LocationID { get; set; } = "";
        public string BloodBankCentreID { get; set; } = "";

        public string Specialty { get; set; } = "";

        public string Gender { get; set; } = "";

        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public int RecordCount { get; set; } = 0;

        public List<int> PaginationList = new List<int>();

        public string ItemListText { get; set; }
    }
}
