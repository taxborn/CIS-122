#pragma checksum "/home/taxborn/Documents/Code/C#/FirstASPSpring2021/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c3bf339295c433db0dca980bd10b93050f5ae82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/home/taxborn/Documents/Code/C#/FirstASPSpring2021/Views/_ViewImports.cshtml"
using FirstASPSpring2021;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/taxborn/Documents/Code/C#/FirstASPSpring2021/Views/_ViewImports.cshtml"
using FirstASPSpring2021.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c3bf339295c433db0dca980bd10b93050f5ae82", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66872a091f480a600c6548ca1155e8ddc6163880", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/taxborn/Documents/Code/C#/FirstASPSpring2021/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n");
#nullable restore
#line 7 "/home/taxborn/Documents/Code/C#/FirstASPSpring2021/Views/Home/Index.cshtml"
 foreach(var song in ViewBag.ListOfSongs)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/taxborn/Documents/Code/C#/FirstASPSpring2021/Views/Home/Index.cshtml"
Write(Html.Raw(song.ToString()));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/taxborn/Documents/Code/C#/FirstASPSpring2021/Views/Home/Index.cshtml"
                              
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
