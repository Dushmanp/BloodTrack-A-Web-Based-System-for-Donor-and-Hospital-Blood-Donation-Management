 
using BloodBankL.Data;
using BloodBankl.Models;
using Microsoft.AspNetCore.Mvc;
using BloodBankL.Models;
using DropDown;
using System.Threading.Tasks;
using Common;
using System.Drawing;
using System.IO;
using System;
using BloodBankSystem.Models;

namespace BloodBank.Areas.BloodBankSystem.Controllers
{
    [Area("BloodBankSystem")]
    public class CampaignController : Controller
    {
        #region Construction

        private readonly IBloodDonationCampaignData bloodDonationCampaign;
        private readonly ICommonDDL commonDDL;


        public CampaignController(IBloodDonationCampaignData bloodDonationCampaign, ICommonDDL commonDDL)
        {
            this.bloodDonationCampaign = bloodDonationCampaign;
            this.commonDDL = commonDDL;
        }

        #endregion
        public async Task<IActionResult> Index(string KeyW = "", string RegistrationDate = "", string BloodBankCentreID = "", string LocationID = "", string ActiveStatus = "")
        {
            Auth.CheckBB();
            var obj = new BloodDonationCampaignSearchView();
            obj.RecordCount = await bloodDonationCampaign.GetCount
                               (
                                   APIKey: AppData.GetAPIKey(),
                                   KeyW: KeyW.ToBlank(),
                                   RegistrationDate: RegistrationDate.ToBlank(),
                                   BloodBankCentreID: BloodBankCentreID.ToBlank(),
                                   LocationID: LocationID.ToBlank(),
                                    
                                   ActiveStatus: ActiveStatus.ToBlank()


                               );
            obj.PaginationList = AppData.GetPaginationList(obj.RecordCount, obj.PageSize);
            return View(obj);
        }

        public async Task<ActionResult> _MainList(string KeyW = "", string RegistrationDate = "", string BloodBankCentreID = "", string LocationID = "", string ActiveStatus = "", int Page = 1, int PageSize = 99999)
        {
            Auth.CheckBBPartial();

            var objList = await bloodDonationCampaign.GetList
                            (
                                APIKey: AppData.GetAPIKey(),
                                KeyW: KeyW.ToBlank(),
                                RegistrationDate: RegistrationDate.ToBlank(),
                                BloodBankCentreID: BloodBankCentreID.ToBlank(),
                                LocationID: LocationID.ToBlank(),

                                ActiveStatus: ActiveStatus.ToBlank(),
                                Page: Page,
                                PageSize: PageSize
                            );

            return View(objList);
        }

        public IActionResult Add()
        {
            Auth.CheckBB();
            var obj = new CampaignEditView();
            obj.Data = new BloodDonationCampaign();
            obj.Data.ActiveStatus = "A";
            try
            {
                obj.Data.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CampaignEditView obj)
        {
            Auth.CheckBB();
            try
            {
                if (obj.FileUpload == null)
                {
                    ViewData["ErrorMessage"] = "Please choose an image file for the banner";
                    return View(obj);
                }
                var user = Auth.GetBB();
                obj.Data.BloodBankCentreID = user.BloodBankCentreID;
                obj.Data.RegistrationDate = DateTime.Now;
                obj.Data.CampaignID = "";
                obj.Data.CampaignID = await bloodDonationCampaign.AddEdit
                                    (
                                       APIKey: AppData.GetAPIKey(),
                                       obj: obj.Data,
                                       LogUserID: ""
                                    );

                if (obj.FileUpload != null)
                {
                    var filename = obj.Data.CampaignID + ".jpg";
                    var filePath = commonDDL.GetUploadPath(filename);
                    obj.FileUpload.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                return Redirect(obj.Data.ReturnURL);
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
            var obj = new CampaignEditView();
            obj.Data = await bloodDonationCampaign.Get(AppData.GetAPIKey(), id);

            try
            {
                obj.Data.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CampaignEditView obj)
        {
            Auth.CheckBB();
            try
            {
                obj.Data.BloodBankCentreID = await bloodDonationCampaign.AddEdit
                                    (
                                       APIKey: AppData.GetAPIKey(),
                                       obj: obj.Data,
                                       LogUserID: ""
                                    );

                if (obj.FileUpload != null)
                {
                    var filename = obj.Data.BloodBankCentreID + ".jpg";
                    var filePath = commonDDL.GetUploadPath(filename);
                    obj.FileUpload.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                return Redirect(obj.Data.ReturnURL);
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


                //var emp = (Employee)Session["Employee"];

                var RetValue = await bloodDonationCampaign.Delete
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
    }
}
