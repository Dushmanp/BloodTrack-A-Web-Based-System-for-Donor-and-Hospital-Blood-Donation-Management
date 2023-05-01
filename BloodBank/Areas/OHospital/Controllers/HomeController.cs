using BloodBankL.Data;
using BloodBankL.Models;
using Donor.Data;
using Donor.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Drawing;
using System.Threading.Tasks;

namespace BloodBank.Areas.OHospital.Controllers
{
    [Area("OHospital")]
    public class HomeController : Controller
    {
        #region Construction
        private readonly ISessionData Session;
        private readonly IOutHospitalData outHospitalData;
        public HomeController(IOutHospitalData outHospitalData, ISessionData Session)
        {
            this.outHospitalData = outHospitalData;
            this.Session = Session;
          
        }
        #endregion

        public IActionResult Index()
        {
            Auth.CheckOH();
            return View();
        }

        public async Task<IActionResult> ProfileDetails()
        {
            Auth.CheckOH();
            var outHospital = Session.GetOHospital();
            var obj = await outHospitalData.Get(AppData.GetAPIKey(), outHospital.HospitalID);
            obj.Password = "";
            try
            {
                obj.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> ProfileDetails(OutHospital obj)
        {


            try
            {
                if (obj.Password != null)
                {
                    obj.Password = Crypto.Encrypt(obj.Password);
                }
                obj.HospitalID = await outHospitalData.AddEdit
                                    (
                                       APIKey: AppData.GetAPIKey(),
                                       obj: obj,
                                       LogUserID: ""
                                    );
                TempData["SuccessMessage"] = "Hospital Detail Has changed";

                return Redirect(obj.ReturnURL);

            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Unable to save record. " + ex.Message;
            }

            return View(obj);
        }
    }
}
