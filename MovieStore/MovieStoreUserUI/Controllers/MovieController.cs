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
    public class MovieController : Controller
    {
        Facade facade = new Facade();

        // GET: Movie
        public ActionResult Index()
        {
            return View(facade.GetMovieGatewayService().ReadAll());
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            Movie movie = facade.GetMovieGatewayService().Read(id);
            return View(movie);
        }

        public ActionResult AddToCart(int id)
        {
            var movie = facade.GetMovieGatewayService().Read(id);
            var cart = GetCart();
            cart.AddOrderLine(movie, 1);

            return RedirectToAction("Index");
        }


        private ShoppingCart GetCart()
        {
            var cart = Session["ShoppingCart"] as ShoppingCart;
            if (cart == null)
            {
                cart = new ShoppingCart();
                Session["ShoppingCart"] = cart;
            }
            return cart;
        }
    }
}
