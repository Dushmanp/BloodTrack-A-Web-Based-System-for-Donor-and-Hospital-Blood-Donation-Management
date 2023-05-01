using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using DBAccess;
using Donor.Models;

namespace Donor.Data
{
    public class DonorInfoData : IDonorInfoData
    {
        #region Construction

        private readonly IDBAccess db;

        public DonorInfoData(IDBAccess db)
        {
            this.db = db;
        }

        #endregion


        public Task<string> AddEdit(string APIKey, DonorInfo obj, string LogUserID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "DonorID", obj.DonorID },
                { "Name", obj.Name },
                { "NIC", obj.NIC },
                { "Email", obj.Email },
                { "Password", obj.Password },
                { "PhoneNumber", obj.PhoneNumber },
                { "OtherPhoneNumber", obj.OtherPhoneNumber },
                { "DonationFrequency", obj.DonationFrequency },
                { "Occupation", obj.Occupation },
                { "MaritalStatus", obj.MaritalStatus },
                { "Address", obj.Address },
                { "DateOfBirth", obj.DateOfBirth },
                { "Location", obj.Location },
                { "Gender", obj.Gender },
                { "BloodType", obj.BloodType },
                { "LogUserID",LogUserID }
            };

            string query = "dnr.Donor_AddEdit";
            return db.Execute(query, param);
        }

        public Task<string> EditPassword(string APIKey, string DonorID, string Password, string LogUserID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "DonorID",DonorID },
                { "Password",Password },
                { "LogUserID",LogUserID }
            };

            string query = "dnr.Donor_PasswordEdit";
            return db.Execute(query, param);
        }

        public Task<int> GetCount(string APIKey, string KeyW = "", string BloodType = "", string Gender = "",
            string Location = "", string DateOfBirth = "")
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "KeyW",KeyW },
                { "BloodType",BloodType },
                { "Gender",Gender },
                { "Location",Location },
                { "DateOfBirth",DateOfBirth }
            };

            string query = "dnr.Donor_Count";
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

            string query = "dnr.Donor_Delete";
            return db.Execute(query, param);
        }

        public Task<DonorInfo> Get(string APIKey, string ID = "" )
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "ID",ID }

            };

            string query = "dnr.Donor_Get";
            return db.Get<DonorInfo, dynamic>(query, param);
        }

        public Task<List<DonorInfo>> GetList(string APIKey, string KeyW = "", string BloodType = "", string Gender = "",
            string Location = "", string DateOfBirth = "", int Page = 0, int PageSize = 99999)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "KeyW",KeyW },
                 { "BloodType",BloodType },
                { "Gender",Gender },
                { "Location",Location },
                { "DateOfBirth",DateOfBirth },
                { "Page",Page },
                { "PageSize",PageSize }
            };

            string query = "dnr.Donor_List";
            return db.GetList<DonorInfo, dynamic>(query, param);
        }

        public Task<DonorInfo> GetByEmail(string APIKey, string EmailAddress)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "EmailAddress",EmailAddress }
            };

            string query = "dnr.Donor_GetByEmail";
            return db.Get<DonorInfo, dynamic>(query, param);
        }

    }
}
