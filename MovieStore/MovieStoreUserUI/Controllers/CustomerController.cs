using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieShopGateway;
using MovieStoreDAL;

namespace MovieStoreUserUI.Controllers
{
        public class CustomerController : Controller
        {
            private Facade facade = new Facade();
            


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

                    return View("CheckEmail");
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
            [HttpGet]
            public ActionResult CheckEmail()
            {
                return View();
            }
        [HttpPost]
        public ActionResult CheckEmail(string email)
        {
            facade.GetCustomerGatewayService().ReadAll().FirstOrDefault(c => c.Email == email);
            if (customer != null)
            {
                ViewBag.Exist = "Customer with email is exist";
                TempData["customer"] = customer;
            }
            else
            {
                ViewBag.Exist = "Customer with email is not exist";
            }
            return View();
        }
    }
    }
