#pragma checksum "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75365b0992b39733bacf966167277c2ccc200887"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Leagues_Index), @"mvc.1.0.view", @"/Views/Leagues/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Leagues/Index.cshtml", typeof(AspNetCore.Views_Leagues_Index))]
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
#line 7 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75365b0992b39733bacf966167277c2ccc200887", @"/Views/Leagues/Index.cshtml")]
    public class Views_Leagues_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FootballApplication.ViewModels.LeagueView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Leagues", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Insert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("table-action"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
  
    ViewData["Title"] = "Leagues";

#line default
#line hidden
            BeginContext(233, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 11 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
 if (TempData.ContainsKey("ActionSuccess"))
{


#line default
#line hidden
            BeginContext(287, 76, true);
            WriteLiteral("    <div class=\"success-msg\">\r\n        <i class=\"fa fa-check\"></i>\r\n        ");
            EndContext();
            BeginContext(364, 25, false);
#line 16 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
   Write(TempData["ActionSuccess"]);

#line default
#line hidden
            EndContext();
            BeginContext(389, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 18 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
}

#line default
#line hidden
            BeginContext(406, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 20 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
 if (TempData.ContainsKey("ActionError"))
{

#line default
#line hidden
            BeginContext(454, 81, true);
            WriteLiteral("    <div class=\"error-msg\">\r\n        <i class=\"fa fa-times-circle\"></i>\r\n        ");
            EndContext();
            BeginContext(536, 23, false);
#line 24 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
   Write(TempData["ActionError"]);

#line default
#line hidden
            EndContext();
            BeginContext(559, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 26 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
}

#line default
#line hidden
            BeginContext(576, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 28 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
 if (TempData["ErrorMessage"] != null)
{
    foreach (var errorMessage in TempData["ErrorMessage"] as IEnumerable<string>)
    {

#line default
#line hidden
            BeginContext(711, 93, true);
            WriteLiteral("        <div class=\"error-msg\">\r\n            <i class=\"fa fa-times-circle\"></i>\r\n            ");
            EndContext();
            BeginContext(805, 12, false);
#line 34 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
       Write(errorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(817, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 36 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
    }

}

#line default
#line hidden
            BeginContext(847, 136, true);
            WriteLiteral("\r\n<div class=\"row content-title\">\r\n    <div class=\"column-left col-6 center\">\r\n    </div>\r\n    <div class=\"column-right col-6 center\">\r\n");
            EndContext();
#line 44 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
         if (HttpContextAccessor.HttpContext.Session.Get("UserRole") != null
&& BitConverter.ToInt16(HttpContextAccessor.HttpContext.Session.Get("UserRole")) == 1)
        {

#line default
#line hidden
            BeginContext(1160, 124, true);
            WriteLiteral("            <div class=\"page-actions\">\r\n                <div class=\"button-link add-item float-right\">\r\n                    ");
            EndContext();
            BeginContext(1284, 235, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75365b0992b39733bacf966167277c2ccc2008878800", async() => {
                BeginContext(1401, 114, true);
                WriteLiteral("\r\n                        <i class=\"fa fa-plus\"></i>\r\n                        Add new league\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1519, 46, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 57 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1576, 192, true);
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-12 table-information\">\r\n        <div class=\"table-wrapper\">\r\n            <table>\r\n                <thead>\r\n                    <tr>\r\n");
            EndContext();
#line 66 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
                         if (HttpContextAccessor.HttpContext.Session.Get("UserRole") != null
&& BitConverter.ToInt16(HttpContextAccessor.HttpContext.Session.Get("UserRole")) == 1)
                        {

#line default
#line hidden
            BeginContext(1977, 78, true);
            WriteLiteral("                            <th class=\"table-title\" colspan=\"6\">Leagues</th>\r\n");
            EndContext();
#line 70 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2082, 53, true);
            WriteLiteral("                    </tr>\r\n                </thead>\r\n");
            EndContext();
#line 73 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
                 if (Model.leagues.Count != 0)
                {

#line default
#line hidden
            BeginContext(2202, 29, true);
            WriteLiteral("                    <tbody>\r\n");
            EndContext();
#line 76 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
                         foreach (var item in Model.leagues)
                        {

#line default
#line hidden
            BeginContext(2320, 60, true);
            WriteLiteral("                            <tr class=\"match\" data-match-id=");
            EndContext();
            BeginContext(2381, 14, false);
#line 78 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
                                                       Write(item.IdLeagues);

#line default
#line hidden
            EndContext();
            BeginContext(2395, 77, true);
            WriteLiteral(">\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2473, 14, false);
#line 80 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
                               Write(item.IdLeagues);

#line default
#line hidden
            EndContext();
            BeginContext(2487, 124, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"\">\r\n                                    ");
            EndContext();
            BeginContext(2612, 9, false);
#line 83 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2621, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2737, 12, false);
#line 86 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
                               Write(item.Founded);

#line default
#line hidden
            EndContext();
            BeginContext(2749, 124, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"\">\r\n                                    ");
            EndContext();
            BeginContext(2874, 18, false);
#line 89 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
                               Write(item.NumberOfClubs);

#line default
#line hidden
            EndContext();
            BeginContext(2892, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
#line 91 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
                                 if (HttpContextAccessor.HttpContext.Session.Get("UserRole") != null
                                  && BitConverter.ToInt16(HttpContextAccessor.HttpContext.Session.Get("UserRole")) == 1)
                                {

#line default
#line hidden
            BeginContext(3192, 77, true);
            WriteLiteral("                                    <td class=\"delete-action\" data-match-id=\"");
            EndContext();
            BeginContext(3270, 14, false);
#line 94 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
                                                                        Write(item.IdLeagues);

#line default
#line hidden
            EndContext();
            BeginContext(3284, 44, true);
            WriteLiteral("\">\r\n                                        ");
            EndContext();
            BeginContext(3328, 284, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75365b0992b39733bacf966167277c2ccc20088716306", async() => {
                BeginContext(3493, 115, true);
                WriteLiteral("\r\n                                            <i class=\"fa fa-trash\"></i>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 97 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
                                            WriteLiteral(item.IdLeagues);

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
            BeginContext(3612, 147, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"edit-action\">\r\n                                        ");
            EndContext();
            BeginContext(3759, 281, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75365b0992b39733bacf966167277c2ccc20088719159", async() => {
                BeginContext(3922, 114, true);
                WriteLiteral("\r\n                                            <i class=\"fa fa-edit\"></i>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 104 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
                                            WriteLiteral(item.IdLeagues);

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
            BeginContext(4040, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
#line 108 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(4120, 35, true);
            WriteLiteral("                            </tr>\r\n");
            EndContext();
#line 110 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4182, 30, true);
            WriteLiteral("                    </tbody>\r\n");
            EndContext();
#line 112 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(4272, 59, true);
            WriteLiteral("                    <tbody>\r\n                        <tr>\r\n");
            EndContext();
#line 117 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
                             if (HttpContextAccessor.HttpContext.Session.Get("UserRole") != null
&& BitConverter.ToInt16(HttpContextAccessor.HttpContext.Session.Get("UserRole")) == 1)
                            {

#line default
#line hidden
            BeginContext(4548, 147, true);
            WriteLiteral("                                <td colspan=\"6\">\r\n                                    No information found\r\n                                </td>\r\n");
            EndContext();
#line 123 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(4791, 147, true);
            WriteLiteral("                                <td colspan=\"4\">\r\n                                    No information found\r\n                                </td>\r\n");
            EndContext();
#line 129 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(4969, 61, true);
            WriteLiteral("                        </tr>\r\n                    </tbody>\r\n");
            EndContext();
#line 132 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Leagues\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(5049, 58, true);
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FootballApplication.ViewModels.LeagueView> Html { get; private set; }
    }
}
#pragma warning restore 1591
