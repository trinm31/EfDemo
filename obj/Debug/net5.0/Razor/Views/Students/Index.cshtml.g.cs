#pragma checksum "C:\Users\nmtri\source\repos\EfDemo\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ff9199dae4f80c65adbe30be24c41ecc905aa62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
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
#line 1 "C:\Users\nmtri\source\repos\EfDemo\Views\_ViewImports.cshtml"
using EntityFramworkDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nmtri\source\repos\EfDemo\Views\_ViewImports.cshtml"
using EntityFramworkDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ff9199dae4f80c65adbe30be24c41ecc905aa62", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"811911b4c4cc03df23e31ab25693b67258022ec1", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityFramworkDemo.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\nmtri\source\repos\EfDemo\Views\Students\Index.cshtml"
   
    int i = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nmtri\source\repos\EfDemo\Views\Students\Index.cshtml"
 foreach (var student in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>");
#nullable restore
#line 8 "C:\Users\nmtri\source\repos\EfDemo\Views\Students\Index.cshtml"
   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1>");
#nullable restore
#line 9 "C:\Users\nmtri\source\repos\EfDemo\Views\Students\Index.cshtml"
   Write(student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1>");
#nullable restore
#line 10 "C:\Users\nmtri\source\repos\EfDemo\Views\Students\Index.cshtml"
   Write(student.Sex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1>");
#nullable restore
#line 11 "C:\Users\nmtri\source\repos\EfDemo\Views\Students\Index.cshtml"
   Write(student.Major);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1>");
#nullable restore
#line 12 "C:\Users\nmtri\source\repos\EfDemo\Views\Students\Index.cshtml"
   Write(student.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>----------------</p>\r\n");
#nullable restore
#line 14 "C:\Users\nmtri\source\repos\EfDemo\Views\Students\Index.cshtml"
    i++;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityFramworkDemo.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
