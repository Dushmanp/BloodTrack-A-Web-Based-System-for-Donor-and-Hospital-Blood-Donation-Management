using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Donor.Models
{
    public class BloodTestResult
    {

        #region Data

        [Key]
        [Display(Name = "Test ID")]
        public string TestID { get; set; }

        [Required(ErrorMessage = "Donation ID is required")]
        [Display(Name = "Donation ID")]
        public string DonationID { get; set; }

        [Required(ErrorMessage = "Hemoglobin Level is required")]
        [Display(Name = "Hemoglobin Level")]
        public decimal HemoglobinLevel { get; set; }

        [Required(ErrorMessage = "Platelet Level is required")]
        [Display(Name = "Platelet Level")]
        public decimal PlateletLevel { get; set; }

        [Required(ErrorMessage = "HIV Test Result is required")]
        [Display(Name = "HIV Test Result")]
        public string HIVTestResult { get; set; }

        [Required(ErrorMessage = "White Blood Cell Count is required")]
        [Display(Name = "White Blood Cell Count")]
        public int WhiteBloodCellCount { get; set; }

        [Display(Name = "Remarks")]
        [Required(ErrorMessage = "Disease or Virus is required")]
        public string DiseaseOrVirus { get; set; }

        [Display(Name = "Disease or Virus")]
        [Required(ErrorMessage = "Disease or Virus is required")]
        public string DiseaseOrVirusStatus { get; set; }

        [Display(Name = "Test Record Pdf File")]
        public string TestRecordPdfFile { get; set; }
        [Display(Name = "Donation Date")]
        [DisplayFormat(DataFormatString = "{0:dddd, dd MMMM yyyy}")]
        public DateTime? DonationDate { get; set; }


        #endregion


        #region Supporting

        public string ReturnURL { get; set; } = "/Home/Index";

        #endregion


        #region Display


        #endregion

    }
    public class BloodTestResultSearchView
    {
        public string KeyW { get; set; } = "";
        public string DonorID { get; set; } = "";
        public string NIC { get; set; } = "";
        public string ProcessedDate { get; set; } = "";
        public string DonationDate { get; set; } = "";
        public string BloodBankCentreID { get; set; } = "";
        public string Status { get; set; } = "";

        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public int RecordCount { get; set; } = 0;

        public List<int> PaginationList = new List<int>();
    }
}
