#pragma checksum "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "705ec7b2a59e40f394dd315fe91f9d8a74bab610"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminLanches_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminLanches/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AdminLanches/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_AdminLanches_Index))]
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
#line 1 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\_ViewImports.cshtml"
using AppLanches;

#line default
#line hidden
#line 2 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\_ViewImports.cshtml"
using AppLanches.Models;

#line default
#line hidden
#line 3 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\_ViewImports.cshtml"
using AppLanches.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"705ec7b2a59e40f394dd315fe91f9d8a74bab610", @"/Areas/Admin/Views/AdminLanches/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef14c0b65b6b87497018f1f7ef76875178bd4c8e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminLanches_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppLanches.Models.Lanche>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Criar novo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(89, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(118, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6881cd8f23e49228a48ffa1caa922d4", async() => {
                BeginContext(160, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(174, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(267, 40, false);
#line 16 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(307, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(363, 50, false);
#line 19 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DescricaoCurta));

#line default
#line hidden
            EndContext();
            BeginContext(413, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(469, 54, false);
#line 22 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DescricaoDetalhada));

#line default
#line hidden
            EndContext();
            BeginContext(523, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(579, 41, false);
#line 25 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Preco));

#line default
#line hidden
            EndContext();
            BeginContext(620, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(676, 45, false);
#line 28 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ImagemUrl));

#line default
#line hidden
            EndContext();
            BeginContext(721, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(777, 54, false);
#line 31 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ImagemThumbnailUrl));

#line default
#line hidden
            EndContext();
            BeginContext(831, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(887, 53, false);
#line 34 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsLanchePreferido));

#line default
#line hidden
            EndContext();
            BeginContext(940, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(996, 45, false);
#line 37 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmEstoque));

#line default
#line hidden
            EndContext();
            BeginContext(1041, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1097, 45, false);
#line 40 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Categoria));

#line default
#line hidden
            EndContext();
            BeginContext(1142, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 46 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1260, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1309, 39, false);
#line 49 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1348, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1404, 49, false);
#line 52 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DescricaoCurta));

#line default
#line hidden
            EndContext();
            BeginContext(1453, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1509, 53, false);
#line 55 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DescricaoDetalhada));

#line default
#line hidden
            EndContext();
            BeginContext(1562, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1618, 40, false);
#line 58 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Preco));

#line default
#line hidden
            EndContext();
            BeginContext(1658, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1714, 44, false);
#line 61 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ImagemUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1758, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1814, 53, false);
#line 64 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ImagemThumbnailUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1867, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1923, 52, false);
#line 67 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsLanchePreferido));

#line default
#line hidden
            EndContext();
            BeginContext(1975, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2031, 44, false);
#line 70 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmEstoque));

#line default
#line hidden
            EndContext();
            BeginContext(2075, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2131, 56, false);
#line 73 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Categoria.CategoriaId));

#line default
#line hidden
            EndContext();
            BeginContext(2187, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2242, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48012d027fa94fdc8e10ee32465cd125", async() => {
                BeginContext(2293, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
                                       WriteLiteral(item.LancheId);

#line default
#line hidden
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
            EndContext();
            BeginContext(2301, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2321, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "677f566416c1497d8559bdcbeefbc521", async() => {
                BeginContext(2375, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
                                          WriteLiteral(item.LancheId);

#line default
#line hidden
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
            EndContext();
            BeginContext(2386, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2406, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e04bba7912b43f79bde37a87d1bd340", async() => {
                BeginContext(2459, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
                                         WriteLiteral(item.LancheId);

#line default
#line hidden
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
            EndContext();
            BeginContext(2469, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 81 "C:\Users\caio_\Projects\AppLanches\AppLanches\Areas\Admin\Views\AdminLanches\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2508, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppLanches.Models.Lanche>> Html { get; private set; }
    }
}
#pragma warning restore 1591
