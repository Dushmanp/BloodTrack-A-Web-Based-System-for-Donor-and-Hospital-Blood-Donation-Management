using BloodBankL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BloodBankL.Data
{
    public interface ILocationData
    {
        Task<string> AddEdit(string APIKey, Location obj, string LogUserID);
        Task<string> Delete(string APIKey, string ID, string LogUserID);
        Task<Location> Get(string APIKey, string ID);
        Task<int> GetCount(string APIKey, string KeyW = "");
        Task<List<Location>> GetList(string APIKey, string KeyW = "", int Page = 0, int PageSize = 99999);
    }
}