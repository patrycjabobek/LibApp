#pragma checksum "C:\Users\Lenovo\source\repos\LibAppProject\LibApp\Views\Customers\CustomerForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e0ed1d8f3e0f54697d2d3cb90e0654325985a45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_CustomerForm), @"mvc.1.0.view", @"/Views/Customers/CustomerForm.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\LibAppProject\LibApp\Views\_ViewImports.cshtml"
using LibApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\LibAppProject\LibApp\Views\_ViewImports.cshtml"
using LibApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e0ed1d8f3e0f54697d2d3cb90e0654325985a45", @"/Views/Customers/CustomerForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bbce3ab8be2552ae2c0c63b9eec500954dd42b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_CustomerForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibApp.ViewModels.CustomerFormViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\LibAppProject\LibApp\Views\Customers\CustomerForm.cshtml"
  
    ViewBag.Title = Model.Title;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 8 "C:\Users\Lenovo\source\repos\LibAppProject\LibApp\Views\Customers\CustomerForm.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Lenovo\source\repos\LibAppProject\LibApp\Views\Customers\CustomerForm.cshtml"
 using (Html.BeginForm("Save", "Customers"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 13 "C:\Users\Lenovo\source\repos\LibAppProject\LibApp\Views\Customers\CustomerForm.cshtml"
   Write(Html.LabelFor(m => m.Customer.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 14 "C:\Users\Lenovo\source\repos\LibAppProject\LibApp\Views\Customers\CustomerForm.cshtml"
   Write(Html.TextBoxFor(m => m.Customer.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 20 "C:\Users\Lenovo\source\repos\LibAppProject\LibApp\Views\Customers\CustomerForm.cshtml"
   Write(Html.LabelFor(m => m.Customer.Birthdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 21 "C:\Users\Lenovo\source\repos\LibAppProject\LibApp\Views\Customers\CustomerForm.cshtml"
   Write(Html.TextBoxFor(m => m.Customer.Birthdate, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 24 "C:\Users\Lenovo\source\repos\LibAppProject\LibApp\Views\Customers\CustomerForm.cshtml"
   Write(Html.LabelFor(m => m.Customer.MembershipTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 25 "C:\Users\Lenovo\source\repos\LibAppProject\LibApp\Views\Customers\CustomerForm.cshtml"
   Write(Html.DropDownListFor(m => m.Customer.MembershipTypeId, new SelectList(Model.MembershipTypes, "Id", "Name"), "Select Membership Type", new { @class = "form=control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label class=\"form-check-label\" for=\"flexCheckDefault\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Lenovo\source\repos\LibAppProject\LibApp\Views\Customers\CustomerForm.cshtml"
       Write(Html.CheckBoxFor(m => m.Customer.HasNewsletterSubscribed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            Subsribed to Newsletter?\r\n        </label>\r\n    </div>\r\n");
#nullable restore
#line 34 "C:\Users\Lenovo\source\repos\LibAppProject\LibApp\Views\Customers\CustomerForm.cshtml"
Write(Html.HiddenFor(m => m.Customer.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Lenovo\source\repos\LibAppProject\LibApp\Views\Customers\CustomerForm.cshtml"
                                       ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n");
#nullable restore
#line 36 "C:\Users\Lenovo\source\repos\LibAppProject\LibApp\Views\Customers\CustomerForm.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibApp.ViewModels.CustomerFormViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
