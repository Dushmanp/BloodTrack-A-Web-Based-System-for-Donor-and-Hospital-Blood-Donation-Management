using DBAccess;
using Donor.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donor.Data
{
    public class DonorQuestionnaireData : IDonorQuestionnaireData
    {
        #region Construction

        private readonly IDBAccess db;

        public DonorQuestionnaireData(IDBAccess db)
        {
            this.db = db;
        }

        #endregion


        public Task<string> Add(string APIKey, DonorQuestionnaire obj, string LogUserID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey", APIKey },
                { "QuestionnaireID", obj.QuestionnaireID },
                { "Q1Prob", obj.Q1Prob },
                { "Q1Doctor", obj.Q1Doctor },
                { "Q1Health", obj.Q1Health },
                { "Q2medCond", obj.Q2medCond },
                { "Q3Medication", obj.Q3Medication },
                { "Q4Surgery", obj.Q4Surgery },
                { "Q5Heavywork", obj.Q5Heavywork },
                { "Q6Pregnant", obj.Q6Pregnant },
                { "Q7YellowFever", obj.Q7YellowFever },
                { "Q7TbTyphoid", obj.Q7TbTyphoid },
                { "Q7Treated", obj.Q7Treated },
                { "Q8Immunization", obj.Q8Immunization },
                { "Q8TattooAcupuncture", obj.Q8TattooAcupuncture },
                { "Q8Abroad", obj.Q8Abroad },
                { "Q8Prison", obj.Q8Prison },
                { "Q8Blood", obj.Q8Blood },
                { "Q8Malaria", obj.Q8Malaria },
                { "Q9Dengue", obj.Q9Dengue },
                { "Q9Fever", obj.Q9Fever },
                { "Q9Teeth", obj.Q9Teeth },
                { "Q10categories", obj.Q10Categories },
                { "Q11PartnerCategory", obj.Q11PartnerCategory },
                { "Q12Symptoms", obj.Q12Symptoms },
                { "LogUserID", LogUserID },

            };

            string query = "dnr.DonorQuestionnaire_AddEdit";
            return db.Execute(query, param);
        }

        public Task<DonorQuestionnaire> Get(string APIKey, string ID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "ID",ID }
            };

            string query = "dnr.DonorQuestionnaire_Get";
            return db.Get<DonorQuestionnaire, dynamic>(query, param);
        }

    }
}
