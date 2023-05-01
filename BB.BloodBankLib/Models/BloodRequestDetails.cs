using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BloodBankL.Models
{
    public class BloodRequestDetails
    {
        #region Data
        [Key]

        [Display(Name = "Blood Request Details ID")]
        public string BloodRequestDetailsID { get; set; }

        [Display(Name = "Blood Request ID")]
        public string BloodRequestID { get; set; }

        [Display(Name = "Whole Blood Unit")]
        //[Required(ErrorMessage = "Whole Blood Unit is required.")]
        public int? WholeBloodUnit { get; set; }

        [Display(Name = "Packed Cell Unit")]
        //[Required(ErrorMessage = "Packed Cell Unit is required.")]
        public int? PackedCellUnit { get; set; }

        [Display(Name = "Fresh Frozen Plasma Unit")]
        //[Required(ErrorMessage = "Fresh Frozen Plasma Unit is required.")]
        public int? FreshFrozenPlasmaUnit { get; set; }

        [Display(Name = "Platelet Components Unit")]
        //[Required(ErrorMessage = "Platelet Components Unit is required.")]
        public int? PlateletComponentsUnit { get; set; }

        [Display(Name = "Single Donor Platelet Unit")]
        //[Required(ErrorMessage = "Single Donor Platelet Unit is required.")]
        public int? SingleDonorPlateletUnit { get; set; }

        [Display(Name = "CryoPoor Plasma Unit")]
        //[Required(ErrorMessage = "CryoPoor Plasma Unit is required.")]
        public int? CryoPoorPlasmaUnit { get; set; }
        #endregion
        #region Supporting

        public string ReturnURL { get; set; } = "/BloodBankCentre/Index";

        #endregion

        #region Display

        #endregion
    }

    public class BloodRequestDetailsSearchView
    {
        public string KeyW { get; set; } = "";
        public string LocationID { get; set; } = "";

        public string Status { get; set; } = "";

        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public int RecordCount { get; set; } = 0;

        public List<int> PaginationList = new List<int>();
    }

}
