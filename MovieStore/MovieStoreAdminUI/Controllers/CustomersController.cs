using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Design;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieShopGateway;

namespace MovieStoreUserUI.Controllers
{
    public class CustomersController : Controller
    {
        //private CustomerRepository cr = new CustomerRepository();
        private Facade facade = new Facade();
        
            

        // GET: Customers
        public ActionResult Index()
        {
            IEnumerable<Customer> customer = facade.GetCustomerGatewayService().ReadAll();
            return View(customer);
        }

        // GET: Customers/Details/5
        public ActionResult Details(int id)
        {
            var customer = facade.GetCustomerGatewayService().Read(id);
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "FirstName,LastName,Address,Email,EmailConfirm")]Customer customer)
        {
            try
            {
                facade.GetCustomerGatewayService().Add(customer);
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View(customer);
            }
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int id)
        {
            facade.GetCustomerGatewayService().Read(id);
            return View(customer);
        }

        // POST: Customers/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Address,Email, EmailConfirm")]Customer customer)
        {
            try
            {
                facade.GetCustomerGatewayService().Update(customer.id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(customer);
            }
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int id)
        {
            facade.GetCustomerGatewayService().Read(id);
            return View(customer);
        }

        // POST: Customers/Delete/
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                facade.GetCustomerGatewayService().Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
