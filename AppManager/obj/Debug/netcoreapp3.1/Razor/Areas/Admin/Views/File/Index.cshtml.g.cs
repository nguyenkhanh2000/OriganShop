#pragma checksum "D:\Devmaster\AppManager\AppManager\Areas\Admin\Views\File\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57c49d5d6e2166c01c03c2620efa4bf617b6cbc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_File_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/File/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57c49d5d6e2166c01c03c2620efa4bf617b6cbc9", @"/Areas/Admin/Views/File/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_File_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Devmaster\AppManager\AppManager\Areas\Admin\Views\File\Index.cshtml"
  
    Layout = @"~/Areas/Admin/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("<h2> Quan ly File </h2>\r\n\r\n<div>\r\n    <p>Chon file</p>\r\n    <input type=\"file\" name=\"fileUpload\"/>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        <img src=\"/img/defaultd.png\" id=\"image-upload\" style=\"width:100%\"/>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).on('change','input[name=""fileUpload]', function(){
            let files = $(this).prop(""files"");
            let formData = new FormData();
            formData.append(""file"",files[0]);

            $.ajax({
                url:""/admin/file/uploadFile"",
                type: ""POST"",
                data: formData,
                contentType: false,
                processData: false,
                beforeSend:() => {},
                success: res => {
                    console.log(res);
                    if(res.status == ""success""){

                        $('#imageUpload').attr('src', res.fileInfo.filePath);
                    }else{
                        alert(""Co loi xay ra"");
                    }                   
                },
                error:error => {
                    console.log(error);
                }
            })
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591