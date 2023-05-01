using DBAccess;
using Donor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donor.Data
{
    public class BloodRecordData : IBloodRecordData
    {
        #region Construction

        private readonly IDBAccess db;

        public BloodRecordData(IDBAccess db)
        {
            this.db = db;
        }

        #endregion

        public Task<string> AddEdit(string APIKey, BloodRecord obj, string LogUserID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "BloodRecordID", obj.BloodRecordID },
                { "BloodBankCentreID",obj.BloodBankCentreID },
                { "DonationID", obj.DonationID },
                { "ProcessedDate", obj.ProcessedDate },
                { "ExpirationDate", obj.ExpirationDate },
                { "Location", obj.Location },
                { "LogUserID", LogUserID },

            };

            string query = "dnr.BloodRecord_AddEdit";
            return db.Execute(query, param);
        }

        public Task<int> GetCount(string APIKey, string KeyW = "", string DonorID = "", string NIC = "", string ProcessedDate = "", string DonationDate = "", string BloodBankCentreID = "", string Status = "")

        {
            var param = new Dictionary<string, object>
            {
               { "APIKey", APIKey },
                { "KeyW", KeyW },
                { "DonorID", DonorID },
                { "NIC", NIC },
                { "ProcessedDate", ProcessedDate },
                { "DonationDate", DonationDate },
                { "BloodBankCentreID", BloodBankCentreID } 
            };

            string query = "dnr.BloodRecord_Count";
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

            string query = "dnr.BloodRecord_Delete";
            return db.Execute(query, param);
        }

        public Task<BloodRecord> Get(string APIKey, string ID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "ID",ID }
            };

            string query = "dnr.BloodRecord_Get";
            return db.Get<BloodRecord, dynamic>(query, param);
        }



        public Task<List<BloodRecord>> GetList(string APIKey, string KeyW = "", string DonorID = "", string NIC = "", string ProcessedDate = "", string DonationDate = "", string BloodBankCentreID = "", string Status = "", int Page = 0, int PageSize = 99999)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "KeyW", KeyW },
                { "DonorID", DonorID },
                { "NIC", NIC },
                { "ProcessedDate", ProcessedDate },
                { "DonationDate", DonationDate },
                { "BloodBankCentreID", BloodBankCentreID },
                { "Status", Status },
                { "Page", Page },
                { "PageSize", PageSize }
            };

            string query = "dnr.BloodRecord_List";
            return db.GetList<BloodRecord, dynamic>(query, param);
        }

    }
}
