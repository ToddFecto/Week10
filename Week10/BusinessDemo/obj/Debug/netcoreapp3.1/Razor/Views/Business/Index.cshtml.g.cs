#pragma checksum "C:\Dev\Week10\Week10\BusinessDemo\Views\Business\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1924a6a0924a506c954989063c279f9630b47770"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Business_Index), @"mvc.1.0.view", @"/Views/Business/Index.cshtml")]
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
#line 1 "C:\Dev\Week10\Week10\BusinessDemo\Views\_ViewImports.cshtml"
using BusinessDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\Week10\Week10\BusinessDemo\Views\_ViewImports.cshtml"
using BusinessDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1924a6a0924a506c954989063c279f9630b47770", @"/Views/Business/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c7943289ba2478bfa0045540feae26f850ec0f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Business_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Department>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Dev\Week10\Week10\BusinessDemo\Views\Business\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Departments</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Dev\Week10\Week10\BusinessDemo\Views\Business\Index.cshtml"
 foreach(Department dept in Model)
 {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div><a");
            BeginWriteAttribute("href", " href=\"", 143, "\"", 184, 2);
            WriteAttributeValue("", 150, "/business/department?dept=", 150, 26, true);
#nullable restore
#line 10 "C:\Dev\Week10\Week10\BusinessDemo\Views\Business\Index.cshtml"
WriteAttributeValue("", 176, dept.id, 176, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 10 "C:\Dev\Week10\Week10\BusinessDemo\Views\Business\Index.cshtml"
                                                 Write(dept.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n");
#nullable restore
#line 11 "C:\Dev\Week10\Week10\BusinessDemo\Views\Business\Index.cshtml"
    //<div><a asp-controller="business" asp-action="department" asp-route="">@dept.name</a></div>
 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a href=\"/business/addform\" class=\"btn btn-primary\">Add Employee</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591