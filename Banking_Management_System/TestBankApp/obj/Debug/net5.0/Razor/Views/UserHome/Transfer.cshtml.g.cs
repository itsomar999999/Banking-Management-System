#pragma checksum "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\UserHome\Transfer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "715188a9a0996f08915229143cf92c47c1963acc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserHome_Transfer), @"mvc.1.0.view", @"/Views/UserHome/Transfer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"715188a9a0996f08915229143cf92c47c1963acc", @"/Views/UserHome/Transfer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a907b181cf7b74f74047f222484149f6fe95f317", @"/Views/_ViewImports.cshtml")]
    public class Views_UserHome_Transfer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataLayer.Models.Beneficiary>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Transfer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\UserHome\Transfer.cshtml"
  
    ViewData["Title"] = "Transfer";
    Layout = "~/Views/Shared/_UserLogoutLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "715188a9a0996f08915229143cf92c47c1963acc4378", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <!-- Bootstrap CSS -->
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "715188a9a0996f08915229143cf92c47c1963acc5923", async() => {
                WriteLiteral(@"
    <div class=""container d-flex align-items-center justify-content-center"" style=""background: #1ba6c6; border-radius: 15px; text-align: center; margin-top: 15px; height: 50px; ""><h3>Profile</h3></div>
    <div class=""container"" style=""margin-top: 50px;"">
        <table class=""table table-bordered table-striped table-hover"">

            <tbody style=""text-align: center;"" class=""table-secondary"">
                <tr class=""row"">

                    <td class=""col-6""><h5>");
#nullable restore
#line 67 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\UserHome\Transfer.cshtml"
                                     Write(Html.DisplayNameFor(model => model.BAccId));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></td>\r\n                    <td class=\"col-6\"><h5>");
#nullable restore
#line 68 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\UserHome\Transfer.cshtml"
                                     Write(Html.DisplayFor(model => model.BAccId));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></td>\r\n\r\n                </tr>\r\n                <tr class=\"row\">\r\n\r\n                    <td class=\"col-6\"><h5>");
#nullable restore
#line 73 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\UserHome\Transfer.cshtml"
                                     Write(Html.DisplayNameFor(model => model.BName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></td>\r\n                    <td class=\"col-6\"><h5>");
#nullable restore
#line 74 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\UserHome\Transfer.cshtml"
                                     Write(Html.DisplayFor(model => model.BName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></td>\r\n\r\n                </tr>\r\n                \r\n\r\n            </tbody>\r\n        </table>\r\n        <div class=\"d-flex justify-content-center align-items-center\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "715188a9a0996f08915229143cf92c47c1963acc8427", async() => {
                    WriteLiteral(@"
                <div class=""login__field"" style=""padding-top: 10px;padding-bottom: 0px;"">
                    <div class=""form-outline mb-4"">
                        <input type=""text"" name=""Amount"" placeholder=""Enter Amount"" class=""form-control"" style=""text-align:center;"" />
                    </div>

                </div>
                <div class=""form-outline mb-4 d-flex justify-content-center align-items-center"">
                    <button type=""submit"" class=""btn btn-primary"">Submit</button>
                </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>
        </div>

        <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p"" crossorigin=""anonymous""></script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataLayer.Models.Beneficiary> Html { get; private set; }
    }
}
#pragma warning restore 1591
