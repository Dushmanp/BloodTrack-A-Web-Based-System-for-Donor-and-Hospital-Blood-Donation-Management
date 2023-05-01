#pragma checksum "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cd574154cfc264d56959195042b97633a41b7f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Doctor_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Doctor/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cd574154cfc264d56959195042b97633a41b7f9", @"/Areas/Doctor/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8201eec98d40e33a6435f52164ee3d628d6dc91", @"/Areas/Doctor/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Doctor_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";
    ViewData["DashboardActive"] = "active";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""d-flex justify-content-between align-items-center flex-wrap grid-margin"">
    <div>
        <h4 class=""mb-3 mb-md-0"">Welcome to Dashboard</h4>
    </div>
    <div class=""d-flex align-items-center flex-wrap text-nowrap"">
        <div class=""input-group date datepicker dashboard-date mr-2 mb-2 mb-md-0 d-md-none d-xl-flex"" id=""dashboardDate"">
            <span class=""input-group-addon bg-transparent""><i data-feather=""calendar"" class="" text-primary""></i></span>
            <input type=""text"" class=""form-control"">
        </div>

    </div>
</div>

<div class=""row"">
    <div class=""col-12 col-xl-12 stretch-card"">
        <div class=""row flex-grow"">
            <div class=""col-md-4 grid-margin stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""d-flex justify-content-between align-items-baseline"">
                            <h6 class=""card-title mb-0"">Processing Donation</h6>
                         ");
            WriteLiteral(@"   <div class=""dropdown mb-2"">
                                <button class=""btn p-0"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                    <i class=""icon-lg text-muted pb-3px"" data-feather=""more-horizontal""></i>
                                </button>
                                <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""dropdownMenuButton"">
                                    <a class=""dropdown-item d-flex align-items-center"" href=""#""><i data-feather=""eye"" class=""icon-sm mr-2""></i> <span");
            BeginWriteAttribute("class", " class=\"", 1728, "\"", 1736, 0);
            EndWriteAttribute();
            WriteLiteral(">View</span></a>\r\n                                    <a class=\"dropdown-item d-flex align-items-center\" href=\"#\"><i data-feather=\"edit-2\" class=\"icon-sm mr-2\"></i> <span");
            BeginWriteAttribute("class", " class=\"", 1907, "\"", 1915, 0);
            EndWriteAttribute();
            WriteLiteral(">Edit</span></a>\r\n                                    <a class=\"dropdown-item d-flex align-items-center\" href=\"#\"><i data-feather=\"trash\" class=\"icon-sm mr-2\"></i> <span");
            BeginWriteAttribute("class", " class=\"", 2085, "\"", 2093, 0);
            EndWriteAttribute();
            WriteLiteral(">Delete</span></a>\r\n                                    <a class=\"dropdown-item d-flex align-items-center\" href=\"#\"><i data-feather=\"printer\" class=\"icon-sm mr-2\"></i> <span");
            BeginWriteAttribute("class", " class=\"", 2267, "\"", 2275, 0);
            EndWriteAttribute();
            WriteLiteral(">Print</span></a>\r\n                                    <a class=\"dropdown-item d-flex align-items-center\" href=\"#\"><i data-feather=\"download\" class=\"icon-sm mr-2\"></i> <span");
            BeginWriteAttribute("class", " class=\"", 2449, "\"", 2457, 0);
            EndWriteAttribute();
            WriteLiteral(@">Download</span></a>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-6 col-md-12 col-xl-5"">
                                <h3 class=""mb-2"">3,897</h3>
                                <div class=""d-flex align-items-baseline"">
                                    <p class=""text-success"">
                                        <span>+3.3%</span>
                                        <i data-feather=""arrow-up"" class=""icon-sm mb-1""></i>
                                    </p>
                                </div>
                            </div>
                            <div class=""col-6 col-md-12 col-xl-7"">
                                <div id=""apexChart1"" class=""mt-md-3 mt-xl-0""></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div cla");
            WriteLiteral(@"ss=""col-md-4 grid-margin stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""d-flex justify-content-between align-items-baseline"">
                            <h6 class=""card-title mb-0"">Completed Donation</h6>
                            <div class=""dropdown mb-2"">
                                <button class=""btn p-0"" type=""button"" id=""dropdownMenuButton1"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                    <i class=""icon-lg text-muted pb-3px"" data-feather=""more-horizontal""></i>
                                </button>
                                <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""dropdownMenuButton1"">
                                    <a class=""dropdown-item d-flex align-items-center"" href=""#""><i data-feather=""eye"" class=""icon-sm mr-2""></i> <span");
            BeginWriteAttribute("class", " class=\"", 4417, "\"", 4425, 0);
            EndWriteAttribute();
            WriteLiteral(">View</span></a>\r\n                                    <a class=\"dropdown-item d-flex align-items-center\" href=\"#\"><i data-feather=\"edit-2\" class=\"icon-sm mr-2\"></i> <span");
            BeginWriteAttribute("class", " class=\"", 4596, "\"", 4604, 0);
            EndWriteAttribute();
            WriteLiteral(">Edit</span></a>\r\n                                    <a class=\"dropdown-item d-flex align-items-center\" href=\"#\"><i data-feather=\"trash\" class=\"icon-sm mr-2\"></i> <span");
            BeginWriteAttribute("class", " class=\"", 4774, "\"", 4782, 0);
            EndWriteAttribute();
            WriteLiteral(">Delete</span></a>\r\n                                    <a class=\"dropdown-item d-flex align-items-center\" href=\"#\"><i data-feather=\"printer\" class=\"icon-sm mr-2\"></i> <span");
            BeginWriteAttribute("class", " class=\"", 4956, "\"", 4964, 0);
            EndWriteAttribute();
            WriteLiteral(">Print</span></a>\r\n                                    <a class=\"dropdown-item d-flex align-items-center\" href=\"#\"><i data-feather=\"download\" class=\"icon-sm mr-2\"></i> <span");
            BeginWriteAttribute("class", " class=\"", 5138, "\"", 5146, 0);
            EndWriteAttribute();
            WriteLiteral(@">Download</span></a>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-6 col-md-12 col-xl-5"">
                                <h3 class=""mb-2"">35,084</h3>
                                <div class=""d-flex align-items-baseline"">
                                    <p class=""text-danger"">
                                        <span>-2.8%</span>
                                        <i data-feather=""arrow-down"" class=""icon-sm mb-1""></i>
                                    </p>
                                </div>
                            </div>
                            <div class=""col-6 col-md-12 col-xl-7"">
                                <div id=""apexChart2"" class=""mt-md-3 mt-xl-0""></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div c");
            WriteLiteral(@"lass=""col-md-4 grid-margin stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""d-flex justify-content-between align-items-baseline"">
                            <h6 class=""card-title mb-0"">Rejected Donation</h6>
                            <div class=""dropdown mb-2"">
                                <button class=""btn p-0"" type=""button"" id=""dropdownMenuButton2"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                    <i class=""icon-lg text-muted pb-3px"" data-feather=""more-horizontal""></i>
                                </button>
                                <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""dropdownMenuButton2"">
                                    <a class=""dropdown-item d-flex align-items-center"" href=""#""><i data-feather=""eye"" class=""icon-sm mr-2""></i> <span");
            BeginWriteAttribute("class", " class=\"", 7107, "\"", 7115, 0);
            EndWriteAttribute();
            WriteLiteral(">View</span></a>\r\n                                    <a class=\"dropdown-item d-flex align-items-center\" href=\"#\"><i data-feather=\"edit-2\" class=\"icon-sm mr-2\"></i> <span");
            BeginWriteAttribute("class", " class=\"", 7286, "\"", 7294, 0);
            EndWriteAttribute();
            WriteLiteral(">Edit</span></a>\r\n                                    <a class=\"dropdown-item d-flex align-items-center\" href=\"#\"><i data-feather=\"trash\" class=\"icon-sm mr-2\"></i> <span");
            BeginWriteAttribute("class", " class=\"", 7464, "\"", 7472, 0);
            EndWriteAttribute();
            WriteLiteral(">Delete</span></a>\r\n                                    <a class=\"dropdown-item d-flex align-items-center\" href=\"#\"><i data-feather=\"printer\" class=\"icon-sm mr-2\"></i> <span");
            BeginWriteAttribute("class", " class=\"", 7646, "\"", 7654, 0);
            EndWriteAttribute();
            WriteLiteral(">Print</span></a>\r\n                                    <a class=\"dropdown-item d-flex align-items-center\" href=\"#\"><i data-feather=\"download\" class=\"icon-sm mr-2\"></i> <span");
            BeginWriteAttribute("class", " class=\"", 7828, "\"", 7836, 0);
            EndWriteAttribute();
            WriteLiteral(@">Download</span></a>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-6 col-md-12 col-xl-5"">
                                <h3 class=""mb-2"">89.87%</h3>
                                <div class=""d-flex align-items-baseline"">
                                    <p class=""text-success"">
                                        <span>+2.8%</span>
                                        <i data-feather=""arrow-up"" class=""icon-sm mb-1""></i>
                                    </p>
                                </div>
                            </div>
                            <div class=""col-6 col-md-12 col-xl-7"">
                                <div id=""apexChart3"" class=""mt-md-3 mt-xl-0""></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
   ");
            WriteLiteral(" </div>\r\n</div> <!-- row -->\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 132 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Home\Index.cshtml"
      
        await Html.RenderPartialAsync("_ValidationScriptsPartial");
    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script>

        $(document).ready(function () {
            if ($('#dashboardDate').length) {
                var date = new Date();
                var options = { day: 'numeric', month: 'long', year: 'numeric' };
                var formattedDate = date.toLocaleDateString('en-US', options);
                $('#dashboardDate').datepicker({
                    format: ""dd-M-yyyy"",
                    todayHighlight: true,
                    autoclose: true
                }).datepicker('setDate', formattedDate);
            }
        });



    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
