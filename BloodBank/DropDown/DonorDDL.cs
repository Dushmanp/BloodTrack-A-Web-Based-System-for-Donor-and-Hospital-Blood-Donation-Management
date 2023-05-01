using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
 

// Helps to generate drop down lists (select lists)

namespace DropDown
{
    public class DonorDDL : IDonorDDL
    {
        #region Constructions

        private readonly IWebHostEnvironment environment;
        public DonorDDL(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        #endregion

        public SelectList maritalStatusList()
        {
            var objList = new List<_DDLItem>();

            objList.Add(new _DDLItem("S", "Single"));
            objList.Add(new _DDLItem("M", "Married"));
            objList.Add(new _DDLItem("D", "Divorced"));
            objList.Add(new _DDLItem("S", "Separated"));
            objList.Add(new _DDLItem("DP", "Domestic Partnership"));

            return new SelectList(objList, "Value", "Text");
        }

        public SelectList bloodTypeList()
        {
            var objList = new List<_DDLItem>();

            objList.Add(new _DDLItem("A+", "A+"));
            objList.Add(new _DDLItem("A-", "A-"));
            objList.Add(new _DDLItem("B+", "B+"));
            objList.Add(new _DDLItem("B-", "B-"));
            objList.Add(new _DDLItem("AB+", "AB+"));
            objList.Add(new _DDLItem("AB-", "AB-"));
            objList.Add(new _DDLItem("O+", "O+"));
            objList.Add(new _DDLItem("O-", "O-"));

            return new SelectList(objList, "Value", "Text");
        }
        public SelectList genderList()
        {
            var objList = new List<_DDLItem>();

            objList.Add(new _DDLItem("M", "Male"));
            objList.Add(new _DDLItem("F", "Female"));
            objList.Add(new _DDLItem("NB", "Non-binary"));
            objList.Add(new _DDLItem("T", "Transgender"));
            objList.Add(new _DDLItem("O", "Other"));

            return new SelectList(objList, "Value", "Text");
        }

        public SelectList FrequencyList()
        {
            var objList = new List<_DDLItem>();

            objList.Add(new _DDLItem("4", "Every 4 Months"));
            objList.Add(new _DDLItem("6", "Every 6 Month"));
        ;

            return new SelectList(objList, "Value", "Text");
        }


        public SelectList occupationTypeList()
        {
            var objList = new List<_DDLItem>();

            objList.Add(new _DDLItem("SA", "Sales"));
            objList.Add(new _DDLItem("FN", "Finance"));
            objList.Add(new _DDLItem("EN", "Engineering"));
            objList.Add(new _DDLItem("HR", "Human Resources"));
            objList.Add(new _DDLItem("MK", "Marketing"));
            objList.Add(new _DDLItem("IT", "Information Technology"));
            objList.Add(new _DDLItem("OW", "Office Worker"));
            objList.Add(new _DDLItem("MD", "Medicine"));
            objList.Add(new _DDLItem("ED", "Education"));
            objList.Add(new _DDLItem("LG", "Legal"));
            objList.Add(new _DDLItem("AG", "Agriculture"));
            objList.Add(new _DDLItem("OT", "Other"));

            return new SelectList(objList, "Value", "Text");
        }


        public SelectList DonationExaminationList()
        {
            var objList = new List<_DDLItem>();

            objList.Add(new _DDLItem("NA", "No any symptoms"));
            objList.Add(new _DDLItem("RD", "Reject on doctor Recommandation"));
            objList.Add(new _DDLItem("FW", "Feeling Unwell"));
            objList.Add(new _DDLItem("NS", "Not Sleeped 6 hrs"));
            objList.Add(new _DDLItem("NM", "Last meal not eaten <4hr>"));
            objList.Add(new _DDLItem("HR", "High Risk Behaviour"));

            objList.Add(new _DDLItem("PL", "looking or Pallor"));
            objList.Add(new _DDLItem("LT", "Lcterus"));
            objList.Add(new _DDLItem("AC", "Alcohol Smell"));
            objList.Add(new _DDLItem("IW", "Infectecd Wound"));
            objList.Add(new _DDLItem("VL", "Venepuncture Site Lesions"));


            return new SelectList(objList, "Value", "Text");
        }

        public string GetUploadPath(string filename)
        {
            var ParerntPath = Directory.GetParent(environment.ContentRootPath).FullName;
            var FullPath = ParerntPath + "\\" + AppData.GetUplaodPath() + "\\"+ filename;
            return FullPath;
        }
    }
}

