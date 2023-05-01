using BloodBankL.Models;
using DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankL.Data
{

    public class BloodRequestDetailsData : IBloodRequestDetailsData
    {
        #region Construction

        private readonly IDBAccess db;

        public BloodRequestDetailsData(IDBAccess db)
        {
            this.db = db;
        }

        #endregion

        public Task<string> AddEdit(string APIKey, BloodRequestDetails obj, string LogUserID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                {"BloodRequestDetailsID",obj.BloodRequestDetailsID },
                { "BloodRequestID", obj.BloodRequestID },
                { "WholeBloodUnit", obj.WholeBloodUnit },
                { "PackedCellUnit", obj.PackedCellUnit },
                { "FreshFrozenPlasmaUnit", obj.FreshFrozenPlasmaUnit },
                { "PlateletComponentsUnit", obj.PlateletComponentsUnit },
                { "SingleDonorPlateletUnit", obj.SingleDonorPlateletUnit },
                { "CryoPoorPlasmaUnit", obj.CryoPoorPlasmaUnit },
                { "LogUserID", LogUserID}
            };

            string query = "bbk.BloodRequestDetails_AddEdit";
            return db.Execute(query, param);
        }


        public Task<int> GetCount(string APIKey, string KeyW = "", string LocationID = "", string Status = "")
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "KeyW", KeyW },
                { "LocationID", LocationID },
                { "Status", Status }
            };

            string query = "bbk.BloodRequestDetails_Count";
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

            string query = "bbk.BloodRequestDetails_Delete";
            return db.Execute(query, param);
        }

        public Task<BloodRequestDetails> Get(string APIKey, string ID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "ID",ID }
            };

            string query = "bbk.BloodRequestDetails_Get";
            return db.Get<BloodRequestDetails, dynamic>(query, param);
        }
        public Task<List<BloodRequestDetails>> GetList(string APIKey, string KeyW = "", string LocationID = "", string Status = "", int Page = 0, int PageSize = 99999)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "KeyW", KeyW },
                { "LocationID", LocationID },
                { "Status", Status },
                { "Page", Page },
                { "PageSize", PageSize }
            };

            string query = "bbk.BloodRequestDetails_List";
            return db.GetList<BloodRequestDetails, dynamic>(query, param);
        }
    }
}
