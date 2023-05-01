using BloodBankL.Data;
using Donor.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Timers;

namespace BloodBank.Areas.BloodBankSystem.Controllers
{
    [Area("BloodBankSystem")]


    public class HomeController : Controller
    {


        #region Construction
 
        private readonly IDonationProgressionData progressionData;
        

        public HomeController(IDonationProgressionData progressionData)
        {
            
            this.progressionData = progressionData;

         
        }
        #endregion

       

        public IActionResult Index()
        {
            Auth.CheckBB();

            
            return View();
        }
        public async Task<JsonResult> GetPayrollProgression(string Year)
        {
            Auth.CheckBB();
           
            try
            {
                var objList = await progressionData.GetList(AppData.GetAPIKey(), Year);
                return Json(objList);
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


    }
}
