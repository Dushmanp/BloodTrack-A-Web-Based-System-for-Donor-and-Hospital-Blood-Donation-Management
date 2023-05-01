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
    public class DoctorController : Controller
    {
        #region Construction

        private readonly IDoctorData doctorData;
        private readonly IEmailSender email;
        public DoctorController(IDoctorData doctorData, IEmailSender email)
        {
            this.doctorData = doctorData;
            this.email = email;
        }
        #endregion

        public async Task<IActionResult> Index(string KeyW = "", string LocationID = "", string BloodBankCentreID = "", string Specialty = "", string Gender = "")
        {

            Auth.CheckBB();


            var obj = new DoctorInfoSearchView();
            obj.KeyW = KeyW;
            obj.LocationID = LocationID;
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

        public async Task<ActionResult> _MainList(string KeyW = "", string LocationID = "", string BloodBankCentreID = "", string Specialty = "", string Gender = "", int Page = 1, int PageSize = 99999)
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

        public IActionResult Add()
        {
            Auth.CheckBB();

            var obj = new DoctorInfo();

            try
            {
                obj.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Add(DoctorInfo obj)
        {
            Auth.CheckBB();

            try
            {
                var BloodBankID = Auth.GetBB();
                obj.DoctorID = "";
                obj.BloodBankCentreID = BloodBankID.BloodBankCentreID;
                var Pass = Crypto.GeneratePassword(obj.Email);
                obj.Password = Crypto.Encrypt(Pass);
                obj.DoctorID = await doctorData.AddEdit
                                    (
                                       APIKey: AppData.GetAPIKey(),
                                       obj: obj,
                                       LogUserID: ""
                                    );
                SendPasswordEmail(obj.DoctorID);

                return Redirect(obj.ReturnURL);
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

            var obj = await doctorData.Get(AppData.GetAPIKey(), id);
            obj.Password = "";
            try
            {
                obj.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(DoctorInfo obj)
        {
            Auth.CheckBB();

            try
            {
                var BloodBankID = Auth.GetBB();
                obj.BloodBankCentreID = BloodBankID.BloodBankCentreID;
                if (obj.Password != null)
                {
                    obj.Password = Crypto.Encrypt(obj.Password);
                }
                obj.DoctorID = await doctorData.AddEdit
                                    (
                                       APIKey: AppData.GetAPIKey(),
                                       obj: obj,
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

        public async Task<JsonResult> Delete(string id)
        {
            try
            {
                if (id == null || id == "")
                {
                    return Json(new { success = false, responseText = "Invalid request or bad parameters" });
                }

                //var emp = (User)Session["User"];

                var RetValue = await doctorData.Delete
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

        private async void SendPasswordEmail(string DoctorID)
        {
            var doctor = await doctorData.Get(AppData.GetAPIKey(), ID: DoctorID);
           

            email.Subject = $"Doctor # {doctor.FullName} - Your User Carditional";
            email.ToName = doctor.FullName;
            email.Description += $"Dr. {doctor.FullName},<br /><br />";
            email.Description += $"Your username is: {doctor.UserName}<br />";
            email.Description += $"Your password is: {Crypto.Decrypt(doctor.Password)}<br />";
            email.Description += "Please use the given username and password for your first login.<br />";
            email.Description += $"For further information, please contact our Blood Bank Centre at {doctor.BloodBankCentre}.<br />";



            email.ActionName = "View login Page";
            email.URL = $"/Account/LoginDoc";

            email.Sendto = new List<string>(new[] { doctor.Email });
            await email.SendEmail();
        }

    }
}
