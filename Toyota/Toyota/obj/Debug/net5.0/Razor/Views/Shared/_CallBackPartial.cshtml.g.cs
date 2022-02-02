#pragma checksum "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\Toyota\Toyota\Views\Shared\_CallBackPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "588fb8291ac6b56960f5ade36d87506a5376946b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CallBackPartial), @"mvc.1.0.view", @"/Views/Shared/_CallBackPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"588fb8291ac6b56960f5ade36d87506a5376946b", @"/Views/Shared/_CallBackPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d20eaa3efef274dfb0cd425bd231ced5df79e5ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CallBackPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""callBack"">
    <div class=""input-group mb-3 m-3 div-input"">
        <span class=""input-group-text"">Name</span>
        <input type=""text"" class=""form-control"" id=""callbackName"" />
    </div>

    <div class=""input-group mb-3 m-3 div-input"">
        <span class=""input-group-text"">Phone</span>
        <input type=""text"" class=""form-control"" id=""callbackPhone"" />
    </div>

    <input type=""button"" class=""btn btn-primary m-3"" id=""callbackSend"" value=""Send"" />
</div>

<style>
    .div-input{
        width:300px;
    }
</style>

<script>
    document.getElementById(""callbackSend"").onclick = function () {
        let callBack = {
            Name: document.getElementById(""callbackName"").value,
            Phone: document.getElementById(""callbackPhone"").value
        }

        fetch(""/api/StoreCallBack"", {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(callBack)
  ");
            WriteLiteral("      })\r\n            .then(res => { console.log(res); return res.json() })\r\n            .then(cb => console.log(cb))\r\n            .catch(err => console.log(err));\r\n\r\n        console.log(callBack);\r\n    }\r\n</script>\r\n");
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
