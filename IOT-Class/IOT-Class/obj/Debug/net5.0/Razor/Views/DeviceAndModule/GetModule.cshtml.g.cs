#pragma checksum "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\DeviceAndModule\GetModule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4028c4cfaa5d16b3fafd9cedea775b4bb977898"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DeviceAndModule_GetModule), @"mvc.1.0.view", @"/Views/DeviceAndModule/GetModule.cshtml")]
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
#line 1 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\_ViewImports.cshtml"
using IOT_Class;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\DeviceAndModule\GetModule.cshtml"
using IOT_Class.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4028c4cfaa5d16b3fafd9cedea775b4bb977898", @"/Views/DeviceAndModule/GetModule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47f5e88c271b6e8f72d50ae8d3dde59a82211966", @"/Views/_ViewImports.cshtml")]
    public class Views_DeviceAndModule_GetModule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Module>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DeviceAndModule", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetModule", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddModule", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-icon waves-effect waves-light btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\DeviceAndModule\GetModule.cshtml"
  
    ViewData["Title"] = "GetModule";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-page"">
    <div class=""content"">

        <!-- Start Content-->
        <div class=""container-fluid"">

            <!-- start page title -->
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""page-title-box"">
                        <div class=""page-title-right"">
                            <ol class=""breadcrumb m-0"">
                                <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4028c4cfaa5d16b3fafd9cedea775b4bb9778985163", async() => {
                WriteLiteral("Modül");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                            </ol>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card"">
                        <div class=""card-body"">

                            <h5 class=""header-title"">Modüller Listesi</h5>
                            <div class=""table-responsive"">
                                <table class=""table table-centered mb-0"" id=""btn-editable"">
                                    <thead>
                                        <tr>
                                            <th>#</th>
                                            <th>Modül Adı</th>
                                            <th>Dijital Minimum Değeri</th>
                                            <th>Dijital Maksimum Değeri</th>
                                            <th>Analog Maksimum Değeri</th>
                                            ");
            WriteLiteral(@"<th>Analog Maksimum Değeri</th>
                                            <th>Durumu</th>
                                            <th>Düzenle</th>
                                            <th>Sil</th>
                                        </tr>
                                    </thead>

                                    <tbody>
");
#nullable restore
#line 50 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\DeviceAndModule\GetModule.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 53 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\DeviceAndModule\GetModule.cshtml"
                                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 54 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\DeviceAndModule\GetModule.cshtml"
                                               Write(item.ModuleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 55 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\DeviceAndModule\GetModule.cshtml"
                                               Write(item.DigitalMinValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 56 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\DeviceAndModule\GetModule.cshtml"
                                               Write(item.DigitalMaxValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 57 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\DeviceAndModule\GetModule.cshtml"
                                               Write(item.AnalogMinValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 58 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\DeviceAndModule\GetModule.cshtml"
                                               Write(item.AnalogMaxValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 59 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\DeviceAndModule\GetModule.cshtml"
                                               Write(item.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                \r\n                                                <td><a");
            BeginWriteAttribute("href", " href=\"", 2849, "\"", 2892, 2);
            WriteAttributeValue("", 2856, "/DeviceAndModule/EditModule/", 2856, 28, true);
#nullable restore
#line 61 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\DeviceAndModule\GetModule.cshtml"
WriteAttributeValue("", 2884, item.Id, 2884, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-icon waves-effect waves-light btn-warning\"> <i class=\"fas fa-wrench\"></i> </a></td>\r\n                                                <td><a");
            BeginWriteAttribute("href", " href=\"", 3048, "\"", 3093, 2);
            WriteAttributeValue("", 3055, "/DeviceAndModule/DeleteModule/", 3055, 30, true);
#nullable restore
#line 62 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\DeviceAndModule\GetModule.cshtml"
WriteAttributeValue("", 3085, item.Id, 3085, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-icon waves-effect waves-light btn-danger\"> <i class=\"fas fa-times\"></i> </a></td>\r\n                                            </tr>\r\n");
#nullable restore
#line 64 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\DeviceAndModule\GetModule.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tbody>\r\n                                </table>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4028c4cfaa5d16b3fafd9cedea775b4bb97789812251", async() => {
                WriteLiteral(" Yeni Modül Ekle ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <!-- end .table-responsive-->
                        </div>
                        <!-- end card-body -->
                    </div>
                    <!-- end card -->
                </div>
                <!-- end col -->
            </div>
            <!-- end row -->

        </div>
        <!-- end container-fluid -->

    </div>
    <!-- end content -->
</div>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Module>> Html { get; private set; }
    }
}
#pragma warning restore 1591
