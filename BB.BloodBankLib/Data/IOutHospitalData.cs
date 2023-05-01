using BloodBankL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BloodBankL.Data
{
    public interface IOutHospitalData
    {
        Task<string> AddEdit(string APIKey, OutHospital obj, string LogUserID);
        Task<string> Delete(string APIKey, string ID, string LogUserID);
        Task<OutHospital> Get(string APIKey, string ID);
        Task<OutHospital> GetByEmail(string APIKey, string EmailAddress);
        Task<OutHospital> GetByUsername(string APIKey, string EmailAddress);
        Task<int> GetCount(string APIKey, string KeyW = "", string LocationID = "");
        Task<List<OutHospital>> GetList(string APIKey, string KeyW = "", string LocationID = "", int Page = 0, int PageSize = 99999);
    }
}