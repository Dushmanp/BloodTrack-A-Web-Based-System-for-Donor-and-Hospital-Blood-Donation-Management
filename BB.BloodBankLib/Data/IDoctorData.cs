using BloodBankL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BloodBankL.Data
{
    public interface IDoctorData
    {
        Task<string> AddEdit(string APIKey, DoctorInfo obj, string LogUserID);
        Task<string> Delete(string APIKey, string ID, string LogUserID);
        Task<DoctorInfo> Get(string APIKey, string ID);
        Task<DoctorInfo> GetByEmail(string APIKey, string EmailAddress);
        Task<DoctorInfo> GetByUsername(string APIKey, string EmailAddress);
        Task<int> GetCount(string APIKey, string KeyW = "", string LocationID = "", string BloodBankCentreID = "", string Specialty = "", string Gender = "");
        Task<List<DoctorInfo>> GetList(string APIKey, string KeyW = "", string LocationID = "", string BloodBankCentreID = "", string Specialty = "", string Gender = "", int Page = 0, int PageSize = 99999);
    }
}