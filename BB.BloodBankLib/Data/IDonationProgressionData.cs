using BloodBankL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BloodBankL.Data
{
    public interface IDonationProgressionData
    {
        Task<List<DonationProgression>> GetList(string APIKey, string Year = "");
    }
}