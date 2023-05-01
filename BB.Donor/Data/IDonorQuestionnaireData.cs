using Donor.Models;
using System.Threading.Tasks;

namespace Donor.Data
{
    public interface IDonorQuestionnaireData
    {
        Task<string> Add(string APIKey, DonorQuestionnaire obj, string LogUserID);
        Task<DonorQuestionnaire> Get(string APIKey, string ID);
    }
}