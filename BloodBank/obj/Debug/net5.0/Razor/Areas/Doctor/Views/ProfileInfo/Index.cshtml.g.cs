#pragma checksum "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b833fe15af6823a397a2c7bb2086850c1fa6d92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Doctor_Views_ProfileInfo_Index), @"mvc.1.0.view", @"/Areas/Doctor/Views/ProfileInfo/Index.cshtml")]
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
#line 1 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\_ViewImports.cshtml"
using BloodBank;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\_ViewImports.cshtml"
using BloodBank.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\_ViewImports.cshtml"
using BloodBankL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\_ViewImports.cshtml"
using Donor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\_ViewImports.cshtml"
using BloodBankSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\_ViewImports.cshtml"
using Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b833fe15af6823a397a2c7bb2086850c1fa6d92", @"/Areas/Doctor/Views/ProfileInfo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8201eec98d40e33a6435f52164ee3d628d6dc91", @"/Areas/Doctor/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Doctor_Views_ProfileInfo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorInfo>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SelectData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
  
    ViewData["Title"] = "Edit Doctor";

    ViewData["DoctorActive"] = "active";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3b833fe15af6823a397a2c7bb2086850c1fa6d924467", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!-- start page title -->\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div class=\"page-title-box\">\r\n            <h4 class=\"page-title\">");
#nullable restore
#line 18 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                              Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- end page title -->\r\n");
#nullable restore
#line 23 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-6 grid-margin\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n\r\n                    <div class=\"form-group row d-none\">\r\n                        ");
#nullable restore
#line 35 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                   Write(Html.LabelFor(model => model.ReturnURL, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 37 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.EditorFor(model => model.ReturnURL, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 38 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.ReturnURL, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row d-none\">\r\n                        ");
#nullable restore
#line 43 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                   Write(Html.LabelFor(model => model.DoctorID, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 45 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.EditorFor(model => model.DoctorID, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 46 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.DoctorID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 51 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                   Write(Html.LabelFor(model => model.FullName, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 53 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.EditorFor(model => model.FullName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 54 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.FullName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 58 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                   Write(Html.LabelFor(model => model.DateOfBirth, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 60 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.EditorFor(model => model.DateOfBirth, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 61 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.DateOfBirth, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 66 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                   Write(Html.LabelFor(model => model.Gender, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 68 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.DropDownList("Gender", donnorDDL.genderList(), "(Select Gender)", htmlAttributes: new { @class = "", id = "cmbGender" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 69 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Gender, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 74 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                   Write(Html.LabelFor(model => model.Address, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 76 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.EditorFor(model => model.Address, new { htmlAttributes = new { @class = "form-control",@rows="5" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 77 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Address, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 83 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                   Write(Html.LabelFor(model => model.UserName, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 85 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.EditorFor(model => model.UserName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 86 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.UserName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 93 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                   Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 95 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 96 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>

                    <div class=""form-group row"">
                        <div class=""col-4""></div>
                        <div class=""col-8"">
                            <input type=""checkbox"" id=""chkPassword"" />
                            <label for=""chkPassword"">Reset password</label>
                        </div>
                    </div>

                    <div id=""grpPassword"" class=""form-group row d-none"">
                        ");
#nullable restore
#line 109 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                   Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 111 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 112 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 117 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                   Write(Html.LabelFor(model => model.PhoneNumber, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 119 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.EditorFor(model => model.PhoneNumber, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 120 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.PhoneNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 124 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                   Write(Html.LabelFor(model => model.Specialty, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 126 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.DropDownList("Specialty", bloodBankDDL.SpecialtyList(), "(Select Specialty)", htmlAttributes: new { @class = "", id = "cmbSpecialty" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 127 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Specialty, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 132 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                   Write(Html.LabelFor(model => model.BloodBankCentreID, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 134 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.DropDownList("BloodBankCentreID",await bloodBankDDL.BloodBankCentreList(), "(Select Specialty)", htmlAttributes: new { @class = "", id = "cmbSpecialty",@readonly="readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 135 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.BloodBankCentreID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 140 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                   Write(Html.LabelFor(model => model.LicenseNumber, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 142 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.EditorFor(model => model.LicenseNumber, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 143 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.LicenseNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 148 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                   Write(Html.LabelFor(model => model.LicenseExpirationDate, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 150 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.EditorFor(model => model.LicenseExpirationDate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 151 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.LicenseExpirationDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"row mt-2 \">\r\n\r\n        <div class=\"col-md-12 justify-content-center\">\r\n\r\n            <button type=\"submit\" class=\"btn btn-primary mr-2\">Update</button>\r\n\r\n            <a class=\"mt-2\"");
            BeginWriteAttribute("href", " href=\"", 9036, "\"", 9059, 1);
#nullable restore
#line 171 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
WriteAttributeValue("", 9043, Model.ReturnURL, 9043, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cancel</a>\r\n\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 176 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 179 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\ProfileInfo\Index.cshtml"
      
        await Html.RenderPartialAsync("_ValidationScriptsPartial");
    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script>

        $(document).ready(function () {

        });

        $(""#chkPassword"").change(function () {
            if (this.checked) {
                $(""#grpPassword"").removeClass(""d-none"");
            }
            else {
                $(""#grpPassword"").addClass(""d-none"");
            }
        });

    </script>


");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public DropDown.IDonorDDL donnorDDL { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public DropDown.IBloodBankDDL bloodBankDDL { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public DropDown.ICommonDDL CommonDDL { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoctorInfo> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
