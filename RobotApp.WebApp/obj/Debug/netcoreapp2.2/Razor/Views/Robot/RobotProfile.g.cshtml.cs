#pragma checksum "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Robot\RobotProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2f88fb280ba4cdda511eee2856a6e01e77321e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Robot_RobotProfile), @"mvc.1.0.view", @"/Views/Robot/RobotProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Robot/RobotProfile.cshtml", typeof(AspNetCore.Views_Robot_RobotProfile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2f88fb280ba4cdda511eee2856a6e01e77321e0", @"/Views/Robot/RobotProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f88a075bb9527f41a2204d2e4f4ffbd36cc25b1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Robot_RobotProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RobotProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("createRobot"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(35, 21, false);
#line 2 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Robot\RobotProfile.cshtml"
Write(Model.Robot.RobotName);

#line default
#line hidden
            EndContext();
            BeginContext(56, 25, true);
            WriteLiteral("\'s Profile</h1>\r\n<hr />\r\n");
            EndContext();
            BeginContext(81, 1017, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2f88fb280ba4cdda511eee2856a6e01e77321e04111", async() => {
                BeginContext(104, 58, true);
                WriteLiteral("\r\n    <div class=\"robotID\" style=\"display:none\">\r\n        ");
                EndContext();
                BeginContext(163, 37, false);
#line 6 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Robot\RobotProfile.cshtml"
   Write(Html.DisplayFor(x => x.Robot.RobotID));

#line default
#line hidden
                EndContext();
                BeginContext(200, 38, true);
                WriteLiteral("\r\n    </div>\r\n    <div class=\"robotId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 238, "\"", 266, 1);
#line 8 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Robot\RobotProfile.cshtml"
WriteAttributeValue("", 246, Model.Robot.RobotID, 246, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(267, 143, true);
                WriteLiteral(" style=\"display:none;\"></div>\r\n    <h4>Robot Name</h4>\r\n    <div class=\"robotNameError\" style=\"display:none\">Robot name is required</div>\r\n    ");
                EndContext();
                BeginContext(411, 82, false);
#line 11 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Robot\RobotProfile.cshtml"
Write(Html.TextBoxFor(x => x.Robot.RobotName, new { @class = "robotName form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(493, 60, true);
                WriteLiteral("\r\n    <h4>Robot Type</h4>\r\n    <div class=\"RobotTypeList\">\r\n");
                EndContext();
#line 14 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Robot\RobotProfile.cshtml"
         if (Model.RobotTypesList != null)
        {

#line default
#line hidden
                BeginContext(608, 41, true);
                WriteLiteral("            <div class=\"RobotTypeItem\">\r\n");
                EndContext();
                BeginContext(719, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(736, 150, false);
#line 18 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Robot\RobotProfile.cshtml"
           Write(Html.DropDownList("RobotType", Model.RobotTypesList, new { @id = "RobotTypesList", @name = "RobotTypesList", @class = "RobotTypesList form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(886, 22, true);
                WriteLiteral("\r\n            </div>\r\n");
                EndContext();
#line 20 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Robot\RobotProfile.cshtml"
        }

#line default
#line hidden
                BeginContext(919, 172, true);
                WriteLiteral("    </div>\r\n    <div class=\"updateProfileBtn\">\r\n        <button class=\"btn btn-success updateProfile submit\" type=\"submit\" disabled=\"disabled\">Update</button>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1098, 41, true);
            WriteLiteral("\r\n<script>\r\n    $(\'.RobotTypesList\').val(");
            EndContext();
            BeginContext(1140, 23, false);
#line 27 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Robot\RobotProfile.cshtml"
                        Write(Model.Robot.RobotTypeID);

#line default
#line hidden
            EndContext();
            BeginContext(1163, 784, true);
            WriteLiteral(@");
    $('.robotName').keyup(function () {
        validateUpdateRobot();
    })
    $('.RobotTypesList').change(function () {
        validateCreateRobotModal();
    })
    function validateUpdateRobot() {
        if ($('.robotName').val().trim() == '' || $('#RobotTypesList').val() < 1 || $('#RobotTypesList').val() == """") {
            $('.submit').prop('disabled', true)
        } else {
            $('.submit').prop('disabled', false)
        }
    };
    $('.updateProfile').click(function () {
        var robotInfo = {
            RobotID: parseInt($('.robotID').text().trim()),
            RobotName: $('.robotName').val(),
            RobotType: parseInt($('.RobotTypeList :selected').val())
        }
        UpdateRobot(robotInfo)
    })

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RobotProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
