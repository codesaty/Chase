#pragma checksum "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Admin\Views\WorkOrders\ShowJobDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca6df4b180420b1a1f363357f758a0d01cd249d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_WorkOrders_ShowJobDetail), @"mvc.1.0.view", @"/Areas/Admin/Views/WorkOrders/ShowJobDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca6df4b180420b1a1f363357f758a0d01cd249d1", @"/Areas/Admin/Views/WorkOrders/ShowJobDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbff66e2efd1648c6bd1638619b5fe656748a425", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_WorkOrders_ShowJobDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Chase.Entities.DTOs.DutyListAllDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "WorkOrders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetExcelFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Admin\Views\WorkOrders\ShowJobDetail.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";


#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Admin\Views\WorkOrders\ShowJobDetail.cshtml"
 if (Model.Reports.Count != 0) 

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Admin\Views\WorkOrders\ShowJobDetail.cshtml"
                                                                 
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-right mt-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca6df4b180420b1a1f363357f758a0d01cd249d14899", async() => {
                WriteLiteral("Excel\'de Görüntüle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Admin\Views\WorkOrders\ShowJobDetail.cshtml"
                                                                   WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <table class=\"table table-striped table-dark mt-3 text-center\">\r\n        <thread>\r\n            <tr>\r\n                <th colspan=\"2\">");
#nullable restore
#line 16 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Admin\Views\WorkOrders\ShowJobDetail.cshtml"
                           Write(Model.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Admin\Views\WorkOrders\ShowJobDetail.cshtml"
                                               Write(Model.AppUser.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Personelin ");
#nullable restore
#line 16 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Admin\Views\WorkOrders\ShowJobDetail.cshtml"
                                                                                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Görevine Yazmış Olduğu raporlar</th>
            </tr>
            <tr>
                <th class=""font-italic text-danger"" style=""text-transform: uppercase"">Tanım</th>
                <th class=""font-italic text-danger"" style=""text-transform: uppercase"">Detay</th>
            </tr>
");
#nullable restore
#line 22 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Admin\Views\WorkOrders\ShowJobDetail.cshtml"
             foreach (var reportsValue in Model.Reports)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 26 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Admin\Views\WorkOrders\ShowJobDetail.cshtml"
                   Write(reportsValue.ReportDefinition);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>");
#nullable restore
#line 28 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Admin\Views\WorkOrders\ShowJobDetail.cshtml"
                   Write(reportsValue.ReportDetail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                </tr>\r\n");
#nullable restore
#line 30 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Admin\Views\WorkOrders\ShowJobDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </thread>\r\n\r\n\r\n    </table>\r\n");
#nullable restore
#line 36 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Admin\Views\WorkOrders\ShowJobDetail.cshtml"
}
else 

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Admin\Views\WorkOrders\ShowJobDetail.cshtml"
                                   
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card bg-secondary\">\r\n        <div class=\"card-body shadow\">\r\n              <div class=\"text-center badge-info mt-3\">\r\n            \r\n                    <strong>\r\n                        ");
#nullable restore
#line 45 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Admin\Views\WorkOrders\ShowJobDetail.cshtml"
                   Write(Model.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 45 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Admin\Views\WorkOrders\ShowJobDetail.cshtml"
                                       Write(Model.AppUser.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Personeliniz ");
#nullable restore
#line 45 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Admin\Views\WorkOrders\ShowJobDetail.cshtml"
                                                                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Görevin\'de şuan aktif olarak çalışıyor.Henüz\r\n                        Rapor Yazmamış.<i class=\"fas fa-check-double fa-2x ml-2\"></i>\r\n                    </strong>\r\n            \r\n                </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 52 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Admin\Views\WorkOrders\ShowJobDetail.cshtml"
  
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Chase.Entities.DTOs.DutyListAllDto> Html { get; private set; }
    }
}
#pragma warning restore 1591