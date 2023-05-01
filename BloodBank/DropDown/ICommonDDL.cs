using Microsoft.AspNetCore.Mvc.Rendering;

namespace DropDown
{
    public interface ICommonDDL
    {
        SelectList ActiveStatusList();
        string CheckFile(string ImageId = "");
        string GetWebURL();
        SelectList DonationStatusList();
        string GetUploadPath(string filename);
        string SetUploadPath();

        SelectList RequestStatusList();
    }
}