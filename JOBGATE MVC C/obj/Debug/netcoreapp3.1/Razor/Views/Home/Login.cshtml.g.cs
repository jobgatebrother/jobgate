#pragma checksum "D:\Project JOBGATE\JOBGATE MVC C\JOBGATE MVC C\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdc3afbce73cf48be8c8ea98b964340541b0f67c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 1 "D:\Project JOBGATE\JOBGATE MVC C\JOBGATE MVC C\Views\_ViewImports.cshtml"
using JOBGATE_MVC_C;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project JOBGATE\JOBGATE MVC C\JOBGATE MVC C\Views\_ViewImports.cshtml"
using JOBGATE_MVC_C.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdc3afbce73cf48be8c8ea98b964340541b0f67c", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b70ea79728982a5ce83bea0122772f9151a8f277", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid"">
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class=""row justify-content-center"">
        <div class=""col-xl-5 col-lg-12 col-md-9"">
                    <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" id=""Employee-tab"" data-toggle=""tab"" href=""#Employee"" role=""tab"" aria-controls=""Employee"" aria-selected=""true"">Employee</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""Company-tab"" data-toggle=""tab"" href=""#Company"" role=""tab"" aria-controls=""Company"" aria-selected=""false"">Company</a>
                        </li>
                    </ul>
                    <div class=""tab-content"" id=""myTabContent"">
                        <div class=""tab-pane fade show active"" id=""Employee"" role=""tabpanel"" aria-labelledby=""Employee-tab"">
                            <div class=""c");
            WriteLiteral(@"ard o-hidden border-0 shadow-lg"">
                                <div class=""card-body p-0"">
                                    <div class=""row"">
                                        <div class=""col-lg-7"">
                                            <div class=""p-5"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdc3afbce73cf48be8c8ea98b964340541b0f67c4985", async() => {
                WriteLiteral(@"
                                                    <div class=""form-group"">
                                                        <input type=""email"" class=""form-control form-control-user""
                                                               id=""exampleInputEmail"" aria-describedby=""emailHelp""
                                                               placeholder=""Email or Username"">
                                                    </div>
                                                    <div class=""form-group"">
                                                        <input type=""password"" class=""form-control form-control-user""
                                                               id=""exampleInputPassword"" placeholder=""Password"">
                                                    </div>
                                                    <div class=""form-group"">
                                                        <div class=""custom-control custom-checkbox small"">");
                WriteLiteral(@"
                                                            <input type=""checkbox"" class=""custom-control-input"" id=""customCheck"">
                                                            <label class=""custom-control-label"" for=""customCheck"">
                                                                Remember Me
                                                            </label>
                                                        </div>
                                                    </div>
                                                    <a href=""#"" class=""btn btn-primary btn-user btn-block"">
                                                        Login
                                                    </a>
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                <hr />
                                                <div class=""text-center"">
                                                    <a class=""small"" href=""#"">Forgot Password?</a>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""col-lg-5"">
                                            <div class=""p-5"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdc3afbce73cf48be8c8ea98b964340541b0f67c8765", async() => {
                WriteLiteral(@"
                                                    <div class=""form-group"">
                                                        <a href=""#"" class=""btn btn-google btn-user btn-block"">
                                                            <i class=""fab fa-google fa-fw""></i> Login with Google
                                                        </a>
                                                    </div>
                                                    <div class=""form-group"">
                                                        <a href=""#"" class=""btn btn-facebook btn-user btn-block"">
                                                            <i class=""fab fa-facebook-f fa-fw""></i> Login with Facebook
                                                        </a>
                                                    </div>
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                <hr>
                                                <div class=""text-center"">
                                                    <a class=""small"" href=""#"">Create an Account!</a>
                                                </div>

                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""Company"" role=""tabpanel"" aria-labelledby=""Company-tab"">
                            <div class=""card o-hidden border-0 shadow-lg"">
                                <div class=""card-body p-0"">
                                    <div class=""row"">
                                        <div class=""col-lg-7"">
                                            <div class=""p-5"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdc3afbce73cf48be8c8ea98b964340541b0f67c12047", async() => {
                WriteLiteral(@"
                                                    <div class=""form-group"">
                                                        <input type=""email"" class=""form-control form-control-user""
                                                               id=""exampleInputEmail"" aria-describedby=""emailHelp""
                                                               placeholder=""Email or Username"">
                                                    </div>
                                                    <div class=""form-group"">
                                                        <input type=""password"" class=""form-control form-control-user""
                                                               id=""exampleInputPassword"" placeholder=""Password"">
                                                    </div>
                                                    <div class=""form-group"">
                                                        <div class=""custom-control custom-checkbox small"">");
                WriteLiteral(@"
                                                            <input type=""checkbox"" class=""custom-control-input"" id=""customCheck"">
                                                            <label class=""custom-control-label"" for=""customCheck"">
                                                                Remember Me
                                                            </label>
                                                        </div>
                                                    </div>
                                                    <a href=""#"" class=""btn btn-primary btn-user btn-block"">
                                                        Login
                                                    </a>
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                <hr />
                                                <div class=""text-center"">
                                                    <a class=""small"" href=""#"">Forgot Password?</a>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""col-lg-5"">
                                            <div class=""p-5"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdc3afbce73cf48be8c8ea98b964340541b0f67c15828", async() => {
                WriteLiteral(@"
                                                    <div class=""form-group"">
                                                        <a href=""#"" class=""btn btn-google btn-user btn-block"">
                                                            <i class=""fab fa-google fa-fw""></i> Login with Google
                                                        </a>
                                                    </div>
                                                    <div class=""form-group"">
                                                        <a href=""#"" class=""btn btn-facebook btn-user btn-block"">
                                                            <i class=""fab fa-facebook-f fa-fw""></i> Login with Facebook
                                                        </a>
                                                    </div>
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                <hr>
                                                <div class=""text-center"">
                                                    <a class=""small"" href=""#"">Create an Account!</a>
                                                </div>

                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
