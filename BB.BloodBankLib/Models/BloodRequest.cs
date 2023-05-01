using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BloodBankL.Models
{
    public class BloodRequest
    {
        #region Data

        [Key]
        [Display(Name = "Blood Request ID")]
        public string BloodRequestID { get; set; }

        [Required(ErrorMessage = "Hospital ID is required.")]
        [Display(Name = "Hospital ID")]
        public string HospitalID { get; set; }

        [Required(ErrorMessage = "Patient name is required.")]
        [Display(Name = "Patient Name")]
        public string PatientName { get; set; }

        [Required(ErrorMessage = "Patient age is required.")]
        [Range(0, 150, ErrorMessage = "Patient age should be between 0 and 150.")]
        [Display(Name = "Patient Age")]
        public int PatientAge { get; set; }

        [Required(ErrorMessage = "Patient sex is required.")]
        [Display(Name = "Patient Sex")]
        public string PatientSex { get; set; }

        [Required(ErrorMessage = "Blood group is required.")]
        [Display(Name = "Blood Group")]
        public string BloodGroup { get; set; }

        [Required(ErrorMessage = "Doctor InCharge is required.")]
        [Display(Name = "Doctor InCharge")]
        public string DoctorInCharge { get; set; }

        [Required(ErrorMessage = "Doctor contact is required.")]
        [Display(Name = "Doctor Contact")]
        public string DoctorContact { get; set; }

        [Required(ErrorMessage = "Request Date is required.")]
        [Display(Name = "Request Date")]
        public DateTime DateOfRequest { get; set; }

        [Required(ErrorMessage = "Requirement Date is required.")]
        [Display(Name = "Requirement Date")]
        public DateTime DateTimeOfRequirement { get; set; }

        [Required(ErrorMessage = "Reason of transfusion is required.")]
        [Display(Name = "Reason of Transfusion")]
        [DataType(DataType.MultilineText)]
        public string ReasonOfTransfusion { get; set; }

        [Required(ErrorMessage = "Blood bank centre is required.")]
        [Display(Name = "Blood Bank")]
        public string BloodBankCentreID { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        [Display(Name = "Status")]
        public string Status { get; set; }

        #endregion


        #region Supporting

        public string ReturnURL { get; set; } = "/BloodRequest/Index";

        [Display(Name = "Hospital")]
        public string HospitalName { get; set; }

        [Display(Name = "Blood Bank")]
        public string BloodBankCentreName { get; set; }

        [Display(Name = "Telephone")]
        public string HPhoneNumber { get; set; }

        [Display(Name = "Address")]
        public string HAddress { get; set; }

        [Display(Name = "Location")]
        public string LocationName { get; set; }

        [Display(Name = "OutHospitalPhoneNumber")]
        public string OutHospitalPhoneNumber { get; set; }


        #endregion


        #region Display


        [Display(Name = "Patient Sex")]
        public string PatientSexText
        {
            get
            {
                string retVal = "";
                switch (PatientSex)
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
                        retVal = Status;
                        break;
                }
                return retVal;
            }
        }


        [Display(Name = "Status")]
        public string StatusText
        {
            get
            {
                string retVal = "";
                switch (Status)
                {
                    case "P":
                        retVal = "Processing";
                        break;

                    case "A":
                        retVal = "Accepted";
                        break;

                    case "NA":
                        retVal = "Not Available";
                        break;

                    case "RO":
                        retVal = "Rejected By Hospital ";
                        break;

                    case "RB":
                        retVal = "Rejected By Blood Bank ";
                        break;

                    case "DL":
                        retVal = "Delivered";
                        break;

                    default:
                        retVal = Status;
                        break;
                }
                return retVal;
            }
        }

        public string StatusClass
        {
            get
            {
                string retVal = "";
                switch (Status)
                {
                    case "P":
                        retVal = "primary";
                        break;

                    case "A":
                        retVal = "success";
                        break;

                    case "NA":
                        retVal = "warning";
                        break;

                    case "RO":
                        retVal = "secondary";
                        break;

                    case "RB":
                        retVal = "danger";
                        break;

                    case "DL":
                        retVal = "success";
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

    public class BloodRequestSearchView
    {
        public string KeyW { get; set; } = "";

        public string HospitalID { get; set; } = "";
        public string LocationID { get; set; } = "";
        public string DateTimeOfRequirement = "";
        public string Status { get; set; } = "";

        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public int RecordCount { get; set; } = 0;

        public List<int> PaginationList = new List<int>();
    }

    public class BloodRequestDetailView
    {
        public BloodRequest bloodRequest { get; set; }
        public BloodRequestDetails bloodrequestDetails { get; set; }

         
        //public List<BloodRequestDetails> BloodRequestDetailsList = new List<BloodRequestDetails>();

        public string ReturnURL { get; set; } = "/BloodRequest/Details";
    }



}
