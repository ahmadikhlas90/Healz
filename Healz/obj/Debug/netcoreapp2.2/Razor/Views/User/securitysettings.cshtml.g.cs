#pragma checksum "C:\Users\user\Documents\MHealz\Healz\Healz\Views\User\securitysettings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8480016f38283f751c94fe67a8dc60aac9434a3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_securitysettings), @"mvc.1.0.view", @"/Views/User/securitysettings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/securitysettings.cshtml", typeof(AspNetCore.Views_User_securitysettings))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8480016f38283f751c94fe67a8dc60aac9434a3b", @"/Views/User/securitysettings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b634e72b02b176cc6987405462b0434bcd0c04a", @"/Views/_ViewImports.cshtml")]
    public class Views_User_securitysettings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("tg-formtheme tg-formaddcompany"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\user\Documents\MHealz\Healz\Healz\Views\User\securitysettings.cshtml"
  
    ViewData["Title"] = "securitysettings";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(101, 387, true);
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
            BeginContext(489, 62, false);
#line 16 "C:\Users\user\Documents\MHealz\Healz\Healz\Views\User\securitysettings.cshtml"
               Write(await Html.PartialAsync("~/Views/Shared/_user_Partial.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(551, 4979, true);
            WriteLiteral(@"
                </div>
                <div class=""col-lg-9 col-md-8 col-sm-8 col-xs-12 pull-right"">
                    <div class=""tg-dashboardsecuritysettings"">
                        <div class=""tg-dashboardbox"">
                            <div class=""tg-dashboardboxtitle"">
                                <h2>Change Password</h2>
                            </div>
                            <div class=""tg-box tg-changepassword"">
                                <div class=""row tg-rowmargin"">
                                    <div class=""col-md-4 col-sm-6 col-xs-12 tg-columnpadding"">
                                        <div class=""form-group tg-formgroup"">
                                            <input type=""password"" name=""currentpassword"" class=""form-control"" placeholder=""Current Password *"">
                                        </div>
                                    </div>
                                    <div class=""col-md-4 col-sm-6 col-xs-12 tg-columnpadding"">
 ");
            WriteLiteral(@"                                       <div class=""form-group tg-formgroup"">
                                            <input type=""password"" name=""mewpassword"" class=""form-control"" placeholder=""New Password *"">
                                        </div>
                                    </div>
                                    <div class=""col-md-4 col-sm-6 col-xs-12 tg-columnpadding"">
                                        <div class=""form-group tg-formgroup"">
                                            <input type=""password"" name=""retypepassword"" class=""form-control"" placeholder=""Retype Password *"">
                                        </div>
                                    </div>
                                    <div class=""col-md-12 col-sm-6 col-xs-12 tg-columnpadding"">
                                        <button class=""tg-btn"" type=""submit"">Change Now</button>
                                    </div>
                                </div>
                          ");
            WriteLiteral(@"  </div>
                        </div>
                        <div class=""tg-dashboardbox"">
                            <div class=""tg-dashboardboxtitle"">
                                <h2>Deactivate Account</h2>
                            </div>
                            <div class=""tg-description"">
                                <p>Consectetur adipisicing elit eiusmod ipor incididunt utreiat dolorena aliqua minim veniam ullamcoaoris nisi ut aliquip exeao consuataui te irure dolor in reprehenderit aperiam eaque ipsa quae ab illo inventore.</p>
                            </div>
                            <div class=""tg-box tg-deactivateaccount"">
                                <div class=""row tg-rowmargin"">
                                    <div class=""col-sm-6 col-xs-12 tg-columnpadding"">
                                        <div class=""form-group tg-formgroup"">
                                            <input type=""password"" name=""currentpassword"" class=""form-control"" placehold");
            WriteLiteral(@"er=""Current Password *"">
                                        </div>
                                    </div>
                                    <div class=""col-sm-6 col-xs-12 tg-columnpadding"">
                                        <div class=""form-group tg-formgroup"">
                                            <input type=""password"" name=""mewpassword"" class=""form-control"" placeholder=""Retype Password *"">
                                        </div>
                                    </div>
                                    <div class=""col-sm-12 tg-columnpadding"">
                                        <div class=""form-group tg-formgroup"">
                                            <textarea placeholder=""Why Leaving Us?""></textarea>
                                        </div>
                                    </div>
                                    <div class=""col-sm-12 col-xs-12 tg-columnpadding"">
                                        <button class=""tg-btn"" type=""subm");
            WriteLiteral(@"it"">Deactivate now</button>
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
<!--************************************
            Light Box Start
*************************************-->
<div class=""modal tg-modal tg-addcompany fade"" id=""tg-addcompany"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog tg-modaldialog"">
        <div class=""modal-content tg-modalcontent"">
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true""></span></button>
            <h2>Add Demo Company</h2>
            ");
            EndContext();
            BeginContext(5530, 4027, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8480016f38283f751c94fe67a8dc60aac9434a3b10606", async() => {
                BeginContext(5575, 2051, true);
                WriteLiteral(@"
                <fieldset>
                    <div class=""row tg-rowmargin"">
                        <div class=""col-sm-6 col-xs-12 tg-columnpadding"">
                            <div class=""form-group tg-formgroup"">
                                <input type=""text"" name=""companytitle"" class=""form-control"" placeholder=""Company Title"">
                            </div>
                        </div>
                        <div class=""col-sm-6 col-xs-12 tg-columnpadding"">
                            <div class=""form-group tg-formgroup"">
                                <input type=""text"" name=""companysubtitle"" class=""form-control"" placeholder=""Company Subtitle"">
                            </div>
                        </div>
                        <div class=""col-sm-12 col-xs-12 tg-columnpadding"">
                            <div class=""form-group tg-formgroup"">
                                <textarea class=""form-control"" name=""companydescription"" placeholder=""Company Description""></text");
                WriteLiteral(@"area>
                            </div>
                        </div>
                        <div class=""col-sm-6 col-xs-12 tg-columnpadding"">
                            <div class=""form-group tg-formgroup"">
                                <input type=""text"" name=""yourfeepervisit"" class=""form-control"" placeholder=""Your Fee Per Visit"">
                            </div>
                        </div>
                        <div class=""col-sm-6 col-xs-12 tg-columnpadding"">
                            <div class=""form-group tg-formgroup"">
                                <input type=""text"" name=""yourvoice"" class=""form-control"" placeholder=""Your Voice"">
                            </div>
                        </div>
                        <div class=""col-sm-6 col-xs-12 tg-columnpadding"">
                            <div class=""form-group tg-formgroup"">
                                <span class=""tg-select"">
                                    <select>
                                     ");
                WriteLiteral("   ");
                EndContext();
                BeginContext(7626, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8480016f38283f751c94fe67a8dc60aac9434a3b13178", async() => {
                    BeginContext(7634, 6, true);
                    WriteLiteral("Monday");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7649, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(7691, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8480016f38283f751c94fe67a8dc60aac9434a3b14475", async() => {
                    BeginContext(7699, 6, true);
                    WriteLiteral("Monday");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7714, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(7756, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8480016f38283f751c94fe67a8dc60aac9434a3b15772", async() => {
                    BeginContext(7764, 6, true);
                    WriteLiteral("Monday");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7779, 444, true);
                WriteLiteral(@"
                                    </select>
                                </span>
                            </div>
                        </div>
                        <div class=""col-sm-6 col-xs-12 tg-columnpadding"">
                            <div class=""form-group tg-formgroup"">
                                <span class=""tg-select"">
                                    <select>
                                        ");
                EndContext();
                BeginContext(8223, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8480016f38283f751c94fe67a8dc60aac9434a3b17477", async() => {
                    BeginContext(8231, 6, true);
                    WriteLiteral("Sunday");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8246, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(8288, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8480016f38283f751c94fe67a8dc60aac9434a3b18774", async() => {
                    BeginContext(8296, 6, true);
                    WriteLiteral("Sunday");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8311, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(8353, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8480016f38283f751c94fe67a8dc60aac9434a3b20071", async() => {
                    BeginContext(8361, 6, true);
                    WriteLiteral("Sunday");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8376, 1174, true);
                WriteLiteral(@"
                                    </select>
                                </span>
                            </div>
                        </div>
                        <div class=""col-sm-6 col-xs-12 tg-columnpadding"">
                            <div class=""form-group tg-formgroup"">
                                <span class=""tg-inputicon tg-calendaricon""><input type=""text"" name=""starttime"" class=""form-control"" placeholder=""Start Time""></span>
                            </div>
                        </div>
                        <div class=""col-sm-6 col-xs-12 tg-columnpadding"">
                            <div class=""form-group tg-formgroup"">
                                <span class=""tg-inputicon tg-calendaricon""><input type=""text"" name=""endtime"" class=""form-control"" placeholder=""End Time""></span>
                            </div>
                        </div>
                        <div class=""col-sm-4 col-xs-12 tg-columnpadding"">
                            <button class=""");
                WriteLiteral("tg-btn tg-btn-lg\" type=\"submit\">submit</button>\r\n                        </div>\r\n                    </div>\r\n                </fieldset>\r\n            ");
                EndContext();
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
            EndContext();
            BeginContext(9557, 2495, true);
            WriteLiteral(@"
        </div>
    </div>
</div>
<!--************************************
            Light Box End
*************************************-->
<!--************************************
            Light Box Start
*************************************-->
<div class=""modal tg-modal tg-addjobdetailinfo fade"" id=""tg-addjobdetailinfo"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog tg-modaldialog"">
        <div class=""modal-content tg-modalcontent"">
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true""></span></button>
            <h2>Fill Up Important Details</h2>
            <div class=""tg-directpost"">
                <figure class=""tg-directpostimg"">
                    <a href=""#""><img src=""images/directpost/img-01.jpg"" alt=""image description""></a>
                    <figcaption>
                        <a class=""tg-usericon tg-iconfeatured"" href=""#"">
                            <em class=""tg-usericonholder"">
             ");
            WriteLiteral(@"                   <i class=""fa fa-bolt""></i>
                                <span>featured</span>
                            </em>
                        </a>
                        <a class=""tg-usericon tg-iconvarified"" href=""#"">
                            <em class=""tg-usericonholder"">
                                <i class=""fa fa-shield""></i>
                                <span>varified</span>
                            </em>
                        </a>
                    </figcaption>
                </figure>
                <div class=""tg-directinfo"">
                    <div class=""tg-directposthead"">
                        <h3><a href=""#"">Life Saver Pharmacy</a></h3>
                        <div class=""tg-subjects"">Local Pharmaceutical Council (LPhC)</div>
                        <ul class=""tg-metadata"">
                            <li><span class=""tg-stars""><span></span></span></li>
                            <li><a href=""#""><i class=""fa fa-heart tg-like""></i></a></li");
            WriteLiteral(@">
                            <li><a href=""#""><i class=""fa fa-thumbs-o-up""></i> 99% (1009 votes)</a></li>
                        </ul>
                    </div>
                    <div class=""tg-description"" style=""max-height: none;"">
                        <p>Consectetur adipisicing elit eiusmod tempor iidunt utabor dolore eiusmod tempor iidunt.</p>
                    </div>
                </div>
            </div>
            ");
            EndContext();
            BeginContext(12052, 3010, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8480016f38283f751c94fe67a8dc60aac9434a3b26360", async() => {
                BeginContext(12097, 1034, true);
                WriteLiteral(@"
                <fieldset>
                    <div class=""row tg-rowmargin"">
                        <div class=""col-sm-6 col-xs-12 tg-columnpadding"">
                            <div class=""form-group tg-formgroup"">
                                <input type=""text"" name=""yourfeepervisit"" class=""form-control"" placeholder=""Your Fee Per Visit"">
                            </div>
                        </div>
                        <div class=""col-sm-6 col-xs-12 tg-columnpadding"">
                            <div class=""form-group tg-formgroup"">
                                <input type=""text"" name=""yourvoice"" class=""form-control"" placeholder=""Your Voice"">
                            </div>
                        </div>
                        <div class=""col-sm-6 col-xs-12 tg-columnpadding"">
                            <div class=""form-group tg-formgroup"">
                                <span class=""tg-select"">
                                    <select>
                              ");
                WriteLiteral("          ");
                EndContext();
                BeginContext(13131, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8480016f38283f751c94fe67a8dc60aac9434a3b27847", async() => {
                    BeginContext(13139, 6, true);
                    WriteLiteral("Monday");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(13154, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(13196, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8480016f38283f751c94fe67a8dc60aac9434a3b29147", async() => {
                    BeginContext(13204, 6, true);
                    WriteLiteral("Monday");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(13219, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(13261, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8480016f38283f751c94fe67a8dc60aac9434a3b30447", async() => {
                    BeginContext(13269, 6, true);
                    WriteLiteral("Monday");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(13284, 444, true);
                WriteLiteral(@"
                                    </select>
                                </span>
                            </div>
                        </div>
                        <div class=""col-sm-6 col-xs-12 tg-columnpadding"">
                            <div class=""form-group tg-formgroup"">
                                <span class=""tg-select"">
                                    <select>
                                        ");
                EndContext();
                BeginContext(13728, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8480016f38283f751c94fe67a8dc60aac9434a3b32155", async() => {
                    BeginContext(13736, 6, true);
                    WriteLiteral("Sunday");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(13751, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(13793, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8480016f38283f751c94fe67a8dc60aac9434a3b33455", async() => {
                    BeginContext(13801, 6, true);
                    WriteLiteral("Sunday");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(13816, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(13858, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8480016f38283f751c94fe67a8dc60aac9434a3b34755", async() => {
                    BeginContext(13866, 6, true);
                    WriteLiteral("Sunday");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(13881, 1174, true);
                WriteLiteral(@"
                                    </select>
                                </span>
                            </div>
                        </div>
                        <div class=""col-sm-6 col-xs-12 tg-columnpadding"">
                            <div class=""form-group tg-formgroup"">
                                <span class=""tg-inputicon tg-calendaricon""><input type=""text"" name=""starttime"" class=""form-control"" placeholder=""Start Time""></span>
                            </div>
                        </div>
                        <div class=""col-sm-6 col-xs-12 tg-columnpadding"">
                            <div class=""form-group tg-formgroup"">
                                <span class=""tg-inputicon tg-calendaricon""><input type=""text"" name=""endtime"" class=""form-control"" placeholder=""End Time""></span>
                            </div>
                        </div>
                        <div class=""col-sm-4 col-xs-12 tg-columnpadding"">
                            <button class=""");
                WriteLiteral("tg-btn tg-btn-lg\" type=\"submit\">submit</button>\r\n                        </div>\r\n                    </div>\r\n                </fieldset>\r\n            ");
                EndContext();
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
            EndContext();
            BeginContext(15062, 149, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--************************************\r\n            Light Box End\r\n*************************************-->\r\n");
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
