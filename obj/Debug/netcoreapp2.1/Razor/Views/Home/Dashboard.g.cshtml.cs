#pragma checksum "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f8b4bc87fc80508708fcff85f06decf5650f245"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/_ViewImports.cshtml"
using BeltExam;

#line default
#line hidden
#line 2 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/_ViewImports.cshtml"
using BeltExam.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f8b4bc87fc80508708fcff85f06decf5650f245", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a84119000702c45f5036e3e300b27d647b6aca13", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 24, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n\n");
            EndContext();
            BeginContext(24, 537, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "555820d3612c4d44a39e6df92ec00911", async() => {
                BeginContext(30, 524, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Page Title</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css""
        integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""main.css"">
    <script src=""main.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(561, 120, true);
            WriteLiteral("\n<style>\n    body {\n        background-color: rgb(231, 235, 219);\n    }\n    .alert{\n        color: red;\n    }\n</style>\n\n");
            EndContext();
            BeginContext(681, 3317, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45b8b3a1863346f3894ce19d5aa1f5a4", async() => {
                BeginContext(687, 727, true);
                WriteLiteral(@"
    <div class=""header"">
        <nav class=""navbar navbar-expand-lg navbar-light "" style=""background-color: #eb9ab9; font-size: 15px"">
            <h2> Coding Dojo Center</h2>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarTogglerDemo02""
                aria-controls=""navbarTogglerDemo02"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>

            <div class=""collapse navbar-collapse"" id=""navbarTogglerDemo02"">
                <ul class=""navbar-nav mr-auto mt-2 mt-lg-0"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""#"">Welcome ");
                EndContext();
                BeginContext(1415, 25, false);
#line 35 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
                                                        Write(ViewBag.CurUser.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(1440, 442, true);
                WriteLiteral(@"! <span class=""sr-only"">(current)</span></a>
                    </li>
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""/NewAct"">Add New Activity <span class=""sr-only"">(current)</span></a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Logout"">Logout</a>
                    </li>

                </ul>
                ");
                EndContext();
                BeginContext(1882, 258, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbe8f71053a747249946d3f1d245aaa2", async() => {
                    BeginContext(1921, 212, true);
                    WriteLiteral("\n                    <input class=\"form-control mr-sm-2\" type=\"search\" placeholder=\"Search\">\n                    <button class=\"btn btn-outline-success my-2 my-sm-0\" type=\"submit\">Search</button>\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2140, 67, true);
                WriteLiteral("\n            </div>\n        </nav>\n    </div>\n    <!-- <h3>Welcome ");
                EndContext();
                BeginContext(2208, 25, false);
#line 52 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
                Write(ViewBag.CurUser.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(2233, 535, true);
                WriteLiteral(@" to Dashboard</h3> -->
    <!-- <a href=""/Logout"">Logout</a>
    <a href=""NewAct"">Add New Activity</a> -->
    <table class=""table"">
        <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">Activity</th>
                <th scope=""col"">Date & Time</th>
                <th scope=""col"">Duration</th>
                <th scope=""col"">Event Cordinator</th>
                <th scope=""col"">Number of Participants</th>
                <th scope=""col"">Action</th>
            </tr>
        </thead>
        <tbody>
");
                EndContext();
#line 67 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
             foreach(var e in ViewBag.AllActs){

#line default
#line hidden
                BeginContext(2816, 39, true);
                WriteLiteral("            <tr>\n                <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2855, "\"", 2882, 2);
                WriteAttributeValue("", 2862, "Detail/", 2862, 7, true);
#line 69 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2869, e.ActivityId, 2869, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2883, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2885, 7, false);
#line 69 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
                                              Write(e.Title);

#line default
#line hidden
                EndContext();
                BeginContext(2892, 30, true);
                WriteLiteral("</a></td>\n                <td>");
                EndContext();
                BeginContext(2923, 36, false);
#line 70 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
               Write(e.Date.ToString("dddd, MM-dd-yyyy "));

#line default
#line hidden
                EndContext();
                BeginContext(2959, 4, true);
                WriteLiteral(" at ");
                EndContext();
                BeginContext(2964, 6, false);
#line 70 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
                                                        Write(e.Time);

#line default
#line hidden
                EndContext();
                BeginContext(2970, 27, true);
                WriteLiteral(" </td>\n                <td>");
                EndContext();
                BeginContext(2998, 13, false);
#line 71 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
               Write(e.DurationNum);

#line default
#line hidden
                EndContext();
                BeginContext(3011, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(3013, 13, false);
#line 71 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
                              Write(e.DurationStr);

#line default
#line hidden
                EndContext();
                BeginContext(3026, 26, true);
                WriteLiteral("</td>\n                <td>");
                EndContext();
                BeginContext(3053, 19, false);
#line 72 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
               Write(e.Creator.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(3072, 26, true);
                WriteLiteral("</td>\n                <td>");
                EndContext();
                BeginContext(3099, 17, false);
#line 73 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
               Write(e.UserToAct.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3116, 45, true);
                WriteLiteral("</td>\n                <!-- <td><a href=\"Join/");
                EndContext();
                BeginContext(3162, 12, false);
#line 74 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
                                  Write(e.ActivityId);

#line default
#line hidden
                EndContext();
                BeginContext(3174, 20, true);
                WriteLiteral("\">Join</a></td> -->\n");
                EndContext();
#line 75 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
                 if(ViewBag.CurUser.UserId != e.CreatorId){
                    int temp=0;
                    

#line default
#line hidden
#line 77 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
                     foreach( var guest in @e.UserToAct){
                        if(guest.Users== ViewBag.CurUser){
                            temp=guest.Users.UserId;
                        }
                    }

#line default
#line hidden
#line 82 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
                     if(temp==0){

#line default
#line hidden
                BeginContext(3538, 30, true);
                WriteLiteral("                        <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3568, "\"", 3594, 2);
                WriteAttributeValue("", 3575, "/Join/", 3575, 6, true);
#line 83 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 3581, e.ActivityId, 3581, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3595, 18, true);
                WriteLiteral(">Join</a></td>   \n");
                EndContext();
#line 84 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
                    }
                    else{

#line default
#line hidden
                BeginContext(3661, 26, true);
                WriteLiteral("                    <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3687, "\"", 3714, 2);
                WriteAttributeValue("", 3694, "/Leave/", 3694, 7, true);
#line 86 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 3701, e.ActivityId, 3701, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3715, 16, true);
                WriteLiteral(">Leave</a></td>\n");
                EndContext();
#line 87 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
                    }

#line default
#line hidden
#line 87 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
                     
                 
                } 
                else{

#line default
#line hidden
                BeginContext(3811, 7, true);
                WriteLiteral(" <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3818, "\"", 3846, 2);
                WriteAttributeValue("", 3825, "/Delete/", 3825, 8, true);
#line 90 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 3833, e.ActivityId, 3833, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3847, 17, true);
                WriteLiteral(">Delete</a></td>\n");
                EndContext();
#line 91 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
                }

#line default
#line hidden
                BeginContext(3882, 18, true);
                WriteLiteral("            </tr>\n");
                EndContext();
#line 93 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
            }

#line default
#line hidden
                BeginContext(3914, 53, true);
                WriteLiteral("        </tbody>\n    </table>\n    <div class=\"alert\">");
                EndContext();
                BeginContext(3968, 16, false);
#line 96 "/Users/joliepham/Desktop/C#.NET/ASP_MVC/BeltExam/Views/Home/Dashboard.cshtml"
                  Write(ViewBag.SameDate);

#line default
#line hidden
                EndContext();
                BeginContext(3984, 7, true);
                WriteLiteral("</div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3998, 9, true);
            WriteLiteral("\n\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
