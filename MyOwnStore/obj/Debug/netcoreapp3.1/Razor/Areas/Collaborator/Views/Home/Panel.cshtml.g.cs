#pragma checksum "C:\Users\Eduardo\Documents\DevOps\MyOwnStore\MyOwnStore\Areas\Collaborator\Views\Home\Panel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a5a340ddeb6a60b8ae0e937ba735f2d57c695a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Collaborator_Views_Home_Panel), @"mvc.1.0.view", @"/Areas/Collaborator/Views/Home/Panel.cshtml")]
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
#line 3 "C:\Users\Eduardo\Documents\DevOps\MyOwnStore\MyOwnStore\Areas\Collaborator\Views\_ViewImports.cshtml"
using MyOwnStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Eduardo\Documents\DevOps\MyOwnStore\MyOwnStore\Areas\Collaborator\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Eduardo\Documents\DevOps\MyOwnStore\MyOwnStore\Areas\Collaborator\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Eduardo\Documents\DevOps\MyOwnStore\MyOwnStore\Areas\Collaborator\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Eduardo\Documents\DevOps\MyOwnStore\MyOwnStore\Areas\Collaborator\Views\_ViewImports.cshtml"
using MyOwnStore.Libraries.Const;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a5a340ddeb6a60b8ae0e937ba735f2d57c695a1", @"/Areas/Collaborator/Views/Home/Panel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6c5424fa94c815134efb988ac563e53a1424a66", @"/Areas/Collaborator/Views/_ViewImports.cshtml")]
    public class Areas_Collaborator_Views_Home_Panel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Panel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Eduardo\Documents\DevOps\MyOwnStore\MyOwnStore\Areas\Collaborator\Views\Home\Panel.cshtml"
  
    ViewData["Title"] = "Panel";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <section role=""main"" class=""content-body"">
        <header class=""page-header"">
            <h2>Categorias</h2>

            <div class=""right-wrapper pull-right"">
                <ol class=""breadcrumbs"">
                    <li>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a5a340ddeb6a60b8ae0e937ba735f2d57c695a14992", async() => {
                WriteLiteral("\r\n                            <i class=\"fa fa-home\"></i>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </li>
                    <li><span>Categorias</span></li>
                </ol>

                <a class=""sidebar-right-toggle"" data-open=""sidebar-right""><i class=""fa fa-chevron-left""></i></a>
            </div>
        </header>
        <div class=""row"">
            <div class=""col-md-6 col-lg-12 col-xl-6"">
                <div class=""row"">
                    <div class=""col-md-12 col-lg-6 col-xl-6"">
                        <section class=""panel panel-featured-left panel-featured-primary"">
                            <div class=""panel-body"">
                                <div class=""widget-summary"">
                                    <div class=""widget-summary-col widget-summary-col-icon"">
                                        <div class=""summary-icon bg-primary"">
                                            <i class=""fa fa-life-ring""></i>
                                        </div>
                                    </div>
                                 ");
            WriteLiteral(@"   <div class=""widget-summary-col"">
                                        <div class=""summary"">
                                            <h4 class=""title"">Support Questions</h4>
                                            <div class=""info"">
                                                <strong class=""amount"">1281</strong>
                                                <span class=""text-primary"">(14 unread)</span>
                                            </div>
                                        </div>
                                        <div class=""summary-footer"">
                                            <a class=""text-muted text-uppercase"">(view all)</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </section>
                    </div>
                    <div class=""col-md-12 col-lg-6 col-xl-6"">
                        <sectio");
            WriteLiteral(@"n class=""panel panel-featured-left panel-featured-secondary"">
                            <div class=""panel-body"">
                                <div class=""widget-summary"">
                                    <div class=""widget-summary-col widget-summary-col-icon"">
                                        <div class=""summary-icon bg-secondary"">
                                            <i class=""fa fa-usd""></i>
                                        </div>
                                    </div>
                                    <div class=""widget-summary-col"">
                                        <div class=""summary"">
                                            <h4 class=""title"">Total Profit</h4>
                                            <div class=""info"">
                                                <strong class=""amount"">$ 14,890.30</strong>
                                            </div>
                                        </div>
                                    ");
            WriteLiteral(@"    <div class=""summary-footer"">
                                            <a class=""text-muted text-uppercase"">(withdraw)</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </section>
                    </div>
                    <div class=""col-md-12 col-lg-6 col-xl-6"">
                        <section class=""panel panel-featured-left panel-featured-tertiary"">
                            <div class=""panel-body"">
                                <div class=""widget-summary"">
                                    <div class=""widget-summary-col widget-summary-col-icon"">
                                        <div class=""summary-icon bg-tertiary"">
                                            <i class=""fa fa-shopping-cart""></i>
                                        </div>
                                    </div>
                                    <div c");
            WriteLiteral(@"lass=""widget-summary-col"">
                                        <div class=""summary"">
                                            <h4 class=""title"">Today's Orders</h4>
                                            <div class=""info"">
                                                <strong class=""amount"">38</strong>
                                            </div>
                                        </div>
                                        <div class=""summary-footer"">
                                            <a class=""text-muted text-uppercase"">(statement)</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </section>
                    </div>
                    <div class=""col-md-12 col-lg-6 col-xl-6"">
                        <section class=""panel panel-featured-left panel-featured-quartenary"">
                            <div class=""pane");
            WriteLiteral(@"l-body"">
                                <div class=""widget-summary"">
                                    <div class=""widget-summary-col widget-summary-col-icon"">
                                        <div class=""summary-icon bg-quartenary"">
                                            <i class=""fa fa-user""></i>
                                        </div>
                                    </div>
                                    <div class=""widget-summary-col"">
                                        <div class=""summary"">
                                            <h4 class=""title"">Today's Visitors</h4>
                                            <div class=""info"">
                                                <strong class=""amount"">3765</strong>
                                            </div>
                                        </div>
                                        <div class=""summary-footer"">
                                            <a class=""text-muted text-uppe");
            WriteLiteral(@"rcase"">(report)</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </section>
                    </div>
                </div>
            </div>
        </div>
    </section>");
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
