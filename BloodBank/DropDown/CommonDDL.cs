using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// Helps to generate drop down lists (select lists)

namespace DropDown
{
    public class CommonDDL : ICommonDDL
    {
        private readonly IWebHostEnvironment environment;
        #region Constructions
        [Obsolete]
        public CommonDDL(IHostingEnvironment Environment, IWebHostEnvironment environment)
        {
            this.environment = environment;
        }
        #endregion
        public SelectList ActiveStatusList()
        {
            var objList = new List<_DDLItem>();

            objList.Add(new _DDLItem("A", "Active"));
            objList.Add(new _DDLItem("I", "Inactive"));

            return new SelectList(objList, "Value", "Text");
        }

        public  string GetWebURL()
        {
            return SettingHelper.AppSetting("Directory:WebURL");
        }

        public string CheckFile(string ImageId = "")
        {

            var ParerntPath = Directory.GetParent(environment.ContentRootPath).FullName;
            string pathOLD = ParerntPath + "\\" + "Uploads" + "\\" + ImageId + ".jpg";

            if (String.IsNullOrEmpty(ImageId))
            {
                return "download.jpg";
            }

            else if (File.Exists(pathOLD))
            {
                return ImageId + ".jpg";
            }

            else
            {
                return "download.jpg";
            }




        }

        public string GetUploadPath(string filename)
        {
            var ParerntPath = Directory.GetParent(environment.ContentRootPath).FullName;
            var FullPath = ParerntPath + "\\" + AppData.GetUplaodPath() + "\\" + filename;
            return FullPath;
        }

        public string SetUploadPath()
        {
            var ParerntPath = Directory.GetParent(environment.ContentRootPath).FullName;
            var FullPath = ParerntPath + "\\" + AppData.GetUplaodPath() + "\\";
            return FullPath;
        }

        public SelectList RequestStatusList()
        {
            var objList = new List<_DDLItem>();

            objList.Add(new _DDLItem("P", "Processing"));
            objList.Add(new _DDLItem("NA", "Not Available"));
            objList.Add(new _DDLItem("DL", "Delivered"));
            objList.Add(new _DDLItem("RO", "Rejected by Hospital"));
            objList.Add(new _DDLItem("RB", "Rejected by Blood Bank"));

            return new SelectList(objList, "Value", "Text");
        }

        public SelectList DonationStatusList()
        {
            var objList = new List<_DDLItem>();

            objList.Add(new _DDLItem("E", "Eligible"));
            objList.Add(new _DDLItem("AD", "Doctor Appointed"));
            objList.Add(new _DDLItem("NE", "Not Eligible"));
            objList.Add(new _DDLItem("DV", "Doctor Verified"));
            objList.Add(new _DDLItem("DD", "Doctor Declined"));
            objList.Add(new _DDLItem("D", "Donated"));
            objList.Add(new _DDLItem("C", "Completed"));
            objList.Add(new _DDLItem("T", "Transfusion"));
            return new SelectList(objList, "Value", "Text");
        }

    }
}

