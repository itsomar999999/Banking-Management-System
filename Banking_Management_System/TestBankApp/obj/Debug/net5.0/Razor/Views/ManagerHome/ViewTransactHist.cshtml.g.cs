#pragma checksum "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\ViewTransactHist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "794f213088d32ab26c8f764ecdcec17e6cc43021"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManagerHome_ViewTransactHist), @"mvc.1.0.view", @"/Views/ManagerHome/ViewTransactHist.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"794f213088d32ab26c8f764ecdcec17e6cc43021", @"/Views/ManagerHome/ViewTransactHist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a907b181cf7b74f74047f222484149f6fe95f317", @"/Views/_ViewImports.cshtml")]
    public class Views_ManagerHome_ViewTransactHist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataLayer.Models.TransactionHistory>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewTransactHist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\ViewTransactHist.cshtml"
  
    ViewData["Title"] = "ViewTransactHist";
    Layout = "~/Views/Shared/_AdminLogoutLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "794f213088d32ab26c8f764ecdcec17e6cc430214481", async() => {
                WriteLiteral(@"

    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">


    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">

    <title>Hello, world!</title>
    <style>
        body {
            background: linear-gradient(270deg, #ddd6f3, #faaca8);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "794f213088d32ab26c8f764ecdcec17e6cc430215942", async() => {
                WriteLiteral(@"
    <div class=""container d-flex align-items-center justify-content-center"" style="" background-color: #1ba6c6; text-align: center; margin-top: 15px; height: 50px; border-radius: 15px;"">
        <h3>Transaction History</h3>
    </div>

    <div class=""container"" style=""margin-top: 50px; margin-bottom:150px;"">
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "794f213088d32ab26c8f764ecdcec17e6cc430216530", async() => {
                    WriteLiteral(@"
            <div class=""row"">
                <div class=""col-4"" style=""width:315px;"">
                    <div class=""form-outline mb-4"">
                        <table>
                            <tr style=""text-align: center;"">
                                <td>
                                    <h5>From</h5>
                                </td>
                                <td>
                                    <h5>To</h5>
                                </td>
                            </tr>
                            <tr>
                                <td>

                                    <input type=""date"" name=""Date1"" style=""border-radius:5px; border:1px solid black"" />

                                </td>

                                <td>

                                    <input type=""date"" name=""Date2"" style=""border-radius: 5px; border: 1px solid black"" />


                                </td>

                            </tr>

           ");
                    WriteLiteral(@"             </table>
                    </div>
                </div>
                <div class=""col-2"">
                    <div class=""form-outline mb-4"">
                        <button style=""margin-top: 32px;"" class=""btn btn-primary"" type=""submit"">Search</button>
                    </div>
                </div>

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
                WriteLiteral("\r\n        <table class=\"table table-bordered table-striped table-hover\">\r\n            <thead class=\"table-primary\" style=\"text-align: center;\">\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 141 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\ViewTransactHist.cshtml"
                   Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 144 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\ViewTransactHist.cshtml"
                   Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 147 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\ViewTransactHist.cshtml"
                   Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 150 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\ViewTransactHist.cshtml"
                   Write(Html.DisplayNameFor(model => model.Receiver));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 153 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\ViewTransactHist.cshtml"
                   Write(Html.DisplayNameFor(model => model.Balance));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 156 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\ViewTransactHist.cshtml"
                   Write(Html.DisplayNameFor(model => model.Acc));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n\r\n                </tr>\r\n            </thead>\r\n            <tbody style=\"text-align: center;\" class=\"table-secondary\">\r\n");
#nullable restore
#line 163 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\ViewTransactHist.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 167 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\ViewTransactHist.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 170 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\ViewTransactHist.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 173 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\ViewTransactHist.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 176 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\ViewTransactHist.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Receiver));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 179 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\ViewTransactHist.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Balance));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 182 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\ViewTransactHist.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Acc.AccId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 185 "C:\Users\Omar\Desktop\Bank Management Template\Bank Test Updated Final\BankTest\TestBankApp\Views\ManagerHome\ViewTransactHist.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </tbody>
        </table>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataLayer.Models.TransactionHistory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
