using BloodBankl.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BloodBankL.Data
{
    public interface IBloodBankCentreData
    {
        Task<string> AddEdit(string APIKey, BloodBankCentre obj, string LogUserID);
        Task<string> Delete(string APIKey, string ID, string LogUserID);
        Task<BloodBankCentre> Get(string APIKey, string ID);
        Task<int> GetCount(string APIKey, string KeyW = "", string LocationID = "");
        Task<List<BloodBankCentre>> GetList(string APIKey, string KeyW = "", string LocationID = "", int Page = 0, int PageSize = 99999);
    }
}