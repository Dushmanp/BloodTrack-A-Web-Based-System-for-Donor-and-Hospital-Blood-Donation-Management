 
using BloodBankL.Data;
using BloodBankl.Models;
using Microsoft.AspNetCore.Mvc;
using BloodBankL.Models;
using DropDown;
using System.Threading.Tasks;
using Common;
using System.Drawing;

namespace BloodBank.Areas.Donor.Controllers
{
    [Area("Donor")]
    public class CampaignController : Controller
    {
        #region Construction

        private readonly IBloodDonationCampaignData bloodDonationCampaign;
       

        public CampaignController(IBloodDonationCampaignData bloodDonationCampaign)
        {
            this.bloodDonationCampaign = bloodDonationCampaign;
           
        }

        #endregion
        public async Task<IActionResult> Index(string KeyW = "", string RegistrationDate = "",string StartDate ="", string BloodBankCentreID = "", string LocationID = "", string ActiveStatus = "")
        {
            Auth.CheckUser();
            var obj = new BloodDonationCampaignSearchView();
            obj.LocationID = LocationID;
            obj.StartDate = StartDate;
            obj.RecordCount = await bloodDonationCampaign.GetCount
                               (
                                   APIKey: AppData.GetAPIKey(),
                                   KeyW: KeyW.ToBlank(),
                                   RegistrationDate: RegistrationDate.ToBlank(),
                                   StartDate: StartDate.ToBlank(),
                                   BloodBankCentreID: BloodBankCentreID.ToBlank(),
                                   LocationID: LocationID.ToBlank(),
                                    
                                   ActiveStatus: "A"


                               );
            obj.PaginationList = AppData.GetPaginationList(obj.RecordCount, obj.PageSize);
            return View(obj);
        }

        public async Task<ActionResult> _MainList(string KeyW = "", string RegistrationDate = "", string StartDate = "", string BloodBankCentreID = "", string LocationID = "", string ActiveStatus = "", int Page = 1, int PageSize = 99999)
        {
            Auth.CheckUserPartial();
            
            var objList = await bloodDonationCampaign.GetList
                            (
                                APIKey: AppData.GetAPIKey(),
                                KeyW: KeyW.ToBlank(),
                                RegistrationDate: RegistrationDate.ToBlank(),
                                StartDate: StartDate.ToBlank(),
                                BloodBankCentreID: BloodBankCentreID.ToBlank(),
                                LocationID: LocationID.ToBlank(),
                                ActiveStatus: "A",
                                Page: Page,
                                PageSize: PageSize
                            );

            return View(objList);
        }
    }
}
