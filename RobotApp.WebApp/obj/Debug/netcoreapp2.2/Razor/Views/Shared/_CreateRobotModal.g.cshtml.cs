#pragma checksum "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Shared\_CreateRobotModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58a56fd53fc0f04d80558ac303c3e33575a5be3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CreateRobotModal), @"mvc.1.0.view", @"/Views/Shared/_CreateRobotModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_CreateRobotModal.cshtml", typeof(AspNetCore.Views_Shared__CreateRobotModal))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58a56fd53fc0f04d80558ac303c3e33575a5be3e", @"/Views/Shared/_CreateRobotModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f88a075bb9527f41a2204d2e4f4ffbd36cc25b1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CreateRobotModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateRobotModalViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("createRobotModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(34, 469, true);
            WriteLiteral(@"<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""createRobotModal"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Create Robot</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            EndContext();
            BeginContext(503, 2165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58a56fd53fc0f04d80558ac303c3e33575a5be3e4300", async() => {
                BeginContext(531, 561, true);
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div class=""robotNameError"" style=""display:none"">Robot name is required</div>
                    <input type=""text"" id=""robotName"" placeholder=""* Robot Name"" class=""form-control robotName"">
                    <div class=""choreListTitle""><span>*</span> Select 5 or more chores for your robot to complete:</div>
                    <div class=""robotChoreError"" style=""display:none"">You must select at least 5 chores for the robot to perform</div>
                    <div class=""choresList"">
");
                EndContext();
#line 18 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Shared\_CreateRobotModal.cshtml"
                         if (Model.ChoresList.Count >= 1)
                        {
                            

#line default
#line hidden
#line 20 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Shared\_CreateRobotModal.cshtml"
                             foreach (var chore in Model.ChoresList)
                            {

#line default
#line hidden
                BeginContext(1279, 115, true);
                WriteLiteral("                                <div class=\"choreItem\">\r\n                                    <input type=\"checkbox\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1394, "\"", 1416, 1);
#line 23 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Shared\_CreateRobotModal.cshtml"
WriteAttributeValue("", 1402, chore.ChoreID, 1402, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1417, 97, true);
                WriteLiteral(" class=\"choreCheckbox\" />\r\n                                    <label class=\"choreCheckboxLabel\">");
                EndContext();
                BeginContext(1515, 45, false);
#line 24 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Shared\_CreateRobotModal.cshtml"
                                                                 Write(Html.DisplayFor(modelItem => chore.ChoreName));

#line default
#line hidden
                EndContext();
                BeginContext(1560, 50, true);
                WriteLiteral("</label>\r\n                                </div>\r\n");
                EndContext();
#line 26 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Shared\_CreateRobotModal.cshtml"
                            }

#line default
#line hidden
#line 26 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Shared\_CreateRobotModal.cshtml"
                             
                        }

#line default
#line hidden
                BeginContext(1668, 77, true);
                WriteLiteral("                    </div>\r\n                    <div class=\"RobotTypeList\">\r\n");
                EndContext();
#line 30 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Shared\_CreateRobotModal.cshtml"
                         if (Model.RobotTypesList != null)
                        {

#line default
#line hidden
                BeginContext(1832, 89, true);
                WriteLiteral("                            <div class=\"RobotTypeItem\">\r\n                                ");
                EndContext();
                BeginContext(1922, 179, false);
#line 33 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Shared\_CreateRobotModal.cshtml"
                           Write(Html.DropDownList("RobotType", Model.RobotTypesList, "* - select a robot type -", new { @id = "RobotTypesList", @name = "RobotTypesList", @class = "RobotTypesList form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(2101, 38, true);
                WriteLiteral("\r\n                            </div>\r\n");
                EndContext();
#line 35 "C:\Users\rachael-smith\Desktop\RobotApp\RobotApp.WebApp\Views\Shared\_CreateRobotModal.cshtml"
                        }

#line default
#line hidden
                BeginContext(2166, 495, true);
                WriteLiteral(@"                    </div>
                    <input type=""text"" id=""numberOfRobots"" placeholder=""* Number of Robots"" class=""form-control numberOfRobots"">
                </div>
                <div class=""modal-footer"">
                    <button class=""btn btn-success submit createRobotSubmit"" type=""submit"" disabled=""disabled"">Create</button>
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                </div>
            ");
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
            BeginContext(2668, 1500, true);
            WriteLiteral(@"
        </div>
    </div>
</div>

<script>
    //form validation (disable submit until criteria met)
    $('.choreCheckboxLabel').on('click', function () {
        checkbox = $(this).prev();
        checkbox.click();
        validateCreateRobotModal();
    });
    $('.robotName, .numberOfRobots').keyup(function () {
        validateCreateRobotModal();
    })
    $('.RobotTypesList').change(function () {
        validateCreateRobotModal();
    })

    $('#createRobotModal').on('submit', function (e) {
        var numberOfRobots = parseInt($('.numberOfRobots').val())
        for (i = 0; i <= numberOfRobots; i++) {
            e.preventDefault()
            var robotInfo = {
                RobotName: $('.robotName').val(),
                RobotType: parseInt($('.RobotTypeList :selected').val())
            }
            CreateRobot(robotInfo)
        }
    });
    function validateCreateRobotModal() {
        var count = 0;
        $('.choresList').find('input[type=checkbox]:che");
            WriteLiteral(@"cked').each(function () {
            if (count < 4) {
                count++
                $('.submit').prop('disabled', true)
            } else if ($('.robotName').val().trim() =="""" || $('#RobotTypesList').val() < 1 || $('#RobotTypesList').val() == """" || $('.numberOfRobots').val() == """") {
                $('.submit').prop('disabled', true)
            }else {
                $('.submit').prop('disabled', false)
            }
        });
    }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateRobotModalViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
