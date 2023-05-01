using BloodBankl.Models;
using BloodBankL.Data;
using BloodBankL.Models;
using BloodBankSystem.Models;
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
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace BloodBank.Areas.BloodBankSystem.Controllers
{
    [Area("BloodBankSystem")]
    public class DonorDonationController : Controller
    {
        #region Construction
        private readonly IDoctorData doctorData;
        private readonly IDonarDonationData donarDonationData;
        private readonly IEmailSender email;
        private readonly IDonorInfoData donor;
        private readonly IBloodTestResultData testResultData;
        private readonly IBloodRecordData bloodRecordData;
        private readonly ICommonDDL commonDDL;
        private readonly IDonorQuestionnaireData questionnaireData;
        public DonorDonationController(IDoctorData doctorData,IEmailSender email, IDonarDonationData donarDonationData, IDonorInfoData donor, IBloodTestResultData testResultData, IBloodRecordData bloodRecordData, ICommonDDL commonDDL, IDonorQuestionnaireData questionnaireData)
        {
            this.doctorData = doctorData;

            this.email = email;
            this.donarDonationData = donarDonationData;
            this.donor = donor;
            this.testResultData = testResultData;
            this.bloodRecordData = bloodRecordData;
            this.commonDDL = commonDDL;
            this.questionnaireData = questionnaireData;
        }
        #endregion


        public async Task<IActionResult> Index(string KeyW = "", string DonorID = "", string NIC = "", string DonationDate = "", string BloodBankCentreID = "",string DoctorID="", string Status = "")
        {
            Auth.CheckBB();


            var obj = new DonarDonationSearchView();
            obj.KeyW = KeyW;
            obj.DonorID = DonorID;
            obj.NIC = NIC;

            obj.DonationDate = DonationDate;
            obj.DoctorID = DoctorID;
            obj.BloodBankCentreID = BloodBankCentreID;
            obj.Status = Status;

            obj.RecordCount = await donarDonationData.GetCount
                                (
                                    APIKey: AppData.GetAPIKey(),
                                    KeyW: KeyW.ToBlank(),
                                    DonorID: DonorID.ToBlank(),
                                    NIC: NIC.ToBlank(),
                                    DonationDate: DonationDate.ToBlank(),
                                    BloodBankCentreID: BloodBankCentreID.ToBlank(),
                                    DoctorID: DoctorID.ToBlank(),
                                    Status: Status.ToBlank()


                                );
            obj.PaginationList = AppData.GetPaginationList(obj.RecordCount, obj.PageSize);

            return View(obj);
        }

        public async Task<ActionResult> _MainList(string KeyW = "", string DonorID = "", string NIC = "", string DonationDate = "", string BloodBankCentreID = "", string DoctorID = "", string Status = "", int Page = 1, int PageSize = 99999)
        {
            Auth.CheckBBPartial();

            var objList = await donarDonationData.GetList
                            (
                                APIKey: AppData.GetAPIKey(),
                                KeyW: KeyW.ToBlank(),
                                DonorID: DonorID.ToBlank(),
                                NIC: NIC.ToBlank(),
                                DonationDate: DonationDate.ToBlank(),
                                BloodBankCentreID: BloodBankCentreID.ToBlank(),
                                DoctorID: DoctorID.ToBlank(),
                                Status: Status.ToBlank(),
                                Page: Page,
                                PageSize: PageSize
                            );

            return View(objList);
        }

        public async Task<IActionResult> MarkDonated(string KeyW = "", string DonorID = "", string NIC = "", string DonationDate = "", string BloodBankCentreID = "", string DoctorID = "", string Status = "")
        {
            Auth.CheckBB();


            var obj = new DonarDonationSearchView();
            obj.KeyW = KeyW;
            obj.DonorID = DonorID;
            obj.NIC = NIC;

            obj.DonationDate = DonationDate;
            obj.DoctorID = DoctorID;
            obj.BloodBankCentreID = BloodBankCentreID;
            obj.Status = Status;

            obj.RecordCount = await donarDonationData.GetCount
                                (
                                    APIKey: AppData.GetAPIKey(),
                                    KeyW: KeyW.ToBlank(),
                                    DonorID: DonorID.ToBlank(),
                                    NIC: NIC.ToBlank(),
                                    DonationDate: DonationDate.ToBlank(),
                                    BloodBankCentreID: BloodBankCentreID.ToBlank(),
                                    DoctorID: DoctorID.ToBlank(),
                                    Status: "DV"


                                );
            obj.PaginationList = AppData.GetPaginationList(obj.RecordCount, obj.PageSize);

            return View(obj);
        }

        public async Task<ActionResult> _MainListMarkDonated(string KeyW = "", string DonorID = "", string NIC = "", string DonationDate = "", string BloodBankCentreID = "", string DoctorID = "", string Status = "", int Page = 1, int PageSize = 99999)
        {
            Auth.CheckBBPartial();

            var objList = await donarDonationData.GetList
                            (
                                APIKey: AppData.GetAPIKey(),
                                KeyW: KeyW.ToBlank(),
                                DonorID: DonorID.ToBlank(),
                                NIC: NIC.ToBlank(),
                                DonationDate: DonationDate.ToBlank(),
                                BloodBankCentreID: BloodBankCentreID.ToBlank(),
                                DoctorID: DoctorID.ToBlank(),
                                Status: "DV",
                                Page: Page,
                                PageSize: PageSize
                            );

            return View(objList);
        }



        public async Task<IActionResult> DocAppointment(string KeyW = "",string LocationID="", string BloodBankCentreID = "", string Specialty = "", string Gender = "")
        {

            Auth.CheckBBPartial();


            var obj = new DoctorInfoSearchView();
            obj.KeyW = KeyW;
            obj.LocationID= LocationID;
            obj.BloodBankCentreID = BloodBankCentreID;
            obj.Specialty = Specialty;
            obj.Gender = Gender;

            obj.RecordCount = await doctorData.GetCount
                                (
                                    APIKey: AppData.GetAPIKey(),
                                    KeyW: KeyW.ToBlank(),
                                    LocationID: LocationID.ToBlank(),
                                    BloodBankCentreID: BloodBankCentreID.ToBlank(),
                                    Specialty: Specialty.ToBlank(),
                                    Gender: Gender.ToBlank()
                                );
            obj.PaginationList = AppData.GetPaginationList(obj.RecordCount, obj.PageSize);

            return View(obj);
          
        }

        public async Task<ActionResult> _MainListDoc(string KeyW = "", string LocationID = "", string BloodBankCentreID = "", string Specialty = "", string Gender = "", int Page = 1, int PageSize = 99999)
        {
            Auth.CheckBBPartial();

            var objList = await doctorData.GetList
                            (
                                APIKey: AppData.GetAPIKey(),
                                KeyW: KeyW.ToBlank(),
                                LocationID: LocationID.ToBlank(),
                                BloodBankCentreID: BloodBankCentreID.ToBlank(),
                                Specialty: Specialty.ToBlank(),
                                Gender: Gender.ToBlank(),
                                Page: Page,
                                PageSize: PageSize
                            );

            return View(objList);
        }


        public async Task<ActionResult> _MainListDonation(string KeyW = "", string DonorID = "", string NIC = "", string DonationDate = "", string BloodBankCentreID = "", string Status = "", int Page = 1, int PageSize = 99999)
        {
            Auth.CheckBBPartial();
         
            var objList = await donarDonationData.GetList
                            (
                                APIKey: AppData.GetAPIKey(),
                                KeyW: KeyW.ToBlank(),
                                DonorID: DonorID.ToBlank(),
                                NIC: NIC.ToBlank(),
                                DonationDate: DateTime.Now.ToString("yyyy-MM-dd"),
                                BloodBankCentreID: BloodBankCentreID.ToBlank(),
                                Status: "E",
                                Page: Page,
                                PageSize: PageSize
                            );

            return View(objList);
        }

        [HttpPost]
        public async Task<ActionResult> AppointDoctor(DoctorInfoSearchView obj)
        {
            Auth.CheckBB();
            List<string> donationIDs = new List<string>();
            try
            {
                string[] lines = obj.ItemListText.Split(new[] { "[LINE]" }, StringSplitOptions.None);

                foreach (var line in lines)
                {
                    string[] cols = line.Split(new[] { "[TAB]" }, StringSplitOptions.None);

                    var objDonation = await donarDonationData.Get(APIKey: AppData.GetAPIKey(), ID: cols[0]);
                    objDonation.Status = "AD";
                    objDonation.DonotionID = cols[0];
                    objDonation.DoctorID = cols[1];
                    objDonation.DonotionID = await donarDonationData.AddEdit
                                   (
                                      APIKey: AppData.GetAPIKey(),
                                      obj: objDonation,
                                      LogUserID: ""
                                   );
                    donationIDs.Add(objDonation.DonotionID);
                }

                foreach (var donationID in donationIDs)
                {
                    await SendProcessEmail(donationID);
                }

                TempData["SuccessMessage"] = "Donors appointment is successfull ";
                return RedirectToAction("DocAppointment", "DonorDonation", new { Areas = "BloodBankSystem" });

            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Unable to save record. " + ex.Message;
            }

            return RedirectToAction("DocAppointment", "DonorDonation", new { Areas = "BloodBankSystem" });
        }


        private async Task SendProcessEmail(string donationID)
        {
            var donation = await donarDonationData.Get(AppData.GetAPIKey(), ID: donationID);
            var don = await donor.Get(AppData.GetAPIKey(), donation.DonorID);

            email.Subject = $"Donation # {donationID} - Doctor Appointed Status";
            email.ToName = don.Name;
            email.Description += $"the doctor have appointed {don.Name}, you are verification process can be start when you available at  the  {donation.BloodBankCentre} - !.<br /><br />";
          
            email.Description += $"For Further Information please contact our Blood Bank {donation.BloodBankCentre} .<br />";

            email.ActionName = "View Your Donation Status";
            email.URL = $"/Donor/DonarDonation";

            email.Sendto = new List<string>(new[] { don.Email });
            await email.SendEmail(true);
        }



        public async Task<JsonResult> AddDonated(string DonotionID, string BloodBagNo)
        {

            try
            {
                if (DonotionID == null || DonotionID == "")
                {
                    return Json(new { success = false, responseText = "Invalid parameters" });
                }

                var objDonation = await donarDonationData.Get(APIKey: AppData.GetAPIKey(), ID: DonotionID);
                var don = await donor.Get(AppData.GetAPIKey(), objDonation.DonorID);

                var nextdonationdateset = don.DonationFrequency;

                // Calculate the next donation date based on the donation frequency
                DateTime nextDonationDate = DateTime.Now;
                if (nextdonationdateset == 4) // 4 months
                {
                    nextDonationDate = nextDonationDate.AddMonths(4);
                }
                else if (nextdonationdateset == 6) // 6 months
                {
                    nextDonationDate = nextDonationDate.AddMonths(6);
                }


                objDonation.NextDonationDate = nextDonationDate;
                objDonation.BloodBagNo = BloodBagNo;
                objDonation.Status = "D";
                objDonation.DonotionID = await donarDonationData.AddEdit
                                   (
                                      APIKey: AppData.GetAPIKey(),
                                      obj: objDonation,
                                      LogUserID: ""
                                   );
                await SendDonatedEmail(objDonation.DonotionID);
                return Json(new { success = true, responseText = "Saved successfully" });
            }
            catch (Exception ex)
            {
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }
                return Json(new { success = false, responseText = ex.Message });
            }
        }

        private async Task SendDonatedEmail(string donationID)
        {
            var donation = await donarDonationData.Get(AppData.GetAPIKey(), ID: donationID);
            var don = await donor.Get(AppData.GetAPIKey(), donation.DonorID);
            DateTime next = (DateTime)donation.NextDonationDate;



            email.Subject = $"Thank You for Saving a Life - Donation #{donationID} Blood Donated Status";
            email.ToName = don.Name;
            email.Description += $"We would like to express our sincere gratitude to you for your recent blood donation. Your selfless act of kindness has helped save a life and we cannot thank you enough.<br /><br />Your blood donation process has been completed and your next donation date is scheduled for {next.ToString("dddd d\\'\\t\\h MMMM yyyy")}. You will be notified once your blood test results are available.<br /><br />For any further information, please do not hesitate to contact our Blood Bank Center at {donation.BloodBankCentre}.<br /><br />Once again, thank you for your generosity and for making a positive impact on someone's life.";


            email.ActionName = "View Your Donation Status";
            email.URL = $"[WebURL]/Donor/DonarDonation";

            email.Sendto = new List<string>(new[] { don.Email });
            await email.SendEmail(true);
        }

        public async Task<ActionResult> MarkCompleted(string id)
        {
            Auth.CheckBB();

            var obj = new BloodDonationDetailView();
            obj.donarDonation = await donarDonationData.Get(APIKey: AppData.GetAPIKey(), ID: id);
             
            obj.donor = await donor.Get(APIKey: AppData.GetAPIKey(), ID: obj.donarDonation.DonorID);
            
            var bloodTestResult = await testResultData.Get(APIKey: AppData.GetAPIKey(), ID: id);
            if (bloodTestResult == null)
            {
                bloodTestResult = new BloodTestResult() { DonationID = id };
            }

            var bloodRecord = await bloodRecordData.Get(APIKey: AppData.GetAPIKey(), ID: id);
            if (bloodRecord == null)
            {
                bloodRecord = new BloodRecord() { DonationID = id };
                bloodRecord.ProcessedDate = DateTime.Now;
                bloodRecord.ExpirationDate = null;
            }

            obj.bloodTestResult = bloodTestResult;
            obj.bloodRecord = bloodRecord;
           

            try
            {
                obj.donarDonation.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> MarkCompleted(BloodDonationDetailView obj)
        {
            Auth.CheckBB();
          
            try
            {
                var BloodBankID = Auth.GetBB();


                #region Update Blood Type 
                var bloodtype = obj.donarDonation.BloodType;
                var donorinfo = await donor.Get(APIKey: AppData.GetAPIKey(), ID: obj.donarDonation.DonorID);
                if(donorinfo.BloodType == null || donorinfo.BloodType=="")
                {
                    donorinfo.BloodType = bloodtype;
                    donorinfo.DonorID = await donor.AddEdit
                                      (
                                         APIKey: AppData.GetAPIKey(),
                                         obj: donorinfo,
                                         LogUserID: ""
                                      );
                }

                #endregion


                #region Update Status
                obj.donarDonation = await donarDonationData.Get(APIKey: AppData.GetAPIKey(), ID: obj.bloodTestResult.DonationID);

               

                obj.donarDonation.Status = obj.bloodRecord.Status;
                
                obj.donarDonation.DonotionID = await donarDonationData.AddEdit
                                   (
                                      APIKey: AppData.GetAPIKey(),
                                      obj: obj.donarDonation,
                                      LogUserID: ""
                                   );

                #endregion

                #region Save Blood Record
                obj.bloodRecord.BloodRecordID = "";
                obj.bloodRecord.BloodBankCentreID = BloodBankID.BloodBankCentreID;
                obj.bloodRecord.BloodRecordID = await bloodRecordData.AddEdit
                                    (
                                       APIKey: AppData.GetAPIKey(),
                                       obj: obj.bloodRecord,
                                       LogUserID: ""
                                    );
                #endregion

                #region Save Test Results
                obj.bloodTestResult.TestID = "";
                var donationId = obj.bloodTestResult.DonationID;
                var currentDate = DateTime.Now.ToString("yyyyMMdd");
                var randomNum = new Random().Next(1000, 9999); // generates a random number between 1000 and 9999
                var filename = $"{currentDate}-{randomNum}-{donationId}.pdf";
                obj.bloodTestResult.TestRecordPdfFile = filename;
                if (obj.bloodTestResult.DiseaseOrVirusStatus == "NA")
                {
                    obj.bloodTestResult.DiseaseOrVirus = "Negative";
                }
                obj.bloodTestResult.TestID = await testResultData.AddEdit
                                    (
                                       APIKey: AppData.GetAPIKey(),
                                       obj: obj.bloodTestResult,
                                       LogUserID: ""
                                    );
                if (obj.FileUpload != null)
                {
                     
                    
                    var filePath = commonDDL.GetUploadPath(filename);
                    obj.FileUpload.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                #endregion


                if (obj.bloodRecord.Status == "C")
                {
                    await SendCompletedEmail(obj.donarDonation.DonotionID);
                }

                if (obj.bloodRecord.Status == "T")
                {
                    await SendTransfusionEmail(obj.donarDonation.DonotionID);
                }


                TempData["SuccessMessage"] = "Successfully marked for " + obj.bloodTestResult.DonationID;
                return RedirectToAction("Index", "DonorDonation");

            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Unable to save record. " + ex.Message;
                return RedirectToAction("Index", "DonorDonation");
            }

            return View(obj);
        }


        private async Task SendCompletedEmail(string donationID)
        {
            var donation = await donarDonationData.Get(AppData.GetAPIKey(), ID: donationID);
            var don = await donor.Get(AppData.GetAPIKey(), donation.DonorID);
            DateTime next = (DateTime)donation.NextDonationDate;



            email.Subject = $" Donation #{donationID} Blood Donated Test Results Has Updated";
            email.ToName = don.Name;
            email.Description += $"We would like to express our sincere gratitude to you for your  blood donation. Your selfless act of kindness has helped save a life and we cannot thank you enough.<br /><br />Your blood donation process has been completed.<br /><br />For any further information, please do not hesitate to contact our Blood Bank Center at {donation.BloodBankCentre}.<br /><br />Once again, thank you for your generosity and for making a positive impact on someone's life.";


            email.ActionName = "View Your Donation Status";
            email.URL = $"/Donor/DonarDonation";

            email.Sendto = new List<string>(new[] { don.Email });
            await email.SendEmail(true);
        }

        private async Task SendTransfusionEmail(string donationID)
        {
            var donation = await donarDonationData.Get(AppData.GetAPIKey(), ID: donationID);
            var don = await donor.Get(AppData.GetAPIKey(), donation.DonorID);
            DateTime next = (DateTime)donation.NextDonationDate;



            email.Subject = $"Thank You for Saving a Life - Donation #{donationID} Donated Blood Saved a Patient";
            email.ToName = don.Name;
            email.Description += $"We would like to express our sincere gratitude to you for your  blood donation.For any further information, please do not hesitate to contact our Blood Bank Center at {donation.BloodBankCentre}.<br /><br />Once again, thank you for your generosity and for making a positive impact on someone's life.";


            email.ActionName = "View Your Donation Status";
            email.URL = $"[WebURL]/Donor/DonarDonation";

            email.Sendto = new List<string>(new[] { don.Email });
            await email.SendEmail(true);
        }

        public async Task<JsonResult> UpdateTransfusion(string donationID)
        {
            try
            {
                if (donationID == null || donationID == "")
                {
                    return Json(new { success = false, responseText = "Invalid request or bad parameters" });
                }

                var donation = await donarDonationData.Get(AppData.GetAPIKey(), ID: donationID);
                donation.Status = "T";
                donation.DonotionID = await donarDonationData.AddEdit
                                (
                                    APIKey: AppData.GetAPIKey(),
                                    obj: donation,
                                    LogUserID: ""
                                );
                await SendTransfusionEmail(donationID);
                return Json(new { success = true, responseText = "Updated Transfusion successfully" });
            }
            catch (Exception ex)
            {
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }
                return Json(new { success = false, responseText = "Unable to delete record. " + ex.Message });
            }
        }

        public async Task<ActionResult> ViewDetails(string id)
        {
            Auth.CheckBB();

            var obj = new BloodDonationDetailView();
            obj.donarDonation = await donarDonationData.Get(APIKey: AppData.GetAPIKey(), ID: id);
            obj.questionnaire = await questionnaireData.Get(APIKey: AppData.GetAPIKey(), ID: id);
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

        public async Task<IActionResult> DonorDetails(string id)
        {
            Auth.CheckBB();

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
