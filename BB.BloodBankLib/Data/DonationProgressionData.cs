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
    public class DonationProgressionData : IDonationProgressionData
    {

        #region Construction

        private readonly IDBAccess db;

        public DonationProgressionData(IDBAccess db)
        {
            this.db = db;
        }

        #endregion

        public Task<List<DonationProgression>> GetList(string APIKey, string Year = "")
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "Year", Year },

            };

            string query = "dsh.DonationProgression";
            return db.GetList<DonationProgression, dynamic>(query, param);
        }

    }
}
