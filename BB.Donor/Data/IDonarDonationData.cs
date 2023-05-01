using Donor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Donor.Data
{
    public interface IDonarDonationData
    {
        Task<string> AddEdit(string APIKey, DonarDonation obj, string LogUserID);
        Task<string> Delete(string APIKey, string ID, string LogUserID);
        Task<DonarDonation> Get(string APIKey, string ID);
        Task<int> GetCount(string APIKey, string KeyW = "", string DonorID = "", string NIC = "", string DonationDate = "", string BloodBankCentreID = "", string DoctorID = "", string Status = "");
        Task<List<DonarDonation>> GetList(string APIKey, string KeyW = "", string DonorID = "", string NIC = "", string DonationDate = "", string BloodBankCentreID = "", string DoctorID = "", string Status = "", int Page = 0, int PageSize = 99999);
    }
}