#pragma checksum "D:\Devmaster\AppManager\AppManager\Views\Product\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a715d1d85e57d098b03b9b28636dd7297a62c664"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Cart), @"mvc.1.0.view", @"/Views/Product/Cart.cshtml")]
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
#line 1 "D:\Devmaster\AppManager\AppManager\Views\_ViewImports.cshtml"
using AppManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Devmaster\AppManager\AppManager\Views\_ViewImports.cshtml"
using AppManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a715d1d85e57d098b03b9b28636dd7297a62c664", @"/Views/Product/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39bdf4e2eeb9182a14600fe5d339bdb2f9540938", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Hero Section Begin -->
<section class=""hero hero-normal"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <div class=""hero__categories"">
                    <div class=""hero__categories__all"">
                        <i class=""fa fa-bars""></i>
                        <span>All departments</span>
                    </div>
                    <ul>
                        <li><a href=""#"">Fresh Meat</a></li>
                        <li><a href=""#"">Vegetables</a></li>
                        <li><a href=""#"">Fruit & Nut Gifts</a></li>
                        <li><a href=""#"">Fresh Berries</a></li>
                        <li><a href=""#"">Ocean Foods</a></li>
                        <li><a href=""#"">Butter & Eggs</a></li>
                        <li><a href=""#"">Fastfood</a></li>
                        <li><a href=""#"">Fresh Onion</a></li>
                        <li><a href=""#"">Papayaya & Crisps</a></li>
                        <li><a href=""#"">Oatmeal</a></");
            WriteLiteral(@"li>
                        <li><a href=""#"">Fresh Bananas</a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-lg-9"">
                <div class=""hero__search"">
                    <div class=""hero__search__form"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a715d1d85e57d098b03b9b28636dd7297a62c6644937", async() => {
                WriteLiteral(@"
                            <div class=""hero__search__categories"">
                                All Categories
                                <span class=""arrow_carrot-down""></span>
                            </div>
                            <input type=""text"" placeholder=""What do yo u need?"">
                            <button type=""submit"" class=""site-btn"">SEARCH</button>
                        ");
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
            WriteLiteral(@"
                    </div>
                    <div class=""hero__search__phone"">
                        <div class=""hero__search__phone__icon"">
                            <i class=""fa fa-phone""></i>
                        </div>
                        <div class=""hero__search__phone__text"">
                            <h5>+65 11.188.888</h5>
                            <span>support 24/7 time</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Hero Section End -->
<!-- Breadcrumb Section Begin -->
<section class=""breadcrumb-section set-bg"" data-setbg=""/img/breadcrumb.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""breadcrumb__text"">
                    <h2>Shopping Cart</h2>
                    <div class=""breadcrumb__option"">
                        <a href=""./index.html"">Home</a>
                        <span>Shopping Ca");
            WriteLiteral(@"rt</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Breadcrumb Section End -->
<!-- Shoping Cart Section Begin -->
<section class=""shoping-cart spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""shoping__cart__table"">
                    <table id=""cartTable"">
                        <thead>
                            <tr>
                                <th class=""shoping__product"">Products</th>
                                <th>Price</th>
                                <th>Quantity</th>
                                <th>Total</th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
                            
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div clas");
            WriteLiteral(@"s=""col-lg-12"">
                <div class=""shoping__cart__btns"">
                    <a href=""/product/index"" class=""primary-btn cart-btn"">CONTINUE SHOPPING</a>
                    <a onclick=""Clickupdate"" class=""primary-btn cart-btn cart-btn-right"">
                        <span class=""icon_loading""></span>
                        Upadate Cart
                    </a>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""shoping__continue"">
                    <div class=""shoping__discount"">
                        <h5>Discount Codes</h5>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a715d1d85e57d098b03b9b28636dd7297a62c6649460", async() => {
                WriteLiteral("\n                            <input type=\"text\" placeholder=\"Enter your coupon code\">\n                            <button type=\"submit\" class=\"site-btn\">APPLY COUPON</button>\n                        ");
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
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""shoping__checkout"">
                    <h5>Cart Total</h5>
                    <ul>
                        <li>Subtotal <span>$454.98</span></li>
                        <li>Total <span>$454.98</span></li>
                    </ul>
                    <a href=""#"" class=""primary-btn"">PROCEED TO CHECKOUT</a>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Shoping Cart Section End -->
<!-- Footer Section Begin -->

<!-- Footer Section End -->
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function(){
            getCartData();
        });
        function getCartData() {
            // lấy cart từ localstorerage
            let cartStr = localStorage.getItem('cart');
            let cart = cartStr ? JSON.parse(cartStr) : [];
            // get ajax lấy dữ liệu sản phẩm
            if(cart.length > 0){
                let prodIds = cart.map(x => x.productId); 
                let obj = {
                    ids: prodIds
                }
                $.ajax({
                    url: ""/Product/getCartData"",
                    type: ""POST"",
                    data: JSON.stringify(obj),
                    dataType: ""json"",
                    contentType: ""application/json"",
                    beforeSend: function () {
                        //bat loading
                    },
                    success: function (res) {
                        //console.log(res); 
                        let data = res.map(prod => {
                           ");
                WriteLiteral(@" let quan = cart.find(x => x.productId == prod.id);
                            if(quan){
                                prod.quantity = eval(quan.quantity); 
                            }
                            return prod;
                        });

                        //console.log(data);

                        rederHtml(data);               
                    },
                    error: function (error) {
                        // khi server thực thi lỗi
                    },
                    complete: function () {

                    }
                });
            }
            
        }
        //function UpdateCart(){
        //    let cartStr = localStorage.getItem('cart');
        //    let cart = cartStr ? JSON.parse(cartStr) : [];

             
        function rederHtml(data){
            $('#cartTable tbody').html('');
            data.forEach(function (item) {
                let row = `<tr>
                                <td class=""shoping__cart__item"">
     ");
                WriteLiteral(@"                               <img src=""${item.avatar}"" alt="""">
                                    <h5>${item.name}</h5>
                                </td>
                                <td class=""shoping__cart__price"">
                                    ${item.price}
                                </td>
                                <td class=""shoping__cart__quantity"">
                                    <div class=""quantity"">
                                        <div class=""pro-qty"">
                                            <input id=""quantity"" type=""number"" value=""${item.quantity}"">
                                        </div>
                                    </div>
                                </td>
                                <td class=""shoping__cart__total"">
                                    ${item.price * item.quantity} 
                                    
                                </td>
                                <td class=""shoping__cart__item__close"">
      ");
                WriteLiteral(@"                              <span class=""icon_close""></span>
                                </td>
                           </tr>`;

                $('#cartTable tbody').append(row);
            });
        

        }

        function AddToCart(productId) {
            // lấy cart từ localstorage
            let cartStr = localStorage.getItem('cart');
            let cart = cartStr ? JSON.parse(cartStr) : [];
            // cập nhật cart
            let obj = cart.find(x => x.productId == productId);
            if (obj) {
                obj.quantity++;
            } else {
                cart.push({
                    productId: productId,
                    quantity: 1
                });
            }
            // update lại cart vào local storage
            localStorage.setItem('cart', JSON.stringify(cart));
            alert(""Đã thêm vào giỏ hàng"");
        }
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