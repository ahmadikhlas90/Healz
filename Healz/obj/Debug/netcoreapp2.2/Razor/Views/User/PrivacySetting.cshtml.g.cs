#pragma checksum "C:\Users\user\Documents\MHealz\Healz\Healz\Views\User\PrivacySetting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c54d3c204277ac232ebfb6940b6812e2a3208fac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_PrivacySetting), @"mvc.1.0.view", @"/Views/User/PrivacySetting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/PrivacySetting.cshtml", typeof(AspNetCore.Views_User_PrivacySetting))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c54d3c204277ac232ebfb6940b6812e2a3208fac", @"/Views/User/PrivacySetting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b634e72b02b176cc6987405462b0434bcd0c04a", @"/Views/_ViewImports.cshtml")]
    public class Views_User_PrivacySetting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("tg-formtheme"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\user\Documents\MHealz\Healz\Healz\Views\User\PrivacySetting.cshtml"
  
    ViewData["Title"] = "PrivacySetting";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(99, 385, true);
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
            BeginContext(485, 86, false);
#line 15 "C:\Users\user\Documents\MHealz\Healz\Healz\Views\User\PrivacySetting.cshtml"
               Write(await Html.PartialAsync("~/Views/Shared/_user_Partial.cshtml",(PatientInfo)ViewBag.bd));

#line default
#line hidden
            EndContext();
            BeginContext(571, 470, true);
            WriteLiteral(@"
                </div>
                <div class=""col-lg-9 col-md-8 col-sm-8 col-xs-12 pull-right"">
                    <div class=""tg-dashboardprivacy"">
                        <div class=""tg-dashboardbox"">
                            <div class=""tg-dashboardboxtitle"">
                                <h2>Privacy Settings</h2>
                            </div>
                            <div class=""tg-privacysettingbox"">
                                ");
            EndContext();
            BeginContext(1041, 18236, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c54d3c204277ac232ebfb6940b6812e2a3208fac5708", async() => {
                BeginContext(1068, 18202, true);
                WriteLiteral(@"
                                    <fieldset>
                                        <div class=""row tg-rowmargin"">
                                            <div class=""col-md-6 col-sm-6 col-xs-12 tg-columnpadding"">
                                                <div class=""form-group tg-formgroup"">
                                                    <div class=""tg-optionbox"">
                                                        <span>Profile Picture</span>
                                                        <span class=""tg-iosstylcheckbox"">
                                                            <input type=""checkbox"" id=""profilepicture"" name=""profilepicture"" value=""profilepicture"">
                                                            <label for=""profilepicture""></label>
                                                        </span>
                                                    </div>
                                                </div>
                         ");
                WriteLiteral(@"                   </div>
                                            <div class=""col-md-6 col-sm-6 col-xs-12 tg-columnpadding"">
                                                <div class=""form-group tg-formgroup"">
                                                    <div class=""tg-optionbox"">
                                                        <span>Timeline Picture</span>
                                                        <span class=""tg-iosstylcheckbox"">
                                                            <input type=""checkbox"" id=""timelinepicture"" name=""timelinepicture"" value=""timelinepicture"" checked>
                                                            <label for=""timelinepicture""></label>
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=");
                WriteLiteral(@"""col-md-6 col-sm-6 col-xs-12 tg-columnpadding"">
                                                <div class=""form-group tg-formgroup"">
                                                    <div class=""tg-optionbox"">
                                                        <span>Social Detail</span>
                                                        <span class=""tg-iosstylcheckbox"">
                                                            <input type=""checkbox"" id=""socialdetail"" name=""socialdetail"" value=""socialdetail"" checked>
                                                            <label for=""socialdetail""></label>
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col-md-6 col-sm-6 col-xs-12 tg-columnpadding"">
                                                ");
                WriteLiteral(@"<div class=""form-group tg-formgroup"">
                                                    <div class=""tg-optionbox"">
                                                        <span>Location</span>
                                                        <span class=""tg-iosstylcheckbox"">
                                                            <input type=""checkbox"" id=""location"" name=""location"" value=""location"">
                                                            <label for=""location""></label>
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col-md-6 col-sm-6 col-xs-12 tg-columnpadding"">
                                                <div class=""form-group tg-formgroup"">
                                                    <div class=""tg-optionbox"">
       ");
                WriteLiteral(@"                                                 <span>About Me</span>
                                                        <span class=""tg-iosstylcheckbox"">
                                                            <input type=""checkbox"" id=""aboutme"" name=""aboutme"" value=""aboutme"" checked>
                                                            <label for=""aboutme""></label>
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col-md-6 col-sm-6 col-xs-12 tg-columnpadding"">
                                                <div class=""form-group tg-formgroup"">
                                                    <div class=""tg-optionbox"">
                                                        <span>Schedule</span>
                                                  ");
                WriteLiteral(@"      <span class=""tg-iosstylcheckbox"">
                                                            <input type=""checkbox"" id=""schedule"" name=""schedule"" value=""schedule"">
                                                            <label for=""schedule""></label>
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col-md-6 col-sm-6 col-xs-12 tg-columnpadding"">
                                                <div class=""form-group tg-formgroup"">
                                                    <div class=""tg-optionbox"">
                                                        <span>Contact Form</span>
                                                        <span class=""tg-iosstylcheckbox"">
                                                            <input type=""checkbox");
                WriteLiteral(@""" id=""contactform"" name=""contactform"" value=""contactform"" checked>
                                                            <label for=""contactform""></label>
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col-md-6 col-sm-6 col-xs-12 tg-columnpadding"">
                                                <div class=""form-group tg-formgroup"">
                                                    <div class=""tg-optionbox"">
                                                        <span>Skills</span>
                                                        <span class=""tg-iosstylcheckbox"">
                                                            <input type=""checkbox"" id=""skills"" name=""skills"" value=""skills"">
                                                            <la");
                WriteLiteral(@"bel for=""skills""></label>
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col-md-6 col-sm-6 col-xs-12 tg-columnpadding"">
                                                <div class=""form-group tg-formgroup"">
                                                    <div class=""tg-optionbox"">
                                                        <span>Experience</span>
                                                        <span class=""tg-iosstylcheckbox"">
                                                            <input type=""checkbox"" id=""experience"" name=""experience"" value=""experience"" checked>
                                                            <label for=""experience""></label>
                                                        </span>
                ");
                WriteLiteral(@"                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col-md-6 col-sm-6 col-xs-12 tg-columnpadding"">
                                                <div class=""form-group tg-formgroup"">
                                                    <div class=""tg-optionbox"">
                                                        <span>Qualification</span>
                                                        <span class=""tg-iosstylcheckbox"">
                                                            <input type=""checkbox"" id=""qualification"" name=""qualification"" value=""qualification"" checked>
                                                            <label for=""qualification""></label>
                                                        </span>
                                                    </div>
                                                <");
                WriteLiteral(@"/div>
                                            </div>
                                            <div class=""col-md-6 col-sm-6 col-xs-12 tg-columnpadding"">
                                                <div class=""form-group tg-formgroup"">
                                                    <div class=""tg-optionbox"">
                                                        <span>Honour &amp; Awards</span>
                                                        <span class=""tg-iosstylcheckbox"">
                                                            <input type=""checkbox"" id=""honourawards"" name=""honourawards"" value=""honourawards"">
                                                            <label for=""honourawards""></label>
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                        ");
                WriteLiteral(@"    <div class=""col-md-6 col-sm-6 col-xs-12 tg-columnpadding"">
                                                <div class=""form-group tg-formgroup"">
                                                    <div class=""tg-optionbox"">
                                                        <span>Presentation Video</span>
                                                        <span class=""tg-iosstylcheckbox"">
                                                            <input type=""checkbox"" id=""presentationvideo"" name=""presentationvideo"" value=""presentationvideo"" checked>
                                                            <label for=""presentationvideo""></label>
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col-md-6 col-sm-6 col-xs-12 tg-columnpadding"">
        ");
                WriteLiteral(@"                                        <div class=""form-group tg-formgroup"">
                                                    <div class=""tg-optionbox"">
                                                        <span>Photo Gallery</span>
                                                        <span class=""tg-iosstylcheckbox"">
                                                            <input type=""checkbox"" id=""photogallery"" name=""photogallery"" value=""photogallery"">
                                                            <label for=""photogallery""></label>
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col-md-6 col-sm-6 col-xs-12 tg-columnpadding"">
                                                <div class=""form-group tg-formgroup"">
                          ");
                WriteLiteral(@"                          <div class=""tg-optionbox"">
                                                        <span>Review &amp; Rating</span>
                                                        <span class=""tg-iosstylcheckbox"">
                                                            <input type=""checkbox"" id=""reviewrating"" name=""reviewrating"" value=""reviewrating"" checked>
                                                            <label for=""reviewrating""></label>
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col-md-6 col-sm-6 col-xs-12 tg-columnpadding"">
                                                <div class=""form-group tg-formgroup"">
                                                    <div class=""tg-optionbox"">
                                     ");
                WriteLiteral(@"                   <span>Fee</span>
                                                        <span class=""tg-iosstylcheckbox"">
                                                            <input type=""checkbox"" id=""fee"" name=""fee"" value=""fee"" checked>
                                                            <label for=""fee""></label>
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col-md-6 col-sm-6 col-xs-12 tg-columnpadding"">
                                                <div class=""form-group tg-formgroup"">
                                                    <div class=""tg-optionbox"">
                                                        <span>Language</span>
                                                        <span class=""tg-iosstylcheckbox"">
          ");
                WriteLiteral(@"                                                  <input type=""checkbox"" id=""language"" name=""language"" value=""language"">
                                                            <label for=""language""></label>
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col-md-6 col-sm-6 col-xs-12 tg-columnpadding"">
                                                <div class=""form-group tg-formgroup"">
                                                    <div class=""tg-optionbox"">
                                                        <span>Gender</span>
                                                        <span class=""tg-iosstylcheckbox"">
                                                            <input type=""checkbox"" id=""gender"" name=""gender"" value=""gender"">
            ");
                WriteLiteral(@"                                                <label for=""gender""></label>
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col-md-6 col-sm-6 col-xs-12 tg-columnpadding"">
                                                <div class=""form-group tg-formgroup"">
                                                    <div class=""tg-optionbox"">
                                                        <span>Age Range</span>
                                                        <span class=""tg-iosstylcheckbox"">
                                                            <input type=""checkbox"" id=""agerange"" name=""agerange"" value=""agerange"" checked>
                                                            <label for=""agerange""></label>
                                       ");
                WriteLiteral(@"                 </span>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col-md-6 col-sm-6 col-xs-12 tg-columnpadding"">
                                                <div class=""tg-optionbox"">
                                                    <span>Public URL</span>
                                                    <span class=""tg-iosstylcheckbox"">
                                                        <input type=""checkbox"" id=""publicurl"" name=""publicurl"" value=""publicurl"">
                                                        <label for=""publicurl""></label>
                                                    </span>
                                                </div>
                                            </div>
                                            <div class=""col-md-6 col-sm-6 col-xs-12 tg-columnpadd");
                WriteLiteral(@"ing"">
                                                <div class=""tg-optionbox"">
                                                    <span>Contact Details</span>
                                                    <span class=""tg-iosstylcheckbox"">
                                                        <input type=""checkbox"" id=""contactdetail"" name=""contactdetail"" value=""contactdetail"" checked>
                                                        <label for=""contactdetail""></label>
                                                    </span>
                                                </div>
                                            </div>
                                        </div>
                                    </fieldset>
                                ");
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
            BeginContext(19277, 588, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""tg-updateall"">
                            <span class=""tg-note"">* Click <strong>update all changes</strong> to update latest added detail (s).</span>
                            <button class=""tg-btn"" type=""submit"">update now</button>
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
