using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace DropDown
{
    public interface IBloodBankDDL
    {
        Task<SelectList> BloodBankCentreList();
        Task<SelectList> LocationList();
        SelectList TestResultsList();
        SelectList SpecialtyList();

        SelectList BloodStatusList();
    }
}