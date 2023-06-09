#pragma checksum "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dac692998c49f8883bff6c6205258a116366078"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BloodBankSystem_Views_OutHospital_Edit), @"mvc.1.0.view", @"/Areas/BloodBankSystem/Views/OutHospital/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dac692998c49f8883bff6c6205258a116366078", @"/Areas/BloodBankSystem/Views/OutHospital/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3e2a1175bd834b9cce5cf5dcc58f3b2b0b57a3b", @"/Areas/BloodBankSystem/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_BloodBankSystem_Views_OutHospital_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OutHospital>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
  
    ViewData["Title"] = "Edit Hospital Information";

    ViewData["DonarDetailsActive"] = "active";



#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- start page title -->\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div class=\"page-title-box\">\r\n            <h4 class=\"page-title\">");
#nullable restore
#line 15 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                              Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- end page title -->\r\n");
#nullable restore
#line 20 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
 using (Html.BeginForm("Edit", "OutHospital", FormMethod.Post, new { area = "BloodBankSystem", @class = "forms-sample", id = "frmProfileInfo" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 770, "\"", 854, 4);
            WriteAttributeValue("", 778, "mt-2", 778, 4, true);
            WriteAttributeValue(" ", 782, "alert", 783, 6, true);
            WriteAttributeValue(" ", 788, "alert-danger", 789, 13, true);
#nullable restore
#line 27 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
WriteAttributeValue("  ", 801, TempData["ErrorMessage"] == null ? "d-none" : "", 803, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
#nullable restore
#line 28 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
            Write(TempData["ErrorMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 939, "\"", 1026, 4);
            WriteAttributeValue("", 947, "mt-2", 947, 4, true);
            WriteAttributeValue(" ", 951, "alert", 952, 6, true);
            WriteAttributeValue(" ", 957, "alert-success", 958, 14, true);
#nullable restore
#line 30 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
WriteAttributeValue("  ", 971, TempData["SuccessMessage"] == null ? "d-none" : "", 973, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
#nullable restore
#line 31 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
            Write(TempData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-6 grid-margin"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""form-group row d-none"">
                        ");
#nullable restore
#line 40 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                   Write(Html.LabelFor(model => model.HospitalID, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 42 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                       Write(Html.EditorFor(model => model.HospitalID, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 43 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.HospitalID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 48 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                   Write(Html.LabelFor(model => model.HospitalName, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 50 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                       Write(Html.EditorFor(model => model.HospitalName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 51 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.HospitalName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 61 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                   Write(Html.LabelFor(model => model.PhoneNumber, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 63 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                       Write(Html.EditorFor(model => model.PhoneNumber, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 64 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.PhoneNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 69 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Address, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 71 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                       Write(Html.EditorFor(model => model.Address, new { htmlAttributes = new { @class = "form-control", rows = "5" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 72 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Address, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        <div class=\"col-4\"></div>\r\n                        <div class=\"col-7\">\r\n                            ");
#nullable restore
#line 79 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                       Write(Html.CheckBoxFor(model => model.UseAuthentication, new Dictionary<string, object> { { "id", "chkAuth" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 80 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                       Write(Html.LabelFor(model => model.UseAuthentication));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 81 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.UseAuthentication, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div id=""authSection"" style=""display:none"" class=""list-group-item list-group-item-warning"">
                        <div class=""form-group row"">
                            ");
#nullable restore
#line 86 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                       Write(Html.LabelFor(model => model.Username, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <div class=\"col-7\">\r\n                                ");
#nullable restore
#line 88 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                           Write(Html.EditorFor(model => model.Username, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 89 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Username, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"form-group row\">\r\n                            ");
#nullable restore
#line 93 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                       Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <div class=\"col-7\">\r\n                                ");
#nullable restore
#line 95 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                           Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 96 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group row\">\r\n                            ");
#nullable restore
#line 101 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                       Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <div class=\"col-md-7\">\r\n                                ");
#nullable restore
#line 103 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                           Write(Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 104 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n                    <br />\r\n\r\n                 \r\n\r\n\r\n                    <div class=\"form-group row  \">\r\n                        ");
#nullable restore
#line 116 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                   Write(Html.LabelFor(model => model.LocationID, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 118 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                       Write(Html.DropDownList("LocationID", await bloodBankDDL.LocationList(), "(Select Location)", htmlAttributes: new { @class = "",  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 119 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.LocationID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <input type=\"submit\" value=\"Update\" class=\"btn btn-primary mr-2 mb-2 mb-md-0 text-white\" />\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 130 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"






}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 138 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\OutHospital\Edit.cshtml"
      
        await Html.RenderPartialAsync("_ValidationScriptsPartial");
    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script>

        $(document).ready(function () {
            if ($('#chkAuth').is(':checked')) {
                $('#authSection').fadeIn(1000, ""swing"");
            }
            else {
                $('#authSection').fadeOut(500, ""swing"");
            }

            $('#frmProfileInfo').submit(function (event) {
                var dob = $('#DateOfBirth').val();
                var age = calculateAge(dob);
                if (age < 18) {
                    event.preventDefault();
                    $('#age-error').show();
                }
            });
        });


        $(""#chkAuth"").click(function (event) {
            if ($('#chkAuth').is(':checked')) {
                $('#authSection').fadeIn(500, ""swing"");
                $('#newID').focus();

            }
            else {
                $('#authSection').fadeOut(500, ""swing"");
            }
        });


        function calculateAge(dateString) {
            var today = new Date();
            v");
                WriteLiteral(@"ar birthDate = new Date(dateString);
            var age = today.getFullYear() - birthDate.getFullYear();
            var m = today.getMonth() - birthDate.getMonth();
            if (m < 0 || (m === 0 && today.getDate() < birthDate.getDate())) {
                age--;
            }
            return age;
        }



    </script>

");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public DropDown.IBloodBankDDL bloodBankDDL { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public DropDown.IDonorDDL donorDDL { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OutHospital> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
