#pragma checksum "C:\Users\alesy\source\repos\CoreBlogProject\CoreBlogProject\Views\Blog\BlogDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e75cc217e7fa3fc16745bdb19794014a71b05e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogDetails), @"mvc.1.0.view", @"/Views/Blog/BlogDetails.cshtml")]
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
#line 1 "C:\Users\alesy\source\repos\CoreBlogProject\CoreBlogProject\Views\_ViewImports.cshtml"
using CoreBlogProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alesy\source\repos\CoreBlogProject\CoreBlogProject\Views\_ViewImports.cshtml"
using CoreBlogProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alesy\source\repos\CoreBlogProject\CoreBlogProject\Views\_ViewImports.cshtml"
using BusinessLayer.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alesy\source\repos\CoreBlogProject\CoreBlogProject\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alesy\source\repos\CoreBlogProject\CoreBlogProject\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\alesy\source\repos\CoreBlogProject\CoreBlogProject\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\alesy\source\repos\CoreBlogProject\CoreBlogProject\Views\_ViewImports.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e75cc217e7fa3fc16745bdb19794014a71b05e5", @"/Views/Blog/BlogDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f16fc60483d16c90ff9f997cdcd85ba6291245a", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Template/css/single.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Template/images/b1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Template/images/banner1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Template/images/2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\alesy\source\repos\CoreBlogProject\CoreBlogProject\Views\Blog\BlogDetails.cshtml"
  
    ViewData["Title"] = "BlogDetails";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("css", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8e75cc217e7fa3fc16745bdb19794014a71b05e57846", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"<section class=""banner-bottom"">
    <!--/blog-->
    <div class=""container"">
        <div class=""row"">
            <!--left-->
            <div class=""col-lg-8 left-blog-info-w3layouts-agileits text-left"">
                <div class=""blog-grid-top"">
                    <div class=""b-grid-top"">
                        <div class=""blog_info_left_grid"">
                            <a href=""single.html"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8e75cc217e7fa3fc16745bdb19794014a71b05e59541", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </a>
                        </div>
                        <div class=""blog-info-middle"">
                            <ul>
                                <li>
                                    <a href=""#"">
                                        <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 26 "C:\Users\alesy\source\repos\CoreBlogProject\CoreBlogProject\Views\Blog\BlogDetails.cshtml"
                                                                       Write(Model.BlogDate.ToString("ddddd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </a>
                                </li>
                                <li class=""mx-2"">
                                    <a href=""#"">
                                        <i class=""far fa-thumbs-up""></i> 201 Likes
                                    </a>
                                </li>
                                <li>
                                    <a href=""#"">
                                        <i class=""far fa-comment""></i> 15 Comments
                                    </a>
                                </li>

                            </ul>
                        </div>
                    </div>

                    <h3>
                        <a href=""single.html"">");
#nullable restore
#line 45 "C:\Users\alesy\source\repos\CoreBlogProject\CoreBlogProject\Views\Blog\BlogDetails.cshtml"
                                         Write(Model.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                    </h3>\r\n                    <p>\r\n                        ");
#nullable restore
#line 48 "C:\Users\alesy\source\repos\CoreBlogProject\CoreBlogProject\Views\Blog\BlogDetails.cshtml"
                   Write(Model.BlogContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <div>\r\n                        <div class=\"comment-top\">\r\n                            <h4>Leave a Comment</h4>\r\n");
#nullable restore
#line 53 "C:\Users\alesy\source\repos\CoreBlogProject\CoreBlogProject\Views\Blog\BlogDetails.cshtml"
                             if (User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"comment-bottom\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e75cc217e7fa3fc16745bdb19794014a71b05e513326", async() => {
                WriteLiteral(@"
                            <textarea class=""form-control"" id=""commentinfo"" placeholder=""Write Comment..."" required></textarea>
                            <button type=""button"" class=""btn btn-primary submit"" onclick=""postComment()"">Submit</button>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div> ");
#nullable restore
#line 60 "C:\Users\alesy\source\repos\CoreBlogProject\CoreBlogProject\Views\Blog\BlogDetails.cshtml"
                           }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"/Login/Index\" class=\"btn btn-success\">Login for Comment</a>");
#nullable restore
#line 63 "C:\Users\alesy\source\repos\CoreBlogProject\CoreBlogProject\Views\Blog\BlogDetails.cshtml"
                                                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        ");
#nullable restore
#line 65 "C:\Users\alesy\source\repos\CoreBlogProject\CoreBlogProject\Views\Blog\BlogDetails.cshtml"
                   Write(await Component.InvokeAsync("Comment", new { id = Model.BlogId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <!--//left-->
                    <!--right-->
                    <aside class=""col-lg-4 agileits-w3ls-right-blog-con text-right"">
                        <div class=""right-blog-info text-left"">
                            <div class=""tech-btm"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8e75cc217e7fa3fc16745bdb19794014a71b05e516432", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""tech-btm"">
                                <h4>Sign up to our newsletter</h4>
                                <p>Pellentesque dui, non felis. Maecenas male </p>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e75cc217e7fa3fc16745bdb19794014a71b05e517903", async() => {
                WriteLiteral("\r\n                                    <input type=\"email\" placeholder=\"Email\"");
                BeginWriteAttribute("required", " required=\"", 3664, "\"", 3675, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <input type=\"submit\" value=\"Subscribe\">\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                            </div>
                            <div class=""tech-btm"">
                                <h4>Categories</h4>
                                <ul class=""list-group single"">
                                    <li class=""list-group-item d-flex justify-content-between align-items-center"">
                                        Cras justo odio
                                        <span class=""badge badge-primary badge-pill"">14</span>
                                    </li>
                                    <li class=""list-group-item d-flex justify-content-between align-items-center"">
                                        Dapibus ac facilisis in
                                        <span class=""badge badge-primary badge-pill"">2</span>
                                    </li>
                                    <li class=""list-group-item d-flex justify-content-between align-items-center"">
                                        Morbi leo risus
           ");
            WriteLiteral(@"                             <span class=""badge badge-primary badge-pill"">1</span>
                                    </li>
                                </ul>
                            </div>
                            <div class=""tech-btm"">
                                <h4>Top stories of the week</h4>

                                <div class=""blog-grids row mb-3"">
                                    <div class=""col-md-5 blog-grid-left"">
                                        <a href=""single.html"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8e75cc217e7fa3fc16745bdb19794014a71b05e521426", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </a>
                                    </div>
                                    <div class=""col-md-7 blog-grid-right"">

                                        <h5>
                                            <a href=""single.html"">Pellentesque dui, non felis. Maecenas male non felis </a>
                                        </h5>
                                        <div class=""sub-meta"">
                                            <span>
                                                <i class=""far fa-clock""></i> 20 Jan, 2018
                                            </span>
                                        </div>
                                    </div>

                                </div>
                                <div class=""blog-grids row mb-3"">
                                    <div class=""col-md-5 blog-grid-left"">
                                        <a href=""single.html"">
                                    ");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8e75cc217e7fa3fc16745bdb19794014a71b05e523698", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </a>
                                    </div>
                                    <div class=""col-md-7 blog-grid-right"">
                                        <h5>
                                            <a href=""single.html"">Pellentesque dui, non felis. Maecenas male non felis </a>
                                        </h5>
                                        <div class=""sub-meta"">
                                            <span>
                                                <i class=""far fa-clock""></i> 20 Feb, 2018
                                            </span>
                                        </div>
                                    </div>

                                </div>
                            </div>
                            <div class=""single-gd my-5 tech-btm"">
                                <h4>Our Progress</h4>
                                <div class=""progress"">
                              ");
            WriteLiteral(@"      <div class=""progress-bar progress-bar-striped"" role=""progressbar"" style=""width: 10%"" aria-valuenow=""10"" aria-valuemin=""0""
                                         aria-valuemax=""100""></div>
                                </div>
                                <div class=""progress"">
                                    <div class=""progress-bar progress-bar-striped bg-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0""
                                         aria-valuemax=""100""></div>
                                </div>
                                <div class=""progress"">
                                    <div class=""progress-bar progress-bar-striped bg-info"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0""
                                         aria-valuemax=""100""></div>
                                </div>
                                <div class=""progress"">
                                    <div class=""progress-bar pr");
            WriteLiteral(@"ogress-bar-striped bg-warning"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0""
                                         aria-valuemax=""100""></div>
                                </div>
                                <div class=""progress"">
                                    <div class=""progress-bar progress-bar-striped bg-danger"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0""
                                         aria-valuemax=""100""></div>
                                </div>
                            </div>
                            <div class=""single-gd tech-btm"">
                                <h4>Recent Post</h4>
                                <div class=""blog-grids"">
                                    <div class=""blog-grid-left"">
                                        <a href=""single.html"">
                                            <img src=""images/b1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 9570, "\"", 9576, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </a>
                                    </div>
                                    <div class=""blog-grid-right"">

                                        <h5>
                                            <a href=""single.html"">Pellentesque dui, non felis. Maecenas male</a>
                                        </h5>
                                    </div>
                                    <div class=""clearfix""> </div>
                                </div>
                            </div>
                        </div>

                    </aside>
                    <!--//right-->
                </div>
            </div>
</section>

<script>
    let textArea = document.getElementById(""commentinfo"");
        function postComment() {
            let data = textArea.value;
            console.log(data);
            $.ajax({
                type: ""POST"",
                url: ""/Comment/CommentPost/"",
                data: { content: d");
            WriteLiteral("ata, blogid: ");
#nullable restore
#line 197 "C:\Users\alesy\source\repos\CoreBlogProject\CoreBlogProject\Views\Blog\BlogDetails.cshtml"
                                          Write(Model.BlogId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" },
                success: function (comment) {
                    alert(comment)
                    let cont = document.querySelector(""#cont"");
                    cont.innerHTML += `<div class=""media"">
    <img src=""~/Template/images/"" alt="""" class=""img-fluid"" />
    <div class=""media-body"">
        <h5 class=""mt-0"">");
#nullable restore
#line 204 "C:\Users\alesy\source\repos\CoreBlogProject\CoreBlogProject\Views\Blog\BlogDetails.cshtml"
                    Write(Model.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
        <p>
            ${data}
        </p>
    </div>
</div>`
                },
                error: function () {
                    alert('Failed to receive the Data');
                    console.log('Failed ');
                }
            });
    };
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
