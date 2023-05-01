using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BloodBankl.Models
{
    public  class BloodBankCentre
    {

        #region Data

        [Key]
        [Display(Name = "Blood Bank Centre ID")]
        public string BloodBankCentreID { get; set; }

        [Display(Name = "Blood Bank Centre Name")]
        public string BloodBankCentreName { get; set; }

        [Display(Name = "Location ID")]
        public string LocationID { get; set; }

        public string BloodBankCentreDet { get; set; }


        #endregion


        #region Supporting

        public string ReturnURL { get; set; } = "/BloodBankCentre/Index";

        #endregion


        #region Display

        [Display(Name = "Location ID")]
        public string LocationName { get; set; }
        

        #endregion

    }
    public class BloodBankCentreSearchView
    {
        public string KeyW { get; set; } = "";
        public string LocationID { get; set; } = "";


        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public int RecordCount { get; set; } = 0;

        public List<int> PaginationList = new List<int>();
    }
}
