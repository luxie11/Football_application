#pragma checksum "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\LeagueTeams\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7683eced19011bb6922b57e6a82c272f32ac0f3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LeagueTeams_Index), @"mvc.1.0.view", @"/Views/LeagueTeams/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LeagueTeams/Index.cshtml", typeof(AspNetCore.Views_LeagueTeams_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7683eced19011bb6922b57e6a82c272f32ac0f3e", @"/Views/LeagueTeams/Index.cshtml")]
    public class Views_LeagueTeams_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FootballApplication.Models.LeagueTeams>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\LeagueTeams\Index.cshtml"
  
    ViewData["Title"] = "League";

#line default
#line hidden
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(106, 105, true);
            WriteLiteral("\r\n<div class=\"row content-title\">\r\n    <div class=\"column-left col-6 center\">\r\n        <h2>\r\n            ");
            EndContext();
            BeginContext(212, 24, false);
#line 11 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\LeagueTeams\Index.cshtml"
       Write(ViewData["League-Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(236, 937, true);
            WriteLiteral(@"
        </h2>
    </div>
    <div class=""column-right col-6 center"">
    </div>
</div>
<div class=""row"">
    <div class=""col-12 table-information"">
        <div class=""table-wrapper"">
            <table>
                <thead>
                    <tr>
                        <th class=""position"">P</th>
                        <th class=""team-name"">Team</th>
                        <th class=""club-statistics"">M</th>
                        <th class=""club-statistics"">W</th>
                        <th class=""club-statistics"">D</th>
                        <th class=""club-statistics"">L</th>
                        <th class=""club-statistics"">G+</th>
                        <th class=""club-statistics"">G-</th>
                        <th class=""club-statistics"">GD</th>
                        <th class=""club-statistics"">P</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 36 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\LeagueTeams\Index.cshtml"
                     foreach (var item in Model.Select((value, index) => new {value, index }))
                    {

#line default
#line hidden
            BeginContext(1292, 127, true);
            WriteLiteral("                        <tr class=\"match\">\r\n                            <td class=\"position\">\r\n                                ");
            EndContext();
            BeginContext(1421, 14, false);
#line 40 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\LeagueTeams\Index.cshtml"
                            Write(item.index + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1436, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1471, 26, false);
#line 41 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\LeagueTeams\Index.cshtml"
                           Write(item.value.FkTeam.CrestUrl);

#line default
#line hidden
            EndContext();
            BeginContext(1497, 239, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"team-name\">\r\n                                <div class=\"club-image align-center float-left\" style=\"padding-right:20px;\">\r\n                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 1736, "", 1768, 1);
#line 45 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\LeagueTeams\Index.cshtml"
WriteAttributeValue("", 1741, item.value.FkTeam.CrestUrl, 1741, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1768, 151, true);
            WriteLiteral(" />\r\n                                </div>\r\n                                <div class=\"club-name align-center\">\r\n                                    ");
            EndContext();
            BeginContext(1920, 26, false);
#line 48 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\LeagueTeams\Index.cshtml"
                               Write(item.value.FkTeam.TeamName);

#line default
#line hidden
            EndContext();
            BeginContext(1946, 167, true);
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                            <td class=\"club-statistics\">\r\n                                ");
            EndContext();
            BeginContext(2114, 24, false);
#line 52 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\LeagueTeams\Index.cshtml"
                           Write(item.value.MatchesPlayed);

#line default
#line hidden
            EndContext();
            BeginContext(2138, 127, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"club-statistics\">\r\n                                ");
            EndContext();
            BeginContext(2266, 15, false);
#line 55 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\LeagueTeams\Index.cshtml"
                           Write(item.value.Wins);

#line default
#line hidden
            EndContext();
            BeginContext(2281, 127, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"club-statistics\">\r\n                                ");
            EndContext();
            BeginContext(2409, 16, false);
#line 58 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\LeagueTeams\Index.cshtml"
                           Write(item.value.Draws);

#line default
#line hidden
            EndContext();
            BeginContext(2425, 127, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"club-statistics\">\r\n                                ");
            EndContext();
            BeginContext(2553, 16, false);
#line 61 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\LeagueTeams\Index.cshtml"
                           Write(item.value.Loses);

#line default
#line hidden
            EndContext();
            BeginContext(2569, 127, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"club-statistics\">\r\n                                ");
            EndContext();
            BeginContext(2697, 22, false);
#line 64 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\LeagueTeams\Index.cshtml"
                           Write(item.value.GoalsScored);

#line default
#line hidden
            EndContext();
            BeginContext(2719, 127, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"club-statistics\">\r\n                                ");
            EndContext();
            BeginContext(2847, 24, false);
#line 67 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\LeagueTeams\Index.cshtml"
                           Write(item.value.GoalsConceded);

#line default
#line hidden
            EndContext();
            BeginContext(2871, 127, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"club-statistics\">\r\n                                ");
            EndContext();
            BeginContext(3000, 49, false);
#line 70 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\LeagueTeams\Index.cshtml"
                            Write(item.value.GoalsScored - item.value.GoalsConceded);

#line default
#line hidden
            EndContext();
            BeginContext(3050, 127, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"club-statistics\">\r\n                                ");
            EndContext();
            BeginContext(3178, 17, false);
#line 73 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\LeagueTeams\Index.cshtml"
                           Write(item.value.Points);

#line default
#line hidden
            EndContext();
            BeginContext(3195, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 76 "D:\Universitetas\KTU Ketvirtas Kursas\Framework\FootballApplication\FootballApplication\Views\LeagueTeams\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(3286, 86, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FootballApplication.Models.LeagueTeams>> Html { get; private set; }
    }
}
#pragma warning restore 1591
