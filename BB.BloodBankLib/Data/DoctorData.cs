using BloodBankl.Models;
using BloodBankL.Models;
using DBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankL.Data
{
    public class DoctorData : IDoctorData
    {
        #region Construction

        private readonly IDBAccess db;

        public DoctorData(IDBAccess db)
        {
            this.db = db;
        }

        #endregion


        public Task<string> AddEdit(string APIKey, DoctorInfo obj, string LogUserID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "DoctorID", obj.DoctorID },
                { "FullName", obj.FullName },
                { "UserName", obj.UserName },
                { "Password", obj.Password },
                { "Email", obj.Email },
                { "PhoneNumber", obj.PhoneNumber },
                { "BloodBankCentreID", obj.BloodBankCentreID },
                { "Specialty", obj.Specialty },
                { "LicenseNumber", obj.LicenseNumber },
                { "LicenseExpirationDate", obj.LicenseExpirationDate },
                { "DateOfBirth", obj.DateOfBirth },
                { "Gender", obj.Gender },
                { "Address", obj.Address },
                { "LogUserID", LogUserID }
            };

            string query = "bbk.Doctors_AddEdit";
            return db.Execute(query, param);
        }

        public Task<int> GetCount(string APIKey, string KeyW = "", string LocationID = "", string BloodBankCentreID = "", string Specialty = "", string Gender = "")
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "KeyW", KeyW },
                { "LocationID", LocationID },
                { "BloodBankCentreID", BloodBankCentreID },
                { "Specialty", Specialty },
                { "Gender", Gender }

            };

            string query = "bbk.Doctors_Count";
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

            string query = "bbk.Doctors_Delete";
            return db.Execute(query, param);
        }

        public Task<DoctorInfo> Get(string APIKey, string ID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "ID",ID }
            };

            string query = "bbk.Doctors_Get";
            return db.Get<DoctorInfo, dynamic>(query, param);
        }

        public Task<List<DoctorInfo>> GetList(string APIKey, string KeyW = "", string LocationID = "", string BloodBankCentreID = "", string Specialty = "", string Gender = "", int Page = 0, int PageSize = 99999)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "KeyW", KeyW },
                { "LocationID", LocationID },
                { "BloodBankCentreID", BloodBankCentreID },
                { "Specialty", Specialty },
                { "Gender", Gender },
                { "Page", Page },
                { "PageSize", PageSize }
            };

            string query = "bbk.Doctors_List";
            return db.GetList<DoctorInfo, dynamic>(query, param);
        }


        public Task<DoctorInfo> GetByEmail(string APIKey, string EmailAddress)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "EmailAddress",EmailAddress }
            };

            string query = "bbk.Doctors_GetByEmail";
            return db.Get<DoctorInfo, dynamic>(query, param);
        }

        public Task<DoctorInfo> GetByUsername(string APIKey, string EmailAddress)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "Username",EmailAddress }
            };

            string query = "bbk.Doctors_GetByUsername";
            return db.Get<DoctorInfo, dynamic>(query, param);
        }
    }
}
