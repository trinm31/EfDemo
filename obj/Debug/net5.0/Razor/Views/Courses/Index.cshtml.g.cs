#pragma checksum "/Users/minhtri/RiderProjects/EfDemo/Views/Courses/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06bdac400a35e98d00b771fb5687f4b68264a5d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Index), @"mvc.1.0.view", @"/Views/Courses/Index.cshtml")]
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
#line 1 "/Users/minhtri/RiderProjects/EfDemo/Views/_ViewImports.cshtml"
using EntityFramworkDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/minhtri/RiderProjects/EfDemo/Views/_ViewImports.cshtml"
using EntityFramworkDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06bdac400a35e98d00b771fb5687f4b68264a5d3", @"/Views/Courses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f545f5adafe3c8995fa33fd44114a11c2e10f97", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityFramworkDemo.Models.Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 6 "/Users/minhtri/RiderProjects/EfDemo/Views/Courses/Index.cshtml"
 foreach (var course in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>");
#nullable restore
#line 8 "/Users/minhtri/RiderProjects/EfDemo/Views/Courses/Index.cshtml"
   Write(course.CourseId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    <h2>");
#nullable restore
#line 9 "/Users/minhtri/RiderProjects/EfDemo/Views/Courses/Index.cshtml"
   Write(course.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    <p>--------------------</p>\n");
#nullable restore
#line 11 "/Users/minhtri/RiderProjects/EfDemo/Views/Courses/Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityFramworkDemo.Models.Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
