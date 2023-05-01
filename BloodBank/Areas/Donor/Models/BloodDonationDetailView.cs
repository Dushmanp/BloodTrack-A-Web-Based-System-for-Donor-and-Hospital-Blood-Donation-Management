using BloodBankl.Models;
using BloodBankL.Models;
using Donor.Models;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BloodBank.Areas.Donor.Models
{
    public class BloodDonationDetailView
    {
        public DonorInfo donor { get; set; }
        public DonarDonation donarDonation { get; set; }

        public BloodTestResult bloodTestResult { get; set; }

        public DonorQuestionnaire questionnaire { get; set; }
        public DoctorInfo doctor { get; set; }

        public BloodBankCentre bloodBank { get; set; }

        public BloodRecord bloodRecord { get; set; }

        [Display(Name = "Upload PDF")]
        [Required(ErrorMessage = "Please select a PDF file.")]
        [FileExtensions(Extensions = "pdf", ErrorMessage = "Please select a PDF file.")]
        public IFormFile FileUpload { get; set; }

    }
}
