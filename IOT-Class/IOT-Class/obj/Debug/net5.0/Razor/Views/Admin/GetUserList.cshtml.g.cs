#pragma checksum "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\Admin\GetUserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63d779de39dd5838fb81f920d0d819f5f26b079a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetUserList), @"mvc.1.0.view", @"/Views/Admin/GetUserList.cshtml")]
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
#line 2 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\_ViewImports.cshtml"
using IOT_Class.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\Admin\GetUserList.cshtml"
using IOT_Class.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63d779de39dd5838fb81f920d0d819f5f26b079a", @"/Views/Admin/GetUserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47f5e88c271b6e8f72d50ae8d3dde59a82211966", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetUserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GetUserListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-pink btn-rounded waves-light waves-effect width-md"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/vendor.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/jquery-tabledit/jquery.tabledit.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/pages/tabledit.init.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/app.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\Admin\GetUserList.cshtml"
  
    ViewData["Title"] = "GetUserList";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-page"">
    <div class=""content"">

        <!-- Start Content-->
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card"">
                        <div class=""card-body"">

                            <h5 class=""header-title"">Kullanıcılar Listesi</h5>

                            <div class=""table-responsive"">
                                <table class=""table table-centered mb-0"" id=""btn-editable"">
                                    <thead>
                                        <tr>
                                            <th>#</th>
                                            <th>Ad-Soyad</th>
                                            <th>Kullanıcı Adı</th>
                                            <th>Email</th>
                                            <th> Sınıf</th>
                                            <th>Cihaz</th>
                                         ");
            WriteLiteral(@"   <th>Telefon</th>
                                            <th>Okul</th>
                                            <th>Kayıt Tarih</th>
                                            <th>Durum</th>
                                            <th>Düzenle</th>
                                            <th>Okul-Sınıf Ata</th>
                                            <th>Cihaz Ata</th>
                                            <th>Sil</th>
                                        </tr>
                                    </thead>

                                    <tbody>
");
#nullable restore
#line 42 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\Admin\GetUserList.cshtml"
                                         foreach (var item in Model.user)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 45 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\Admin\GetUserList.cshtml"
                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 46 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\Admin\GetUserList.cshtml"
                                           Write(item.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 47 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\Admin\GetUserList.cshtml"
                                           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 48 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\Admin\GetUserList.cshtml"
                                           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 49 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\Admin\GetUserList.cshtml"
                                           Write(Model.classe.Where(x => x.Id == item.Class.Id).FirstOrDefault().ClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 50 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\Admin\GetUserList.cshtml"
                                           Write(Model.device.Where(x=>x.Id==item.Device.Id).FirstOrDefault().DeviceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 51 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\Admin\GetUserList.cshtml"
                                           Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 52 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\Admin\GetUserList.cshtml"
                                           Write(Model.school.Where(x => x.Id == item.School.Id).FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 53 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\Admin\GetUserList.cshtml"
                                           Write(item.RegistrationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 54 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\Admin\GetUserList.cshtml"
                                           Write(item.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2860, "\"", 2893, 2);
            WriteAttributeValue("", 2867, "/Admin/UpdateUser/", 2867, 18, true);
#nullable restore
#line 55 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\Admin\GetUserList.cshtml"
WriteAttributeValue("", 2885, item.Id, 2885, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-purple btn-rounded waves-light waves-effect width-sm\">Düzenle</a></td>\r\n                                            <td> <a");
            BeginWriteAttribute("href", " href=\"", 3041, "\"", 3083, 2);
            WriteAttributeValue("", 3048, "/Admin/AssignSchoolForUser/", 3048, 27, true);
#nullable restore
#line 56 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\Admin\GetUserList.cshtml"
WriteAttributeValue("", 3075, item.Id, 3075, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-orange btn-rounded waves-light waves-effect width-md\">Okul-Sınıf Ata</a></td>\r\n                                            <td> <a");
            BeginWriteAttribute("href", " href=\"", 3238, "\"", 3280, 2);
            WriteAttributeValue("", 3245, "/Admin/AssignDeviceForUser/", 3245, 27, true);
#nullable restore
#line 57 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\Admin\GetUserList.cshtml"
WriteAttributeValue("", 3272, item.Id, 3272, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary btn-rounded waves-light waves-effect width-md\">Cihaz Ata</a></td>\r\n                                            <td><a");
            BeginWriteAttribute("href", " href=\"", 3430, "\"", 3463, 2);
            WriteAttributeValue("", 3437, "/Admin/DeleteUser/", 3437, 18, true);
#nullable restore
#line 58 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\Admin\GetUserList.cshtml"
WriteAttributeValue("", 3455, item.Id, 3455, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger btn-rounded waves-light waves-effect width-sm\">Sil</a></td>\r\n                                        </tr>\r\n");
#nullable restore
#line 60 "C:\Users\cemom\Desktop\IOT-Class\IOT-Class\Views\Admin\GetUserList.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tbody>\r\n                                </table>\r\n                               \r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63d779de39dd5838fb81f920d0d819f5f26b079a14252", async() => {
                WriteLiteral("Yeni Kullanıcı Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
    <!-- Vendor js -->
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63d779de39dd5838fb81f920d0d819f5f26b079a16185", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <!-- Table Editable plugin-->\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63d779de39dd5838fb81f920d0d819f5f26b079a17270", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <!-- Table editable init-->\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63d779de39dd5838fb81f920d0d819f5f26b079a18353", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <!-- App js -->\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63d779de39dd5838fb81f920d0d819f5f26b079a19424", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GetUserListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
