using Microsoft.AspNetCore.Mvc.Rendering;

namespace DropDown
{
    public interface IDonorDDL
    {
        SelectList bloodTypeList();
        SelectList genderList();
        SelectList maritalStatusList();
        SelectList occupationTypeList();
        SelectList FrequencyList();
        SelectList DonationExaminationList();
        string GetUploadPath(string filename);
    }
}