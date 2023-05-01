using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank.Models
{

    public class LoginView  
    {
        

        [Required(ErrorMessage = "Username is required")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirm password is required")]
        [Display(Name = "Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Old password is required")]
        [Display(Name = "Old Password")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }


        [Required(ErrorMessage = "Username address is required")]
         
        [Display(Name = "Usename Address")]
        public string Usename { get; set; }

        public string ReturnURL { get; set; }
        public bool RememberMe { get; set; }

        // Token

        [Display(Name = "Donor ID")]
        public string DonorID { get; set; } = "";

        [Display(Name = "Hospital ID")]
        public string HospitalID { get; set; } = "";

        [Display(Name = "Doctor ID")]
        public string DoctorID { get; set; } = "";

        [Display(Name = "User ID")]
        public string UserID { get; set; } = "";


        [Display(Name = "TokenID")]
        public string TokenID { get; set; } = "";

    }

}
