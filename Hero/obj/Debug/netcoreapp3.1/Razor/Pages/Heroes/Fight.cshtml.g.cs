#pragma checksum "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Heroes\Fight.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdc8197f160b51d2e4e43ab68b47add5fb0319d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Hero.Pages.Heroes.Pages_Heroes_Fight), @"mvc.1.0.razor-page", @"/Pages/Heroes/Fight.cshtml")]
namespace Hero.Pages.Heroes
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
#line 1 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\_ViewImports.cshtml"
using Hero;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Heroes\Fight.cshtml"
using Hero.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdc8197f160b51d2e4e43ab68b47add5fb0319d3", @"/Pages/Heroes/Fight.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec7b117b1eb581ce631b326146449a1b396ac486", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Heroes_Fight : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"container\">\r\n\t<div class=\"text-center bg-blur\">\r\n\t\t<h1>Fight</h1>\r\n\t\t<div>\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-md-4\">\r\n");
#nullable restore
#line 13 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Heroes\Fight.cshtml"
                     if (Model.attackHero.Gender.Equals(Gender.Male))
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<img src=\"/img/male.jpg\" alt=\"photo\" class=\"align-middle\" width=\"150px\" height=\"250\" />\r\n");
#nullable restore
#line 16 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Heroes\Fight.cshtml"
					}
					else
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<img src=\"/img/female.jpg\" alt=\"photo\" class=\"align-middle\" width=\"150px\" height=\"250\" />\r\n");
#nullable restore
#line 20 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Heroes\Fight.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t\t\t<h3 class=\"align-middle\">");
#nullable restore
#line 23 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Heroes\Fight.cshtml"
                                        Write(Model.attackHero.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t\t\t\t\t<h3 class=\"align-middle\">");
#nullable restore
#line 24 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Heroes\Fight.cshtml"
                                        Write(Model.attackerPoints);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-md-4\">\r\n\t\t\t\t\t<h2>VS</h2>\r\n\t\t\t\t\t<h2 >");
#nullable restore
#line 28 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Heroes\Fight.cshtml"
                    Write(Model.winner);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\t\t\t\t\t<a class=\"btn btn-info\" href=\"/Index\">Back to Arena</a>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-md-4\">\r\n");
#nullable restore
#line 32 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Heroes\Fight.cshtml"
                     if (Model.deffenceHero.Gender.Equals(Gender.Male))
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<img src=\"/img/male.jpg\" alt=\"photo\" class=\"align-middle\" width=\"150px\" height=\"250\" />\r\n");
#nullable restore
#line 35 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Heroes\Fight.cshtml"
					}
					else
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<img src=\"/img/female.jpg\" alt=\"photo\" class=\"align-middle\" width=\"150px\" height=\"250\" />\r\n");
#nullable restore
#line 39 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Heroes\Fight.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t\t\t<h3 class=\"align-middle\">");
#nullable restore
#line 42 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Heroes\Fight.cshtml"
                                        Write(Model.deffenceHero.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t\t\t\t\t<h3 class=\"align-middle\">");
#nullable restore
#line 43 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Heroes\Fight.cshtml"
                                        Write(Model.deffenderPoints);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hero.Pages.Heroes.FightModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Hero.Pages.Heroes.FightModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Hero.Pages.Heroes.FightModel>)PageContext?.ViewData;
        public Hero.Pages.Heroes.FightModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
