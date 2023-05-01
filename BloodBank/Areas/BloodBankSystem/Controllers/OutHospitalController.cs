using Account.Models;
using BloodBankL.Data;
using BloodBankL.Models;
using Common;
using DropDown;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace BloodBank.Areas.BloodBankSystem.Controllers
{
    [Area("BloodBankSystem")]
    public class OutHospitalController : Controller
    {
        #region Construction

        private readonly IOutHospitalData hospitalData;
        private readonly IEmailSender email;
        public OutHospitalController(IOutHospitalData hospitalData, IEmailSender email)
        {
            this.hospitalData = hospitalData;
            this.email = email;
        }
        #endregion

        public async Task<IActionResult> Index(string KeyW = "", string LocationID = "")
        {

            Auth.CheckBB();


            var obj = new OutHospitalSearchView();
            obj.KeyW = KeyW;
            obj.LocationID = LocationID;
           

            obj.RecordCount = await hospitalData.GetCount
                                (
                                    APIKey: AppData.GetAPIKey(),
                                    KeyW: KeyW.ToBlank(),
                                    LocationID: LocationID.ToBlank() 
                                    
                                );
            obj.PaginationList = AppData.GetPaginationList(obj.RecordCount, obj.PageSize);

            return View(obj);

        }

        public async Task<ActionResult> _MainList(string KeyW = "", string LocationID = "", string BloodBankCentreID = "", string Specialty = "", string Gender = "", int Page = 1, int PageSize = 99999)
        {
            Auth.CheckBBPartial();

            var objList = await hospitalData.GetList
                            (
                                APIKey: AppData.GetAPIKey(),
                                KeyW: KeyW.ToBlank(),
                                LocationID: LocationID.ToBlank(),
                                Page: Page,
                                PageSize: PageSize
                            );

            return View(objList);
        }

        public IActionResult Add()
        {
            Auth.CheckBB();

            var obj = new OutHospital();

            try
            {
                obj.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Add(OutHospital obj)
        {
            Auth.CheckBB();

            try
            {
                var BloodBankID = Auth.GetBB();
                obj.HospitalID = "";
                obj.ApprovedBy = BloodBankID.BloodBankCentreID;
                var password = Crypto.GenerateRandomString(10);

                obj.Password = Crypto.Encrypt(password);
                obj.HospitalID = await hospitalData.AddEdit
                                    (
                                       APIKey: AppData.GetAPIKey(),
                                       obj: obj,
                                       LogUserID: ""
                                    );
                SendPasswordEmail(obj.HospitalID);

              return RedirectToAction("Index", "OutHospital", new { area = "BloodBankSystem" });

            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to save record. " + ex.Message;
            }

            return View(obj);
        }

        public async Task<IActionResult> Edit(string id)
        {
            Auth.CheckBB();

            var obj = await hospitalData.Get(AppData.GetAPIKey(), id);
            obj.Password = "";
            try
            {
                obj.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(OutHospital obj)
        {
            Auth.CheckBB();

            try
            {
                var BloodBankID = Auth.GetBB();
                obj.ApprovedBy = BloodBankID.BloodBankCentreID;
                if (obj.Password != null)
                {
                    obj.Password = Crypto.Encrypt(obj.Password);
                }
                obj.HospitalID = await hospitalData.AddEdit
                                    (
                                       APIKey: AppData.GetAPIKey(),
                                       obj: obj,
                                       LogUserID: ""
                                    );

                return RedirectToAction("Index", "OutHospital", new { area = "BloodBankSystem" });
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to save record. " + ex.Message;
            }

            return View(obj);
        }

        public async Task<JsonResult> Delete(string id)
        {
            try
            {
                if (id == null || id == "")
                {
                    return Json(new { success = false, responseText = "Invalid request or bad parameters" });
                }

                //var emp = (User)Session["User"];

                var RetValue = await hospitalData.Delete
                                (
                                    APIKey: AppData.GetAPIKey(),
                                    ID: id,
                                    LogUserID: ""
                                );

                return Json(new { success = true, responseText = "Deleted successfully" });
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

        private async void SendPasswordEmail(string HospitalID)
        {
            var outHospital = await hospitalData.Get(AppData.GetAPIKey(), ID: HospitalID);
            var PASS = Crypto.Decrypt(outHospital.Password);

            email.Subject = $"Hospital # {outHospital.HospitalName} - Your User Carditional";
            email.ToName = outHospital.HospitalName;
            email.Description += $"Dr. {outHospital.HospitalName},<br /><br />";
            email.Description += $"Your username is: {outHospital.Username}<br />";
            email.Description += $"Your password is: {PASS}<br />";
            email.Description += "Please use the given username and password for your first login.<br />";
            email.Description += $"For further information, please contact our Blood Bank Centre at {outHospital.ApprovedBy}.<br />";



            email.ActionName = "View login Page";
            email.URL = $"/Account/LoginOH";

            email.Sendto = new List<string>(new[] { outHospital.Email });
            await email.SendEmail();
        }

    }
}
