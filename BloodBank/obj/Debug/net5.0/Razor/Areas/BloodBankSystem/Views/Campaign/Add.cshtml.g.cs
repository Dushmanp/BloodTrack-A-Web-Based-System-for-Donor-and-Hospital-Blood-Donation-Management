#pragma checksum "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f624240b59c0f1361a672d20bba42f439a903383"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BloodBankSystem_Views_Campaign_Add), @"mvc.1.0.view", @"/Areas/BloodBankSystem/Views/Campaign/Add.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\_ViewImports.cshtml"
using BloodBank;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\_ViewImports.cshtml"
using BloodBank.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\_ViewImports.cshtml"
using BloodBankL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\_ViewImports.cshtml"
using Donor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\_ViewImports.cshtml"
using Account.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\_ViewImports.cshtml"
using Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\_ViewImports.cshtml"
using BloodBankSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f624240b59c0f1361a672d20bba42f439a903383", @"/Areas/BloodBankSystem/Views/Campaign/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3e2a1175bd834b9cce5cf5dcc58f3b2b0b57a3b", @"/Areas/BloodBankSystem/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_BloodBankSystem_Views_Campaign_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CampaignEditView>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
  
    ViewData["Title"] = "Add Campaign";

    ViewData["DonarDonationActive"] = "active";
  

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- start page title -->\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div class=\"page-title-box\">\r\n            <h4 class=\"page-title\">");
#nullable restore
#line 13 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                              Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- end page title -->\r\n");
#nullable restore
#line 18 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
 using (Html.BeginForm("Add", "Campaign", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-6 grid-margin stretch-card\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n\r\n                    <div class=\"form-group row d-none\">\r\n                        ");
#nullable restore
#line 30 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                   Write(Html.LabelFor(model => model.Data.ReturnURL, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 32 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.EditorFor(model => model.Data.ReturnURL, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 33 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.ReturnURL, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row d-none\">\r\n                        ");
#nullable restore
#line 38 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                   Write(Html.LabelFor(model => model.Data.CampaignID, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 40 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.EditorFor(model => model.Data.CampaignID, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 41 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.CampaignID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 46 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                   Write(Html.LabelFor(model => model.Data.OrganizerName, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 48 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.EditorFor(model => model.Data.OrganizerName, new { htmlAttributes = new { @class = "form-control", autofocus = "autofocus" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 49 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.OrganizerName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 54 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                   Write(Html.LabelFor(model => model.Data.OrganizerAddress, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 56 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.EditorFor(model => model.Data.OrganizerAddress, new { htmlAttributes = new { @class = "form-control", autofocus = "autofocus", @rows = 6 } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 57 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.OrganizerAddress, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 62 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                   Write(Html.LabelFor(model => model.Data.Email, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 64 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.EditorFor(model => model.Data.Email, new { htmlAttributes = new { @class = "form-control", autofocus = "autofocus" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 65 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 70 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                   Write(Html.LabelFor(model => model.Data.PhoneNumber, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 72 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.EditorFor(model => model.Data.PhoneNumber, new { htmlAttributes = new { @class = "form-control", autofocus = "autofocus" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 73 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.PhoneNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                      <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 77 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                   Write(Html.LabelFor(model => model.Data.VerifiedBy, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 79 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.EditorFor(model => model.Data.VerifiedBy, new { htmlAttributes = new { @class = "form-control", autofocus = "autofocus" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 80 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.VerifiedBy, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 84 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                   Write(Html.LabelFor(model => model.Data.NumberOfDonors, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 86 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.EditorFor(model => model.Data.NumberOfDonors, new { htmlAttributes = new { @class = "form-control", autofocus = "autofocus" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 87 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.NumberOfDonors, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 91 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                   Write(Html.LabelFor(model => model.Data.TargetAddress, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 93 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.EditorFor(model => model.Data.TargetAddress, new { htmlAttributes = new { @class = "form-control", autofocus = "autofocus" , @rows = 6 } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 94 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.TargetLocation, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 99 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                   Write(Html.LabelFor(model => model.Data.TargetLocation, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 101 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.DropDownList("Data.TargetLocation", await bloodBankDDL.LocationList(), "(Select Blood Bank)", htmlAttributes: new { @class = "", id = "cmbCategoryMainID" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 102 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.TargetLocation, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                      <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 106 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                   Write(Html.LabelFor(model => model.Data.StartDate, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 108 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.EditorFor(model => model.Data.StartDate, new { htmlAttributes = new { @class = "form-control", autofocus = "autofocus" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 109 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.StartDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 113 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                   Write(Html.LabelFor(model => model.Data.EndDate, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 115 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.EditorFor(model => model.Data.EndDate, new { htmlAttributes = new { @class = "form-control", autofocus = "autofocus" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 116 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.EndDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    \r\n                   \r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 122 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                   Write(Html.LabelFor(model => model.FileUpload, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 124 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.EditorFor(model => model.FileUpload, new { htmlAttributes = new { @class = "form-control", autofocus = "autofocus" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 125 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.FileUpload, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 130 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                   Write(Html.LabelFor(model => model.Data.ActiveStatus, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8 pt-2\">\r\n                            <div class=\"custom-control custom-switch\">\r\n                                ");
#nullable restore
#line 133 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
                           Write(Html.CheckBoxFor(model => model.Data.ActiveStatusBool, new { @class = "custom-control-input checkbox-success", id = "customSwitch1" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <label class=""custom-control-label"" for=""customSwitch1"">Active</label>
                            </div>
                        </div>
                    </div>


                    <div class=""form-group row"">
                        <div class=""col-4"">
                        </div>
                        <div class=""col-8"">
                            <button type=""submit"" class=""btn btn-danger mr-2"">Add</button>
                            &nbsp;
                            <a");
            BeginWriteAttribute("href", " href=\"", 9254, "\"", 9282, 1);
#nullable restore
#line 146 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
WriteAttributeValue("", 9261, Model.Data.ReturnURL, 9261, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cancel</a>\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 155 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"

}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 158 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Add.cshtml"
      
        await Html.RenderPartialAsync("_ValidationScriptsPartial");
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <script>\r\n\r\n    </script>\r\n\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public DropDown.IBloodBankDDL bloodBankDDL { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CampaignEditView> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591