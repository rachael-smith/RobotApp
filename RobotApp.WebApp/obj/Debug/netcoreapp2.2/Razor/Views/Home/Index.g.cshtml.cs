#pragma checksum "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99e7fa19aacb69f260796c45f61c745c32ca2993"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\_ViewImports.cshtml"
using RobotApp.WebApp;

#line default
#line hidden
#line 2 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\_ViewImports.cshtml"
using RobotApp.WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99e7fa19aacb69f260796c45f61c745c32ca2993", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f88a075bb9527f41a2204d2e4f4ffbd36cc25b1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateRobotModalViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/audio/Star_Wars_original_opening_crawl_1977.mp3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("audio/mpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/StarWars.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(90, 109, true);
            WriteLiteral("<style>\r\n    body {\r\n        background-color: black;\r\n    }\r\n</style>\r\n<audio preload=\"auto\" autoplay>\r\n    ");
            EndContext();
            BeginContext(199, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "99e7fa19aacb69f260796c45f61c745c32ca29934712", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(281, 368, true);
            WriteLiteral(@"
</audio>
<section class=""intro"">
    A long time ago, in a galaxy far,<br> far away....
</section>

<section class=""logo"">
    <img class=""galactic"" src=""https://fontmeme.com/permalink/190416/8075d1392c0d185d19e9b49174fdbbd0.png"" />
    <img class=""botServices"" src=""https://fontmeme.com/permalink/190416/0c3d128f26a6997d8a75bd304d996234.png"" />
</section>
");
            EndContext();
            BeginContext(9386, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99e7fa19aacb69f260796c45f61c745c32ca29936347", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9426, 146, true);
            WriteLiteral("\r\n<div id=\"board\">\r\n    <div id=\"content\">\r\n        <p id=\"title\">Leaderboard</p>\r\n        <p id=\"subtitle\">THE CODER\'S MENACE</p>\r\n        <br>\r\n");
            EndContext();
#line 124 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Home\Index.cshtml"
         if (Model.Leaderboard.Count >= 1)
        {

#line default
#line hidden
            BeginContext(9627, 42, true);
            WriteLiteral("            <ol class=\"leaderboardList\">\r\n");
            EndContext();
#line 127 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Home\Index.cshtml"
                 foreach (var robot in Model.Leaderboard)
                {

#line default
#line hidden
            BeginContext(9747, 32, true);
            WriteLiteral("                    <li><strong>");
            EndContext();
            BeginContext(9780, 15, false);
#line 129 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Home\Index.cshtml"
                           Write(robot.RobotName);

#line default
#line hidden
            EndContext();
            BeginContext(9795, 32, true);
            WriteLiteral("</strong> has completed <strong>");
            EndContext();
            BeginContext(9828, 29, false);
#line 129 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Home\Index.cshtml"
                                                                           Write(robot.NumberOfChoresCompleted);

#line default
#line hidden
            EndContext();
            BeginContext(9857, 23, true);
            WriteLiteral("</strong> chores</li>\r\n");
            EndContext();
#line 130 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(9899, 19, true);
            WriteLiteral("            </ol>\r\n");
            EndContext();
#line 132 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Home\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(9954, 37, true);
            WriteLiteral("            <div> no results </div>\r\n");
            EndContext();
#line 136 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(10002, 51, true);
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"text-center\">\r\n    ");
            EndContext();
            BeginContext(10054, 164, false);
#line 140 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Home\Index.cshtml"
Write(Html.ActionLink("But Seriously, Here Is the Leaderboard", "Leaderboard", "Home", null, new { @class = "btn btnSeriously btn-primary btn-lg", @style="display:none"}));

#line default
#line hidden
            EndContext();
            BeginContext(10218, 146, true);
            WriteLiteral("\r\n    <button type=\"button\" class=\"btn btn-info btn-lg center\" data-toggle=\"modal\" data-target=\"#createRobotModal\">Create Robot</button>\r\n</div>\r\n");
            EndContext();
            BeginContext(10365, 51, false);
#line 143 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_CreateRobotModal", Model));

#line default
#line hidden
            EndContext();
            BeginContext(10416, 137, true);
            WriteLiteral("\r\n<script>\r\n    $(document).ready(function () {\r\n        setTimeout(function () { $(\'.btnSeriously\').show() }, 20000)\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateRobotModalViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
