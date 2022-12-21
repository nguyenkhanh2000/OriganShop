using AppManager.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace AppManager.Controllers
{
    public class CartController : Controller
    {
        private const string CartSession = "CartSession";
        

        public IActionResult Index()
        {
            return View();
        }
        //public ActionResult AddItem(int productId, int quantity)
        //{
        //    var cart = HttpContext.Session.GetString(CartSession);
        //    if (cart != null)
        //    {
        //        var list = (List<CartModel>)cart;
        //        if(list.Exists())
        //    }
        //    else
        //    {
        //        var item = new CartModel();
        //        item.ProductId = productId;
        //        item.Quantity = quantity;
        //        var list = new List<CartModel>();
        //        list = HttpContext.Session.SetString);
        //    }
        //}
       
    }
}
