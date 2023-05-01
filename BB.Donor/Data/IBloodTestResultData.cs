using Donor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Donor.Data
{
    public interface IBloodTestResultData
    {
        Task<string> AddEdit(string APIKey, BloodTestResult obj, string LogUserID);
        Task<string> Delete(string APIKey, string ID, string LogUserID);
        Task<BloodTestResult> Get(string APIKey, string ID);
        Task<int> GetCount(string APIKey, string KeyW = "", string DonorID = "", string NIC = "", string DonationDate = "", string BloodBankCentreID = "", string Status = "");
        Task<List<BloodTestResult>> GetList(string APIKey, string KeyW = "", string DonorID = "", string NIC = "", string DonationDate = "", string BloodBankCentreID = "", string Status = "", int Page = 0, int PageSize = 99999);
    }
}