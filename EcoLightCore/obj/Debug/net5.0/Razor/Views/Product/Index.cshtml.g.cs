#pragma checksum "D:\C# projects\EcoLightCore\EcoLightCore\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dede36c88b19ee13a3acd408878cdaf08c05f03b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "D:\C# projects\EcoLightCore\EcoLightCore\Views\_ViewImports.cshtml"
using EcoLightCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C# projects\EcoLightCore\EcoLightCore\Views\_ViewImports.cshtml"
using EcoLightCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C# projects\EcoLightCore\EcoLightCore\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dede36c88b19ee13a3acd408878cdaf08c05f03b", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2891cf33ef7328ce8123cdeaefdf8dd00359121f", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dede36c88b19ee13a3acd408878cdaf08c05f03b3986", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<br />

<div class=""container-fluid"">
    <table id=""tbl1"" class=""table table-bordered"" style=""margin-top:20px"">
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Brand</th>
                <th>Descrtiptionvv</th>
                <th>Lumens </th>
                <th>Watt</th>
                <th>Stock</th>
                <th>Delete</th>
                <th>Update</th>
                <th>Detalis</th>
            </tr>
        </thead>
");
#nullable restore
#line 25 "D:\C# projects\EcoLightCore\EcoLightCore\Views\Product\Index.cshtml"
         foreach (var pr in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 28 "D:\C# projects\EcoLightCore\EcoLightCore\Views\Product\Index.cshtml"
               Write(pr.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>");
#nullable restore
#line 30 "D:\C# projects\EcoLightCore\EcoLightCore\Views\Product\Index.cshtml"
               Write(pr.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "D:\C# projects\EcoLightCore\EcoLightCore\Views\Product\Index.cshtml"
               Write(pr.Brand.BrandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "D:\C# projects\EcoLightCore\EcoLightCore\Views\Product\Index.cshtml"
               Write(pr.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "D:\C# projects\EcoLightCore\EcoLightCore\Views\Product\Index.cshtml"
               Write(pr.Lumens);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "D:\C# projects\EcoLightCore\EcoLightCore\Views\Product\Index.cshtml"
               Write(pr.Watt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "D:\C# projects\EcoLightCore\EcoLightCore\Views\Product\Index.cshtml"
               Write(pr.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 989, "\"", 1025, 2);
            WriteAttributeValue("", 996, "/Product/Delete/", 996, 16, true);
#nullable restore
#line 36 "D:\C# projects\EcoLightCore\EcoLightCore\Views\Product\Index.cshtml"
WriteAttributeValue("", 1012, pr.ProductID, 1012, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" style=\"width:100%\">Delete</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1108, "\"", 1148, 2);
            WriteAttributeValue("", 1115, "/Product/GetProduct/", 1115, 20, true);
#nullable restore
#line 37 "D:\C# projects\EcoLightCore\EcoLightCore\Views\Product\Index.cshtml"
WriteAttributeValue("", 1135, pr.ProductID, 1135, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\" style=\"width:100%\">Update</a></td>\r\n                <td><a href\"\" class=\"btn btn-info\" style=\"width:100%\">Detalis</a></td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 41 "D:\C# projects\EcoLightCore\EcoLightCore\Views\Product\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
</div>

<a href=""/Product/Add"" class=""btn btn-info"">Add</a>

<script src=""//ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js""></script>
<link href=""https://cdn.datatables.net/responsive/2.1.1/css/responsive.bootstrap.min.css"" rel=""stylesheet"" />
<script src=""https://cdn.datatables.net/1.10.15/js/dataTables.bootstrap4.min.js ""></script>
<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.11.3/css/jquery.dataTables.css"">
<script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.11.3/js/jquery.dataTables.js""></script>

<script>
    $('#tbl1').dataTable();
</script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
