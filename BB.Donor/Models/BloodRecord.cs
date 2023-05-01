using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donor.Models
{
    public class BloodRecord
    {

        [Key]
        [Display(Name = "Blood Record ID")]
        public string BloodRecordID { get; set; }

        [Required(ErrorMessage = "Blood bank centre  is required")]
        [Display(Name = "Blood Bank Centre ")]
        public string BloodBankCentreID { get; set; }

        [Required(ErrorMessage = "Donation ID is required")]
        [Display(Name = "Donation ")]
        public string DonationID { get; set; }

        [Required(ErrorMessage = "Processed date is required")]
        [Display(Name = "Processed Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ProcessedDate { get; set; }

        [Required(ErrorMessage = "Expiration date is required")]
        [Display(Name = "Expiration Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? ExpirationDate { get; set; }

        [Required(ErrorMessage = "Status is required")]
        [Display(Name = "Status")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [Display(Name = "Location")]
        public string Location { get; set; }

    }
    public class BloodRecordSearchView
        {
            public string KeyW { get; set; } = "";
            public string DonorID { get; set; } = "";
            public string NIC { get; set; } = "";

            public string DonationDate { get; set; } = "";
        public string ProcessedDate { get; set; } = "";
            

        public string BloodBankCentreID { get; set; } = "";
            public string Status { get; set; } = "";

            public int Page { get; set; } = 1;
            public int PageSize { get; set; } = 15;

            public int RecordCount { get; set; } = 0;

        public void Method()
        {

        }

        public List<int> PaginationList = new List<int>();
        }
}
