#pragma checksum "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbf96fdcf8e7eb0bfbcda7ed43bc161faf7493f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BloodBankSystem_Views_Campaign_Edit), @"mvc.1.0.view", @"/Areas/BloodBankSystem/Views/Campaign/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbf96fdcf8e7eb0bfbcda7ed43bc161faf7493f5", @"/Areas/BloodBankSystem/Views/Campaign/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3e2a1175bd834b9cce5cf5dcc58f3b2b0b57a3b", @"/Areas/BloodBankSystem/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_BloodBankSystem_Views_Campaign_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CampaignEditView>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
  
    ViewData["Title"] = "Edit Campaign";

    ViewData["DonarDonationActive"] = "active";
  

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- start page title -->\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div class=\"page-title-box\">\r\n            <h4 class=\"page-title\">");
#nullable restore
#line 13 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                              Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- end page title -->\r\n");
#nullable restore
#line 18 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
 using (Html.BeginForm("Edit", "Campaign", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-6 grid-margin stretch-card\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n\r\n                    <div class=\"form-group row d-none\">\r\n                        ");
#nullable restore
#line 30 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Data.ReturnURL, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 32 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.EditorFor(model => model.Data.ReturnURL, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 33 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.ReturnURL, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row d-none\">\r\n                        ");
#nullable restore
#line 38 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Data.CampaignID, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 40 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.EditorFor(model => model.Data.CampaignID, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 41 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.CampaignID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 45 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Data.BloodBankCentreID, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 47 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.DropDownList("Data.BloodBankCentreID", await bloodBankDDL.BloodBankCentreList(), "(Select Blood Bank)", htmlAttributes: new { @class = "", id = "cmbCategoryMainID", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 48 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.BloodBankCentreID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 53 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Data.RegistrationDate, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 55 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.EditorFor(model => model.Data.RegistrationDate, new { htmlAttributes = new { @class = "form-control", autofocus = "autofocus", @readonly = "readonly" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 56 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.RegistrationDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 62 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Data.OrganizerName, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 64 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.EditorFor(model => model.Data.OrganizerName, new { htmlAttributes = new { @class = "form-control", autofocus = "autofocus" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 65 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.OrganizerName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 70 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Data.OrganizerAddress, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 72 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.EditorFor(model => model.Data.OrganizerAddress, new { htmlAttributes = new { @class = "form-control", autofocus = "autofocus", @rows = 6 } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 73 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.OrganizerAddress, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 78 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Data.Email, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 80 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.EditorFor(model => model.Data.Email, new { htmlAttributes = new { @class = "form-control", autofocus = "autofocus" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 81 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 86 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Data.PhoneNumber, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 88 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.EditorFor(model => model.Data.PhoneNumber, new { htmlAttributes = new { @class = "form-control", autofocus = "autofocus" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 89 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.PhoneNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                      <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 93 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Data.VerifiedBy, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 95 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.EditorFor(model => model.Data.VerifiedBy, new { htmlAttributes = new { @class = "form-control", autofocus = "autofocus" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 96 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.VerifiedBy, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 100 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Data.NumberOfDonors, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 102 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.EditorFor(model => model.Data.NumberOfDonors, new { htmlAttributes = new { @class = "form-control", autofocus = "autofocus" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 103 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.NumberOfDonors, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 107 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Data.TargetAddress, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 109 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.EditorFor(model => model.Data.TargetAddress, new { htmlAttributes = new { @class = "form-control", autofocus = "autofocus" , @rows = 6 } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 110 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.TargetLocation, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 115 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Data.TargetLocation, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 117 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.DropDownList("Data.TargetLocation", await bloodBankDDL.LocationList(), "(Select Location)", htmlAttributes: new { @class = "", id = "cmbCategoryMainID" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 118 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.TargetLocation, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                      <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 122 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Data.StartDate, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 124 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.EditorFor(model => model.Data.StartDate, new { htmlAttributes = new { @class = "form-control", autofocus = "autofocus" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 125 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.StartDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 129 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Data.EndDate, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 131 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.EditorFor(model => model.Data.EndDate, new { htmlAttributes = new { @class = "form-control", autofocus = "autofocus" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 132 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Data.EndDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 138 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                   Write(Html.LabelFor(model => model.FileUpload, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bbf96fdcf8e7eb0bfbcda7ed43bc161faf7493f524543", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9187, "~/Uploads/", 9187, 10, true);
#nullable restore
#line 140 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
AddHtmlAttributeValue("", 9197, Model.Data.CampaignID, 9197, 24, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 9221, ".jpg", 9221, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>

                    <div class=""form-group row"">
                        <label class=""col-4 col-form-label"">New Image</label>
                        <div class=""col-8"">
                            ");
#nullable restore
#line 147 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                       Write(Html.EditorFor(model => model.FileUpload, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 152 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Data.ActiveStatus, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8 pt-2\">\r\n                            <div class=\"custom-control custom-switch\">\r\n                                ");
#nullable restore
#line 155 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
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
            BeginWriteAttribute("href", " href=\"", 10664, "\"", 10692, 1);
#nullable restore
#line 168 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
WriteAttributeValue("", 10671, Model.Data.ReturnURL, 10671, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cancel</a>\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 177 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"

}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 180 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Edit.cshtml"
      
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
