using BloodBankL.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DropDown
{
    public class BloodBankDDL : IBloodBankDDL
    {

        #region Constructions
        private readonly IBloodBankCentreData bloodBankCentreData;
        private readonly ILocationData locationData;
        public BloodBankDDL(IBloodBankCentreData bloodBankCentreData, ILocationData locationData)
        {
            this.bloodBankCentreData = bloodBankCentreData;
            this.locationData = locationData;

        }
        #endregion

        public async Task<SelectList> BloodBankCentreList()
        {
            var objList = await bloodBankCentreData.GetList(AppData.GetAPIKey());
            return objList.ToSelectList("BloodBankCentreID", "BloodBankCentreDet");
        }
        public async Task<SelectList> LocationList()
        {
            var objList = await locationData.GetList(AppData.GetAPIKey());
            return objList.ToSelectList("LocationID", "LocationName");
        }

        public SelectList SpecialtyList()
        {
            var objList = new List<_DDLItem>();
            objList.Add(new _DDLItem("PA", "Pathology"));
            objList.Add(new _DDLItem("AN", "Anesthesiology"));
            objList.Add(new _DDLItem("EM", "Emergency Medicine"));
            objList.Add(new _DDLItem("IM", "Internal Medicine"));
            objList.Add(new _DDLItem("OB", "Obstetrics and Gynecology"));
            objList.Add(new _DDLItem("OP", "Ophthalmology"));
            objList.Add(new _DDLItem("OS", "Orthopedic Surgery"));
            objList.Add(new _DDLItem("PS", "Plastic Surgery"));
            objList.Add(new _DDLItem("RA", "Radiology"));
            objList.Add(new _DDLItem("SU", "Surgery"));
            objList.Add(new _DDLItem("OT", "Other"));

            return new SelectList(objList, "Value", "Text");


        }

        public SelectList TestResultsList()
        {
            var objList = new List<_DDLItem>();
            objList.Add(new _DDLItem("NA", "Negative"));
            objList.Add(new _DDLItem("P", "Positive"));
            

            return new SelectList(objList, "Value", "Text");


        }

        public SelectList BloodStatusList()
        {
            var objList = new List<_DDLItem>();
            objList.Add(new _DDLItem("C", "Completed"));
            objList.Add(new _DDLItem("T", "Transfusion"));
           

            return new SelectList(objList, "Value", "Text");


        }
    }
}
