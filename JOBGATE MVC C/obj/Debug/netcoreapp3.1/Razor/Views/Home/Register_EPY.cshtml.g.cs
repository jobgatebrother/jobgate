#pragma checksum "D:\Project JOBGATE\JOBGATE MVC C\jobgatebrother\jobgate\JOBGATE MVC C\Views\Home\Register_EPY.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0073e55b27982d296ccb7f0748e2039eacb9de56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register_EPY), @"mvc.1.0.view", @"/Views/Home/Register_EPY.cshtml")]
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
#line 1 "D:\Project JOBGATE\JOBGATE MVC C\jobgatebrother\jobgate\JOBGATE MVC C\Views\_ViewImports.cshtml"
using JOBGATE_MVC_C;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project JOBGATE\JOBGATE MVC C\jobgatebrother\jobgate\JOBGATE MVC C\Views\_ViewImports.cshtml"
using JOBGATE_MVC_C.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0073e55b27982d296ccb7f0748e2039eacb9de56", @"/Views/Home/Register_EPY.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b70ea79728982a5ce83bea0122772f9151a8f277", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register_EPY : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <br />
    <br />
    <br />
    <div class=""row justify-content-center"">
        <a class=""fa fa-5x fa-user""></a>
        <div class=""text-center"">
            <h2 class=""font-weight-bold"">Employee Register</h2>
            <h5>Welcome To Job Gate</h5>
        </div>
    </div>
    <br />
    <div class=""row justify-content-center"">
        <div class=""col-xl-5 col-lg-12 col-md-9"">
            <div class=""card o-hidden border-0 shadow-lg"">
                <div class=""card-body"">
                    <div class=""row justify-content-center mt-3"">
                        <input type=""email"" class=""form-control col-sm-6"" placeholder=""Email Address"" />
                    </div>
                    <div class=""row justify-content-center mt-3"">
                        <input type=""email"" class=""form-control col-sm-6"" placeholder=""Confirm Email Address"" />
                    </div>
                    <div class=""row justify-content-center mt-3"">
                        <input type=""passwo");
            WriteLiteral(@"rd"" class=""form-control col-sm-6"" placeholder=""Password"" />
                    </div>
                    <div class=""row justify-content-center mt-3"">
                        <input type=""password"" class=""form-control col-sm-6"" placeholder=""Confirm Password"" />
                    </div>
                    <div class=""row justify-content-center mt-3"">
                        <div class=""form-group justify-content-center"">
                            <div class=""custom-control custom-checkbox small"">
                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck"">
                                <label class=""custom-control-label"" for=""customCheck"">
                                    I agree to Jobgate's <a class=""text-primary""><u>Terms&Condition</u></a> and <a class=""text-primary""><u>Privacy Policy</u></a>
                                </label>
                            </div>
                        </div>
                    </div>
                ");
            WriteLiteral("    <div class=\"row justify-content-center\">\r\n                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 2144, "\"", 2188, 1);
#nullable restore
#line 39 "D:\Project JOBGATE\JOBGATE MVC C\jobgatebrother\jobgate\JOBGATE MVC C\Views\Home\Register_EPY.cshtml"
WriteAttributeValue("", 2151, Url.Action("Register_Result","Home"), 2151, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <h3 class=\"text-white\">Register</h3>\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"row justify-content-center\">\r\n                        <a class=\"h3 text-primary\"");
            BeginWriteAttribute("href", " href=\"", 2428, "\"", 2462, 1);
#nullable restore
#line 44 "D:\Project JOBGATE\JOBGATE MVC C\jobgatebrother\jobgate\JOBGATE MVC C\Views\Home\Register_EPY.cshtml"
WriteAttributeValue("", 2435, Url.Action("Login","Home"), 2435, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Do you have already Account? <u>Log In</u></a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
