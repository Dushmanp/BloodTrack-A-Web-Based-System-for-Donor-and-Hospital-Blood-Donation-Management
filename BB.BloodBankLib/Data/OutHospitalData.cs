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
    public class OutHospitalData : IOutHospitalData
    {
        #region Construction

        private readonly IDBAccess db;

        public OutHospitalData(IDBAccess db)
        {
            this.db = db;
        }

        #endregion


        public Task<string> AddEdit(string APIKey, OutHospital obj, string LogUserID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "HospitalID", obj.HospitalID },
                { "HospitalName", obj.HospitalName },
                { "Email", obj.Email },
                { "PhoneNumber", obj.PhoneNumber },
                { "Address", obj.Address },
                { "Username", obj.Username },
                { "Password", obj.Password },
                { "ApprovedBy", obj.ApprovedBy },
                { "LocationID", obj.LocationID },
                { "LogUserID", LogUserID }
            };

            string query = "bbk.OutHospital_AddEdit";
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

            string query = "bbk.OutHospital_Count";
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

            string query = "bbk.OutHospital_Delete";
            return db.Execute(query, param);
        }

        public Task<OutHospital> Get(string APIKey, string ID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "ID",ID }
            };

            string query = "bbk.OutHospital_Get";
            return db.Get<OutHospital, dynamic>(query, param);
        }

        public Task<List<OutHospital>> GetList(string APIKey, string KeyW = "", string LocationID = "", int Page = 0, int PageSize = 99999)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "KeyW", KeyW },
                { "LocationID", LocationID },
                { "Page", Page },
                { "PageSize", PageSize }
            };

            string query = "bbk.OutHospital_List";
            return db.GetList<OutHospital, dynamic>(query, param);
        }


        public Task<OutHospital> GetByEmail(string APIKey, string EmailAddress)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "EmailAddress",EmailAddress }
            };

            string query = "bbk.OutHospital_GetByEmail";
            return db.Get<OutHospital, dynamic>(query, param);
        }

        public Task<OutHospital> GetByUsername(string APIKey, string EmailAddress)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "Username",EmailAddress }
            };

            string query = "bbk.OutHospital_GetByUsername";
            return db.Get<OutHospital, dynamic>(query, param);
        }
    }
}
