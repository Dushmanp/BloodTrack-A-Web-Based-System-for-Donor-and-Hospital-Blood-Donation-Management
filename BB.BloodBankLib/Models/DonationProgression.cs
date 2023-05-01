using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BloodBankL.Models
{
    public class DonationProgression
    {

        #region Data
        [Display(Name = "Period")]
        public int Month { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }

        [Display(Name = "Count")]
        public int Count { get; set; }
        #endregion

    }
}
