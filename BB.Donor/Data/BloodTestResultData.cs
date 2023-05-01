using DBAccess;
using Donor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donor.Data
{
    public class BloodTestResultData : IBloodTestResultData
    {
        #region Construction

        private readonly IDBAccess db;

        public BloodTestResultData(IDBAccess db)
        {
            this.db = db;
        }

        #endregion

        public Task<string> AddEdit(string APIKey, BloodTestResult obj, string LogUserID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "TestID", obj.TestID },
                { "DonationID", obj.DonationID },
                { "HemoglobinLevel", obj.HemoglobinLevel },
                { "PlateletLevel", obj.PlateletLevel },
                { "HIVTestResult", obj.HIVTestResult },
                { "WhiteBloodCellCount", obj.WhiteBloodCellCount },
                { "DiseaseOrVirus", obj.DiseaseOrVirus },
                { "TestRecordPdfFile", obj.TestRecordPdfFile },
                { "LogUserID", LogUserID },

            };

            string query = "dnr.TestRecord_AddEdit";
            return db.Execute(query, param);
        }

        public Task<int> GetCount(string APIKey, string KeyW = "", string DonorID = "", string NIC = "", string DonationDate = "", string BloodBankCentreID = "", string Status = "")
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "KeyW", KeyW },
                { "DonorID", DonorID },
                { "NIC", NIC },
                { "DonationDate", DonationDate },
                { "BloodBankCentreID", BloodBankCentreID },
                { "Status", Status }
            };

            string query = "dnr.TestRecord_Count";
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

            string query = "dnr.TestRecord_Delete";
            return db.Execute(query, param);
        }

        public Task<BloodTestResult> Get(string APIKey, string ID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "ID",ID }
            };

            string query = "dnr.TestRecord_Get";
            return db.Get<BloodTestResult, dynamic>(query, param);
        }



        public Task<List<BloodTestResult>> GetList(string APIKey, string KeyW = "", string DonorID = "", string NIC = "", string DonationDate = "", string BloodBankCentreID = "", string Status = "", int Page = 0, int PageSize = 99999)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "KeyW", KeyW },
                { "DonorID", DonorID },
                { "NIC", NIC },
                { "DonationDate", DonationDate },
                { "BloodBankCentreID", BloodBankCentreID },
                { "Status", Status },
                { "Page", Page },
                { "PageSize", PageSize }
            };

            string query = "dnr.TestRecord_List";
            return db.GetList<BloodTestResult, dynamic>(query, param);
        }

    }
}
