#pragma checksum "E:\Coding projects\Visual Studio projects\ProofOfConcept\Application\Pages\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc60d99aa7304648793b601b5e858b7bc9ce5cbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Application.Pages.Pages_Register), @"mvc.1.0.razor-page", @"/Pages/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Register.cshtml", typeof(Application.Pages.Pages_Register), null)]
namespace Application.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\Coding projects\Visual Studio projects\ProofOfConcept\Application\Pages\_ViewImports.cshtml"
using Application;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc60d99aa7304648793b601b5e858b7bc9ce5cbd", @"/Pages/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c90dca39a37f6f45ea220907f468a30a4a34bc9f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Register : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(29, 332, true);
            WriteLiteral(@"
     <div class=""container"">
			<div class=""row main"">
				<div class=""panel-heading"">
	               <div class=""panel-title text-center"">
	               		<h1 class=""title"">ITS WEDNESDAY MY DUDES</h1>
	               		<hr />
	               	</div>
	            </div> 
				<div class=""main-login main-center"">
					");
            EndContext();
            BeginContext(361, 3029, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "974b3f92b95843d19a4a87dad451ca59", async() => {
                BeginContext(433, 2950, true);
                WriteLiteral(@"
						
						<div class=""form-group"">
							<label for=""userName"" class=""cols-sm-2 control-label"">Username</label>
							<div class=""cols-sm-10"">
								<div class=""input-group"">
									<span class=""input-group-addon""><i class=""fa fa-user fa"" aria-hidden=""true""></i></span>
									<input type=""text"" class=""form-control"" name=""userName"" id=""userName""  placeholder=""Enter your user name""/>
								</div>
							</div>
						</div>

						<div class=""form-group"">
							<label for=""email"" class=""cols-sm-2 control-label"">Your Email</label>
							<div class=""cols-sm-10"">
								<div class=""input-group"">
									<span class=""input-group-addon""><i class=""fa fa-envelope fa"" aria-hidden=""true""></i></span>
									<input type=""text"" class=""form-control"" name=""email"" id=""email""  placeholder=""Enter your Email""/>
								</div>
							</div>
						</div>

						<div class=""form-group"">
							<label for=""password"" class=""cols-sm-2 control-label"">Password</label>
							<div class=""cols-sm");
                WriteLiteral(@"-10"">
								<div class=""input-group"">
									<span class=""input-group-addon""><i class=""fa fa-lock fa-lg"" aria-hidden=""true""></i></span>
									<input type=""password"" class=""form-control"" name=""password"" id=""password""  placeholder=""Enter your Password""/>
								</div>
							</div>
						</div>

						<div class=""form-group"">
							<label for=""confirm"" class=""cols-sm-2 control-label"">Confirm Password</label>
							<div class=""cols-sm-10"">
								<div class=""input-group"">
									<span class=""input-group-addon""><i class=""fa fa-lock fa-lg"" aria-hidden=""true""></i></span>
									<input type=""password"" class=""form-control"" name=""confirm"" id=""confirm""  placeholder=""Confirm your Password""/>
								</div>
							</div>
						</div>

                        <div class=""form-group"">
							<label for=""phone"" class=""cols-sm-2 control-label"">Your phone number</label>
							<div class=""cols-sm-10"">
								<div class=""input-group"">
									<span class=""input-group-addon""><i class=""fa f");
                WriteLiteral(@"a-user fa"" aria-hidden=""true""></i></span>
									<input type=""text"" class=""form-control"" name=""phone"" id=""phone""  placeholder=""Enter your phone number""/>
								</div>
							</div>
						</div>

						<div class=""form-group"">
							<label for=""name"" class=""cols-sm-2 control-label"">Your name</label>
							<div class=""cols-sm-10"">
								<div class=""input-group"">
									<span class=""input-group-addon""><i class=""fa fa-user fa"" aria-hidden=""true""></i></span>
									<input type=""text"" class=""form-control"" name=""name"" id=""name""  placeholder=""Enter your name""/>
								</div>
							</div>
						</div>

						<div class=""form-group "">
							<button type=""submit"" class=""btn btn-primary btn-lg btn-block login-button"">Register</button>
						</div>
						<div class=""login-register"">
				            <a href=""https://localhost:4201"">Login</a>
				         </div>
					");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3390, 33, true);
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterModel>)PageContext?.ViewData;
        public RegisterModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
