#pragma checksum "D:\Jobgate\Source\JOBGATE-MVC\JOBGATE MVC C\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "014f4bb12e4126c7a661b084ac6ecd80799ef61e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
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
#line 1 "D:\Jobgate\Source\JOBGATE-MVC\JOBGATE MVC C\Views\_ViewImports.cshtml"
using JOBGATE_MVC_C;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Jobgate\Source\JOBGATE-MVC\JOBGATE MVC C\Views\_ViewImports.cshtml"
using JOBGATE_MVC_C.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"014f4bb12e4126c7a661b084ac6ecd80799ef61e", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b70ea79728982a5ce83bea0122772f9151a8f277", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid"">
    <div class=""text-center"">
        <h1 class=""font-weight-bold"">Register Account</h1>
        <h4>Welcome to Job Gate</h4>
    </div>
    <div class=""row justify-content-center"">
        <div class=""col-xl-10 col-lg-12 col-md-9"">
            <div class=""card o-hidden border-0 my-5 bg-transparent"">
                <div class=""card-body p-0"">
                    <div class=""row"">
                        <div class=""col-lg-2""></div>
                        <div class=""col-lg-4"">
                            <div class=""p-5"">
                                <div class=""card-body border text-center"">
                                    <a class=""fa fa-5x fa-user""></a>
                                    <h2 class=""font-weight-bold"">Employee</h2>
                                    <h3>Searching Job!</h3>
                                    <br />
                                    <br />
                                    <br />
                                ");
            WriteLiteral("    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1054, "\"", 1095, 1);
#nullable restore
#line 21 "D:\Jobgate\Source\JOBGATE-MVC\JOBGATE MVC C\Views\Home\Register.cshtml"
WriteAttributeValue("", 1061, Url.Action("Register_EPY","Home"), 1061, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <h3 class=""text-white"">Register</h3>
                                    </a>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-4"">
                            <div class=""p-5"">
                                <div class=""card-body border text-center"">
                                    <a class=""fa fa-5x fa-landmark""></a>
                                    <h2 class=""font-weight-bold"">Company</h2>
                                    <h3>Searching Job!</h3>
                                    <br />
                                    <br />
                                    <br />
                                    <a class=""btn btn-warning""");
            BeginWriteAttribute("href", " href=\"", 1906, "\"", 1947, 1);
#nullable restore
#line 36 "D:\Jobgate\Source\JOBGATE-MVC\JOBGATE MVC C\Views\Home\Register.cshtml"
WriteAttributeValue("", 1913, Url.Action("Register_CPN","Home"), 1913, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <h3 class=""text-white"">Register</h3>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""justify-content-center row"">
        <a class=""h3 text-primary""");
            BeginWriteAttribute("href", " href=\"", 2359, "\"", 2393, 1);
#nullable restore
#line 48 "D:\Jobgate\Source\JOBGATE-MVC\JOBGATE MVC C\Views\Home\Register.cshtml"
WriteAttributeValue("", 2366, Url.Action("Login","Home"), 2366, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Do you have already Account? <u>Log In</u></a>\r\n    </div>\r\n</div>\r\n");
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
