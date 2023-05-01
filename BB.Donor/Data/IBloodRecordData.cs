using Donor.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Donor.Data
{
    public interface IBloodRecordData
    {
        Task<string> AddEdit(string APIKey, BloodRecord obj, string LogUserID);
        Task<string> Delete(string APIKey, string ID, string LogUserID);
        Task<BloodRecord> Get(string APIKey, string ID);
        Task<int> GetCount(string APIKey, string KeyW = "", string DonorID = "", string NIC = "", string ProcessedDate = "", string DonationDate = "", string BloodBankCentreID = "", string Status = "");
        Task<List<BloodRecord>> GetList(string APIKey, string KeyW = "", string DonorID = "", string NIC = "", string ProcessedDate = "", string DonationDate = "", string BloodBankCentreID = "", string Status = "", int Page = 0, int PageSize = 99999);
    }
}