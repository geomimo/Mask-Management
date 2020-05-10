#pragma checksum "C:\Users\GeoMimo\source\repos\MaskManagement\MaskManagement\Views\Shared\_MasksTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0381d708216f1627477400017e70aa74c2b76cab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MasksTable), @"mvc.1.0.view", @"/Views/Shared/_MasksTable.cshtml")]
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
#line 1 "C:\Users\GeoMimo\source\repos\MaskManagement\MaskManagement\Views\_ViewImports.cshtml"
using MaskManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GeoMimo\source\repos\MaskManagement\MaskManagement\Views\_ViewImports.cshtml"
using MaskManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0381d708216f1627477400017e70aa74c2b76cab", @"/Views/Shared/_MasksTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e50cf094022a8f4e5e89d6359294792e4e3f0872", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MasksTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MaskVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<label class=""control-label"">Choose masks</label>
<table asp-for=""SelectedMasks"" class=""table"">
    <thead>
        <tr>
            <th>
                Fabric Id
            </th>
            <th>
                Description
            </th>
            <th>
                Image
            </th>
            <th>
                Quantity
            </th>
            <th>
                Add
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 25 "C:\Users\GeoMimo\source\repos\MaskManagement\MaskManagement\Views\Shared\_MasksTable.cshtml"
         foreach (var m in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\GeoMimo\source\repos\MaskManagement\MaskManagement\Views\Shared\_MasksTable.cshtml"
               Write(m.FabricId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\GeoMimo\source\repos\MaskManagement\MaskManagement\Views\Shared\_MasksTable.cshtml"
               Write(m.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=", 770, "", 788, 2);
            WriteAttributeValue("", 775, "\\", 775, 1, true);
#nullable restore
#line 35 "C:\Users\GeoMimo\source\repos\MaskManagement\MaskManagement\Views\Shared\_MasksTable.cshtml"
WriteAttributeValue("", 776, m.ImagePath, 776, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\" />\r\n                </td>\r\n                <td>\r\n                    <div class=\"input-group-sm col-6\">\r\n                        <input class=\"form-control\" type=\"number\"");
            BeginWriteAttribute("id", " id=", 981, "", 996, 1);
#nullable restore
#line 39 "C:\Users\GeoMimo\source\repos\MaskManagement\MaskManagement\Views\Shared\_MasksTable.cshtml"
WriteAttributeValue("", 985, m.FabricId, 985, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\"1\" />\r\n                    </div>\r\n                </td>\r\n                <td>\r\n                    <a class=\"btn btn-success text-dark\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1140, "\"", 1172, 3);
            WriteAttributeValue("", 1150, "addMask(\'", 1150, 9, true);
#nullable restore
#line 43 "C:\Users\GeoMimo\source\repos\MaskManagement\MaskManagement\Views\Shared\_MasksTable.cshtml"
WriteAttributeValue("", 1159, m.FabricId, 1159, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1170, "\')", 1170, 2, true);
            EndWriteAttribute();
            WriteLiteral(">+</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 46 "C:\Users\GeoMimo\source\repos\MaskManagement\MaskManagement\Views\Shared\_MasksTable.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MaskVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591