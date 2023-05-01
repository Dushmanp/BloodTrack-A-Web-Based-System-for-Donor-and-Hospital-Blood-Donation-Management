#pragma checksum "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44a0409449e01491598cdf787f9cc7188ef96089"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BloodBankSystem_Views_BloodRequest__MainList), @"mvc.1.0.view", @"/Areas/BloodBankSystem/Views/BloodRequest/_MainList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a0409449e01491598cdf787f9cc7188ef96089", @"/Areas/BloodBankSystem/Views/BloodRequest/_MainList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3e2a1175bd834b9cce5cf5dcc58f3b2b0b57a3b", @"/Areas/BloodBankSystem/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_BloodBankSystem_Views_BloodRequest__MainList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BloodRequest>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
  
    Layout = null;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""table-responsive"">
    <table class=""table table-centered table-nowrap table-striped"">
        <thead>
            <tr>
                <th>Request ID</th>
                <th style=""width:70px;"">Action</th>
                <th>Patient</th>
                <th>");
#nullable restore
#line 15 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
               Write(Html.DisplayNameFor(model => model.BloodGroup));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 16 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
               Write(Html.DisplayNameFor(model => model.HospitalName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 17 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
               Write(Html.DisplayNameFor(model => model.HPhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 18 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
               Write(Html.DisplayNameFor(model => model.DateOfRequest));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 19 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
               Write(Html.DisplayNameFor(model => model.DateTimeOfRequirement));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                <th>");
#nullable restore
#line 21 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
               Write(Html.DisplayNameFor(model => model.LocationName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 22 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
               Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 26 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td><a");
            BeginWriteAttribute("class", " class=\"", 1022, "\"", 1030, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1031, "\"", 1136, 1);
#nullable restore
#line 29 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
WriteAttributeValue("", 1038, Url.Action("Details", "BloodRequest", new { Area = "BloodBankSystem", id = item.BloodRequestID }), 1038, 98, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
                                                                                                                                         Write(Html.DisplayFor(modelItem => item.BloodRequestID));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></td>
                    <td>
                        <div class=""btn-group"">
                            <button class=""btn btn-sm dropdown-toggle btn-secondary btn-icon-text"" type=""button"" id=""dropdownMenuButton2"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <i data-feather=""more-vertical"" class=""btn-icon-prepend""></i> Action
                            </button>
                            <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton2""");
            BeginWriteAttribute("style", " style=\"", 1713, "\"", 1721, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1781, "\"", 1886, 1);
#nullable restore
#line 36 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
WriteAttributeValue("", 1788, Url.Action("Details", "BloodRequest", new { Area = "BloodBankSystem", id = item.BloodRequestID }), 1788, 98, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detail View</a>\r\n");
#nullable restore
#line 37 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
                                 if (item.Status != "RO" && item.Status != "RB" && item.Status != "DL")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a href=\"javascript:void(0);\" class=\"dropdown-item\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2132, "\"", 2254, 5);
            WriteAttributeValue("", 2142, "ConfirmReject(\'", 2142, 15, true);
#nullable restore
#line 39 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
WriteAttributeValue("", 2157, item.BloodRequestID, 2157, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2177, "\',\'", 2177, 3, true);
#nullable restore
#line 39 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
WriteAttributeValue("", 2180, Url.Action("Rejected","BloodRequest", new { Area = "BloodBankSystem" }), 2180, 72, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2252, "\')", 2252, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Rejected</a>\r\n");
#nullable restore
#line 40 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
                                 if (item.Status != "RO" && item.Status != "RB" && item.Status != "DL" && item.Status != "NA")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a href=\"javascript:void(0);\" class=\"dropdown-item\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2555, "\"", 2681, 5);
            WriteAttributeValue("", 2565, "ConfirmDelivered(\'", 2565, 18, true);
#nullable restore
#line 43 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
WriteAttributeValue("", 2583, item.BloodRequestID, 2583, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2603, "\',\'", 2603, 3, true);
#nullable restore
#line 43 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
WriteAttributeValue("", 2606, Url.Action("Delivered","BloodRequest", new { Area = "BloodBankSystem" }), 2606, 73, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2679, "\')", 2679, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Delivered</a>\r\n");
#nullable restore
#line 44 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
                                 if (item.Status != "RO" && item.Status != "RB" && item.Status != "DL" && item.Status != "A" && item.Status != "NA")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a href=\"javascript:void(0);\" class=\"dropdown-item\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3005, "\"", 3129, 5);
            WriteAttributeValue("", 3015, "ConfirmAccepted(\'", 3015, 17, true);
#nullable restore
#line 47 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
WriteAttributeValue("", 3032, item.BloodRequestID, 3032, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3052, "\',\'", 3052, 3, true);
#nullable restore
#line 47 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
WriteAttributeValue("", 3055, Url.Action("Accepted","BloodRequest", new { Area = "BloodBankSystem" }), 3055, 72, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3127, "\')", 3127, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Accepted</a>\r\n");
#nullable restore
#line 48 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 50 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
                                 if (item.Status != "RO" && item.Status != "RB" && item.Status != "DL" && item.Status != "NA")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a href=\"javascript:void(0);\" class=\"dropdown-item\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3432, "\"", 3554, 5);
            WriteAttributeValue("", 3442, "ConfirmNA(\'", 3442, 11, true);
#nullable restore
#line 52 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
WriteAttributeValue("", 3453, item.BloodRequestID, 3453, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3473, "\',\'", 3473, 3, true);
#nullable restore
#line 52 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
WriteAttributeValue("", 3476, Url.Action("NotAvailable","BloodRequest", new { Area = "BloodBankSystem" }), 3476, 76, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3552, "\')", 3552, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Not Available</a>\r\n");
#nullable restore
#line 53 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n\r\n                    <td>");
#nullable restore
#line 60 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PatientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 62 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.BloodGroup));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 63 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.HospitalName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 64 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.HPhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 65 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
                   Write(item.DateOfRequest.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 66 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
                   Write(item.DateTimeOfRequirement.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 68 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LocationName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><span");
            BeginWriteAttribute("class", " class=\"", 4294, "\"", 4331, 3);
            WriteAttributeValue("", 4302, "badge", 4302, 5, true);
            WriteAttributeValue(" ", 4307, "badge-", 4308, 7, true);
#nullable restore
#line 69 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
WriteAttributeValue("", 4314, item.StatusClass, 4314, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 69 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
                                                               Write(item.StatusText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                </tr>\r\n");
#nullable restore
#line 71 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\_MainList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div> ");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BloodRequest>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
