#pragma checksum "C:\Users\user\Documents\MHealz\Healz\Healz\Views\Home\Appointments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b08558751709dd6334c23e6db7745b461fdb156a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Appointments), @"mvc.1.0.view", @"/Views/Home/Appointments.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Appointments.cshtml", typeof(AspNetCore.Views_Home_Appointments))]
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
#line 1 "C:\Users\user\Documents\MHealz\Healz\Healz\Views\_ViewImports.cshtml"
using Healz;

#line default
#line hidden
#line 2 "C:\Users\user\Documents\MHealz\Healz\Healz\Views\_ViewImports.cshtml"
using Healz.Models;

#line default
#line hidden
#line 3 "C:\Users\user\Documents\MHealz\Healz\Healz\Views\_ViewImports.cshtml"
using Healz.Entities;

#line default
#line hidden
#line 4 "C:\Users\user\Documents\MHealz\Healz\Healz\Views\_ViewImports.cshtml"
using Healz.Models.UserProfile;

#line default
#line hidden
#line 5 "C:\Users\user\Documents\MHealz\Healz\Healz\Views\_ViewImports.cshtml"
using Healz.Entities.BasicInfo;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b08558751709dd6334c23e6db7745b461fdb156a", @"/Views/Home/Appointments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b634e72b02b176cc6987405462b0434bcd0c04a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Appointments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\user\Documents\MHealz\Healz\Healz\Views\Home\Appointments.cshtml"
  
    ViewData["Title"] = "Appointments";
  Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(95, 393, true);
            WriteLiteral(@"
<!--************************************
                Main Start
        *************************************-->
<main id=""tg-main"" class=""tg-main tg-haslayout"">
    <div class=""container"">
        <div class=""row"">
            <div id=""tg-content"" class=""tg-content tg-dashboard"">
                <div class=""col-lg-3 col-md-4 col-sm-4 col-xs-12 pull-left"">
                    ");
            EndContext();
            BeginContext(489, 63, false);
#line 15 "C:\Users\user\Documents\MHealz\Healz\Healz\Views\Home\Appointments.cshtml"
               Write(await Html.PartialAsync("~/Views/Shared/_InsitePartial.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(552, 6519, true);
            WriteLiteral(@"
                </div>
                <div class=""col-lg-9 col-md-8 col-sm-8 col-xs-12 pull-right"">
                    <div class=""tg-dashboardappointments"">
                        <div class=""tg-dashboardbox"">
                            <div class=""tg-dashboardboxtitle"">
                                <h2>Your Appointments</h2>
                            </div>
                            <div id=""tg-calendar"" class=""tg-calendar""></div>
                            <div class=""tg-dashboardinvoices tg-appointmentdetails"">
                                <div class=""tg-tablescroll"">
                                    <div class=""tg-dashboardbox tg-appointmentdetailbox"">
                                        <div class=""tg-dashboardboxtitle"">
                                            <h2>Appointments Of <span>Jan 11, 2017</span></h2>
                                        </div>
                                        <div class=""tg-favoritlistingbox"">
                               ");
            WriteLiteral(@"             <div class=""tg-invoicestitle"">
                                                <span>Title</span>
                                                <span class=""tg-titleamount"">Time</span>
                                                <span class=""tg-titleaction"">Action</span>
                                            </div>
                                            <ul class=""tg-invoices"">
                                                <li>
                                                    <div class=""tg-invoicesheading"">
                                                        <h3><a href=""#"">Reason For Visit Here</a></h3>
                                                        <span>Appointment Type Here</span>
                                                    </div>
                                                    <div class=""tg-amout"">
                                                        <em>15.00</em>
                                                    </div>
   ");
            WriteLiteral(@"                                                 <div class=""tg-btnaction"">
                                                        <a class=""tg-btnview"" href=""#"" data-toggle=""modal"" data-target=""#tg-appointmentapprove""><i class=""fa fa-check""></i></a>
                                                        <a class=""tg-btndelete"" href=""#"" data-toggle=""modal"" data-target=""#tg-appointmentreject""><i class=""fa fa-minus""></i></a>
                                                    </div>
                                                </li>
                                                <li>
                                                    <div class=""tg-invoicesheading"">
                                                        <h3><a href=""#"">Reason For Visit Here</a></h3>
                                                        <span>Appointment Type Here</span>
                                                    </div>
                                                    <div class=""tg-amout"">
     ");
            WriteLiteral(@"                                                   <em>15.00</em>
                                                    </div>
                                                    <div class=""tg-btnaction"">
                                                        <a class=""tg-btnview"" href=""#"" data-toggle=""modal"" data-target=""#tg-appointmentapprove""><i class=""fa fa-check""></i></a>
                                                        <a class=""tg-btndelete"" href=""#"" data-toggle=""modal"" data-target=""#tg-appointmentreject""><i class=""fa fa-minus""></i></a>
                                                    </div>
                                                </li>
                                                <li>
                                                    <div class=""tg-invoicesheading"">
                                                        <h3><a href=""#"">Reason For Visit Here</a></h3>
                                                        <span>Appointment Type Here</span>
           ");
            WriteLiteral(@"                                         </div>
                                                    <div class=""tg-amout"">
                                                        <em>10.00</em>
                                                    </div>
                                                    <div class=""tg-btnaction"">
                                                        <a class=""tg-btnview"" href=""#"" data-toggle=""modal"" data-target=""#tg-appointmentapprove""><i class=""fa fa-check""></i></a>
                                                        <a class=""tg-btndelete"" href=""#"" data-toggle=""modal"" data-target=""#tg-appointmentreject""><i class=""fa fa-minus""></i></a>
                                                    </div>
                                                </li>
                                                <li>
                                                    <div class=""tg-invoicesheading"">
                                                        <h3><a href=""#"">Reaso");
            WriteLiteral(@"n For Visit Here</a></h3>
                                                        <span>Appointment Type Here</span>
                                                    </div>
                                                    <div class=""tg-amout"">
                                                        <em>20.00</em>
                                                    </div>
                                                    <div class=""tg-btnaction"">
                                                        <a class=""tg-btnview"" href=""#"" data-toggle=""modal"" data-target=""#tg-appointmentapprove""><i class=""fa fa-check""></i></a>
                                                        <a class=""tg-btndelete"" href=""#"" data-toggle=""modal"" data-target=""#tg-appointmentreject""><i class=""fa fa-minus""></i></a>
                                                    </div>
                                                </li>
                                            </ul>
                                    ");
            WriteLiteral(@"    </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>
<!--************************************
        Main End
*************************************-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
