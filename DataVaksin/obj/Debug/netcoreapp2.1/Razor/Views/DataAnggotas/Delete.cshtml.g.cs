#pragma checksum "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "116cb2000a9a0b46cb75cce5739ea249cfa632d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DataAnggotas_Delete), @"mvc.1.0.view", @"/Views/DataAnggotas/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DataAnggotas/Delete.cshtml", typeof(AspNetCore.Views_DataAnggotas_Delete))]
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
#line 1 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\_ViewImports.cshtml"
using DataVaksin;

#line default
#line hidden
#line 2 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\_ViewImports.cshtml"
using DataVaksin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"116cb2000a9a0b46cb75cce5739ea249cfa632d2", @"/Views/DataAnggotas/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6db955a32b37373ab40fbb320385050c9b6b154f", @"/Views/_ViewImports.cshtml")]
    public class Views_DataAnggotas_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataVaksin.Models.DataAnggota>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(82, 172, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>DataAnggota</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(255, 40, false);
#line 15 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nama));

#line default
#line hidden
            EndContext();
            BeginContext(295, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(339, 36, false);
#line 18 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nama));

#line default
#line hidden
            EndContext();
            BeginContext(375, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(419, 40, false);
#line 21 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Umur));

#line default
#line hidden
            EndContext();
            BeginContext(459, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(503, 36, false);
#line 24 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Umur));

#line default
#line hidden
            EndContext();
            BeginContext(539, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(583, 45, false);
#line 27 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pekerjaan));

#line default
#line hidden
            EndContext();
            BeginContext(628, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(672, 41, false);
#line 30 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pekerjaan));

#line default
#line hidden
            EndContext();
            BeginContext(713, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(757, 54, false);
#line 33 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TempatTanggalLahir));

#line default
#line hidden
            EndContext();
            BeginContext(811, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(855, 50, false);
#line 36 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TempatTanggalLahir));

#line default
#line hidden
            EndContext();
            BeginContext(905, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(949, 48, false);
#line 39 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.JenisKelamin));

#line default
#line hidden
            EndContext();
            BeginContext(997, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1041, 44, false);
#line 42 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.JenisKelamin));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1129, 47, false);
#line 45 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.JenisVaksin));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1220, 43, false);
#line 48 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.JenisVaksin));

#line default
#line hidden
            EndContext();
            BeginContext(1263, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1307, 42, false);
#line 51 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Alamat));

#line default
#line hidden
            EndContext();
            BeginContext(1349, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1393, 38, false);
#line 54 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Alamat));

#line default
#line hidden
            EndContext();
            BeginContext(1431, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1475, 40, false);
#line 57 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Foto));

#line default
#line hidden
            EndContext();
            BeginContext(1515, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1559, 36, false);
#line 60 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Foto));

#line default
#line hidden
            EndContext();
            BeginContext(1595, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1633, 208, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "116cb2000a9a0b46cb75cce5739ea249cfa632d212185", async() => {
                BeginContext(1659, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1669, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "116cb2000a9a0b46cb75cce5739ea249cfa632d212578", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 65 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Nik);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1706, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1790, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "116cb2000a9a0b46cb75cce5739ea249cfa632d214520", async() => {
                    BeginContext(1812, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1828, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1841, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataVaksin.Models.DataAnggota> Html { get; private set; }
    }
}
#pragma warning restore 1591
