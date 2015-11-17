using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MovieShopGateway;
using MovieStoreDAL;

namespace MovieStoreUI.Controllers
{
    public class OrdersController : Controller
    {
        Facade facade = new Facade();

        // GET: Orders
        public ActionResult Index()
        {
            var orders = facade.GetOrderGatewayService().ReadAll().Include(o => o.Customer).Include(o=>o.OrderLines);
            List<Order> ordersInList = orders.ToList();
            return View(ordersInList);
        }

        // GET: Orders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            facade.GetOrderGatewayService().Read(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        

        // GET: Orders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            facade.GetOrderGatewayService().Read(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            facade.GetOrderGatewayService().Delete(id);
            
            return RedirectToAction("Index");
        }


    }
}
