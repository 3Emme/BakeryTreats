#pragma checksum "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Engineers\AddMachine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fabf9bd658d2d53b434d3966b31e92b986ead53b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Engineers_AddMachine), @"mvc.1.0.view", @"/Views/Engineers/AddMachine.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Engineers/AddMachine.cshtml", typeof(AspNetCore.Views_Engineers_AddMachine))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fabf9bd658d2d53b434d3966b31e92b986ead53b", @"/Views/Engineers/AddMachine.cshtml")]
    public class Views_Engineers_AddMachine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Engineer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Engineers\AddMachine.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(62, 74, true);
            WriteLiteral("<h1>Assign a Machine</h1>\r\n<hr />\r\n<h3>Assign a Machine to this Engineer: ");
            EndContext();
            BeginContext(137, 44, false);
#line 7 "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Engineers\AddMachine.cshtml"
                                  Write(Html.DisplayFor(model => model.EngineerName));

#line default
#line hidden
            EndContext();
            BeginContext(181, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 8 "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Engineers\AddMachine.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(221, 41, false);
#line 10 "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Engineers\AddMachine.cshtml"
Write(Html.HiddenFor(model => model.EngineerId));

#line default
#line hidden
            EndContext();
            BeginContext(267, 28, false);
#line 11 "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Engineers\AddMachine.cshtml"
Write(Html.Label("Select Machine"));

#line default
#line hidden
            EndContext();
            BeginContext(300, 30, false);
#line 12 "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Engineers\AddMachine.cshtml"
Write(Html.DropDownList("MachineId"));

#line default
#line hidden
            EndContext();
            BeginContext(332, 70, true);
            WriteLiteral("  <input type=\"submit\" value=\"Add\" class=\"btn btn-success btn-sm\" />\r\n");
            EndContext();
#line 14 "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Engineers\AddMachine.cshtml"
}

#line default
#line hidden
            BeginContext(405, 11, true);
            WriteLiteral("<hr />\r\n<p>");
            EndContext();
            BeginContext(417, 105, false);
#line 16 "D:\Code\seeSharpProjects\Factory.Solution\factory\Views\Engineers\AddMachine.cshtml"
Write(Html.ActionLink("Cancel", "Details", new { id = Model.EngineerId}, new {@class="btn btn-primary btn-sm"}));

#line default
#line hidden
            EndContext();
            BeginContext(522, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Factory.Models.Engineer> Html { get; private set; }
    }
}
#pragma warning restore 1591
