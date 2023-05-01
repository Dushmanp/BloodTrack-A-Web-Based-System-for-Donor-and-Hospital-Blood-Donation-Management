using BloodBankl.Models;
using BloodBankL.Models;
using DBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankL.Data
{
    public class BloodDonationCampaignData : IBloodDonationCampaignData
    {
        #region Construction

        private readonly IDBAccess db;

        public BloodDonationCampaignData(IDBAccess db)
        {
            this.db = db;
        }

        #endregion


        public Task<string> AddEdit(string APIKey, BloodDonationCampaign obj, string LogUserID)
        {
            var param = new Dictionary<string, object>
            {
                 { "APIKey", APIKey },
                { "CampaignID", obj.CampaignID },
                { "OrganizerName", obj.OrganizerName },
                { "OrganizerAddress", obj.OrganizerAddress },
                { "Email", obj.Email },
                { "PhoneNumber", obj.PhoneNumber },
                { "BloodBankCentreID", obj.BloodBankCentreID },
                { "RegistrationDate", obj.RegistrationDate },
                { "VerifiedBy", obj.VerifiedBy },
                { "StartDate", obj.StartDate },
                { "EndDate", obj.EndDate },
                { "TargetAddress", obj.TargetAddress },
                { "TargetLocation", obj.TargetLocation },
                { "NumberOfDonors", obj.NumberOfDonors },
                { "ActiveStatus", obj.ActiveStatus },
                { "LogUserID", LogUserID }
            };

            string query = "bbk.BloodDonationCampaign_AddEdit";
            return db.Execute(query, param);
        }

     
        public Task<int> GetCount(string APIKey, string KeyW = "", string RegistrationDate = "", string StartDate = "", string BloodBankCentreID = "", string LocationID = "", string ActiveStatus = "")
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "KeyW", KeyW },
                { "RegistrationDate", RegistrationDate },
                { "StartDate", StartDate },
                { "BloodBankCentreID", BloodBankCentreID },
                { "LocationID", LocationID },
                { "ActiveStatus", ActiveStatus }
            };

            string query = "bbk.BloodDonationCampaign_Count";
            return db.GetCount(query, param);
        }

        public Task<string> Delete(string APIKey, string ID, string LogUserID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "ID",ID },
                { "LogUserID",LogUserID }
            };

            string query = "bbk.BloodDonationCampaign_Delete";
            return db.Execute(query, param);
        }

        public Task<BloodDonationCampaign> Get(string APIKey, string ID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "ID",ID }
            };

            string query = "bbk.BloodDonationCampaign_Get";
            return db.Get<BloodDonationCampaign, dynamic>(query, param);
        }



        public Task<List<BloodDonationCampaign>> GetList(string APIKey, string KeyW = "", string RegistrationDate = "", string StartDate = "", string BloodBankCentreID = "", string LocationID = "", string ActiveStatus = "", int Page = 0, int PageSize = 99999)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "KeyW", KeyW },
                { "RegistrationDate", RegistrationDate },
                { "StartDate", StartDate },
                { "BloodBankCentreID", BloodBankCentreID },
                { "LocationID", LocationID },
                { "ActiveStatus", ActiveStatus },
                { "Page", Page },
                { "PageSize", PageSize }
            };

            string query = "bbk.BloodDonationCampaign_List";
            return db.GetList<BloodDonationCampaign, dynamic>(query, param);
        }

    }
}