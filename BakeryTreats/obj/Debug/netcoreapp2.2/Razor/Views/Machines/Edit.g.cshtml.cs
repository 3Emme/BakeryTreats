#pragma checksum "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Machines\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93302b4e5c47bd0dda56b5b08442ab075edb8178"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Machines_Edit), @"mvc.1.0.view", @"/Views/Machines/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Machines/Edit.cshtml", typeof(AspNetCore.Views_Machines_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93302b4e5c47bd0dda56b5b08442ab075edb8178", @"/Views/Machines/Edit.cshtml")]
    public class Views_Machines_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Machine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Machines\Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(61, 17, true);
            WriteLiteral("<h3>Edit Machine ");
            EndContext();
            BeginContext(79, 43, false);
#line 5 "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Machines\Edit.cshtml"
            Write(Html.DisplayFor(model => model.MachineName));

#line default
#line hidden
            EndContext();
            BeginContext(122, 15, true);
            WriteLiteral("</h3>\r\n<hr />\r\n");
            EndContext();
#line 7 "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Machines\Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(170, 40, false);
#line 9 "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.HiddenFor(model => model.MachineId));

#line default
#line hidden
            EndContext();
            BeginContext(215, 19, false);
#line 10 "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.Label("Name:"));

#line default
#line hidden
            EndContext();
            BeginContext(239, 69, false);
#line 11 "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.EditorFor(model => model.MachineName,new {@required="required"}));

#line default
#line hidden
            EndContext();
            BeginContext(313, 26, false);
#line 12 "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.Label("Description:"));

#line default
#line hidden
            EndContext();
            BeginContext(344, 76, false);
#line 13 "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.EditorFor(model => model.MachineDescription,new {@required="required"}));

#line default
#line hidden
            EndContext();
            BeginContext(425, 21, false);
#line 14 "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.Label("Status:"));

#line default
#line hidden
            EndContext();
            BeginContext(451, 298, false);
#line 15 "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.DropDownListFor(model => model.MachineStatus, new List<SelectListItem>
  { new SelectListItem{Text="Operational", Value="Operational"},
    new SelectListItem{Text="Malfunctioning", Value="Malfunctioning"},
    new SelectListItem{Text="In Repair", Value="In Repair"}
  },"-Please select-"));

#line default
#line hidden
            EndContext();
            BeginContext(751, 60, true);
            WriteLiteral("  <br><br>\r\n  <input type=\"submit\" value=\"Save Changes\" />\r\n");
            EndContext();
#line 22 "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Machines\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(814, 11, true);
            WriteLiteral("<hr />\r\n<p>");
            EndContext();
            BeginContext(826, 85, false);
#line 24 "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.ActionLink("Cancel", "Index", null, null, new {@class="btn btn-primary btn-sm"}));

#line default
#line hidden
            EndContext();
            BeginContext(911, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Factory.Models.Machine> Html { get; private set; }
    }
}
#pragma warning restore 1591
