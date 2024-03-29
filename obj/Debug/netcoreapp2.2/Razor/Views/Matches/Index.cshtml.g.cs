#pragma checksum "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "988c101aadf9a7cde03b3ca9e5eee82ab431ba16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Matches_Index), @"mvc.1.0.view", @"/Views/Matches/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Matches/Index.cshtml", typeof(AspNetCore.Views_Matches_Index))]
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
#line 7 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"988c101aadf9a7cde03b3ca9e5eee82ab431ba16", @"/Views/Matches/Index.cshtml")]
    public class Views_Matches_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FootballApplication.ViewModels.MatchDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("icon item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("item active-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
  
    ViewData["Title"] = "Matches";

#line default
#line hidden
            BeginContext(235, 321, true);
            WriteLiteral(@"<div class=""modal"">
    <div class=""modal-box"">
        <span class=""close-btn"">
            <i class=""fa fa-times""></i>
        </span>
        <div class=""modal-title"">
            <h2>Add new match</h2>
        </div>
        <div class=""modal-content"">
            <div class=""input-field"">
                ");
            EndContext();
            BeginContext(557, 154, false);
#line 19 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
           Write(Html.DropDownList("stadium", new SelectList(Model.LeaguesList.Select(el => new { Value = el.IdLeagues, Key = el.Name }), "Value", "Key"), "Select league"));

#line default
#line hidden
            EndContext();
            BeginContext(711, 77, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"input-field\">\r\n                ");
            EndContext();
            BeginContext(789, 156, false);
#line 22 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
           Write(Html.DropDownList("homeTeam", new SelectList(Model.TeamList.Select(el => new { Value = el.IdTeam, Key = el.TeamName }), "Value", "Key"), "Select home team"));

#line default
#line hidden
            EndContext();
            BeginContext(945, 77, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"input-field\">\r\n                ");
            EndContext();
            BeginContext(1023, 79, false);
#line 25 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
           Write(Html.TextBox("home-team-score", null, new { @placeholder = "Home team score" }));

#line default
#line hidden
            EndContext();
            BeginContext(1102, 77, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"input-field\">\r\n                ");
            EndContext();
            BeginContext(1180, 156, false);
#line 28 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
           Write(Html.DropDownList("awayTeam", new SelectList(Model.TeamList.Select(el => new { Value = el.IdTeam, Key = el.TeamName }), "Value", "Key"), "Select away team"));

#line default
#line hidden
            EndContext();
            BeginContext(1336, 77, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"input-field\">\r\n                ");
            EndContext();
            BeginContext(1414, 79, false);
#line 31 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
           Write(Html.TextBox("away-team-score", null, new { @placeholder = "Away team score" }));

#line default
#line hidden
            EndContext();
            BeginContext(1493, 77, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"input-field\">\r\n                ");
            EndContext();
            BeginContext(1571, 65, false);
#line 34 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
           Write(Html.TextBox("gameweek", null, new { @placeholder = "Gameweek" }));

#line default
#line hidden
            EndContext();
            BeginContext(1636, 77, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"input-field\">\r\n                ");
            EndContext();
            BeginContext(1714, 66, false);
#line 37 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
           Write(Html.TextBox("gameTime", null, new { @placeholder = "Match time"}));

#line default
#line hidden
            EndContext();
            BeginContext(1780, 77, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"input-field\">\r\n                ");
            EndContext();
            BeginContext(1858, 157, false);
#line 40 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
           Write(Html.DropDownList("stadium", new SelectList(Model.StadiumsList.Select(el => new { Value = el.IdStadiums, Key = el.Name }), "Value", "Key"), "Select stadium"));

#line default
#line hidden
            EndContext();
            BeginContext(2015, 321, true);
            WriteLiteral(@"
            </div>
        </div>
        <div class=""modal-actions text-right"">
            <div class=""submit-button"">
                <button class=""btn"">Submit</button>
            </div>
        </div>
    </div>
</div>
<div class=""row content-title"">
    <div class=""column-left col-6 center"">
        ");
            EndContext();
            BeginContext(2337, 63, false);
#line 52 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
   Write(HttpContextAccessor.HttpContext.Session.GetString("Testavimas"));

#line default
#line hidden
            EndContext();
            BeginContext(2400, 691, true);
            WriteLiteral(@"
    </div>
    <div class=""column-right col-6 center"">
        <div class=""page-actions"">
            <div class=""button-link add-item float-right"">
                <a href=""#"" class=""table-action"">
                    <i class=""fa fa-plus""></i>
                    Add new match
                </a>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-12 table-information"">
        <div class=""table-wrapper"">
            <table>
                <thead>
                    <tr>
                        <th class=""table-title"" colspan=""5"">Matches</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 75 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                     foreach (var item in Model.HeadToHeadMatches)
                    {

#line default
#line hidden
            BeginContext(3182, 56, true);
            WriteLiteral("                        <tr class=\"match\" data-match-id=");
            EndContext();
            BeginContext(3239, 7, false);
#line 77 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                                                   Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(3246, 87, true);
            WriteLiteral(">\r\n                            <td class=\"game-week\">\r\n                                ");
            EndContext();
            BeginContext(3334, 13, false);
#line 79 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                           Write(item.gameWeek);

#line default
#line hidden
            EndContext();
            BeginContext(3347, 89, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"matchtime\">\r\n");
            EndContext();
#line 82 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                                 if ((DateTime.Compare(DateTime.Now, item.matchTime.Value.AddHours(1).AddMinutes(50)) > 0)
                              && (item.homeTeamScore != null && item.awayTeamScore != null))
                                {

#line default
#line hidden
            BeginContext(3689, 138, true);
            WriteLiteral("                                    <div>\r\n                                        Full time\r\n                                    </div>\r\n");
            EndContext();
#line 88 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                                }
                                else
                                {
                                    

#line default
#line hidden
            BeginContext(3972, 14, false);
#line 91 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                               Write(item.matchTime);

#line default
#line hidden
            EndContext();
#line 91 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                                                   
                                }

#line default
#line hidden
            BeginContext(4023, 237, true);
            WriteLiteral("                            </td>\r\n                            <td class=\"team-name\">\r\n                                <div class=\"club-image align-center float-right\" style=\"padding-left:20px;\">\r\n                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 4260, "", 4284, 1);
#line 96 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
WriteAttributeValue("", 4265, item.homeTeamCrest, 4265, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4284, 165, true);
            WriteLiteral(" />\r\n                                </div>\r\n                                <div class=\"club-name align-center justify-right\">\r\n                                    ");
            EndContext();
            BeginContext(4450, 17, false);
#line 99 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                               Write(item.homeTeamName);

#line default
#line hidden
            EndContext();
            BeginContext(4467, 158, true);
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                            <td class=\"result\">\r\n                                ");
            EndContext();
            BeginContext(4626, 18, false);
#line 103 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                           Write(item.homeTeamScore);

#line default
#line hidden
            EndContext();
            BeginContext(4644, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(4648, 18, false);
#line 103 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                                                 Write(item.awayTeamScore);

#line default
#line hidden
            EndContext();
            BeginContext(4666, 211, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"team-name\">\r\n                                <div class=\"club-image align-center float-left\">\r\n                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 4877, "", 4901, 1);
#line 107 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
WriteAttributeValue("", 4882, item.awayTeamCrest, 4882, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4901, 151, true);
            WriteLiteral(" />\r\n                                </div>\r\n                                <div class=\"club-name align-center\">\r\n                                    ");
            EndContext();
            BeginContext(5053, 17, false);
#line 110 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                               Write(item.awayTeamName);

#line default
#line hidden
            EndContext();
            BeginContext(5070, 108, true);
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 114 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(5201, 187, true);
            WriteLiteral("                </tbody>\r\n                <tfoot>\r\n                    <tr>\r\n                        <td colspan=\"2\">\r\n                            Show items\r\n                            ");
            EndContext();
            BeginContext(5390, 69, false);
#line 120 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                        Write(Model.HeadToHeadMatches.PageNumber * Model.HeadToHeadMatches.PageSize);

#line default
#line hidden
            EndContext();
            BeginContext(5460, 33, true);
            WriteLiteral("\r\n                            of ");
            EndContext();
            BeginContext(5494, 38, false);
#line 121 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                          Write(Model.HeadToHeadMatches.TotalItemCount);

#line default
#line hidden
            EndContext();
            BeginContext(5532, 134, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td colspan=\"3\">\r\n                            <div class=\"pagination menu\">\r\n");
            EndContext();
#line 125 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                                 if (Model.HeadToHeadMatches.HasPreviousPage)
                                {

#line default
#line hidden
            BeginContext(5780, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(5816, 196, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "988c101aadf9a7cde03b3ca9e5eee82ab431ba1618860", async() => {
                BeginContext(5894, 114, true);
                WriteLiteral("\r\n                                        <i class=\"fa fa-chevron-left\"></i>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 127 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                                           WriteLiteral(Model.HeadToHeadMatches.PageNumber - 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6012, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 130 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(6049, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 131 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                                 for (int i = 0; i < Model.HeadToHeadMatches.PageCount; i++)
                                {
                                    if ((i + 1) == Model.HeadToHeadMatches.PageNumber)
                                    {

#line default
#line hidden
            BeginContext(6305, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(6345, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "988c101aadf9a7cde03b3ca9e5eee82ab431ba1622149", async() => {
                BeginContext(6395, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(6443, 5, false);
#line 136 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                                        Write(i + 1);

#line default
#line hidden
                EndContext();
                BeginContext(6449, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 135 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                                               WriteLiteral(i+1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6495, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 138 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(6617, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(6657, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "988c101aadf9a7cde03b3ca9e5eee82ab431ba1625320", async() => {
                BeginContext(6695, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(6743, 5, false);
#line 142 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                                        Write(i + 1);

#line default
#line hidden
                EndContext();
                BeginContext(6749, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 141 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                                               WriteLiteral(i+1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6795, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 144 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                                    }

                                }

#line default
#line hidden
            BeginContext(6873, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 147 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                                 if (Model.HeadToHeadMatches.HasNextPage)
                                {

#line default
#line hidden
            BeginContext(6983, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(7019, 197, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "988c101aadf9a7cde03b3ca9e5eee82ab431ba1628845", async() => {
                BeginContext(7097, 115, true);
                WriteLiteral("\r\n                                        <i class=\"fa fa-chevron-right\"></i>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 149 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                                           WriteLiteral(Model.HeadToHeadMatches.PageNumber + 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7216, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 152 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\Matches\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(7253, 178, true);
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n                </tfoot>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FootballApplication.ViewModels.MatchDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
