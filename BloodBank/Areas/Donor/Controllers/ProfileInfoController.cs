using Account.Data;
using Account.Models;
using Common;
using Donor.Data;
using Donor.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BloodBank.Areas.Donor.Controllers
{
    [Area("Donor")]
    public class ProfileInfoController : Controller
    {
        #region Construction

        private readonly IDonorInfoData donor;
        private readonly ISessionData Session;


        public ProfileInfoController(IDonorInfoData donor, ISessionData Session)
        {
            this.donor = donor;
            this.Session = Session;

        }

        #endregion

        public async Task<IActionResult> Index()
        {

            Auth.CheckUser();
            var UserInfo = Session.GetUser();
            var obj = await donor.Get(AppData.GetAPIKey(), UserInfo.DonorID);
            obj.Password = "";
            try
            {
                obj.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Index(DonorInfo obj)
        {
             

            try
            {
                if (obj.Password != null)
                {
                    obj.Password = Crypto.Encrypt(obj.Password);
                }
                obj.DonorID = await donor.AddEdit
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
