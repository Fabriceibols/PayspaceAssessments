#pragma checksum "D:\New folder\PayspaceAssessments\PayspaceAssessmentKibuluku\Views\Report\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a123a9c6c36d42ecbfce8d63159459a703194be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_Index), @"mvc.1.0.view", @"/Views/Report/Index.cshtml")]
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
#line 1 "D:\New folder\PayspaceAssessments\PayspaceAssessmentKibuluku\Views\_ViewImports.cshtml"
using PayspaceAssessment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New folder\PayspaceAssessments\PayspaceAssessmentKibuluku\Views\_ViewImports.cshtml"
using PayspaceAssessment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a123a9c6c36d42ecbfce8d63159459a703194be", @"/Views/Report/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0966a43b37d2b561189133304bf673e123fa4e10", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PayspaceAssessment.Models.DbModel.TblTaxCalculation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\New folder\PayspaceAssessments\PayspaceAssessmentKibuluku\Views\Report\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Report</h2>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th scope=\"col\">\n                ");
#nullable restore
#line 13 "D:\New folder\PayspaceAssessments\PayspaceAssessmentKibuluku\Views\Report\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TaxCalculationId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 16 "D:\New folder\PayspaceAssessments\PayspaceAssessmentKibuluku\Views\Report\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th scope=\"col\">\n                ");
#nullable restore
#line 19 "D:\New folder\PayspaceAssessments\PayspaceAssessmentKibuluku\Views\Report\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th scope=\"col\">\n                ");
#nullable restore
#line 22 "D:\New folder\PayspaceAssessments\PayspaceAssessmentKibuluku\Views\Report\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TaxCalculated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 25 "D:\New folder\PayspaceAssessments\PayspaceAssessmentKibuluku\Views\Report\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AnnualIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th scope=\"col\">\n                ");
#nullable restore
#line 28 "D:\New folder\PayspaceAssessments\PayspaceAssessmentKibuluku\Views\Report\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CalculationType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 33 "D:\New folder\PayspaceAssessments\PayspaceAssessmentKibuluku\Views\Report\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 36 "D:\New folder\PayspaceAssessments\PayspaceAssessmentKibuluku\Views\Report\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TaxCalculationId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 39 "D:\New folder\PayspaceAssessments\PayspaceAssessmentKibuluku\Views\Report\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 42 "D:\New folder\PayspaceAssessments\PayspaceAssessmentKibuluku\Views\Report\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 45 "D:\New folder\PayspaceAssessments\PayspaceAssessmentKibuluku\Views\Report\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TaxCalculated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 48 "D:\New folder\PayspaceAssessments\PayspaceAssessmentKibuluku\Views\Report\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AnnualIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 51 "D:\New folder\PayspaceAssessments\PayspaceAssessmentKibuluku\Views\Report\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CalculationType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 54 "D:\New folder\PayspaceAssessments\PayspaceAssessmentKibuluku\Views\Report\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PayspaceAssessment.Models.DbModel.TblTaxCalculation>> Html { get; private set; }
    }
}
#pragma warning restore 1591