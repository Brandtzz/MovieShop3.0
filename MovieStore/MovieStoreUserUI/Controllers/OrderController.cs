using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieShopGateway;
using MovieStoreDAL;
using MovieStoreUserUI.Models;

namespace MovieStoreUserUI.Controllers
{
    public class OrderController : Controller
    {
        Facade facade = new Facade();
        
        //[HttpGet]
        //public ActionResult Buy(ShoppingCart cart)
        //{
        //    Customer customer = (Customer) TempData.Peek("customer");
        //    cart.Customer = customer;

        //    return View(cart);
        //}
        [HttpPost,ActionName("Buy")]
        
        public ActionResult BuyConfirmed(ShoppingCart cart)
        {
            Customer customer = (Customer) TempData["customer"];
            Order order = new Order
            {
                Customer = customer,
                CustomerId = customer.Id,
                Date = DateTime.Now,
                OrderLines = cart.orderLines
            };
            facade.GetOrderGatewayService().Add(order);
            cart.CleanCart();
            return View("Confirmed");
        }


    }
}