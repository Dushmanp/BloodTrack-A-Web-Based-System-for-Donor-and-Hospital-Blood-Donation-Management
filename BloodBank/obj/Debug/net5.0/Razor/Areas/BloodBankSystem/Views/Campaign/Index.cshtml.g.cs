#pragma checksum "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e41b901ac15b0896fa77b3c9b3423aba00f15f3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BloodBankSystem_Views_Campaign_Index), @"mvc.1.0.view", @"/Areas/BloodBankSystem/Views/Campaign/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e41b901ac15b0896fa77b3c9b3423aba00f15f3e", @"/Areas/BloodBankSystem/Views/Campaign/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3e2a1175bd834b9cce5cf5dcc58f3b2b0b57a3b", @"/Areas/BloodBankSystem/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_BloodBankSystem_Views_Campaign_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BloodDonationCampaignSearchView>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ConfirmDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/pagination.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Index.cshtml"
  
    ViewData["Title"] = "Blood Donation Campaign";

    ViewData["CampaignActive"] = "active";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e41b901ac15b0896fa77b3c9b3423aba00f15f3e5384", async() => {
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
            WriteLiteral("\r\n\r\n<!-- start page title -->\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div class=\"page-title-box\">\r\n            <div class=\"row justify-content-start float-right mr-0 mt-2 d-none\">\r\n\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 482, "\"", 526, 1);
#nullable restore
#line 19 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Index.cshtml"
WriteAttributeValue("", 489, Url.Action("Index","SampleCategory"), 489, 37, false);

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
            BeginWriteAttribute("href", " href=\"", 810, "\"", 848, 1);
#nullable restore
#line 26 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Index.cshtml"
WriteAttributeValue("", 817, Url.Action("Index","Customer"), 817, 31, false);

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
#line 34 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Index.cshtml"
                              Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 34 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Index.cshtml"
                                                  Write(Model.RecordCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</h4>
        </div>
    </div>
</div>
<!-- end page title -->
 
<div class=""row"">
    <div class=""col-md-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body p-2 p-md-3"">
                <div class=""text-center float-md-right"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 1508, "\"", 1533, 1);
#nullable restore
#line 45 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Index.cshtml"
WriteAttributeValue("", 1515, Url.Action("Add"), 1515, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-primary btn-icon-text"">
                        <i class=""mdi mdi-plus-circle-outline""></i>
                        Add Campaign
                    </a>
                </div>



                <div class=""row justify-content-md-start justify-content-center"">

                    <div class=""p-1 pl-0"">
                        ");
#nullable restore
#line 56 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Index.cshtml"
                   Write(Html.EditorFor(model => model.KeyW, new { htmlAttributes = new { @class = "form-control", placeholder = "Search", id = "txtKeyW", autofocus = "autofocus", onkeyup = "SearchStart()"  } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 57 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Index.cshtml"
                   Write(Html.ValidationMessageFor(model => model.KeyW, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"p-1 pl-0\">\r\n                        ");
#nullable restore
#line 61 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Index.cshtml"
                   Write(Html.DropDownList("ActiveStatus", CommonDDL.ActiveStatusList(), "(All Statuses)", htmlAttributes: new { @class = "", id = "cmbActiveStatus" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"p-1 pl-0\">\r\n                        ");
#nullable restore
#line 65 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Index.cshtml"
                   Write(Html.DropDownList("BloodBankCentreID",await bloodBankDDL.BloodBankCentreList(), "(All Location)", htmlAttributes: new { @class = "", id = "cmbBloodBankCentreID" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"p-1 pl-0\">\r\n                        ");
#nullable restore
#line 68 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Index.cshtml"
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
            BeginWriteAttribute("value", " value=\"", 3342, "\"", 3368, 1);
#nullable restore
#line 81 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Index.cshtml"
WriteAttributeValue("", 3350, Model.RecordCount, 3350, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <input type=\"hidden\" id=\"txtPageSize\"");
            BeginWriteAttribute("value", " value=\"", 3427, "\"", 3450, 1);
#nullable restore
#line 82 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Index.cshtml"
WriteAttributeValue("", 3435, Model.PageSize, 3435, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""imageModal"" tabindex=""-1"" aria-labelledby=""imageModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog modal-dialog-centered modal-xl"">
    <div class=""modal-content"">
      <div class=""modal-body d-flex justify-content-center"">
        <img id=""modalImage"" class=""img-fluid mx-auto"" style=""max-width: 100%""");
            BeginWriteAttribute("src", " src=\"", 3857, "\"", 3863, 0);
            EndWriteAttribute();
            WriteLiteral(" alt=\"Full screen image\">\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n\r\n\r\n");
#nullable restore
#line 100 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Index.cshtml"
Write(await Html.PartialAsync("_Pagination", Model.PaginationList));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 103 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Index.cshtml"
      
        await Html.RenderPartialAsync("_ValidationScriptsPartial");
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e41b901ac15b0896fa77b3c9b3423aba00f15f3e14452", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 108 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Index.cshtml"
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
        var PageURL = '/BloodBankSystem/Campaign/_MainList';

        $(document).ready(function () {

            LoadPage(1);

           
        });

      
        function GetData(pageNo) {
            var KeyW = $(""#txtKeyW"").val();
            var BloodBankCentreID = $(""#cmbBloodBankCentreID"").val();
            var LocationID = $(""#cmbLocationID"").val();
            var ActiveStatus = $(""#cmbActiveStatus"").val();

            Page = pageNo;
            var PageSize = $(""#txtPageSize"").val();

            var data = {
                KeyW: KeyW,
                BloodBankCentreID: BloodBankCentreID,
                LocationID: LocationID,
                ActiveStatus: ActiveStatus,
                Page: Page,
                PageSize: PageSize
            };

            return data;
        }


    </script>


    <script title=""Search"">
        function SearchStart() {
            // Declare variabl");
                WriteLiteral(@"es
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
                    }
                }
            }
        }
         $(""#txtKeyW"").on(""keydown"",function search(e) {
            if(e.keyCode == 13) {
                Search();
     ");
                WriteLiteral(@"       }
        });

        $(""#cmbLocationID"").change(function (event) {
            Search();
        });

        $(""#cmbBloodBankCentreID"").change(function (event) {
            Search();
        });

        $(""#cmbActiveStatus"").change(function (event) {
            Search();
        });
        
        function Search() {

            var KeyW = $(""#txtKeyW"").val();
            var BloodBankCentreID = $(""#cmbBloodBankCentreID"").val();
            var LocationID = $(""#cmbLocationID"").val();
            var ActiveStatus = $(""#cmbActiveStatus"").val();

            var url = '");
#nullable restore
#line 199 "F:\Asure Final Project\BloodBank\Areas\BloodBankSystem\Views\Campaign\Index.cshtml"
                  Write(Url.Action("Index", "Campaign", new { area = "BloodBankSystem" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';

            var ParamPart = ""&"";
            ParamPart = ParamPart + ((KeyW != """") ? '&KeyW=' + KeyW : '');
            ParamPart = ParamPart + ((BloodBankCentreID != """") ? '&BloodBankCentreID=' + BloodBankCentreID : '');
            ParamPart = ParamPart + ((LocationID != """") ? '&LocationID=' + LocationID : '');
            ParamPart = ParamPart + ((ActiveStatus != """") ? '&ActiveStatus=' + ActiveStatus : '');

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BloodDonationCampaignSearchView> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
