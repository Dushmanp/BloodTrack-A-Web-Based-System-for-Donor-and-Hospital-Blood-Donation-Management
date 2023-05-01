using BloodBankL.Data;
using Donor.Data;
using Donor.Models;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Threading.Tasks;
using System;
using BloodBankL.Models;

namespace BloodBank.Areas.Doctor.Controllers
{
    [Area("Doctor")]
    public class ProfileInfoController : Controller
    {
        #region Construction

        private readonly IDoctorData doctor;
        private readonly ISessionData Session;


        public ProfileInfoController(IDoctorData doctor, ISessionData Session)
        {
            this.doctor = doctor;
            this.Session = Session;

        }

        #endregion

        public async Task<IActionResult> Index()
        {

            Auth.CheckDoctor();
            var UserInfo = Session.GetDoctor();
            var obj = await doctor.Get(AppData.GetAPIKey(), UserInfo.DoctorID);
            obj.Password = "";
            try
            {
                obj.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Index(DoctorInfo obj)
        {

            try
            {
                var BloodBankID = Auth.GetDoctor();
                obj.BloodBankCentreID = BloodBankID.BloodBankCentreID;
                if (obj.Password != null)
                {
                    obj.Password = Crypto.Encrypt(obj.Password);
                }
                obj.DoctorID = await doctor.AddEdit
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


    }
}
