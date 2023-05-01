using DBAccess;
using Donor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donor.Data
{
    public class DonarDonationData : IDonarDonationData
    {
        #region Construction

        private readonly IDBAccess db;

        public DonarDonationData(IDBAccess db)
        {
            this.db = db;
        }

        #endregion

        public Task<string> AddEdit(string APIKey, DonarDonation obj, string LogUserID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "DonotionID", obj.DonotionID },
                { "DonorID", obj.DonorID },
                { "BloodBankCentreID", obj.BloodBankCentreID },
                { "DonationDate", obj.DonationDate },
                { "QuestionnaireID", obj.QuestionnaireID },
                { "DoctorID", obj.DoctorID },
                { "Examination", obj.Examination },
                { "Pulse", obj.Pulse },
                { "BP", obj.BP },
                { "HBLevel", obj.HBLevel },
                { "Weight", obj.Weight },
                { "Remark", obj.Remark },
                { "NextDonationDate", obj.NextDonationDate },
                { "BloodBagNo", obj.BloodBagNo },
                { "Status", obj.Status },
                { "RemarkRejected", obj.RemarkRejected },
                {"FeedBack",obj.FeedBack },
                { "LogUserID", LogUserID }

            };

            string query = "dnr.DonarDonation_AddEdit";
            return db.Execute(query, param);
        }

        public Task<int> GetCount(string APIKey, string KeyW = "", string DonorID = "", string NIC = "", string DonationDate = "", string BloodBankCentreID = "", string DoctorID = "", string Status = "")
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "KeyW", KeyW },
                { "DonorID", DonorID },
                { "NIC", NIC },
                { "DonationDate", DonationDate },
                { "BloodBankCentreID", BloodBankCentreID },
                {"DoctorID",DoctorID },
                { "Status", Status }
            };

            string query = "dnr.DonarDonation_Count";
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

            string query = "dnr.DonarDonation_Delete";
            return db.Execute(query, param);
        }

        public Task<DonarDonation> Get(string APIKey, string ID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "ID",ID }
            };

            string query = "dnr.DonarDonation_Get";
            return db.Get<DonarDonation, dynamic>(query, param);
        }



        public Task<List<DonarDonation>> GetList(string APIKey, string KeyW = "", string DonorID = "", string NIC = "", string DonationDate = "", string BloodBankCentreID = "", string DoctorID = "", string Status = "", int Page = 0, int PageSize = 99999)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "KeyW", KeyW },
                { "DonorID", DonorID },
                { "NIC", NIC },
                { "DonationDate", DonationDate },
                { "BloodBankCentreID", BloodBankCentreID },
                { "DoctorID", DoctorID },
                { "Status", Status },
                { "Page", Page },
                { "PageSize", PageSize }
            };

            string query = "dnr.DonarDonation_List";
            return db.GetList<DonarDonation, dynamic>(query, param);
        }

    }
}
