#pragma checksum "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\StressAssesment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4c9200ed545fbddc66d8104900f0801c14c8122"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MentalHealthAssesment_StressAssesment), @"mvc.1.0.view", @"/Views/MentalHealthAssesment/StressAssesment.cshtml")]
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
#line 1 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\_ViewImports.cshtml"
using Hackathon;

#line default
#line hidden
#line 2 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\_ViewImports.cshtml"
using Hackathon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4c9200ed545fbddc66d8104900f0801c14c8122", @"/Views/MentalHealthAssesment/StressAssesment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"793605a08a66d7a43a86a8f914b921497e372700", @"/Views/_ViewImports.cshtml")]
    public class Views_MentalHealthAssesment_StressAssesment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#line 2 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\StressAssesment.cshtml"
  
    ViewData["Title"] = "StressAssesment";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            WriteLiteral("\n<h1   style=\"color:darkgoldenrod\">Stress Assesment</h1>\n<table style=\"color:darkgoldenrod\">\n    <tr>\n        <td>Do you at times feel nervous? </td>\n    </tr>\n    <tr>\n        <td> Yes ");
#line 13 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\StressAssesment.cshtml"
            Write(Html.RadioButton("nervous", "Yes"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp; No ");
#line 13 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\StressAssesment.cshtml"
                                                                           Write(Html.RadioButton("nervous", "No"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;</td>\n    </tr>\n    <tr>\n        <td>Do you at times feel frustrated? </td>\n    </tr>\n    <tr>\n        <td>Yes ");
#line 19 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\StressAssesment.cshtml"
           Write(Html.RadioButton("frustated", "Yes"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp; No ");
#line 19 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\StressAssesment.cshtml"
                                                                            Write(Html.RadioButton("frustated", "No"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;</td>\n    </tr>\n    <tr>\n        <td>Are you insomniac?  </td>\n    </tr>\n    <tr>\n        <td>Yes ");
#line 25 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\StressAssesment.cshtml"
           Write(Html.RadioButton("insomaniac", "Yes"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp; No ");
#line 25 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\StressAssesment.cshtml"
                                                                             Write(Html.RadioButton("insomaniac", "No"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;</td>\n    </tr>\n    <tr>\n        <td>Do you feel low on energy? </td>\n    </tr>\n    <tr>\n        <td>Yes ");
#line 31 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\StressAssesment.cshtml"
           Write(Html.RadioButton("energy", "Yes"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp; No ");
#line 31 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\StressAssesment.cshtml"
                                                                         Write(Html.RadioButton("energy", "No"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;</td>\n    </tr>\n    <tr>\n        <td>Do you have severe headaches recently which comes back after medication?</td>\n    </tr>\n    <tr>\n        <td>\n            Yes ");
#line 38 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\StressAssesment.cshtml"
           Write(Html.RadioButton("headache", "Yes"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp; No ");
#line 38 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\StressAssesment.cshtml"
                                                                           Write(Html.RadioButton("headache", "No"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;\n        </td>\n    </tr>\n    <tr>\n        <td>Do you know what led to this emotion?</td>\n    </tr>\n    <tr>\n        <td>Yes ");
#line 45 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\StressAssesment.cshtml"
           Write(Html.RadioButton("emotiontrigger", "Yes"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp; No ");
#line 45 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\StressAssesment.cshtml"
                                                                                 Write(Html.RadioButton("emotiontrigger", "No"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;</td>\n    </tr>\n    <tr>\n        <td>If Yes. Is it result of a recent activity?</td>\n    </tr>\n    <tr>\n        <td>Yes ");
#line 51 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\StressAssesment.cshtml"
           Write(Html.RadioButton("recent", "Yes"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp; No ");
#line 51 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\StressAssesment.cshtml"
                                                                         Write(Html.RadioButton("recent", "No"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;</td>\n    </tr>\n    <tr>\n        <td>How recent was that event?</td>\n    </tr>\n    <tr>\n        <td>1-2 days back  ");
#line 57 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\StressAssesment.cshtml"
                      Write(Html.RadioButton("howrecent", "days"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp; A week back ");
#line 57 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\StressAssesment.cshtml"
                                                                                                 Write(Html.RadioButton("howrecent", "weeks"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp; A couple of months back ");
#line 57 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\StressAssesment.cshtml"
                                                                                                                                                                                         Write(Html.RadioButton("howrecent", "months"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;</td>\n    </tr>\n    <tr>\n        <td>\n            <input  class=\"btn btn-info\" style=\"color:darkgoldenrod;background-color:white;\" value=\"Submit\" id=\"btnSubmit\"");
            BeginWriteAttribute("onclick", "  onclick=\"", 2373, "\"", 2436, 3);
            WriteAttributeValue("", 2384, "location.href=\'", 2384, 15, true);
#line 61 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\StressAssesment.cshtml"
WriteAttributeValue("", 2399, Url.Action("Index", "UnderProcess"), 2399, 36, false);

#line default
#line hidden
            WriteAttributeValue("", 2435, "\'", 2435, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n        </td>\n    </tr>\n</table>");
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
