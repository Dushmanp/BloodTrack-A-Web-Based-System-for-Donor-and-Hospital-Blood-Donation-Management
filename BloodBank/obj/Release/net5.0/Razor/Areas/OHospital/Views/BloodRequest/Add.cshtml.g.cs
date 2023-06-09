#pragma checksum "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "769ebbb16e3ad8a8b44faba718a00650648ee6a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OHospital_Views_BloodRequest_Add), @"mvc.1.0.view", @"/Areas/OHospital/Views/BloodRequest/Add.cshtml")]
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
#line 1 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\_ViewImports.cshtml"
using BloodBank;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\_ViewImports.cshtml"
using BloodBank.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\_ViewImports.cshtml"
using BloodBankL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\_ViewImports.cshtml"
using Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"769ebbb16e3ad8a8b44faba718a00650648ee6a6", @"/Areas/OHospital/Views/BloodRequest/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce57c817ecb69a2ed08bec349e0359441436af7c", @"/Areas/OHospital/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_OHospital_Views_BloodRequest_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BloodRequestDetailView>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
  
    ViewData["Title"] = "Add Blood Request";

    ViewData["RequestActive"] = "active";
 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 13 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
 using (Html.BeginForm(null, null, FormMethod.Post, new { id = "frmAddRequest" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-6 grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body"">
                    <h6 class=""text-primary mb-3"">Blood Requesting Info</h6>
                    <div class=""form-group row d-none"">
                        ");
#nullable restore
#line 25 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                   Write(Html.LabelFor(model => model.bloodRequest.BloodRequestID, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 27 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.EditorFor(model => model.bloodRequest.BloodRequestID, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 28 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.bloodRequest.BloodRequestID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 33 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                   Write(Html.LabelFor(model => model.bloodRequest.PatientName, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 35 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.EditorFor(model => model.bloodRequest.PatientName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 36 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.bloodRequest.PatientName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 41 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                   Write(Html.LabelFor(model => model.bloodRequest.PatientAge, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 43 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.EditorFor(model => model.bloodRequest.PatientAge, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 44 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.bloodRequest.PatientAge, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 49 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                   Write(Html.LabelFor(model => model.bloodRequest.PatientSex, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 51 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.DropDownList("bloodRequest.PatientSex", donorDDL.genderList(),  "Select Sex ", htmlAttributes: new { @class = "form-control", data_toggle = "select2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 52 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.bloodRequest.PatientSex, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 57 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                   Write(Html.LabelFor(model => model.bloodRequest.BloodGroup, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 59 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.DropDownList("bloodRequest.BloodGroup", donorDDL.bloodTypeList(),  "Select Type ", htmlAttributes: new { @class = "form-control", data_toggle = "select2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 60 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.bloodRequest.BloodGroup, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 65 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                   Write(Html.LabelFor(model => model.bloodRequest.DoctorInCharge, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 67 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.EditorFor(model => model.bloodRequest.DoctorInCharge, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 68 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.bloodRequest.DoctorInCharge, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                  \r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 73 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                   Write(Html.LabelFor(model => model.bloodRequest.DoctorContact, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 75 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.EditorFor(model => model.bloodRequest.DoctorContact, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 76 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.bloodRequest.DoctorContact, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 81 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                   Write(Html.LabelFor(model => model.bloodRequest.ReasonOfTransfusion, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 83 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.EditorFor(model => model.bloodRequest.ReasonOfTransfusion, new { htmlAttributes = new { @class = "form-control",@rows="10" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 84 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.bloodRequest.ReasonOfTransfusion, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""col-md-6 grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body"">
                    <h6 class=""text-primary mb-3"">Blood  Details</h6>

                    <div class=""row"">
                        <div class=""col-12"">
                            <div id=""ErrorMessage""");
            BeginWriteAttribute("class", " class=\"", 5743, "\"", 5827, 4);
            WriteAttributeValue("", 5751, "mt-2", 5751, 4, true);
            WriteAttributeValue(" ", 5755, "alert", 5756, 6, true);
            WriteAttributeValue(" ", 5761, "alert-danger", 5762, 13, true);
#nullable restore
#line 98 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
WriteAttributeValue("  ", 5774, TempData["ErrorMessage"] == null ? "d-none" : "", 5776, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
#nullable restore
#line 99 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                            Write(TempData["ErrorMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row  d-none\">\r\n                        ");
#nullable restore
#line 105 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                   Write(Html.LabelFor(model => model.bloodrequestDetails.BloodRequestDetailsID, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 107 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.EditorFor(model => model.bloodrequestDetails.BloodRequestDetailsID, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 108 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.bloodrequestDetails.BloodRequestDetailsID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 113 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                   Write(Html.LabelFor(model => model.bloodRequest.DateTimeOfRequirement, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 115 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.EditorFor(model => model.bloodRequest.DateTimeOfRequirement, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 116 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.bloodRequest.DateTimeOfRequirement, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 121 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                   Write(Html.LabelFor(model => model.bloodrequestDetails.WholeBloodUnit, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 123 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.EditorFor(model => model.bloodrequestDetails.WholeBloodUnit, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 124 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.bloodrequestDetails.WholeBloodUnit, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 129 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                   Write(Html.LabelFor(model => model.bloodrequestDetails.PackedCellUnit, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 131 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.EditorFor(model => model.bloodrequestDetails.PackedCellUnit, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 132 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.bloodrequestDetails.PackedCellUnit, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 137 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                   Write(Html.LabelFor(model => model.bloodrequestDetails.FreshFrozenPlasmaUnit, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 139 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.EditorFor(model => model.bloodrequestDetails.FreshFrozenPlasmaUnit, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 140 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.bloodrequestDetails.FreshFrozenPlasmaUnit, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 145 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                   Write(Html.LabelFor(model => model.bloodrequestDetails.PlateletComponentsUnit, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 147 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.EditorFor(model => model.bloodrequestDetails.PlateletComponentsUnit, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 148 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.bloodrequestDetails.PlateletComponentsUnit, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 153 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                   Write(Html.LabelFor(model => model.bloodrequestDetails.SingleDonorPlateletUnit, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 155 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.EditorFor(model => model.bloodrequestDetails.SingleDonorPlateletUnit, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 156 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.bloodrequestDetails.SingleDonorPlateletUnit, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 160 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                   Write(Html.LabelFor(model => model.bloodrequestDetails.CryoPoorPlasmaUnit, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 162 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.EditorFor(model => model.bloodrequestDetails.CryoPoorPlasmaUnit, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 163 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.bloodrequestDetails.CryoPoorPlasmaUnit, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"text-center\">\r\n        <button class=\"mt-2 btn btn-primary \" type=\"submit\">Send Request</button>\r\n    </div>\r\n");
#nullable restore
#line 177 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 179 "F:\Asure Final Project\BloodBank\Areas\OHospital\Views\BloodRequest\Add.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial"); 

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script>
        $(document).ready(function () {
            $(""#frmAddRequest"").submit(function (event) {
                event.preventDefault(); // prevent form submission

                // get the values of each input field
                var wholeBloodUnit = $(""#bloodrequestDetails_WholeBloodUnit"").val();
                var packedCellUnit = $(""#bloodrequestDetails_PackedCellUnit"").val();
                var freshFrozenPlasmaUnit = $(""#bloodrequestDetails_FreshFrozenPlasmaUnit"").val();
                var plateletComponentsUnit = $(""#bloodrequestDetails_PlateletComponentsUnit"").val();
                var singleDonorPlateletUnit = $(""#bloodrequestDetails_SingleDonorPlateletUnit"").val();
                var cryoPoorPlasmaUnit = $(""#bloodrequestDetails_CryoPoorPlasmaUnit"").val();

                // check if at least one field is not empty
                if (wholeBloodUnit || packedCellUnit || freshFrozenPlasmaUnit || plateletComponentsUnit || singleDonorPlateletUnit || cryoPoorPlasmaUn");
                WriteLiteral(@"it) {
                    $(""#frmAddRequest"").unbind(""submit"").submit(); // submit the form if at least one field is not empty
                } else {
                    $(""#ErrorMessage"").removeClass(""d-none"").text(""Please enter at least one blood unit.""); // show an error message if no field is entered
                }
            });
        });

    </script>
");
            }
            );
            WriteLiteral("\r\n  ");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BloodRequestDetailView> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
