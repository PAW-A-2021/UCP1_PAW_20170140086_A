#pragma checksum "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e1ad2619e02217366de08516d7e66ad34b04eb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DataAnggotas_Details), @"mvc.1.0.view", @"/Views/DataAnggotas/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DataAnggotas/Details.cshtml", typeof(AspNetCore.Views_DataAnggotas_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e1ad2619e02217366de08516d7e66ad34b04eb9", @"/Views/DataAnggotas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6db955a32b37373ab40fbb320385050c9b6b154f", @"/Views/_ViewImports.cshtml")]
    public class Views_DataAnggotas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataVaksin.Models.DataAnggota>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 125, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>DataAnggota</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(209, 40, false);
#line 14 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nama));

#line default
#line hidden
            EndContext();
            BeginContext(249, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(293, 36, false);
#line 17 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nama));

#line default
#line hidden
            EndContext();
            BeginContext(329, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(373, 40, false);
#line 20 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Umur));

#line default
#line hidden
            EndContext();
            BeginContext(413, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(457, 36, false);
#line 23 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Umur));

#line default
#line hidden
            EndContext();
            BeginContext(493, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(537, 45, false);
#line 26 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pekerjaan));

#line default
#line hidden
            EndContext();
            BeginContext(582, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(626, 41, false);
#line 29 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pekerjaan));

#line default
#line hidden
            EndContext();
            BeginContext(667, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(711, 54, false);
#line 32 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TempatTanggalLahir));

#line default
#line hidden
            EndContext();
            BeginContext(765, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(809, 50, false);
#line 35 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Details.cshtml"
       Write(Html.DisplayFor(model => model.TempatTanggalLahir));

#line default
#line hidden
            EndContext();
            BeginContext(859, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(903, 48, false);
#line 38 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JenisKelamin));

#line default
#line hidden
            EndContext();
            BeginContext(951, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(995, 44, false);
#line 41 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Details.cshtml"
       Write(Html.DisplayFor(model => model.JenisKelamin));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1083, 47, false);
#line 44 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JenisVaksin));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1174, 43, false);
#line 47 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Details.cshtml"
       Write(Html.DisplayFor(model => model.JenisVaksin));

#line default
#line hidden
            EndContext();
            BeginContext(1217, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1261, 42, false);
#line 50 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Alamat));

#line default
#line hidden
            EndContext();
            BeginContext(1303, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1347, 38, false);
#line 53 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Alamat));

#line default
#line hidden
            EndContext();
            BeginContext(1385, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1429, 40, false);
#line 56 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Foto));

#line default
#line hidden
            EndContext();
            BeginContext(1469, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1513, 36, false);
#line 59 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Foto));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1596, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e1ad2619e02217366de08516d7e66ad34b04eb911461", async() => {
                BeginContext(1643, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "D:\KULIAH\Semester 5\Pengembangan Aplikasi Web\Pertemuan 8\DataVaksin\DataVaksin\Views\DataAnggotas\Details.cshtml"
                           WriteLiteral(Model.Nik);

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
            BeginContext(1651, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1659, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e1ad2619e02217366de08516d7e66ad34b04eb913819", async() => {
                BeginContext(1681, 12, true);
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
            BeginContext(1697, 10, true);
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
