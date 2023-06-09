#pragma checksum "F:\Asure Final Project\BloodBank\Views\Shared\_NAvailableBloodRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f0c78d8f50002f0bcd9a045336fd1d2de7f5d2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NAvailableBloodRequest), @"mvc.1.0.view", @"/Views/Shared/_NAvailableBloodRequest.cshtml")]
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
#line 1 "F:\Asure Final Project\BloodBank\Views\_ViewImports.cshtml"
using BloodBank;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Asure Final Project\BloodBank\Views\_ViewImports.cshtml"
using Donor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Asure Final Project\BloodBank\Views\_ViewImports.cshtml"
using BloodBank.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f0c78d8f50002f0bcd9a045336fd1d2de7f5d2c", @"/Views/Shared/_NAvailableBloodRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f080757e0589bf80119b31399733e15cff69b271", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__NAvailableBloodRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""modal fade"" id=""ConfirmNA"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""bottomModalLabel"">Confirm Not Available</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to mark  this record as Not Available?</p>

                <div id=""loaderNADiv"" class=""progress"">
                    <div class=""progress-bar progress-bar-striped progress-bar-animated bg-warning"" role=""progressbar"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 100%"">
                    </div>
                </div>

                <div style=""text-align:center;display:none"" id=""successNADiv"" class=""alert alert-success"">
                    <p id=""message"" name=""message"">Not Avail");
            WriteLiteral(@"able marked successfully</p>
                </div>

                <div style=""text-align:left;display:none"" id=""errorNADiv"" class=""alert alert-danger"">
                    <p id=""errDMessage"" name=""errDMessage"">Error</p>
                </div>
            </div>
            <div class=""modal-footer"">

                <button type=""button"" class=""btn btn-primary"" disabled=""disabled"" id=""NADel"" onclick=""NARecord()"">Confirm</button>
                <button type=""button"" class=""btn btn-light"" data-dismiss=""modal"">Cancel</button>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal-dialog -->


</div>

<input type=""hidden"" id=""hiddenId"" />
<input type=""hidden"" id=""jsonURL"" />

<script>

    var ConfirmNA = function (Id, jsonURL) {
        $(""#hiddenId"").val(Id);
        $(""#jsonURL"").val(jsonURL);

        $(""#loaderNADiv"").hide();
        $(""#errorNADiv"").hide();
        $(""#successNADiv"").hide();
        $(""#NADel"").removeAttr(""disabled"");
        $(""");
            WriteLiteral(@"#ConfirmNA"").modal('show');
    }

    var NARecord = function () {
        $(""#NADel"").attr(""disabled"", true);
        $(""#loaderNADiv"").show();

        var Id = $(""#hiddenId"").val();

        setTimeout(function () {
            $.ajax({

                type: ""POST"",
                url: $(""#jsonURL"").val(),
                data: { id: Id },
                success: function (result) {
                    if (result != null && result.success) {

                        $(""#loaderNADiv"").hide();
                        $(""#successNADiv"").show();

                        setTimeout(function () {

                            $(""#ConfirmNA"").modal(""hide"");
                            $(""#row_"" + Id).addClass(""danger"");
                            $(""#row_"" + Id).fadeOut(1000, ""swing"");

                            try {
                                $(""#row_summary"").fadeOut(1000, ""swing"");
                            }
                            catch (err) { }


         ");
            WriteLiteral(@"                   //$(""#row_"" + Id).remove();
                        }, 1000);
                        location.reload(); // refresh the page
                    } else {
                        ReportError(result.responseText);
                    }

                },
                error: function (result) {
                    ReportError(result.responseText);
                }
            })
        }, 500);
       

    }

    var ReportError = function (errDMessage) {
        $(""#loaderNADiv"").hide();
        $(""#successNADiv"").hide();
        $(""#NADel"").attr(""disabled"", true);
        $(""#errDMessage"").html(errDMessage);
        $(""#errorNADiv"").show();
    }
</script>");
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
