#pragma checksum "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Appointment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc3a4992d20f6dd9eb0872a3377dfde4e8b5f06b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Doctor_Views_Appointment_Index), @"mvc.1.0.view", @"/Areas/Doctor/Views/Appointment/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc3a4992d20f6dd9eb0872a3377dfde4e8b5f06b", @"/Areas/Doctor/Views/Appointment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8201eec98d40e33a6435f52164ee3d628d6dc91", @"/Areas/Doctor/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Doctor_Views_Appointment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DonarDonationSearchView>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/pagination.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Appointment\Index.cshtml"
  
    ViewData["Title"] = "Appointment Details";

    ViewData["AppointmentActive"] = "active";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!-- start page title -->\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div class=\"page-title-box\">\r\n            <div class=\"row justify-content-start float-right mr-0 mt-2 d-none\">\r\n\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 477, "\"", 521, 1);
#nullable restore
#line 19 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Appointment\Index.cshtml"
WriteAttributeValue("", 484, Url.Action("Index","SampleCategory"), 484, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""ml-1"">
                    <div class=""card-box  bg-white p-1 pr-2 m-0"">
                        <p class=""text- small mb-0"">Figure 1</p>
                        <p class=""text-dark m-0 mb-0"">0.00</p>
                    </div>
                </a>

                <a");
            BeginWriteAttribute("href", " href=\"", 805, "\"", 843, 1);
#nullable restore
#line 26 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Appointment\Index.cshtml"
WriteAttributeValue("", 812, Url.Action("Index","Customer"), 812, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""ml-1"">
                    <div class=""card-box  bg-white p-1 pr-2 m-0"">
                        <p class=""text- small mb-0"">Figure 2 </p>
                        <p class=""text-dark m-0 mb-0"">0.0</p>
                    </div>
                </a>

            </div>
            <h4 class=""page-title"">");
#nullable restore
#line 34 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Appointment\Index.cshtml"
                              Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 34 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Appointment\Index.cshtml"
                                                  Write(Model.RecordCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h4>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- end page title -->\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 1328, "\"", 1412, 4);
            WriteAttributeValue("", 1336, "mt-2", 1336, 4, true);
            WriteAttributeValue(" ", 1340, "alert", 1341, 6, true);
            WriteAttributeValue(" ", 1346, "alert-danger", 1347, 13, true);
#nullable restore
#line 41 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Appointment\Index.cshtml"
WriteAttributeValue("  ", 1359, TempData["ErrorMessage"] == null ? "d-none" : "", 1361, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 42 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Appointment\Index.cshtml"
        Write(TempData["ErrorMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 1485, "\"", 1572, 4);
            WriteAttributeValue("", 1493, "mt-2", 1493, 4, true);
            WriteAttributeValue(" ", 1497, "alert", 1498, 6, true);
            WriteAttributeValue(" ", 1503, "alert-success", 1504, 14, true);
#nullable restore
#line 44 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Appointment\Index.cshtml"
WriteAttributeValue("  ", 1517, TempData["SuccessMessage"] == null ? "d-none" : "", 1519, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 45 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Appointment\Index.cshtml"
        Write(TempData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body p-2 p-md-3"">

                

                <div class=""row justify-content-md-start justify-content-center"">

                    <div class=""p-1 pl-0"">
                        ");
#nullable restore
#line 59 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Appointment\Index.cshtml"
                   Write(Html.EditorFor(model => model.KeyW, new { htmlAttributes = new { @class = "form-control", placeholder = "Search", id = "txtKeyW", autofocus = "autofocus", onkeyup = "SearchStart()" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 60 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Appointment\Index.cshtml"
                   Write(Html.ValidationMessageFor(model => model.KeyW, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"p-1 pl-0 d-none\">\r\n                        ");
#nullable restore
#line 64 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Appointment\Index.cshtml"
                   Write(Html.DropDownList("BloodBankCentreID", await bloodBankDDL.BloodBankCentreList(), "(All Categories)", htmlAttributes: new { @class = "", id = "cmbCategoryMainID" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>




                </div>

                <div id=""divLoad"" class=""d-flex justify-content-center mt-2 position-absolute w-100"">
                    <div id=""spnLoad"" class=""spinner-border "" role=""status""></div>
                </div>

                <div id=""divRecords"" class=""m-0 p-0 mt-2""></div>

                <input type=""hidden"" id=""txtRecordCount""");
            BeginWriteAttribute("value", " value=\"", 2946, "\"", 2972, 1);
#nullable restore
#line 78 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Appointment\Index.cshtml"
WriteAttributeValue("", 2954, Model.RecordCount, 2954, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <input type=\"hidden\" id=\"txtPageSize\"");
            BeginWriteAttribute("value", " value=\"", 3031, "\"", 3054, 1);
#nullable restore
#line 79 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Appointment\Index.cshtml"
WriteAttributeValue("", 3039, Model.PageSize, 3039, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 86 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Appointment\Index.cshtml"
Write(await Html.PartialAsync("_Pagination", Model.PaginationList));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 89 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Appointment\Index.cshtml"
      
        await Html.RenderPartialAsync("_ValidationScriptsPartial");
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc3a4992d20f6dd9eb0872a3377dfde4e8b5f06b12271", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 94 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Appointment\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


    <script title=""Main"">

        var Page = 1;
        var PageURL = '/Doctor/Appointment/_MainList';

        $(document).ready(function () {

            LoadPage(1);
        });

        function GetData(pageNo) {
            var KeyW = $(""#txtKeyW"").val();
            //var CategoryMainID = $(""#cmbCategoryMainID"").val();
            //var CategorySubID = $(""#cmbCategorySubID"").val();
            //var BrandID = $(""#cmbBrandID"").val();
            //var StockAvailable = $(""#cmbStockAvailable"").val();
            //var ActiveStatus = $(""#cmbActiveStatus"").val();

            Page = pageNo;
            var PageSize = $(""#txtPageSize"").val();

            var data = {
                KeyW: KeyW,
                //CategoryMainID: CategoryMainID,
                //CategorySubID: CategorySubID,
                //BrandID: BrandID,
                //StockAvailable: StockAvailable,
                //ActiveStatus: ActiveStatus,
                Page: Page,
                PageSize");
                WriteLiteral(@": PageSize
            };

            return data;
        }


    </script>


    <script title=""Search"">

        function SearchStart() {
            // Declare variables
            var input, filter, table, tr, td, i, txtValue;
            input = document.getElementById(""txtKeyW"");
            filter = input.value.toUpperCase();
            table = document.getElementById(""tblBody"");
            tr = table.getElementsByTagName(""tr"");

            for (i = 0; i < tr.length; i++) {
                td = tr[i].getElementsByTagName(""td"")[0];
                td1 = tr[i].getElementsByTagName(""td"")[1];

                if (td) {
                    txtValue = td.textContent || td.innerText;
                    txtValue = txtValue + ' ' + td1.textContent || td1.innerText;
                    if (txtValue.toUpperCase().indexOf(filter) > -1) {
                        tr[i].style.display = """";
                    } else {
                        tr[i].style.display = ""none"";
        ");
                WriteLiteral(@"            }
                }
            }
        }

        $(""#txtKeyW"").on(""keydown"", function search(e) {
            if (e.keyCode == 13) {
                Search();
            }
        });

        $(""#cmbCategoryMainID"").change(function (event) {
            Search();
        });

        $(""#cmbCategorySubID"").change(function (event) {
            Search();
        });

        $(""#cmbBrandID"").change(function (event) {
            Search();
        });

        $(""#cmbStockAvailable"").change(function (event) {
            Search();
        });

        $(""#cmbActiveStatus"").change(function (event) {
            Search();
        });

        function Search() {

            var KeyW = $(""#txtKeyW"").val();
            //var CategoryMainID = $(""#cmbCategoryMainID"").val();
            //var CategorySubID = $(""#cmbCategorySubID"").val();
            //var BrandID = $(""#cmbBrandID"").val();
            //var StockAvailable = $(""#cmbStockAvailable"").val();
        ");
                WriteLiteral("    //var ActiveStatus = $(\"#cmbActiveStatus\").val();\r\n\r\n            var url = \'");
#nullable restore
#line 197 "F:\Asure Final Project\BloodBank\Areas\Doctor\Views\Appointment\Index.cshtml"
                  Write(Url.Action("Index", "Appointment", new { area = "Doctor" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';

            var ParamPart = ""&"";
            ParamPart = ParamPart + ((KeyW != """") ? '&KeyW=' + KeyW : '');
            //ParamPart = ParamPart + ((CategoryMainID != """") ? '&CategoryMainID=' + CategoryMainID : '');
            //ParamPart = ParamPart + ((CategorySubID != """") ? '&CategorySubID=' + CategorySubID : '');
            //ParamPart = ParamPart + ((BrandID != """") ? '&BrandID=' + BrandID : '');
            //ParamPart = ParamPart + ((StockAvailable != """") ? '&StockAvailable=' + StockAvailable : '');
            //ParamPart = ParamPart + ((ActiveStatus != """") ? '&ActiveStatus=' + ActiveStatus : '');

            ParamPart = ParamPart.replace(""&&"", """");

            window.location.href = url + '?' + ParamPart;
            event.preventDefault();
        };

    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public DropDown.ICommonDDL CommonDDL { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DonarDonationSearchView> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
