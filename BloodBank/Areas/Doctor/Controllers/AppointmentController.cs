using BloodBank.Classes;
using BloodBankL.Data;
using BloodBankL.Models;
using BloodBankSystem.Models;
using Common;
using Donor.Data;
using Donor.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace BloodBank.Areas.Doctor.Controllers
{
    [Area("Doctor")]
    public class AppointmentController : Controller
    {
        #region Construction
        private readonly IDonarDonationData donationData;
        private readonly ISessionData Session;
        private readonly IDonorQuestionnaireData donorQuestionnaireData;
        private readonly IEmailSender email;
        private readonly IDonorInfoData donor;
        private readonly IDoctorData doctorData;
        private readonly IBloodTestResultData bloodTestResultData;
        private readonly IBloodRecordData bloodRecordData;
        public AppointmentController(IDonarDonationData donationData, ISessionData Session, IDonorQuestionnaireData donorQuestionnaireData, IEmailSender email, IDonorInfoData donor, IDoctorData doctorData, IBloodTestResultData bloodTestResultData, IBloodRecordData bloodRecordData)
        {
            this.donationData = donationData;
            this.Session = Session;
            this.donor = donor;
            this.donorQuestionnaireData = donorQuestionnaireData;
            this.email = email;
            this.doctorData = doctorData;
            this.bloodTestResultData = bloodTestResultData;
            this.bloodRecordData = bloodRecordData;
        }

        #endregion

        public async Task<IActionResult> Index(string KeyW = "", string DonorID = "", string NIC = "", string DonationDate = "", string BloodBankCentreID = "", string Status = "")
        {
            Auth.CheckDoctor();


            var obj = new DonarDonationSearchView();
            obj.KeyW = KeyW;
            obj.DonorID = DonorID;
            obj.NIC = NIC;

            obj.DonationDate = DonationDate;
            obj.DoctorID = Auth.GetDoctorID();
            obj.BloodBankCentreID = BloodBankCentreID;
            obj.Status = "AD";

            obj.RecordCount = await donationData.GetCount
                                (
                                    APIKey: AppData.GetAPIKey(),
                                    KeyW: KeyW.ToBlank(),
                                    DonorID: DonorID.ToBlank(),
                                    NIC: obj.NIC.ToBlank(),
                                    DonationDate: DonationDate.ToBlank(),
                                    BloodBankCentreID: BloodBankCentreID.ToBlank(),
                                    DoctorID: obj.DoctorID.ToBlank(),
                                    Status: "AD"


                                );
            obj.PaginationList = AppData.GetPaginationList(obj.RecordCount, obj.PageSize);

            return View(obj);
        }

        public async Task<ActionResult> _MainList(string KeyW = "", string DonorID = "", string NIC = "", string DonationDate = "", string BloodBankCentreID = "", string Status = "", int Page = 1, int PageSize = 99999)
        {
            Auth.CheckDoctorPartial();

            var objList = await donationData.GetList
                            (
                                APIKey: AppData.GetAPIKey(),
                                KeyW: KeyW.ToBlank(),
                                DonorID: DonorID.ToBlank(),
                                NIC: NIC,
                                DonationDate: DonationDate.ToBlank(),
                                BloodBankCentreID: BloodBankCentreID.ToBlank(),
                                DoctorID: Auth.GetDoctorID().ToBlank(),
                                Status: "AD",
                                Page: Page,
                                PageSize: PageSize
                            );

            return View(objList);
        }

        public async Task<ActionResult> Verify(string id)
        {
            Auth.CheckDoctor();
            var obj = new DonationAddEdit();
            obj.donarDonation = await donationData.Get(AppData.GetAPIKey(), ID: id);
            obj.questionnaire = await donorQuestionnaireData.Get(AppData.GetAPIKey(), ID: id);


            try
            {
                obj.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Verify(DonationAddEdit obj)
        {


            try
            {
                CheckDonationVerification checkDoctorVerification = new CheckDonationVerification();
                string result = checkDoctorVerification.ValidateDonation(obj);
                var objList = await donationData.Get(AppData.GetAPIKey(), ID: obj.donarDonation.DonotionID);
                if (string.IsNullOrEmpty(result))
                {
                    obj.donarDonation.Status = "DV";
                    
                }
                else
                {
                    obj.donarDonation.Status = "DD";
                    obj.donarDonation.RemarkRejected = result;

                }
                objList.DonotionID = obj.donarDonation.DonotionID;
                objList.Pulse = obj.donarDonation.Pulse;
                objList.BP = obj.donarDonation.BP;
                objList.HBLevel = obj.donarDonation.HBLevel;
                objList.Weight= obj.donarDonation.Weight;
                objList.Examination = obj.donarDonation.Examination;
                objList.Remark = obj.donarDonation.Remark;
                objList.Status = obj.donarDonation.Status;
                objList.RemarkRejected = obj.donarDonation.RemarkRejected;
                objList.DonotionID = await donationData.AddEdit
                                    (
                                       APIKey: AppData.GetAPIKey(),
                                       obj: objList,
                                       LogUserID: ""
                                    );
                if (string.IsNullOrEmpty(result))
                {
                    SendProcessEmail(objList.DonotionID, "");
                    TempData["SuccessMessage"] = $"#{objList.DonotionID} Donor is eligible to donate blood!";

                }
                else
                {
                    SendRejectEmail(objList.DonotionID, objList.RemarkRejected);
                    TempData["ErrorMessage"] = objList.RemarkRejected;

                }

                return Redirect("/Doctor/Appointment?Index");
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

            email.Subject = $"Donation # {donationID} - Verified Status";
            email.ToName = don.Name;
            email.Description += $"Congratulations {don.Name}, you are verified to donate blood!.<br /><br />";
            email.Description += "You can donate the blood .<br />";
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
            email.Description += $"Unfortunately, your blood donation request has been rejected by the appointed doctor. <br /><br />";
            email.Description += $"Please contact {donation.BloodBankCentre} for more information and instructions on how to reapply correctly.<br />";

            if (remarks != "")
            {
                email.Description += $"<br /><br />Notes:<br />{remarks}<br />";
            }

            email.ActionName = "View Donation Status";
            email.URL = $"[WebURL]/Donor/DonarDonation";

            email.Sendto = new List<string>(new[] { don.Email });

            await email.SendEmail();
        }

        public async Task<IActionResult> DonorPastDonation(string KeyW = "", string DonorID = "", string NIC = "", string DonationDate = "", string BloodBankCentreID = "", string Status = "")
        {
            Auth.CheckDoctor();


            var obj = new DonarDonationSearchView();
            obj.KeyW = KeyW;
            obj.DonorID = DonorID;
            obj.NIC = NIC;

            obj.DonationDate = DonationDate;
            obj.DoctorID = "";
            obj.BloodBankCentreID = BloodBankCentreID;
            obj.Status = Status;

            obj.RecordCount = await donationData.GetCount
                                (
                                    APIKey: AppData.GetAPIKey(),
                                    KeyW: KeyW.ToBlank(),
                                    DonorID: DonorID.ToBlank(),
                                    NIC: obj.NIC.ToBlank(),
                                    DonationDate: DonationDate.ToBlank(),
                                    BloodBankCentreID: BloodBankCentreID.ToBlank(),
                                    DoctorID: "",
                                    Status: Status.ToBlank()


                                );
            obj.PaginationList = AppData.GetPaginationList(obj.RecordCount, obj.PageSize);

            return View(obj);
        }

        public async Task<ActionResult> _MainListDonorPastDonation(string KeyW = "", string DonorID = "", string NIC = "", string DonationDate = "", string BloodBankCentreID = "", string Status = "", int Page = 1, int PageSize = 99999)
        {
            Auth.CheckDoctorPartial();

            var objList = await donationData.GetList
                            (
                                APIKey: AppData.GetAPIKey(),
                                KeyW: KeyW.ToBlank(),
                                DonorID: DonorID.ToBlank(),
                                NIC: NIC.ToBlank(),
                                DonationDate: DonationDate.ToBlank(),
                                BloodBankCentreID: BloodBankCentreID.ToBlank(),
                                DoctorID: "",
                                Status: Status.ToBlank(),
                                Page: Page,
                                PageSize: PageSize
                            );

            return View(objList);
        }


        public async Task<ActionResult> ViewDetails(string id)
        {
            Auth.CheckDoctor();

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



            var bloodTestResult = await bloodTestResultData.Get(APIKey: AppData.GetAPIKey(), ID: id);
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

        public async Task<IActionResult> DonorDetails(string id)
        {
            Auth.CheckDoctor();

            var obj = await donor.Get(AppData.GetAPIKey(), id);

            try
            {
                obj.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }

    }
}
