#pragma checksum "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a72974574400e02b02af2cc8e52ee913b1ee564"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BloodBankSystem_Views_BloodRequest_Index), @"mvc.1.0.view", @"/Areas/BloodBankSystem/Views/BloodRequest/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a72974574400e02b02af2cc8e52ee913b1ee564", @"/Areas/BloodBankSystem/Views/BloodRequest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3e2a1175bd834b9cce5cf5dcc58f3b2b0b57a3b", @"/Areas/BloodBankSystem/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_BloodBankSystem_Views_BloodRequest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BloodRequestSearchView>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_RejectBloodRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DeliveredBloodRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NAvailableBloodRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AcceptedBloodRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/pagination.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\Index.cshtml"
  
    ViewData["Title"] = "Blood Request ";

    ViewData["RequestActive"] = "active";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a72974574400e02b02af2cc8e52ee913b1ee5646297", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a72974574400e02b02af2cc8e52ee913b1ee5647413", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a72974574400e02b02af2cc8e52ee913b1ee5648529", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a72974574400e02b02af2cc8e52ee913b1ee5649645", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!-- start page title -->\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div class=\"page-title-box\">\r\n            <div class=\"row justify-content-start float-right mr-0 mt-2 d-none\">\r\n\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 596, "\"", 640, 1);
#nullable restore
#line 21 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\Index.cshtml"
WriteAttributeValue("", 603, Url.Action("Index","SampleCategory"), 603, 37, false);

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
            BeginWriteAttribute("href", " href=\"", 924, "\"", 962, 1);
#nullable restore
#line 28 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\Index.cshtml"
WriteAttributeValue("", 931, Url.Action("Index","Customer"), 931, 31, false);

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
#line 36 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\Index.cshtml"
                              Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 36 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\Index.cshtml"
                                                  Write(Model.RecordCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h4>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- end page title -->\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 1447, "\"", 1531, 4);
            WriteAttributeValue("", 1455, "mt-2", 1455, 4, true);
            WriteAttributeValue(" ", 1459, "alert", 1460, 6, true);
            WriteAttributeValue(" ", 1465, "alert-danger", 1466, 13, true);
#nullable restore
#line 43 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\Index.cshtml"
WriteAttributeValue("  ", 1478, TempData["ErrorMessage"] == null ? "d-none" : "", 1480, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 44 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\Index.cshtml"
        Write(TempData["ErrorMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 1604, "\"", 1691, 4);
            WriteAttributeValue("", 1612, "mt-2", 1612, 4, true);
            WriteAttributeValue(" ", 1616, "alert", 1617, 6, true);
            WriteAttributeValue(" ", 1622, "alert-success", 1623, 14, true);
#nullable restore
#line 46 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\Index.cshtml"
WriteAttributeValue("  ", 1636, TempData["SuccessMessage"] == null ? "d-none" : "", 1638, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 47 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\Index.cshtml"
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
#line 59 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\Index.cshtml"
                   Write(Html.EditorFor(model => model.KeyW, new { htmlAttributes = new { @class = "form-control", placeholder = "Search", id = "txtKeyW", autofocus = "autofocus", onkeyup = "SearchStart()" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 60 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\Index.cshtml"
                   Write(Html.ValidationMessageFor(model => model.KeyW, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"p-1 pl-0\">\r\n                        ");
#nullable restore
#line 64 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\Index.cshtml"
                   Write(Html.DropDownList("Status", CommonDDL.RequestStatusList(), "(All Statuses)", htmlAttributes: new { @class = "", id = "cmbStatus" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"p-1 pl-0\">\r\n                        ");
#nullable restore
#line 68 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\Index.cshtml"
                   Write(Html.DropDownList("LocationID",await bloodBankDDL.LocationList(), "(All Location)", htmlAttributes: new { @class = "", id = "cmbLocationID" }));

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
            BeginWriteAttribute("value", " value=\"", 3249, "\"", 3275, 1);
#nullable restore
#line 82 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\Index.cshtml"
WriteAttributeValue("", 3257, Model.RecordCount, 3257, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <input type=\"hidden\" id=\"txtPageSize\"");
            BeginWriteAttribute("value", " value=\"", 3334, "\"", 3357, 1);
#nullable restore
#line 83 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\Index.cshtml"
WriteAttributeValue("", 3342, Model.PageSize, 3342, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 93 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\Index.cshtml"
Write(await Html.PartialAsync("_Pagination", Model.PaginationList));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 96 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\Index.cshtml"
      
        await Html.RenderPartialAsync("_ValidationScriptsPartial");
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a72974574400e02b02af2cc8e52ee913b1ee56418925", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 101 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\Index.cshtml"
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
        var PageURL = '/BloodBankSystem/BloodRequest/_MainList';

        $(document).ready(function () {

            LoadPage(1);
        });

        function GetData(pageNo) {
            var KeyW = $(""#txtKeyW"").val();
            var HospitalID =""""
            var LocationID = $(""#cmbLocationID"").val();
            var Status = $(""#cmbStatus"").val();

            Page = pageNo;
            var PageSize = $(""#txtPageSize"").val();

            var data = {
                KeyW: KeyW,
                HospitalID: HospitalID,
                LocationID: LocationID,
                Status: Status,
                
                //Status: Status,
                Page: Page,
                PageSize: PageSize
            };

            return data;
        }





    </script>


    <script title=""Search"">

        function SearchStart() {
            // Declare variables
            var input, filter, table, t");
                WriteLiteral(@"r, td, i, txtValue;
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
                    }
                }
            }
        }

        $(""#txtKeyW"").on(""keydown"", function search(e) {
            if (e.keyCode == 13) {
                Search();
            }
        });

        $(""#cmb");
                WriteLiteral(@"LocationID"").change(function (event) {
            Search();
        });

        $(""#cmbStatus"").change(function (event) {
            Search();
        });

        function Search() {

            var KeyW = $(""#txtKeyW"").val();
            var HospitalID ="""";
            var LocationID =$(""#cmbLocationID"").val();;
            var Status = $(""#cmbStatus"").val();

            var url = '");
#nullable restore
#line 191 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\BloodRequest\Index.cshtml"
                  Write(Url.Action("Index", "BloodRequest", new { area = "BloodBankSystem" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';

            var ParamPart = ""&"";
            ParamPart = ParamPart + ((KeyW != """") ? '&KeyW=' + KeyW : '');
            ParamPart = ParamPart + ((HospitalID != """") ? '&HospitalID=' + HospitalID : '');
            ParamPart = ParamPart + ((LocationID != """") ? '&LocationID=' + LocationID : '');

            ParamPart = ParamPart + ((Status != """") ? '&Status=' + Status : '');

            ParamPart = ParamPart.replace(""&&"", """");

            window.location.href = url + '?' + ParamPart;
            event.preventDefault();
        };

    </script>
");
            }
            );
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BloodRequestSearchView> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
