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
    public class LocationData : ILocationData
    {
        #region Construction

        private readonly IDBAccess db;

        public LocationData(IDBAccess db)
        {
            this.db = db;
        }

        #endregion


        public Task<string> AddEdit(string APIKey, Location obj, string LogUserID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "LocationID", obj.LocationID },
                { "LocationName", obj.LocationName },
             
                { "LogUserID", LogUserID }
            };

            string query = "bbk.Location_AddEdit";
            return db.Execute(query, param);
        }

        public Task<int> GetCount(string APIKey, string KeyW = "")
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "KeyW", KeyW }

            };

            string query = "bbk.Location_Count";
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

            string query = "bbk.Location_Delete";
            return db.Execute(query, param);
        }

        public Task<Location> Get(string APIKey, string ID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "ID",ID }
            };

            string query = "bbk.Location_Get";
            return db.Get<Location, dynamic>(query, param);
        }



        public Task<List<Location>> GetList(string APIKey, string KeyW = "", int Page = 0, int PageSize = 99999)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "KeyW", KeyW },
                { "Page", Page },
                { "PageSize", PageSize }
            };

            string query = "bbk.Location_List";
            return db.GetList<Location, dynamic>(query, param);
        }

    }
}