using Account.Models;
using BloodBank.Classes;
using BloodBankL.Data;
using BloodBankL.Models;
using Common;
using Donor.Data;
using Donor.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace BloodBank.Areas.BloodBankSystem.Controllers
{
    [Area("BloodBankSystem")]
    public class BloodRequestController : Controller
    {

        #region Construction
        private readonly ISessionData Session;
        private readonly IOutHospitalData outHospitalData;
        private readonly IBloodRequestData bloodRequestData;
        private readonly IBloodRequestDetailsData bloodRequestDetailsData;
        private readonly IEmailSender email;
        public BloodRequestController(IOutHospitalData outHospitalData, ISessionData Session, IBloodRequestData bloodRequestData, IBloodRequestDetailsData bloodRequestDetailsData, IEmailSender email)
        {
            this.outHospitalData = outHospitalData;
            this.Session = Session;
            this.bloodRequestData = bloodRequestData;
            this.bloodRequestDetailsData = bloodRequestDetailsData;
            this.email= email;
        }
        #endregion

      

        public async Task<IActionResult> Index(string KeyW = "",string HospitalID="", string LocationID = "",string Status = "")
        {
            Auth.CheckBB();

            var obj = new BloodRequestSearchView();
            obj.KeyW = KeyW;
            obj.HospitalID = HospitalID;
            obj.LocationID = LocationID;
            obj.Status = Status;

            obj.RecordCount = await bloodRequestData.GetCount
                                (
                                    APIKey: AppData.GetAPIKey(),
                                    KeyW: KeyW.ToBlank(),
                                    HospitalID: HospitalID.ToBlank(),
                                    LocationID: LocationID.ToBlank(),
                                    Status: Status.ToBlank()
                                  


                                );
            obj.PaginationList = AppData.GetPaginationList(obj.RecordCount, obj.PageSize);

            return View(obj);
        }

        public async Task<ActionResult> _MainList(string KeyW = "", string HospitalID = "", string LocationID = "", string Status = "", int Page = 1, int PageSize = 99999)
        {
            Auth.CheckBBPartial();
             
            var objList = await bloodRequestData.GetList
                            (
                                APIKey: AppData.GetAPIKey(),
                                KeyW: KeyW.ToBlank(),
                                HospitalID: HospitalID.ToBlank(),
                                LocationID: LocationID.ToBlank(),
                                Status: Status.ToBlank(),
                                Page: Page,
                                PageSize: PageSize
                            );

            return View(objList);
        }

        public async Task<IActionResult> Details(string ID)
        {
            Auth.CheckBB();
            var obj = new BloodRequestDetailView();
            obj.bloodRequest = await bloodRequestData.Get(APIKey: AppData.GetAPIKey(), ID: ID);
            obj.bloodrequestDetails = await bloodRequestDetailsData.Get(APIKey: AppData.GetAPIKey(), ID: ID);

            try
            {
                obj.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }
       
        public async Task<JsonResult> NotAvailable(string id)
        {
            try
            {
                if (id == null || id == "")
                {
                    return Json(new { success = false, responseText = "Invalid request or bad parameters" });
                }
                var obj = await bloodRequestData.Get(APIKey: AppData.GetAPIKey(), ID: id);
                var BloodBank = Auth.GetBB();
                obj.BloodBankCentreID = BloodBank.BloodBankCentreID;
                obj.Status= "NA";
                obj.BloodRequestID = await bloodRequestData.AddEdit
                                    (
                                       APIKey: AppData.GetAPIKey(),
                                       obj: obj,
                                       LogUserID: ""
                                    );

                SendEmail(obj.BloodRequestID,"",  "Not Available");
                return Json(new { success = true, responseText = "Rejected successfully" });
            }
            catch (Exception ex)
            {
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }
                return Json(new { success = false, responseText = "Unable to Reject record. " + ex.Message });
            }
        }

        public async Task<JsonResult> Delivered(string id)
        {
            try
            {
                if (id == null || id == "")
                {
                    return Json(new { success = false, responseText = "Invalid request or bad parameters" });
                }
                var obj = await bloodRequestData.Get(APIKey: AppData.GetAPIKey(), ID: id);
                var BloodBank = Auth.GetBB();
                obj.BloodBankCentreID = BloodBank.BloodBankCentreID;
                obj.Status = "DL";
                obj.BloodRequestID = await bloodRequestData.AddEdit
                                    (
                                       APIKey: AppData.GetAPIKey(),
                                       obj: obj,
                                       LogUserID: ""
                                    );

                SendEmail(obj.BloodRequestID, "", "Delievered");
                return Json(new { success = true, responseText = "Delievered successfully" });
            }
            catch (Exception ex)
            {
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }
                return Json(new { success = false, responseText = "Unable to Reject record. " + ex.Message });
            }
        }

        public async Task<JsonResult> Accepted(string id)
        {
            try
            {
                if (id == null || id == "")
                {
                    return Json(new { success = false, responseText = "Invalid request or bad parameters" });
                }
                var obj = await bloodRequestData.Get(APIKey: AppData.GetAPIKey(), ID: id);
                var BloodBank = Auth.GetBB();
                obj.BloodBankCentreID = BloodBank.BloodBankCentreID;
                obj.Status = "A";
                obj.BloodRequestID = await bloodRequestData.AddEdit
                                    (
                                       APIKey: AppData.GetAPIKey(),
                                       obj: obj,
                                       LogUserID: ""
                                    );
                SendEmail(obj.BloodRequestID, "", "Accepted");

                return Json(new { success = true, responseText = "Accepted successfully" });
            }
            catch (Exception ex)
            {
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }
                return Json(new { success = false, responseText = "Unable to Accept record. " + ex.Message });
            }
        }

        public async Task<JsonResult> Rejected(string id)
        {
            try
            {
                if (id == null || id == "")
                {
                    return Json(new { success = false, responseText = "Invalid request or bad parameters" });
                }
                var obj = await bloodRequestData.Get(APIKey: AppData.GetAPIKey(), ID: id);
                var BloodBank = Auth.GetBB();
                obj.BloodBankCentreID = BloodBank.BloodBankCentreID;
                obj.Status = "RB";
                obj.BloodRequestID = await bloodRequestData.AddEdit
                                    (
                                       APIKey: AppData.GetAPIKey(),
                                       obj: obj,
                                       LogUserID: ""
                                    );

                SendEmail(obj.BloodRequestID, "", "Rejected by Blood Bank");
                return Json(new { success = true, responseText = "Rejected successfully" });
            }
            catch (Exception ex)
            {
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }
                return Json(new { success = false, responseText = "Unable to Reject record. " + ex.Message });
            }
        }

        private async void SendEmail(string BloodRequestID, string remarks = "",string Status="")
        {
            var bloodRequest = await bloodRequestData.Get(AppData.GetAPIKey(), ID: BloodRequestID);
            var blr = await outHospitalData.Get(AppData.GetAPIKey(), bloodRequest.HospitalID);

            email.Subject = $"Blood Request # {BloodRequestID} - {Status}";
            email.ToName = blr.HospitalName;
            email.Description += $"We are here to inform you that your Blood Request (# {BloodRequestID} ) has been {Status}. . !.<br /><br />";
            email.Description += "To check the status of your request, please visit our blood bank request details page. We will make sure to keep you updated on any progress. .<br /><br />";
            email.Description += $"If you have any further questions or concerns, please do not hesitate to contact our Blood Bank. We are more than happy to assist you in any way we can.<br />";

            if (remarks != "")
            {
                email.Description += $"<br />Notes:<br />{remarks}<br />";
            }

            email.ActionName = "View Your Request Status";
            email.URL = $"/BloodRequest/Index";

            email.Sendto = new List<string>(new[] { blr.Email });
            await email.SendEmail();
        }


    }
}
