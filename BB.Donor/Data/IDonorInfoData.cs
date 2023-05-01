using Donor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Donor.Data
{
    public interface IDonorInfoData
    {
        Task<string> AddEdit(string APIKey, DonorInfo obj, string LogUserID);
        Task<string> Delete(string APIKey, string ID, string LogUserID);
        Task<string> EditPassword(string APIKey, string DonorID, string Password, string LogUserID);
        Task<DonorInfo> Get(string APIKey, string ID = "" );
        Task<DonorInfo> GetByEmail(string APIKey, string EmailAddress);
        Task<int> GetCount(string APIKey, string KeyW = "", string BloodType = "", string Gender = "", string Location = "", string DateOfBirth = "");
        Task<List<DonorInfo>> GetList(string APIKey, string KeyW = "", string BloodType = "", string Gender = "", string Location = "", string DateOfBirth = "", int Page = 0, int PageSize = 99999);
    }
}