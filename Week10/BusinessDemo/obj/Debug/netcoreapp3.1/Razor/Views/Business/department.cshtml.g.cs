#pragma checksum "C:\Dev\Week10\Week10\BusinessDemo\Views\Business\department.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be0944be0fa02057897a4419e01fecba66b5b98e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Business_department), @"mvc.1.0.view", @"/Views/Business/department.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be0944be0fa02057897a4419e01fecba66b5b98e", @"/Views/Business/department.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c7943289ba2478bfa0045540feae26f850ec0f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Business_department : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Dev\Week10\Week10\BusinessDemo\Views\Business\department.cshtml"
  
    ViewData["Title"] = "department";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "C:\Dev\Week10\Week10\BusinessDemo\Views\Business\department.cshtml"
Write(ViewData["DeptName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Dev\Week10\Week10\BusinessDemo\Views\Business\department.cshtml"
 foreach(Employee emp in Model)
 {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 155, "\"", 192, 2);
            WriteAttributeValue("", 162, "/business/employee?emp=", 162, 23, true);
#nullable restore
#line 11 "C:\Dev\Week10\Week10\BusinessDemo\Views\Business\department.cshtml"
WriteAttributeValue("", 185, emp.id, 185, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "C:\Dev\Week10\Week10\BusinessDemo\Views\Business\department.cshtml"
                                        Write(emp.firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Dev\Week10\Week10\BusinessDemo\Views\Business\department.cshtml"
                                                       Write(emp.lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 236, "\"", 270, 2);
            WriteAttributeValue("", 243, "/business/delete?id=", 243, 20, true);
#nullable restore
#line 13 "C:\Dev\Week10\Week10\BusinessDemo\Views\Business\department.cshtml"
WriteAttributeValue("", 263, emp.id, 263, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"brn btn-danger\">Delete</a>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 313, "\"", 352, 2);
            WriteAttributeValue("", 320, "/business/editform?empid=", 320, 25, true);
#nullable restore
#line 14 "C:\Dev\Week10\Week10\BusinessDemo\Views\Business\department.cshtml"
WriteAttributeValue("", 345, emp.id, 345, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"brn btn-primary\">Edit</a>\r\n\r\n</div>\r\n");
#nullable restore
#line 17 "C:\Dev\Week10\Week10\BusinessDemo\Views\Business\department.cshtml"
 }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
