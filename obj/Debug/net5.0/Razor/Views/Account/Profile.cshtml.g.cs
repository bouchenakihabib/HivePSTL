#pragma checksum "/Users/habibbouchenaki/Documents/programmes/HivePSTL/Views/Account/Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a11360641899c9617f7f0e67c076efe1e919f1b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
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
#line 1 "/Users/habibbouchenaki/Documents/programmes/HivePSTL/Views/_ViewImports.cshtml"
using HivePSTL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/habibbouchenaki/Documents/programmes/HivePSTL/Views/_ViewImports.cshtml"
using HivePSTL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a11360641899c9617f7f0e67c076efe1e919f1b9", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b536bb249ce3a6e31ed0741d6f190718f3c52d83", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Okta.Sdk.IUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/habibbouchenaki/Documents/programmes/HivePSTL/Views/Account/Profile.cshtml"
  
  ViewData["Title"] = "User Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>User Profile</h1>\n\n<div>\n  <dl class=\"row\">\n    <dt class = \"col-sm-2\">\n      ");
#nullable restore
#line 12 "/Users/habibbouchenaki/Documents/programmes/HivePSTL/Views/Account/Profile.cshtml"
 Write(Html.DisplayNameFor(model => model.Profile.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dt>\n    <dd class = \"col-sm-10\">\n      ");
#nullable restore
#line 15 "/Users/habibbouchenaki/Documents/programmes/HivePSTL/Views/Account/Profile.cshtml"
 Write(Html.DisplayFor(model => model.Profile.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n    <dt class = \"col-sm-2\">\n      ");
#nullable restore
#line 18 "/Users/habibbouchenaki/Documents/programmes/HivePSTL/Views/Account/Profile.cshtml"
 Write(Html.DisplayNameFor(model => model.Profile.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dt>\n    <dd class = \"col-sm-10\">\n      ");
#nullable restore
#line 21 "/Users/habibbouchenaki/Documents/programmes/HivePSTL/Views/Account/Profile.cshtml"
 Write(Html.DisplayFor(model => model.Profile.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n    <dt class = \"col-sm-2\">\n      ");
#nullable restore
#line 24 "/Users/habibbouchenaki/Documents/programmes/HivePSTL/Views/Account/Profile.cshtml"
 Write(Html.DisplayNameFor(model => model.Profile.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dt>\n    <dd class = \"col-sm-10\">\n      ");
#nullable restore
#line 27 "/Users/habibbouchenaki/Documents/programmes/HivePSTL/Views/Account/Profile.cshtml"
 Write(Html.DisplayFor(model => model.Profile.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n    <dt class = \"col-sm-2\">\n      ");
#nullable restore
#line 30 "/Users/habibbouchenaki/Documents/programmes/HivePSTL/Views/Account/Profile.cshtml"
 Write(Html.DisplayNameFor(model => model.Profile.MobilePhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dt>\n    <dd class = \"col-sm-10\">\n      ");
#nullable restore
#line 33 "/Users/habibbouchenaki/Documents/programmes/HivePSTL/Views/Account/Profile.cshtml"
 Write(Html.DisplayFor(model => model.Profile.MobilePhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n    <dt class = \"col-sm-2\">\n      ");
#nullable restore
#line 36 "/Users/habibbouchenaki/Documents/programmes/HivePSTL/Views/Account/Profile.cshtml"
 Write(Html.DisplayNameFor(model => model.Profile.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dt>\n    <dd class = \"col-sm-10\">\n      ");
#nullable restore
#line 39 "/Users/habibbouchenaki/Documents/programmes/HivePSTL/Views/Account/Profile.cshtml"
 Write(Html.DisplayFor(model => model.Profile.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n    <dt class = \"col-sm-2\">\n      ");
#nullable restore
#line 42 "/Users/habibbouchenaki/Documents/programmes/HivePSTL/Views/Account/Profile.cshtml"
 Write(Html.DisplayNameFor(model => model.Profile.PostalAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dt>\n    <dd class = \"col-sm-10\">\n      ");
#nullable restore
#line 45 "/Users/habibbouchenaki/Documents/programmes/HivePSTL/Views/Account/Profile.cshtml"
 Write(Html.DisplayFor(model => model.Profile.PostalAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n    <dt class = \"col-sm-2\">\n      ");
#nullable restore
#line 48 "/Users/habibbouchenaki/Documents/programmes/HivePSTL/Views/Account/Profile.cshtml"
 Write(Html.DisplayNameFor(model => model.Profile.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dt>\n    <dd class = \"col-sm-10\">\n      ");
#nullable restore
#line 51 "/Users/habibbouchenaki/Documents/programmes/HivePSTL/Views/Account/Profile.cshtml"
 Write(Html.DisplayFor(model => model.Profile.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n    <dt class = \"col-sm-2\">\n      ");
#nullable restore
#line 54 "/Users/habibbouchenaki/Documents/programmes/HivePSTL/Views/Account/Profile.cshtml"
 Write(Html.DisplayNameFor(model => model.Profile.CountryCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dt>\n    <dd class = \"col-sm-10\">\n      ");
#nullable restore
#line 57 "/Users/habibbouchenaki/Documents/programmes/HivePSTL/Views/Account/Profile.cshtml"
 Write(Html.DisplayFor(model => model.Profile.CountryCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n  </dl>\n</div>\n<div>\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a11360641899c9617f7f0e67c076efe1e919f1b98405", async() => {
                WriteLiteral("Edit Profile");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Okta.Sdk.IUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
