#pragma checksum "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d4506c089998c7eae2a893f589ba4f45df2189e"
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
#line 1 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\_ViewImports.cshtml"
using CardDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\_ViewImports.cshtml"
using CardDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d4506c089998c7eae2a893f589ba4f45df2189e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fa1be686e57fbfdc6db0052e48337fb3c526412", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CardSet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Results</h1>\r\n\r\nDeck Id: ");
#nullable restore
#line 8 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\Home\Index.cshtml"
    Write(Model.deck_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\nRemaining: ");
#nullable restore
#line 10 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\Home\Index.cshtml"
      Write(Model.remaining);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d4506c089998c7eae2a893f589ba4f45df2189e4465", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 16 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\Home\Index.cshtml"
     for (int i = 0; i < Model.cards.Count(); i++)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>Suit: ");
#nullable restore
#line 18 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\Home\Index.cshtml"
              Write(Model.cards[i].suit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <div>Value: ");
#nullable restore
#line 19 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\Home\Index.cshtml"
               Write(Model.cards[i].value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <div>\r\n            <img");
                BeginWriteAttribute("src", " src=\"", 420, "\"", 447, 1);
#nullable restore
#line 21 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 426, Model.cards[i].image, 426, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n");
#nullable restore
#line 23 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\Home\Index.cshtml"

        string keepCard = "keep" + i;
        

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 596, "\"", 610, 1);
#nullable restore
#line 26 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 601, keepCard, 601, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 611, "\"", 631, 3);
                WriteAttributeValue("", 618, "keepIndex[", 618, 10, true);
#nullable restore
#line 26 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 628, i, 628, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 630, "]", 630, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 632, "\"", 642, 1);
#nullable restore
#line 26 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 640, i, 640, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <label");
                BeginWriteAttribute("for", " for=\"", 662, "\"", 677, 1);
#nullable restore
#line 27 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 668, keepCard, 668, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Keep Card?</label>\r\n");
                WriteLiteral("        <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 792, "\"", 812, 3);
                WriteAttributeValue("", 799, "hand[", 799, 5, true);
#nullable restore
#line 30 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 804, i, 804, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 806, "].suit", 806, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 813, "\"", 841, 1);
#nullable restore
#line 30 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 821, Model.cards[i].suit, 821, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 875, "\"", 896, 3);
                WriteAttributeValue("", 882, "hand[", 882, 5, true);
#nullable restore
#line 31 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 887, i, 887, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 889, "].value", 889, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 897, "\"", 926, 1);
#nullable restore
#line 31 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 905, Model.cards[i].value, 905, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 960, "\"", 981, 3);
                WriteAttributeValue("", 967, "hand[", 967, 5, true);
#nullable restore
#line 32 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 972, i, 972, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 974, "].image", 974, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 982, "\"", 1011, 1);
#nullable restore
#line 32 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 990, Model.cards[i].image, 990, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 33 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br />\r\n    <input type=\"submit\" value=\"Draw more cards\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-deckId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\Josh\source\repos\CardDemo\CardDemo\Views\Home\Index.cshtml"
                                             WriteLiteral(Model.deck_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["deckId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-deckId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["deckId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CardSet> Html { get; private set; }
    }
}
#pragma warning restore 1591