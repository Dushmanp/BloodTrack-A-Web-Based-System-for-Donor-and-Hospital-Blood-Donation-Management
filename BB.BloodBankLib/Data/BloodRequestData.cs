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

    public class BloodRequestData : IBloodRequestData
    {
        #region Construction

        private readonly IDBAccess db;

        public BloodRequestData(IDBAccess db)
        {
            this.db = db;
        }

        #endregion

        public Task<string> AddEdit(string APIKey, BloodRequest obj, string LogUserID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "BloodRequestID", obj.BloodRequestID },
                { "HospitalID", obj.HospitalID },
                { "PatientName", obj.PatientName },
                { "PatientAge", obj.PatientAge },
                { "PatientSex", obj.PatientSex },
                { "BloodGroup", obj.BloodGroup },
                { "DoctorInCharge", obj.DoctorInCharge },
                { "DoctorContact", obj.DoctorContact },
                { "DateOfRequest", obj.DateOfRequest },
                { "DateTimeOfRequirement", obj.DateTimeOfRequirement },
                { "ReasonOfTransfusion", obj.ReasonOfTransfusion },
                { "BloodBankCentreID", obj.BloodBankCentreID },
                { "Status", obj.Status },
                { "LogUserID", LogUserID}
            };

            string query = "bbk.BloodRequest_AddEdit";
            return db.Execute(query, param);
        }


        public Task<int> GetCount(string APIKey, string KeyW = "", string HospitalID="", string LocationID = "", string DateTimeOfRequirement = "", string Status = "")
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "KeyW", KeyW },
                {"HospitalID", HospitalID },
                { "location", LocationID },
                { "DateTimeOfRequirement", DateTimeOfRequirement },

                { "Status", Status }
            };

            string query = "bbk.BloodRequest_Count";
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

            string query = "bbk.BloodRequest_Delete";
            return db.Execute(query, param);
        }

        public Task<BloodRequest> Get(string APIKey, string ID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "ID",ID }
            };

            string query = "bbk.BloodRequest_Get";
            return db.Get<BloodRequest, dynamic>(query, param);
        }
        public Task<List<BloodRequest>> GetList(string APIKey, string KeyW = "", string HospitalID="", string LocationID = "",string DateTimeOfRequirement = "", string Status = "", int Page = 0, int PageSize = 99999)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "KeyW", KeyW },
                { "HospitalID",HospitalID },
                { "LocationID", LocationID },
                { "DateTimeOfRequirement", DateTimeOfRequirement },
                { "Status", Status },
                { "Page", Page },
                { "PageSize", PageSize }
            };

            string query = "bbk.BloodRequest_List";
            return db.GetList<BloodRequest, dynamic>(query, param);
        }
    }
}
