using BloodBank.Areas.Donor.Models;
using BloodBank.Classes;
using BloodBankl.Models;
using BloodBankL.Data;
using BloodBankL.Models;
using Common;
using Donor.Data;
using Donor.Models;
using DropDown;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank.Areas.Donor.Controllers
{
    [Area("Donor")]
    public class DonarDonationController : Controller
    {

        #region Construction

        private readonly IDonarDonationData donationData;
        private readonly ISessionData Session;
        private readonly IDonorInfoData donor;
        private readonly IDonorQuestionnaireData donorQuestionnaireData;
        private readonly IEmailSender email;
        private readonly IBloodRecordData bloodRecordData;
        private readonly IDoctorData doctorData;
        private readonly IBloodTestResultData testResultData;

        public DonarDonationController(IDonarDonationData donationData, ISessionData Session, IDonorInfoData donor, IDonorQuestionnaireData donorQuestionnaireData, IEmailSender email, IBloodTestResultData testResultData, IBloodRecordData bloodRecordData,IDoctorData doctorData)
        {
            this.donationData = donationData;
            this.Session = Session;
            this.donor = donor;
            this.donorQuestionnaireData = donorQuestionnaireData;
            this.email = email;
            this.testResultData = testResultData;
            this.bloodRecordData = bloodRecordData;
            this.doctorData = doctorData;
        }

        #endregion

        public async Task<IActionResult> Index(string KeyW = "",  string DonorID = "", string NIC = "", string DonationDate = "", string BloodBankCentreID = "", string Status = "")
        {
            Auth.CheckUser();
            
            var objDonor = await donor.Get(AppData.GetAPIKey(), ID: Auth.GetUserID());
            var obj = new DonarDonationSearchView();
            obj.KeyW = KeyW;
            obj.DonorID = DonorID;
            obj.NIC = objDonor.NIC;

            obj.DonationDate = DonationDate;

            obj.BloodBankCentreID = BloodBankCentreID;
            obj.Status = Status;  

            obj.RecordCount = await donationData.GetCount
                                (
                                    APIKey: AppData.GetAPIKey(),
                                    KeyW: KeyW.ToBlank(),
                                    DonorID: DonorID.ToBlank(),
                                    NIC: objDonor.NIC.ToBlank(),
                                    DonationDate: DonationDate.ToBlank(),
                                    BloodBankCentreID: BloodBankCentreID.ToBlank(),
                                    Status: Status.ToBlank()


                                );
            obj.PaginationList = AppData.GetPaginationList(obj.RecordCount, obj.PageSize);

            return View(obj);
        }

        public async Task<ActionResult> _MainList(string KeyW = "", string DonorID = "", string NIC = "", string DonationDate = "", string BloodBankCentreID = "", string Status = "", int Page = 1, int PageSize = 99999)
        {
            Auth.CheckUserPartial();
            var objDonor = await donor.Get(AppData.GetAPIKey(), ID: Auth.GetUserID());
            var objList = await donationData.GetList
                            (
                                APIKey: AppData.GetAPIKey(),    
                                KeyW: KeyW.ToBlank(),
                                DonorID: DonorID.ToBlank(),
                                NIC: objDonor.NIC,
                                DonationDate: DonationDate.ToBlank(),
                                BloodBankCentreID: BloodBankCentreID.ToBlank(),
                                Status: Status.ToBlank(),
                                Page: Page,
                                PageSize: PageSize
                            );

            return View(objList);
        }


        public async Task<ActionResult> Add()
        {
            Auth.CheckUser();
            var objDonor = await donor.Get(AppData.GetAPIKey(), ID: Auth.GetUserID());
            var objList = await donationData.GetList
                            (
                                APIKey: AppData.GetAPIKey(),
                                KeyW:"",
                                DonorID: "",
                                NIC: objDonor.NIC,
                                DonationDate: DateTime.Now.ToString("yyyy-MM-dd"),
                                BloodBankCentreID: "",
                                Status: "",
                                Page: 1,
                                PageSize: 199999
                            );
            if (objList.Any(x => new[] { "E", "AD",  "DV", "DD", "D", "C", "T" }.Contains(x.Status)))
            {
                TempData["ErrorMessage"] = "Dear Donor, we appreciate your willingness to donate blood. However, according to our donation policy, you are only eligible to donate once every 4 or 6 months. As you already have an ongoing donation, we kindly ask you to complete it before scheduling another one. Thank you for your understanding";
                return RedirectToAction("Index");
            }

            var obj = new DonorQuestionnaire();

            try
            {
                obj.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Add(DonorQuestionnaire obj)
        {
            

            try
            {
                CheckDonationVerification areAllAnswersCorrect = new CheckDonationVerification();
                string result = areAllAnswersCorrect.CheckResults(obj);
                var objDonation = new DonarDonation();

                 

                obj.QuestionnaireID = await donorQuestionnaireData.Add
                                    (
                                       APIKey: AppData.GetAPIKey(),
                                       obj: obj,
                                       LogUserID: ""
                                    );
            
                objDonation.DonorID = Auth.GetUserID();
                objDonation.BloodBankCentreID = obj.BloodBankCentreID;
                objDonation.DonationDate = DateTime.Now;
                objDonation.QuestionnaireID = obj.QuestionnaireID;
                objDonation.Status = result;
                if(result == "NE")
                {
                    objDonation.RemarkRejected = "We regret to inform you that you are currently unable to donate blood today due to health reasons.";
                    TempData["ErrorMessage"] = objDonation.RemarkRejected;
                }
                else
                {
                    TempData["SuccessMessage"] = $"Congratulations! you are eligible to donate blood! Please note that the doctor appointment may take some time depending on the queue and availability";
                }


                objDonation.DonotionID = "";
                objDonation.DonotionID = await donationData.AddEdit
                                    (
                                       APIKey: AppData.GetAPIKey(),
                                       obj: objDonation,
                                       LogUserID: ""
                                    );
                if (result == "E")
                {
                    SendProcessEmail(objDonation.DonotionID, "Please contact the "+ objDonation.BloodBankCentre + " for further information");
                }
                else
                {
                    SendRejectEmail(objDonation.DonotionID, objDonation.RemarkRejected);
                }

                return Redirect(obj.ReturnURL);
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to save record. " + ex.Message;
            }

            return View(obj);
        }


        private async void SendProcessEmail(string donationID, string remarks = "")
        {
            var donation = await donationData.Get(AppData.GetAPIKey(), ID: donationID);
            var don = await donor.Get(AppData.GetAPIKey(), donation.DonorID);

            email.Subject = $"Donation # {donationID} - Eligibility Status";
            email.ToName = don.Name;
            email.Description += $"Congratulations {don.Name}, you are eligible to donate blood!.<br /><br />";
            email.Description += "Please note that the doctor appointment may take some time depending on the queue and availability.<br />";
            //email.Description += $"For Further Information please contact our Blood Bank {donation.BloodBankCentre} .<br />";

            if (remarks != "")
            {
                email.Description += $"<br />Notes:<br />{remarks}<br />";
            }

            email.ActionName = "View Your Donation Status";
            email.URL = $"[WebURL]/Donor/DonarDonation";

            email.Sendto = new List<string>(new[] { don.Email });
            await email.SendEmail();
        }


        private async void SendRejectEmail(string donationID, string remarks = "")
        {
            var donation = await donationData.Get(AppData.GetAPIKey(), ID: donationID);
            var don = await donor.Get(AppData.GetAPIKey(), donation.DonorID);

            email.Subject = $"Donation # {donationID} - Rejected Status";
            email.ToName = don.Name;
            email.Description += $"Unfortunately, your blood donation request has been rejected today. <br /><br />";
            email.Description += $"Please contact {donation.BloodBankCentre} for more information and instructions on how to reapply correctly.<br />";

            if (remarks != "")
            {
                email.Description += $"<br />Notes:<br />{remarks}<br />";
            }

            email.ActionName = "View Donation Status";
            email.URL = $"[WebURL]/Donor/DonarDonation";

            email.Sendto = new List<string>(new[] { don.Email });

            await email.SendEmail();
        }


        public async Task<ActionResult> ViewDetails(string id)
        {
            Auth.CheckUser();

            var obj = new BloodDonationDetailView();
            obj.donarDonation = await donationData.Get(APIKey: AppData.GetAPIKey(), ID: id);
            obj.questionnaire = await donorQuestionnaireData.Get(APIKey: AppData.GetAPIKey(), ID: id);
            obj.donor = await donor.Get(APIKey: AppData.GetAPIKey(), ID: obj.donarDonation.DonorID);

            var doctor = await doctorData.Get(APIKey: AppData.GetAPIKey(), ID: obj.donarDonation.DoctorID);
            if (doctor == null)
            {
                TempData["Doctor"] = "Pending";
                doctor = new DoctorInfo();
            }



            var bloodTestResult = await testResultData.Get(APIKey: AppData.GetAPIKey(), ID: id);
            if (bloodTestResult == null)
            {
                TempData["bloodTestResult"] = "Pending";
                bloodTestResult = new BloodTestResult();
            }

            var bloodRecord = await bloodRecordData.Get(APIKey: AppData.GetAPIKey(), ID: id);
            if (bloodRecord == null)
            {
                TempData["bloodRecord"] = "Pending";
                bloodRecord = new BloodRecord();
            }
            obj.doctor = doctor;
            obj.bloodTestResult = bloodTestResult;
            obj.bloodRecord = bloodRecord;


            try
            {
                obj.donarDonation.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }


        public async Task<ActionResult> FeedBack(string DonotionID)
        {
            Auth.CheckUser();
            

            var obj =new DonarDonation();
            
            try
            {
                obj.DonotionID = DonotionID;
                obj.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> FeedBack(DonarDonation obj)
        {
           

            try
            {
                var donation = await donationData.Get(AppData.GetAPIKey(), ID: obj.DonotionID);
                donation.FeedBack = obj.FeedBack;

                donation.DonotionID = await donationData.AddEdit
                                   (
                                      APIKey: AppData.GetAPIKey(),
                                      obj: donation,
                                      LogUserID: ""
                                   );

                return Redirect(obj.ReturnURL);
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to save record. " + ex.Message;
            }

            return View(obj);
        }


    }
}
