using BloodBankl.Models;
using DBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankL.Data
{
    public class BloodBankCentreData : IBloodBankCentreData
    {
        #region Construction

        private readonly IDBAccess db;

        public BloodBankCentreData(IDBAccess db)
        {
            this.db = db;
        }

        #endregion


        public Task<string> AddEdit(string APIKey, BloodBankCentre obj, string LogUserID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "BloodBankCentreID", obj.BloodBankCentreID },
                { "BloodBankCentreName", obj.BloodBankCentreName },
                { "LocationID", obj.LocationID },
                { "LogUserID", LogUserID }
            };

            string query = "bbk.DonarDonation_AddEdit";
            return db.Execute(query, param);
        }

        public Task<int> GetCount(string APIKey, string KeyW = "", string LocationID = "")
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "KeyW", KeyW },
                { "LocationID", LocationID }

            };

            string query = "bbk.BloodBankCentre_Count";
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

            string query = "bbk.BloodBankCentre_Delete";
            return db.Execute(query, param);
        }

        public Task<BloodBankCentre> Get(string APIKey, string ID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "ID",ID }
            };

            string query = "bbk.BloodBankCentre_Get";
            return db.Get<BloodBankCentre, dynamic>(query, param);
        }



        public Task<List<BloodBankCentre>> GetList(string APIKey, string KeyW = "", string LocationID = "", int Page = 0, int PageSize = 99999)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "KeyW", KeyW },
                { "LocationID", LocationID },
                { "Page", Page },
                { "PageSize", PageSize }
            };

            string query = "bbk.BloodBankCentre_List";
            return db.GetList<BloodBankCentre, dynamic>(query, param);
        }

    }
}
