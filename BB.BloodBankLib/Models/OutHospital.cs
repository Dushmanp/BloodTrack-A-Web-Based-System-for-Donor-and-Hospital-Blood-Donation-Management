using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BloodBankL.Models
{
    public class OutHospital
    {
        #region Data
        [Key]
        [Display(Name = "Hospital ID")]
        public string HospitalID { get; set; }

        [Required(ErrorMessage = "Hospital Name is required.")]
        [Display(Name = "Hospital Name")]
        public string HospitalName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Contact Number is required")]
        [Display(Name = "Contact Number")]
        [RegularExpression(@"^(\+?\d{8,15})$", ErrorMessage = "Invalid Contact Number. Please enter a valid phone number in the format +[country code][phone number] or [phone number] with no spaces.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address is required")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Approved By is required.")]
        [Display(Name = "Approved By")]
        public string ApprovedBy { get; set; }

        [Required(ErrorMessage = "Location ID is required.")]
        [Display(Name = "Location ID")]
        public string LocationID { get; set; }

        #endregion


        #region Supporting

        [Display(Name = "Location Name")]
        public string LocationName { get; set; }

        [Display(Name = "Change Authentication")]
        public bool UseAuthentication { get; set; }

        public string ReturnURL { get; set; } = "/OHospital/Home/ProfileDetails";

        #endregion

        #region Display

         

        #endregion
    }
    public class OutHospitalSearchView
    {
        public string KeyW { get; set; } = "";
        public string LocationID { get; set; } = "";

        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public int RecordCount { get; set; } = 0;

        public List<int> PaginationList { get; set; } = new List<int>();
    }

}
