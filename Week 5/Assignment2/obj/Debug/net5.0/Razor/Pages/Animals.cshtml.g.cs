#pragma checksum "C:\Users\jdcol\Google Drive\School\Semester 7 (21SP - Spring 2021)\Web Development .NET\Week 5\Assignment2\Pages\Animals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9359fbe5f3f81a03deaf0a9644cf181bb8ab340c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Assignment2.Pages.Pages_Animals), @"mvc.1.0.razor-page", @"/Pages/Animals.cshtml")]
namespace Assignment2.Pages
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
#line 1 "C:\Users\jdcol\Google Drive\School\Semester 7 (21SP - Spring 2021)\Web Development .NET\Week 5\Assignment2\Pages\_ViewImports.cshtml"
using Assignment2;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9359fbe5f3f81a03deaf0a9644cf181bb8ab340c", @"/Pages/Animals.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91771f1eebd9d7f06a7f96c184e0efa222d6330c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Animals : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\jdcol\Google Drive\School\Semester 7 (21SP - Spring 2021)\Web Development .NET\Week 5\Assignment2\Pages\Animals.cshtml"
  
    ViewData["Title"] = "Animals";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"p-3\">Amazing Animals</h1>\r\n<p class=\"px-3\">Animals can be found all over the world.</p>\r\n\r\n<div class=\"card-columns\">\r\n\r\n");
#nullable restore
#line 12 "C:\Users\jdcol\Google Drive\School\Semester 7 (21SP - Spring 2021)\Web Development .NET\Week 5\Assignment2\Pages\Animals.cshtml"
     foreach (var animal in Model.Animals)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\" style=\"height: 450px\">\r\n            <div class=\"card-body\">\r\n                <h2 class=\"card-title\">");
#nullable restore
#line 16 "C:\Users\jdcol\Google Drive\School\Semester 7 (21SP - Spring 2021)\Web Development .NET\Week 5\Assignment2\Pages\Animals.cshtml"
                                  Write(animal.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p>");
#nullable restore
#line 17 "C:\Users\jdcol\Google Drive\School\Semester 7 (21SP - Spring 2021)\Web Development .NET\Week 5\Assignment2\Pages\Animals.cshtml"
              Write(animal.ScientificName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>(");
#nullable restore
#line 18 "C:\Users\jdcol\Google Drive\School\Semester 7 (21SP - Spring 2021)\Web Development .NET\Week 5\Assignment2\Pages\Animals.cshtml"
               Write(animal.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 525, "\"", 544, 1);
#nullable restore
#line 19 "C:\Users\jdcol\Google Drive\School\Semester 7 (21SP - Spring 2021)\Web Development .NET\Week 5\Assignment2\Pages\Animals.cshtml"
WriteAttributeValue("", 531, animal.Image, 531, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 250px\"");
            BeginWriteAttribute("alt", " alt=\"", 566, "\"", 608, 3);
#nullable restore
#line 19 "C:\Users\jdcol\Google Drive\School\Semester 7 (21SP - Spring 2021)\Web Development .NET\Week 5\Assignment2\Pages\Animals.cshtml"
WriteAttributeValue("", 572, animal.Name, 572, 12, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\jdcol\Google Drive\School\Semester 7 (21SP - Spring 2021)\Web Development .NET\Week 5\Assignment2\Pages\Animals.cshtml"
WriteAttributeValue(" ", 584, animal.ScientificName, 585, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 607, "", 608, 1, true);
            EndWriteAttribute();
            WriteLiteral("/>\r\n            </div>\r\n        </div> \r\n");
#nullable restore
#line 22 "C:\Users\jdcol\Google Drive\School\Semester 7 (21SP - Spring 2021)\Web Development .NET\Week 5\Assignment2\Pages\Animals.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assignment2.Pages.AnimalsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Assignment2.Pages.AnimalsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Assignment2.Pages.AnimalsModel>)PageContext?.ViewData;
        public Assignment2.Pages.AnimalsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
