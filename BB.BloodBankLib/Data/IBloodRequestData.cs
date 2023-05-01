using BloodBankL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BloodBankL.Data
{
    public interface IBloodRequestData
    {
        Task<string> AddEdit(string APIKey, BloodRequest obj, string LogUserID);
        Task<string> Delete(string APIKey, string ID, string LogUserID);
        Task<BloodRequest> Get(string APIKey, string ID);
        Task<int> GetCount(string APIKey, string KeyW = "", string HospitalID = "", string LocationID = "", string DateTimeOfRequirement = "", string Status = "");
        Task<List<BloodRequest>> GetList(string APIKey, string KeyW = "", string HospitalID ="", string LocationID = "", string DateTimeOfRequirement = "", string Status = "", int Page = 0, int PageSize = 99999);
    }
}