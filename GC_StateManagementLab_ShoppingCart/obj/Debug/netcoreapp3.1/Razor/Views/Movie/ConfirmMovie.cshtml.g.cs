#pragma checksum "C:\Users\millr\source\repos\GC_StateManagementLab_ShoppingCart\GC_StateManagementLab_ShoppingCart\Views\Movie\ConfirmMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bee133277eebec0fe8340d54e1b2bfbe7a11c45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_ConfirmMovie), @"mvc.1.0.view", @"/Views/Movie/ConfirmMovie.cshtml")]
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
#line 1 "C:\Users\millr\source\repos\GC_StateManagementLab_ShoppingCart\GC_StateManagementLab_ShoppingCart\Views\_ViewImports.cshtml"
using GC_StateManagementLab_ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\millr\source\repos\GC_StateManagementLab_ShoppingCart\GC_StateManagementLab_ShoppingCart\Views\_ViewImports.cshtml"
using GC_StateManagementLab_ShoppingCart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bee133277eebec0fe8340d54e1b2bfbe7a11c45", @"/Views/Movie/ConfirmMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3bc14c67401c5e2296599d91d309da5718e1251", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_ConfirmMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\millr\source\repos\GC_StateManagementLab_ShoppingCart\GC_StateManagementLab_ShoppingCart\Views\Movie\ConfirmMovie.cshtml"
  
    ViewData["Title"] = "AddToCart";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\millr\source\repos\GC_StateManagementLab_ShoppingCart\GC_StateManagementLab_ShoppingCart\Views\Movie\ConfirmMovie.cshtml"
 if (Model[0] == "Movie already in cart!")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Confirm Selection</h1>\r\n    <h4>");
#nullable restore
#line 10 "C:\Users\millr\source\repos\GC_StateManagementLab_ShoppingCart\GC_StateManagementLab_ShoppingCart\Views\Movie\ConfirmMovie.cshtml"
   Write(Model[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 11 "C:\Users\millr\source\repos\GC_StateManagementLab_ShoppingCart\GC_StateManagementLab_ShoppingCart\Views\Movie\ConfirmMovie.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Confirm Selection</h1>\r\n    <h4>Selected Movie: ");
#nullable restore
#line 15 "C:\Users\millr\source\repos\GC_StateManagementLab_ShoppingCart\GC_StateManagementLab_ShoppingCart\Views\Movie\ConfirmMovie.cshtml"
                   Write(Model[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <p><b>Rental Price: </b>");
#nullable restore
#line 16 "C:\Users\millr\source\repos\GC_StateManagementLab_ShoppingCart\GC_StateManagementLab_ShoppingCart\Views\Movie\ConfirmMovie.cshtml"
                       Write(Model[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <a");
            BeginWriteAttribute("href", " href=\"", 294, "\"", 332, 2);
            WriteAttributeValue("", 301, "/Movie/AddToCart?name=", 301, 22, true);
#nullable restore
#line 16 "C:\Users\millr\source\repos\GC_StateManagementLab_ShoppingCart\GC_StateManagementLab_ShoppingCart\Views\Movie\ConfirmMovie.cshtml"
WriteAttributeValue("", 323, Model[0], 323, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add Rental to Cart</a></p>\r\n");
#nullable restore
#line 17 "C:\Users\millr\source\repos\GC_StateManagementLab_ShoppingCart\GC_StateManagementLab_ShoppingCart\Views\Movie\ConfirmMovie.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p><a href=\"/Movie/ViewMovies\">Return to Movie Selection</a></p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
