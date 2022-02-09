#pragma checksum "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\Toyota\Toyota\Views\AdminFile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e46c324f2beb2f527b02222e12b45c9d15926394"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminFile_Index), @"mvc.1.0.view", @"/Views/AdminFile/Index.cshtml")]
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
#line 1 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\Toyota\Toyota\Views\_ViewImports.cshtml"
using Toyota;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\Toyota\Toyota\Views\_ViewImports.cshtml"
using Toyota.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e46c324f2beb2f527b02222e12b45c9d15926394", @"/Views/AdminFile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d20eaa3efef274dfb0cd425bd231ced5df79e5ad", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminFile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\Toyota\Toyota\Views\AdminFile\Index.cshtml"
  
    ViewData["Title"] = "File Commander";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <ul>\r\n");
#nullable restore
#line 7 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\Toyota\Toyota\Views\AdminFile\Index.cshtml"
         foreach (var d in ViewBag.Directories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><span data-dirname=\"");
#nullable restore
#line 9 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\Toyota\Toyota\Views\AdminFile\Index.cshtml"
                               Write(d);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" onclick=\"onDirClick()\">");
#nullable restore
#line 9 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\Toyota\Toyota\Views\AdminFile\Index.cshtml"
                                                          Write(d);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n");
#nullable restore
#line 10 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\Toyota\Toyota\Views\AdminFile\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n\r\n    <ul>\r\n");
#nullable restore
#line 14 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\Toyota\Toyota\Views\AdminFile\Index.cshtml"
         foreach (var f in ViewBag.Files)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 16 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\Toyota\Toyota\Views\AdminFile\Index.cshtml"
           Write(f);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 17 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\Toyota\Toyota\Views\AdminFile\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function onDirClick() {
            el = event.target;
            event.stopPropagation();

            // let dir = el.textContent.toString();
            let dir = event.target.dataset.dirname;
            console.log(""try get: "");
            dir = dir.trim();
            dir = dir.replaceAll('/', '~');
            dir = dir.replaceAll('\\', '~');
            console.log(dir);
            fetch(""/api/GetAdminFiles/"" + dir)
                .then(res => {
                    console.log(res.statusText);
                    return res.json();
                })
                .then(dirs => {
                    console.log(dirs);
                    let ul = document.createElement(""ul"");
                    dirs.map(dir => {
                        let li = document.createElement(""li"");
                        let span = document.createElement(""span"");
                        span.onclick = onDirClick;
                        span.dataset.dirname = dir;
      ");
                WriteLiteral(@"                  span.innerText = dir;
                        li.appendChild(span);
                        ul.appendChild(li);
                    })
                    el.appendChild(ul);
                })
                .catch(err => { console.log(""ERR:""); console.log(err); })
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
