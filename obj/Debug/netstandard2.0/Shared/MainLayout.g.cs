#pragma checksum "/Users/jfehrman/Development/rva_fun/Shared/MainLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd7535226f0054c055f0dcaa6d991e5f9f4ccc5e"
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
    public class MainLayout : BlazorLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "main");
            builder.AddContent(2, "\n    ");
            builder.OpenComponent<rva_fun.Shared.NavMenu>(3);
            builder.CloseComponent();
            builder.AddContent(4, "\n    ");
            builder.OpenElement(5, "div");
            builder.AddAttribute(6, "class", "container content px-4");
            builder.AddContent(7, "\n        ");
            builder.AddContent(8, Body);
            builder.AddContent(9, "\n    ");
            builder.CloseElement();
            builder.AddContent(10, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
