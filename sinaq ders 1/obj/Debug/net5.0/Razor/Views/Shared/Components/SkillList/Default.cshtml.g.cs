#pragma checksum "C:\Users\LENOVO\source\repos\sinaq ders 1\sinaq ders 1\Views\Shared\Components\SkillList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c360d5748c819b19d6dcc2d470bdd49e108ab7cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SkillList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SkillList/Default.cshtml")]
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
#line 1 "C:\Users\LENOVO\source\repos\sinaq ders 1\sinaq ders 1\Views\_ViewImports.cshtml"
using sinaq_ders_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\source\repos\sinaq ders 1\sinaq ders 1\Views\_ViewImports.cshtml"
using sinaq_ders_1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\LENOVO\source\repos\sinaq ders 1\sinaq ders 1\Views\Shared\Components\SkillList\Default.cshtml"
using EntityLayer.Concrate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c360d5748c819b19d6dcc2d470bdd49e108ab7cd", @"/Views/Shared/Components/SkillList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83bd4e85b508a93f7e4a9d842bbab21f25fb68c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SkillList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""section px-3 px-lg-4 pt-5"" id=""skills"">
    <div class=""container-narrow"">
        <div class=""text-center mb-5"">
            <h2 class=""marker marker-center"">Bacariqlarim</h2>
        </div>
        <div class=""text-center"">
            <p class=""mx-auto mb-3"" style=""max-width:600px"">Mən tez öyrənənəm və Veb Tətbiqlərinin İnkişafı və Məhsul Dizaynı üçün tələb olunan çoxsaylı bacarıqlar üzrə ixtisaslaşıram </p>
        </div>
        <div class=""bg-light p-3"">
            <div class=""row"">
                <div class=""col-md-12"">
");
#nullable restore
#line 14 "C:\Users\LENOVO\source\repos\sinaq ders 1\sinaq ders 1\Views\Shared\Components\SkillList\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"py-1\">\r\n                            <div class=\"d-flex text-small fw-bolder\"><span class=\"me-auto\">");
#nullable restore
#line 17 "C:\Users\LENOVO\source\repos\sinaq ders 1\sinaq ders 1\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span>");
#nullable restore
#line 17 "C:\Users\LENOVO\source\repos\sinaq ders 1\sinaq ders 1\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                                              Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span></div>\r\n                            <div class=\"progress my-1\">\r\n                                <div class=\"progress-bar bg-primary\" role=\"progressbar\" data-aos=\"zoom-in-right\" data-aos-delay=\"100\" data-aos-anchor=\".skills-section\"");
            BeginWriteAttribute("style", " style=\"", 1090, "\"", 1117, 3);
            WriteAttributeValue("", 1098, "width:", 1098, 6, true);
#nullable restore
#line 19 "C:\Users\LENOVO\source\repos\sinaq ders 1\sinaq ders 1\Views\Shared\Components\SkillList\Default.cshtml"
WriteAttributeValue(" ", 1104, item.Value, 1105, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1116, "%", 1116, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1118, "\"", 1145, 1);
#nullable restore
#line 19 "C:\Users\LENOVO\source\repos\sinaq ders 1\sinaq ders 1\Views\Shared\Components\SkillList\Default.cshtml"
WriteAttributeValue("", 1134, item.Value, 1134, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 22 "C:\Users\LENOVO\source\repos\sinaq ders 1\sinaq ders 1\Views\Shared\Components\SkillList\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; }
    }
}
#pragma warning restore 1591
