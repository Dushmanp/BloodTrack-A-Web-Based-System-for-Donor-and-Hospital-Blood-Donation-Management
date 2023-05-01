using BloodBankL.Data;
using BloodBankL.Models;
using Common;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BloodBank.Areas.Donor.Controllers
{
    [Area("Donor")]
    public class BloodRequestController : Controller
    {
        #region Construction
    
        private readonly IBloodRequestData bloodRequestData;
        private readonly IBloodRequestDetailsData bloodRequestDetailsData;
    
        public BloodRequestController(  IBloodRequestData bloodRequestData, IBloodRequestDetailsData bloodRequestDetailsData)
        {
         
            this.bloodRequestData = bloodRequestData;
            this.bloodRequestDetailsData = bloodRequestDetailsData;
           
        }
        #endregion


        public async Task<IActionResult> Index(string KeyW = "", string HospitalID = "", string LocationID = "", string DateTimeOfRequirement="", string Status = "")
        {
             Auth.CheckUser();

            var obj = new BloodRequestSearchView();
            obj.KeyW = KeyW;
            obj.HospitalID = HospitalID;
            obj.LocationID = LocationID;
            obj.DateTimeOfRequirement = DateTimeOfRequirement;
            obj.Status = Status;

            obj.RecordCount = await bloodRequestData.GetCount
                                (
                                    APIKey: AppData.GetAPIKey(),
                                    KeyW: KeyW.ToBlank(),
                                    HospitalID: HospitalID.ToBlank(),
                                    LocationID: LocationID.ToBlank(),
                                    DateTimeOfRequirement : DateTimeOfRequirement.ToBlank(),
                                    Status: ""



                                );
            obj.PaginationList = AppData.GetPaginationList(obj.RecordCount, obj.PageSize);

            return View(obj);
        }

        public async Task<ActionResult> _MainList(string KeyW = "", string HospitalID = "", string LocationID = "",string DateTimeOfRequirement ="", string Status = "", int Page = 1, int PageSize = 99999)
        {
            Auth.CheckUser();

            var objList = await bloodRequestData.GetList
                            (
                                APIKey: AppData.GetAPIKey(),
                                KeyW: KeyW.ToBlank(),
                                HospitalID: HospitalID.ToBlank(),
                                LocationID: LocationID.ToBlank(),
                                DateTimeOfRequirement: DateTimeOfRequirement.ToBlank(),
                                Status: "",
                                Page: Page,
                                PageSize: PageSize
                            );

            return View(objList);
        }

    }
}
