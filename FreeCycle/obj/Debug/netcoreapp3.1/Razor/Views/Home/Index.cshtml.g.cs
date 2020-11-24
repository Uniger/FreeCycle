#pragma checksum "C:\Users\Simon\Source\Repos\FreeCycle\FreeCycle\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7557c2b5d6f58f0a9edf9a01cb29a149b05f3372"
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
#line 1 "C:\Users\Simon\Source\Repos\FreeCycle\FreeCycle\Views\_ViewImports.cshtml"
using FreeCycle;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Simon\Source\Repos\FreeCycle\FreeCycle\Views\_ViewImports.cshtml"
using FreeCycle.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7557c2b5d6f58f0a9edf9a01cb29a149b05f3372", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"799a20efbee2bbd4f559790a7ae0e9b8d16ac025", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Simon\Source\Repos\FreeCycle\FreeCycle\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main role=""main"">

    <div class=""text-center"">
        <img src=""/Imagenes/FreeCycle.png"" class=""rounded-circle"" height=""162"" width=""377"" />
    </div>

    <div class=""text-center"">
        <h1 class=""display-4"">Welcome!</h1>
    </div>

    <br/>

    <div class=""jumbotron"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <p style=""text-align: justify"">
                        In FreeCycle, we want you to connect with other people that have similar needs.<br />
                        Have you ever wanted to donate something that you don't use anymore?, however you don't know who might want it or maybe your situation is different and you're looking for something, but before wasting money on it, you wonder if someone could have that item and is looking to donate it?. <br />
                    </p>
                    <img src=""/Imagenes/Donacion.png"" height=""100"" width=""500"" />
                </div>
        ");
            WriteLiteral(@"        <div class=""col-md-6"">
                    <p style=""text-align: justify"">
                        If that's your case we introduce you FreeCycle, a website where you can post your donation offers or your donation requests, all we need is your location, the item description and if you're offering, the status of the item, so people that are looking to take that offer or donating your request can easily deal the donation.
                        <br />
                        <br />
                        Let's get started!
                        <br />
                        <br />
                    </p>
                    <div class=""text-center"">
                        <p><a class=""btn btn-info text-white btn-lg btn-block"" href=""/Home/InicioSesion"" role=""button"">Sign In &raquo;</a></p>
                    </div>                  
                </div>
            </div>
        </div> <!-- /container -->  
    </div>

</main>







");
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
