using BloodBankL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BloodBankL.Data
{
    public interface IBloodDonationCampaignData
    {
        Task<string> AddEdit(string APIKey, BloodDonationCampaign obj, string LogUserID);
        Task<string> Delete(string APIKey, string ID, string LogUserID);
        Task<BloodDonationCampaign> Get(string APIKey, string ID);
        
        Task<int> GetCount(string APIKey, string KeyW = "", string RegistrationDate = "", string StartDate = "", string BloodBankCentreID = "", string LocationID = "", string ActiveStatus = "");
        Task<List<BloodDonationCampaign>> GetList(string APIKey, string KeyW = "", string RegistrationDate = "", string StartDate = "", string BloodBankCentreID = "", string LocationID = "", string ActiveStatus = "", int Page = 0, int PageSize = 99999);
    }
}