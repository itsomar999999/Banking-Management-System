#pragma checksum "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b13c585289f7c4df238d18f33f3fd7f4d05dd9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManagerHome_Details), @"mvc.1.0.view", @"/Views/ManagerHome/Details.cshtml")]
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
#line 1 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\_ViewImports.cshtml"
using TestBankApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\_ViewImports.cshtml"
using TestBankApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b13c585289f7c4df238d18f33f3fd7f4d05dd9c", @"/Views/ManagerHome/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a907b181cf7b74f74047f222484149f6fe95f317", @"/Views/_ViewImports.cshtml")]
    public class Views_ManagerHome_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataLayer.Models.CustomerDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewTransactHist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewAllUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_AdminLogoutLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b13c585289f7c4df238d18f33f3fd7f4d05dd9c5622", async() => {
                WriteLiteral(@"
      
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

     
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">


    <style>
        body {
            background: linear-gradient(270deg, #ad9ee5, #faaca8);
        }

        button {
            display: flex;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b13c585289f7c4df238d18f33f3fd7f4d05dd9c7121", async() => {
                WriteLiteral(@"
    <div class=""container d-flex align-items-center justify-content-center"" style=""background: #1ba6c6; border-radius: 15px; text-align: center; margin-top: 15px; height: 50px; ""><h3>Profile</h3></div>
    <div class=""container"" style=""margin-top: 50px;"">
        <table class=""table table-bordered table-striped table-hover"">

            <tbody style=""text-align: center;"" class=""table-secondary"">
                <tr class=""row"">

                    <td class=""col-6""><h5>");
#nullable restore
#line 92 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\Details.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Fname));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></td>\r\n                    <td class=\"col-6\"><h5>");
#nullable restore
#line 93 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\Details.cshtml"
                                     Write(Html.DisplayFor(model => model.Fname));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></td>\r\n\r\n                </tr>\r\n                <tr class=\"row\">\r\n\r\n                    <td class=\"col-6\"><h5>");
#nullable restore
#line 98 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\Details.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Lname));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></td>\r\n                    <td class=\"col-6\"><h5>");
#nullable restore
#line 99 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\Details.cshtml"
                                     Write(Html.DisplayFor(model => model.Lname));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></td>\r\n\r\n                </tr>\r\n                <tr class=\"row\">\r\n\r\n                    <td class=\"col-6\"><h5>");
#nullable restore
#line 104 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\Details.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></td>\r\n                    <td class=\"col-6\"><h5>");
#nullable restore
#line 105 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\Details.cshtml"
                                     Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></td>\r\n\r\n                </tr>\r\n                <tr class=\"row\">\r\n\r\n                    <td class=\"col-6\"><h5>");
#nullable restore
#line 110 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\Details.cshtml"
                                     Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></td>\r\n                    <td class=\"col-6\"><h5>");
#nullable restore
#line 111 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\Details.cshtml"
                                     Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></td>\r\n\r\n                </tr>\r\n                <tr class=\"row\">\r\n\r\n                    <td class=\"col-6\"><h5>");
#nullable restore
#line 116 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\Details.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Pan));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></td>\r\n                    <td class=\"col-6\"><h5>");
#nullable restore
#line 117 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\Details.cshtml"
                                     Write(Html.DisplayFor(model => model.Pan));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></td>\r\n\r\n                </tr>\r\n                <tr class=\"row\">\r\n\r\n                    <td class=\"col-6\"><h5>");
#nullable restore
#line 122 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\Details.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Aadhaar));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></td>\r\n                    <td class=\"col-6\"><h5>");
#nullable restore
#line 123 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\Details.cshtml"
                                     Write(Html.DisplayFor(model => model.Aadhaar));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></td>\r\n\r\n                </tr>\r\n                <tr class=\"row\">\r\n\r\n                    <td class=\"col-6\"><h5>");
#nullable restore
#line 128 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\Details.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></td>\r\n                    <td class=\"col-6\"><h5>");
#nullable restore
#line 129 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\Details.cshtml"
                                     Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></td>\r\n\r\n                </tr>\r\n\r\n            </tbody>\r\n        </table>\r\n        <div class=\"d-flex justify-content-center align-items-center\">\r\n\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b13c585289f7c4df238d18f33f3fd7f4d05dd9c13846", async() => {
                    WriteLiteral("View Transaction History");
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
#nullable restore
#line 137 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\Details.cshtml"
                                               WriteLiteral(Model.CusId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b13c585289f7c4df238d18f33f3fd7f4d05dd9c16267", async() => {
                    WriteLiteral("Back");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n\r\n\r\n        <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p\" crossorigin=\"anonymous\"></script>\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataLayer.Models.CustomerDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
