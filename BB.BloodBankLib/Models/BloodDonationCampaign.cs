using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BloodBankL.Models
{
    public class BloodDonationCampaign
    {
        [Key]
        [Display(Name = "Campaign ID")]
        public string CampaignID { get; set; }

        [Required(ErrorMessage = "Organizer name is required.")]
        [Display(Name = "Organizer Name")]
        public string OrganizerName { get; set; }

        [Required(ErrorMessage = "Organizer address is required.")]
        [Display(Name = "Organizer Address")]
        [DataType(DataType.MultilineText)]
        public string OrganizerAddress { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Display(Name = "Phone Number")]
        [RegularExpression(@"^(\+?\d{8,15})$", ErrorMessage = "Invalid Contact Number. Please enter a valid phone number in the format +[country code][phone number] or [phone number] with no spaces.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Blood bank centre ID is required.")]
        [Display(Name = "Blood Bank Centre ID")]
        public string BloodBankCentreID { get; set; }

        [Display(Name = "Registration Date")]
        public DateTime? RegistrationDate { get; set; }

        [Display(Name = "Verified By")]
        public string VerifiedBy { get; set; }

        [Required(ErrorMessage = "Start date is required.")]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End date is required.")]
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Target address is required.")]
        [Display(Name = "Target Address")]
        [DataType(DataType.MultilineText)]
        public string TargetAddress { get; set; }

        [Required(ErrorMessage = "Target location is required.")]
        [Display(Name = "Target Location")]
        public string TargetLocation { get; set; }

        [Display(Name = "Number Of Donors")]
        [Required(ErrorMessage = "Number Of Donors is required.")]
        public int? NumberOfDonors { get; set; }

        [Display(Name = "Status")]
        public string ActiveStatus { get; set; }

        public string Location { get; set; }
        public string BloodBankCentre { get; set; }

        #region Supporting

        public string ReturnURL { get; set; } = "/Campaign/Index";

        #endregion

        #region Display


        [Display(Name = "Status")]
        public bool ActiveStatusBool
        {
            get
            {
                return ActiveStatus == "A";
            }

            set
            {
                this.ActiveStatus = value ? "A" : "I";
            }
        }

        [Display(Name = "Status")]
        public string ActiveStatusText
        {
            get
            {
                string retVal = "";
                switch (ActiveStatus)
                {
                    case "A":
                        retVal = "Active";
                        break;

                    case "I":
                        retVal = "Inactive";
                        break;

                    default:
                        retVal = ActiveStatus;
                        break;
                }
                return retVal;
            }
        }

        [Display(Name = "Status")]
        public string ActiveStatusClass
        {
            get
            {
                string retVal = "";
                switch (ActiveStatus)
                {
                    case "A":
                        retVal = "primary";
                        break;

                    case "I":
                        retVal = "danger";
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

    public class BloodDonationCampaignSearchView
    {
        public string APIKey { get; set; }
        public string KeyW { get; set; } = "";
        public string RegistrationDate { get; set; } = "";
        public string BloodBankCentreID { get; set; } = "";
        public string LocationID { get; set; } = "";
        public string StartDate { get; set; } = "";
        public string ActiveStatus { get; set; } = "";


        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public int RecordCount { get; set; } = 0;

        public List<int> PaginationList = new List<int>();
    }
}
