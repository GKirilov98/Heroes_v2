#pragma checksum "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2887cc20a3e13415641ddd6c99c337f507dbf53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Hero.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Hero.Pages
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
#line 7 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Index.cshtml"
using Hero.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2887cc20a3e13415641ddd6c99c337f507dbf53", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec7b117b1eb581ce631b326146449a1b396ac486", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Heroes/Fight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Index.cshtml"
  
	ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Index.cshtml"
 if (Program.currUser == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"	<div class=""container"">
		<h1>Welcome to Victorious Arena</h1>
		<hr class=""my-3"" />
		<p class=""h4"">The most furious arena on the web</p>
		<p class=""h4"">You will find many strong enemies but only the best will survive</p>
		<hr class=""my-3"" />
		<h3>
			<a href=""/Users/Login"">Login</a> if you have an account or
			<a href=""/Users/Create"">Register</a> now and meet the greatest heroes of all time.
		</h3>
	</div>
");
#nullable restore
#line 22 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Index.cshtml"
}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"text-center mb-3\">\r\n\t\t<h4 class=\"text-white mt-2\">Welcome to the arena, ");
#nullable restore
#line 27 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Index.cshtml"
                                                     Write(Program.currUser.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(" !</h4>\r\n\t</div>\r\n\t<hr class=\"my-3\" />\r\n\t<div class=\"container\">\r\n");
#nullable restore
#line 31 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Index.cshtml"
         if (Program.currHero == null)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"text-center\">\r\n\t\t\t\t<h2>");
#nullable restore
#line 34 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Index.cshtml"
               Write(Program.currUser.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(", you don\'t have a hero. Click below and create one.</h2>\r\n\t\t\t\t<a href=\"/Heroes/Create\" class=\"btn btn-secondary\">Create hero</a>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 37 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Index.cshtml"
		}
		else
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"text-center\">\r\n\t\t\t\t<h2>You are ready! Choose hero to begin epic battle!</h2>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 43 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Index.cshtml"
             foreach (var hero in Model.Heroes)
			{
	

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"row flex-md-row m-2\">\r\n\t\t\t<div class=\"col text-center\">\r\n");
#nullable restore
#line 48 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Index.cshtml"
                 if (hero.Gender.Equals(Gender.Male))
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<img src=\"/img/male.jpg\" alt=\"photo\" class=\"align-middle\" width=\"150\" />\r\n");
#nullable restore
#line 51 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Index.cshtml"
				}
				else
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<img src=\"/img/female.jpg\" alt=\"photo\" class=\"align-middle\" width=\"150\" />\r\n");
#nullable restore
#line 55 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<h2 class=\"text-white\">");
#nullable restore
#line 56 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Index.cshtml"
                                  Write(hero.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2887cc20a3e13415641ddd6c99c337f507dbf537936", async() => {
                WriteLiteral("Fight");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Index.cshtml"
                                                                      WriteLiteral(hero.HeroEId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
            WriteLiteral("\t<div class=\"mb-5\"></div>\r\n\t<div class=\"mb-3\"></div>\r\n");
#nullable restore
#line 63 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Index.cshtml"
         

		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n");
#nullable restore
#line 67 "C:\UNWE\Technologies for web applications development\Project\Hero\Hero\Pages\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
