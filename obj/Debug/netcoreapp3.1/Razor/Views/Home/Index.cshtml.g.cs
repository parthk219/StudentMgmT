#pragma checksum "C:\Users\parth\source\repos\StudentMGMT\StudentMGMT\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b000ede89f76704211e316f24e19d04c45c2f03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\parth\source\repos\StudentMGMT\StudentMGMT\Views\_ViewImports.cshtml"
using StudentMGMT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\parth\source\repos\StudentMGMT\StudentMGMT\Views\_ViewImports.cshtml"
using StudentMGMT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b000ede89f76704211e316f24e19d04c45c2f03", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c44389cd3824fceb4cc0cdbb3ac4020905e9c136", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\parth\source\repos\StudentMGMT\StudentMGMT\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Latest compiled and minified CSS -->
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">

<!-- jQuery library -->
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js""></script>

<!-- Latest compiled JavaScript -->
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>

<script>
    $(document).ready(function () {
        //wrong in bracket after {}  {} was left
        $(""#btns"").click(function () {
            var n = $(""#txtname"").val();   //# was left !!
            var m = $(""#txtmob"").val();
            var em = $(""#txtemail"").val();
            var d = $(""#txtdob"").val();
            //alert(""OK"")


            $.ajax({
                type: ""POST"",
                url: ""/Home/InsertRecord"",
                data: 'name=' + n + '&mob=' + m + '&email=' + em + '&dob=' + d,
               success:function(data) {
                    alert(""RECORD SAVED"")
          ");
            WriteLiteral(@"          $(""#txtname"").val("""");   // = null so that value will be reset
                    $(""#txtmob"").val("""") ;
                    $(""#txtemail"").val("""");
                    $(""#txtdob"").val("""");

                },
                error: function () {
                    alert(""Something went wrong"");
                }
                
         //$(""#txtname"").val() = """";   // = null so that value will be reset
         //       $(""#txtmob"").val() = """";
         //       $(""#txtemail"").val() = """";
         //       $(""#txtdob"").val() = """";


            })
        })
    })
</script>




<div class=""text-center"">
    <h1 class=""display-4"">Student Management</h1>
");
            WriteLiteral("</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b000ede89f76704211e316f24e19d04c45c2f035129", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-4"" style=""border: 5px solid lightgreen;"" >
                Name
                <input type=""text"" id=""txtname"" class=""form-control"" />
                Mobile Number
                <input type=""number"" id=""txtmob"" class=""form-control"" />
                E-mail
                <input type=""text"" id=""txtemail"" class=""form-control"" />
                Date of Birth
                <input type=""date"" id=""txtdob"" class=""form-control"" />
                <br /><br />
                <button class=""btn btn-success"" id=""btns"">Save record</button>
                <a href=""/Home/display"" class=""btn btn-danger"">Display Record</a>
            </div>
        </div>
        </div>
");
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
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
