#pragma checksum "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\RewardReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6106c97f0895d27ebf30688fdc9f5ff89c5fc569"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_RewardReport), @"mvc.1.0.view", @"/Views/Member/RewardReport.cshtml")]
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
#line 1 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\_ViewImports.cshtml"
using webcode;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\_ViewImports.cshtml"
using webcode.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\RewardReport.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\RewardReport.cshtml"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6106c97f0895d27ebf30688fdc9f5ff89c5fc569", @"/Views/Member/RewardReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3219487375709b78cdc3d07587f985a228390908", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Member_RewardReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\RewardReport.cshtml"
  
    Layout = "~/Views/Shared/_MemberLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""dss-right-section noside-right-full"">
    <div class=""dashboard-center"">
        <div class=""custom-breadcrumb"">
            <ol class=""cd-breadcrumb"">
                <li><a href=""#"">Dashboard</a></li>
                <li><a href=""#0"">Booster Income Report</a></li>
            </ol>
        </div>
        <div class=""dashboard-center-itm"">
            <div class=""cm-table-data"">
                <div class=""cm-table-data-in"">
");
            WriteLiteral(@"                    <table id=""cmDataTable"" class=""display table"" cellspacing=""0"" width=""100%"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Designation</th>
                                <th>Requirement</th>
                                <th>Gift</th>
                                <th>Start Date</th>
                                <th>Reward Status</th>
                                <th>Achieve</th>
                            </tr>
                        </thead>

                        <tbody>
");
#nullable restore
#line 42 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\RewardReport.cshtml"
                              
                                var i = 0;
                                foreach (DataRow dr in (ViewData["_report"] as DataTable).Rows)
                                {
                                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th>");
#nullable restore
#line 48 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\RewardReport.cshtml"
                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <td><p>");
#nullable restore
#line 49 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\RewardReport.cshtml"
                                          Write(dr["Designation"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                        <td><p>");
#nullable restore
#line 50 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\RewardReport.cshtml"
                                          Write(dr["Requirement"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                        <td><p>");
#nullable restore
#line 51 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\RewardReport.cshtml"
                                          Write(dr["Gift"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                        <td><p>");
#nullable restore
#line 52 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\RewardReport.cshtml"
                                          Write(dr["Startdate"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                        <td><p>");
#nullable restore
#line 53 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\RewardReport.cshtml"
                                          Write(dr["Status"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                        <td><p>");
#nullable restore
#line 54 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\RewardReport.cshtml"
                                          Write(dr["Achievedate"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 56 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\RewardReport.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
