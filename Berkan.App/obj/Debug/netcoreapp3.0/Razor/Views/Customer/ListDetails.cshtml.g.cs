#pragma checksum "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68aedc0da1cec3f0846fa76922f06b14bc4c8c9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_ListDetails), @"mvc.1.0.view", @"/Views/Customer/ListDetails.cshtml")]
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
#line 3 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\_ViewImports.cshtml"
using Berkan.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\_ViewImports.cshtml"
using Berkan.App.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68aedc0da1cec3f0846fa76922f06b14bc4c8c9e", @"/Views/Customer/ListDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2c2f2dcbc4f8675c044582980debf6315ed4ae0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_ListDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerList>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-danger pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CustomerItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""d-flex align-items-center p-3 my-3 text-white bg-primary rounded shadow-sm"">
    <img src=""https://cdn2.iconfinder.com/data/icons/avatars-2-7/128/4-512.png"" width=""48"" height=""38"" style=""margin-right:10px"" />
    <div class=""lh-1"">
        <h1 class=""h6 mb-0 text-white lh-1"">");
#nullable restore
#line 6 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
                                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    </div>\n    <div class=\"align-items-right mt-3\" style=\"width:85%\"></div>\n    <small class=\"d-block text-right mt-3\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68aedc0da1cec3f0846fa76922f06b14bc4c8c9e7119", async() => {
                WriteLiteral("<i class=\"fa fa-edit\"></i>Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-listId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
                                                                                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["listId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-listId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["listId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </small>\n</div>\n\n<div class=\"my-3 p-3 bg-body rounded shadow-sm\">\n");
#nullable restore
#line 15 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
     foreach (var item in Model.CustomerItems)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"d-flex text-muted pt-3\">\n\n");
#nullable restore
#line 19 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
              
                double hours = (item.EndDate - DateTime.Now).TotalHours;
                double day = (item.EndDate - DateTime.Now).TotalDays;
                int IntDay = (int) day;            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"pb-3 mb-0 small lh-sm border-bottom\" style=\"width:100%\">\n\n");
#nullable restore
#line 25 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
                 if (item.Completed)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"btn btn-sm btn-success\"> Completed</span>\n");
#nullable restore
#line 28 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
                }
                else if (hours > 24)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"btn btn-sm btn-primary\"> ");
#nullable restore
#line 31 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
                                                     Write(IntDay);

#line default
#line hidden
#nullable disable
            WriteLiteral(" days left until the last payment.</span>\n");
#nullable restore
#line 32 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
                }
                else if (hours > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"btn btn-sm btn-warning\"> less then 1 day</span>\n");
#nullable restore
#line 36 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"btn btn-sm btn-danger\"> Missed!</span>\n");
#nullable restore
#line 40 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68aedc0da1cec3f0846fa76922f06b14bc4c8c9e12335", async() => {
                WriteLiteral("<i class=\"fa fa-trash\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-itemId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
                                                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-itemId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68aedc0da1cec3f0846fa76922f06b14bc4c8c9e14905", async() => {
                WriteLiteral("<i class=\"fa fa-edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-itemId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
                                                                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-itemId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 43 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
                  
                    var endTime = item.EndDate.AddMilliseconds(-1 * item.EndDate.Millisecond).TimeOfDay;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <strong class=\"d-block text-gray-dark\"><p1>Last Payment Date: </p1>");
#nullable restore
#line 46 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
                                                                              Write(item.EndDate.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 46 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
                                                                                                   Write(endTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong>\n                <span style=\"color:blue;font-weight:bold\">");
#nullable restore
#line 47 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
                                                     Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n            </p>\n        </div>\n");
#nullable restore
#line 50 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <small class=\"d-block text-end mt-3\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68aedc0da1cec3f0846fa76922f06b14bc4c8c9e19101", async() => {
                WriteLiteral("Create New Item");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-listId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
                                                                                               WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["listId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-listId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["listId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </small>\n\n");
#nullable restore
#line 55 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
      
        var missedItems = Model.CustomerItems.Where(item => item.EndDate < DateTime.Now && !item.Completed);
        var incommingItems = Model.CustomerItems.Where(item => item.EndDate > DateTime.Now && item.EndDate < DateTime.Now.AddMinutes(10) && !item.Completed);


#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\n");
#nullable restore
#line 60 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
             foreach(var item in incommingItems)
            {
               

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
          Write(Html.Raw("alert('" + item.Text + " is in comming!');"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
                                                                      ;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </script>\n");
#nullable restore
#line 66 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
     if (!string.IsNullOrWhiteSpace(ViewBag.OperationMessage))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\n        alert(\"");
#nullable restore
#line 69 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
          Write(Html.Raw(ViewBag.OperationMessage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\n        </script>\n");
#nullable restore
#line 71 "C:\Users\90553\Desktop\EminEvim\Berkan.App\Views\Customer\ListDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerList> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
