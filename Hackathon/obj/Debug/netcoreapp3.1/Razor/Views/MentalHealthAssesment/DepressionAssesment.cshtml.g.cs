#pragma checksum "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\DepressionAssesment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cc5b246f4e42fffde265c2bb30520dc5f4d41a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MentalHealthAssesment_DepressionAssesment), @"mvc.1.0.view", @"/Views/MentalHealthAssesment/DepressionAssesment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cc5b246f4e42fffde265c2bb30520dc5f4d41a6", @"/Views/MentalHealthAssesment/DepressionAssesment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"793605a08a66d7a43a86a8f914b921497e372700", @"/Views/_ViewImports.cshtml")]
    public class Views_MentalHealthAssesment_DepressionAssesment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#line 2 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\DepressionAssesment.cshtml"
  
    ViewData["Title"] = "DepressionAssesment";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            WriteLiteral("\n<h1  style=\"color:darkgoldenrod\">Depression  Assesment</h1>\n<table style=\"color:darkgoldenrod\">\n    <tr>\n        <td>\n            Do you feel sad or hopeless?\n        </td>\n           \n    </tr>\n    <tr>\n        <td>Yes ");
#line 16 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\DepressionAssesment.cshtml"
           Write(Html.RadioButton("hopeless", "Yes"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp; No ");
#line 16 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\DepressionAssesment.cshtml"
                                                                           Write(Html.RadioButton("hopeless", "No"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;</td>\n    </tr>\n    <tr>\n        <td>Have you lost interest in most of your daily chores?</td>\n    </tr>\n    <tr>\n        <td> Yes ");
#line 22 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\DepressionAssesment.cshtml"
            Write(Html.RadioButton("lossofinterest", "Yes"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp; No ");
#line 22 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\DepressionAssesment.cshtml"
                                                                                  Write(Html.RadioButton("lossofinterest", "No"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;</td>\n    </tr>\n    <tr>\n        <td>Have you lost OR gained weight suddenly?</td>\n    </tr>\n    <tr>\n        <td>Yes ");
#line 28 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\DepressionAssesment.cshtml"
           Write(Html.RadioButton("weight", "Yes"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp; No ");
#line 28 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\DepressionAssesment.cshtml"
                                                                         Write(Html.RadioButton("weight", "No"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;</td>\n    </tr>\n    <tr>\n        <td>Have you recently started too much binge eating?</td>\n    </tr>\n    <tr>\n        <td>Yes ");
#line 34 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\DepressionAssesment.cshtml"
           Write(Html.RadioButton("bingeeating", "Yes"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp; No ");
#line 34 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\DepressionAssesment.cshtml"
                                                                              Write(Html.RadioButton("bingeeating", "No"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;</td>\n    </tr>\n    <tr>\n        <td>Have you recently lost your appetite by more than 70%-80%?</td>\n    </tr>\n    <tr>\n        <td>Yes ");
#line 40 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\DepressionAssesment.cshtml"
           Write(Html.RadioButton("lossofappetite", "Yes"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp; No ");
#line 40 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\DepressionAssesment.cshtml"
                                                                                 Write(Html.RadioButton("lossofappetite", "No"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;</td>\n    </tr>\n    <tr>\n        <td>Do you feel restless and/or are unable to sit still?</td>\n    </tr>\n    <tr>\n        <td>Yes ");
#line 46 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\DepressionAssesment.cshtml"
           Write(Html.RadioButton("sitstill", "Yes"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp; No ");
#line 46 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\DepressionAssesment.cshtml"
                                                                           Write(Html.RadioButton("sitstill", "No"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;</td>\n    </tr>\n    <tr>\n        <td>Do you feel unworthy and/or guilty every other day?</td>\n    </tr>\n    <tr>\n        <td>Yes ");
#line 52 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\DepressionAssesment.cshtml"
           Write(Html.RadioButton("guilt", "Yes"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp; No ");
#line 52 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\DepressionAssesment.cshtml"
                                                                        Write(Html.RadioButton("guilt", "No"));

#line default
#line hidden
            WriteLiteral(@"&nbsp;&nbsp;&nbsp;&nbsp;</td>
    </tr>
    <tr>
        <td>Have you experienced a week or longer of lower-than-usual interest in activities that you usually enjoy? Examples might include work, exercise, or hobbies.</td>
    </tr>
    <tr>
        <td>Yes ");
#line 58 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\DepressionAssesment.cshtml"
           Write(Html.RadioButton("lowintrestinhobbies", "Yes"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp; No ");
#line 58 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\DepressionAssesment.cshtml"
                                                                                      Write(Html.RadioButton("lowintrestinhobbies", "No"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;</td>\n    </tr>\n    <tr>\n        <td>Do you find it hard to focus, remember things, or make decisions quite often?</td>\n    </tr>\n    <tr>\n        <td>\n            Yes ");
#line 65 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\DepressionAssesment.cshtml"
           Write(Html.RadioButton("hardtofocus", "Yes"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp; No ");
#line 65 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\DepressionAssesment.cshtml"
                                                                              Write(Html.RadioButton("hardtofocus", "No"));

#line default
#line hidden
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;\n        </td>\n    </tr>\n    <tr>\n        <td>  <input  class=\"btn btn-info\" style=\"color:darkgoldenrod;background-color:white;\" value=\"Submit\" id=\"btnSubmit\"");
            BeginWriteAttribute("onclick", "   onclick=\"", 2804, "\"", 2868, 3);
            WriteAttributeValue("", 2816, "location.href=\'", 2816, 15, true);
#line 69 "D:\Hackathon\CovidBusters-master\CovidBusters-master\Hackathon\Views\MentalHealthAssesment\DepressionAssesment.cshtml"
WriteAttributeValue("", 2831, Url.Action("Index", "UnderProcess"), 2831, 36, false);

#line default
#line hidden
            WriteAttributeValue("", 2867, "\'", 2867, 1, true);
            EndWriteAttribute();
            WriteLiteral("></td>\n    </tr>\n</table>");
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
