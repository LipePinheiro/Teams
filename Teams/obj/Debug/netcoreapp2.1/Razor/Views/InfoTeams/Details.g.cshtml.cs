#pragma checksum "C:\Users\Filip\source\repos\Teams\Teams\Views\InfoTeams\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4445227b728dab5e43fa3907b08e749c3a170b7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InfoTeams_Details), @"mvc.1.0.view", @"/Views/InfoTeams/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/InfoTeams/Details.cshtml", typeof(AspNetCore.Views_InfoTeams_Details))]
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
#line 1 "C:\Users\Filip\source\repos\Teams\Teams\Views\_ViewImports.cshtml"
using Teams;

#line default
#line hidden
#line 2 "C:\Users\Filip\source\repos\Teams\Teams\Views\_ViewImports.cshtml"
using Teams.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4445227b728dab5e43fa3907b08e749c3a170b7c", @"/Views/InfoTeams/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55cadc83cd7b3ea84e79ce295c308d0e2edfbf55", @"/Views/_ViewImports.cshtml")]
    public class Views_InfoTeams_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teams.Models.InfoTeams>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Filip\source\repos\Teams\Teams\Views\InfoTeams\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(76, 158, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    \r\n    <hr />\r\n    <dl class=\"dl-horizontal\" >\r\n        <dt>\r\n            Team Name\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(235, 41, false);
#line 17 "C:\Users\Filip\source\repos\Teams\Teams\Views\InfoTeams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Team_name));

#line default
#line hidden
            EndContext();
            BeginContext(276, 96, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Coach Name\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(373, 42, false);
#line 23 "C:\Users\Filip\source\repos\Teams\Teams\Views\InfoTeams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Coach_name));

#line default
#line hidden
            EndContext();
            BeginContext(415, 99, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Maches Played\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(515, 45, false);
#line 29 "C:\Users\Filip\source\repos\Teams\Teams\Views\InfoTeams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Maches_Played));

#line default
#line hidden
            EndContext();
            BeginContext(560, 96, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n           Maches Lost\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(657, 43, false);
#line 35 "C:\Users\Filip\source\repos\Teams\Teams\Views\InfoTeams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Maches_Lost));

#line default
#line hidden
            EndContext();
            BeginContext(700, 96, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Maches Won\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(797, 42, false);
#line 41 "C:\Users\Filip\source\repos\Teams\Teams\Views\InfoTeams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Maches_Won));

#line default
#line hidden
            EndContext();
            BeginContext(839, 68, true);
            WriteLiteral("\r\n        </dd>\r\n     \r\n            \r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(907, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efa050e313bc4ad1a182c47e8ac7f8aa", async() => {
                BeginContext(958, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\Filip\source\repos\Teams\Teams\Views\InfoTeams\Details.cshtml"
                           WriteLiteral(Model.Team_Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(966, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(974, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "259a290412854fbdab951ca4be85ed05", async() => {
                BeginContext(996, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1012, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teams.Models.InfoTeams> Html { get; private set; }
    }
}
#pragma warning restore 1591