using BloodBankL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BloodBankL.Data
{
    public interface IBloodRequestDetailsData
    {
        Task<string> AddEdit(string APIKey, BloodRequestDetails obj, string LogUserID);
        Task<string> Delete(string APIKey, string ID, string LogUserID);
        Task<BloodRequestDetails> Get(string APIKey, string ID);
        Task<int> GetCount(string APIKey, string KeyW = "", string LocationID = "", string Status = "");
        Task<List<BloodRequestDetails>> GetList(string APIKey, string KeyW = "", string LocationID = "", string Status = "", int Page = 0, int PageSize = 99999);
    }
}