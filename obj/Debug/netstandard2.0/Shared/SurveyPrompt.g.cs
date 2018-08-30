#pragma checksum "/Users/jfehrman/Development/rva_fun/Shared/SurveyPrompt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b077e14060797caee7bdbfbe20bcfffa67454721"
// <auto-generated/>
#pragma warning disable 1591
namespace rva_fun.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using rva_fun;
    using rva_fun.Shared;
    public class SurveyPrompt : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "alert alert-secondary mt-4");
            builder.AddAttribute(2, "role", "alert");
            builder.AddContent(3, "\n    ");
            builder.OpenElement(4, "span");
            builder.AddAttribute(5, "class", "oi oi-pencil mr-2");
            builder.AddAttribute(6, "aria-hidden", "true");
            builder.CloseElement();
            builder.AddContent(7, " \n    ");
            builder.OpenElement(8, "strong");
            builder.AddContent(9, Title);
            builder.CloseElement();
            builder.AddContent(10, "\n\n    ");
            builder.OpenElement(11, "span");
            builder.AddAttribute(12, "class", "text-nowrap");
            builder.AddContent(13, "\n        Please take our\n        ");
            builder.OpenElement(14, "a");
            builder.AddAttribute(15, "target", "_blank");
            builder.AddAttribute(16, "class", "font-weight-bold");
            builder.AddAttribute(17, "href", "https://go.microsoft.com/fwlink/?linkid=2006382");
            builder.AddContent(18, "brief survey");
            builder.CloseElement();
            builder.AddContent(19, "\n    ");
            builder.CloseElement();
            builder.AddContent(20, "\n    and tell us what you think.\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 12 "/Users/jfehrman/Development/rva_fun/Shared/SurveyPrompt.cshtml"
            
    [Parameter]
    string Title { get; set; } // Demonstrates how a parent component can supply parameters

#line default
#line hidden
    }
}
#pragma warning restore 1591
