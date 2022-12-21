#pragma checksum "D:\Devmaster\AppManager\AppManager\Areas\Admin\Views\ProductImage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2a52a68e214b5b7d1a2ad108e3c615c95451d06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductImage_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductImage/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2a52a68e214b5b7d1a2ad108e3c615c95451d06", @"/Areas/Admin/Views/ProductImage/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ProductImage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppManager.Models.ProductImageModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formSearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/ProductImage/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("get"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Devmaster\AppManager\AppManager\Areas\Admin\Views\ProductImage\Index.cshtml"
  

    Layout = @"~/Areas/Admin/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Danh sách ảnh sản phẩm";


#line default
#line hidden
#nullable disable
            WriteLiteral("<h2> Trang quan ly ảnh san pham </h2>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2a52a68e214b5b7d1a2ad108e3c615c95451d064105", async() => {
                WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3\">\r\n                <div class=\"form-inline mb-3\">\r\n                    <input type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 456, "\"", 464, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""nhập ký tự..."" class=""form-control"" />
                    <button class=""btn btn-primary ml-2""> Tìm kiếm </button>
                </div>
                <input type=""number"" id=""txtPageNumber"" name=""pageNumber"" value=""1"" />
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<table class=""table table-bordered table-striped"" border=""1"">
    <thead>
        <tr>
            <td>Stt</td>
            <td>Id sản phẩm</td>
            <td>Id File</td>
            <td>Ảnh</td>
            <td>Ngày tạo</td>
            <td>Ngày cập nhật</td>
            <td>Người tạo</td>
            <td>Người cập nhật</td>
            <td>Trạng thái</td>           
            <td>Xóa</td>
            <td> Tools</td>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 39 "D:\Devmaster\AppManager\AppManager\Areas\Admin\Views\ProductImage\Index.cshtml"
          
            foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 43 "D:\Devmaster\AppManager\AppManager\Areas\Admin\Views\ProductImage\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "D:\Devmaster\AppManager\AppManager\Areas\Admin\Views\ProductImage\Index.cshtml"
                   Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "D:\Devmaster\AppManager\AppManager\Areas\Admin\Views\ProductImage\Index.cshtml"
                   Write(item.FileId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "D:\Devmaster\AppManager\AppManager\Areas\Admin\Views\ProductImage\Index.cshtml"
                   Write(item.ImageMore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                  \r\n                    <td>");
#nullable restore
#line 47 "D:\Devmaster\AppManager\AppManager\Areas\Admin\Views\ProductImage\Index.cshtml"
                   Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "D:\Devmaster\AppManager\AppManager\Areas\Admin\Views\ProductImage\Index.cshtml"
                   Write(item.UpdatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "D:\Devmaster\AppManager\AppManager\Areas\Admin\Views\ProductImage\Index.cshtml"
                   Write(item.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "D:\Devmaster\AppManager\AppManager\Areas\Admin\Views\ProductImage\Index.cshtml"
                   Write(item.UpdatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 51 "D:\Devmaster\AppManager\AppManager\Areas\Admin\Views\ProductImage\Index.cshtml"
                   Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 52 "D:\Devmaster\AppManager\AppManager\Areas\Admin\Views\ProductImage\Index.cshtml"
                   Write(item.IsDeleted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1860, "\"", 1910, 3);
            WriteAttributeValue("", 1867, "/*~/Admin/Product/AddOrUpdate?id=", 1867, 33, true);
#nullable restore
#line 54 "D:\Devmaster\AppManager\AppManager\Areas\Admin\Views\ProductImage\Index.cshtml"
WriteAttributeValue("", 1900, item.Id, 1900, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1908, "*/", 1908, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\"> Sửa </a>\r\n                        <a href=\"#\" class=\"btn btn-danger\"> Xóa </a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 58 "D:\Devmaster\AppManager\AppManager\Areas\Admin\Views\ProductImage\Index.cshtml"
            }

        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppManager.Models.ProductImageModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591