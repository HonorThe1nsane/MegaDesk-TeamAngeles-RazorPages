#pragma checksum "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\Desks\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d4fd1a1ada647de65e374452fb3ab83b836a8cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MegaDesk_RazorPages_TeamAngeles.Pages.Desks.Pages_Desks_Details), @"mvc.1.0.razor-page", @"/Pages/Desks/Details.cshtml")]
namespace MegaDesk_RazorPages_TeamAngeles.Pages.Desks
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
#line 1 "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\_ViewImports.cshtml"
using MegaDesk_RazorPages_TeamAngeles;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d4fd1a1ada647de65e374452fb3ab83b836a8cc", @"/Pages/Desks/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11bd0a2f673e95d83d460fb0ccb301e3c37cd4b3", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Desks_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\Desks\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Desk</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\Desks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Desk.DeskWidth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\Desks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Desk.DeskWidth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\Desks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Desk.DeskDepth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\Desks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Desk.DeskDepth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\Desks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Desk.NumDrawers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\Desks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Desk.NumDrawers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\Desks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Desk.DeskMaterial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\Desks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Desk.DeskMaterial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\Desks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Desk.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\Desks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Desk.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\Desks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Desk.RushDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\Desks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Desk.RushDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\Desks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Desk.DrawerCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\Desks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Desk.DrawerCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\Desks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Desk.QuotePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\Desks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Desk.QuotePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\Desks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Desk.RushCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\Desks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Desk.RushCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d4fd1a1ada647de65e374452fb3ab83b836a8cc10422", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\troym\source\repos\MegaDesk-RazorPages\MegaDesk_RazorPages_TeamAngeles\Pages\Desks\Details.cshtml"
                           WriteLiteral(Model.Desk.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d4fd1a1ada647de65e374452fb3ab83b836a8cc12595", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MegaDesk_RazorPages_TeamAngeles.Pages.Desks.DetailsModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MegaDesk_RazorPages_TeamAngeles.Pages.Desks.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MegaDesk_RazorPages_TeamAngeles.Pages.Desks.DetailsModel>)PageContext?.ViewData;
        public MegaDesk_RazorPages_TeamAngeles.Pages.Desks.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591