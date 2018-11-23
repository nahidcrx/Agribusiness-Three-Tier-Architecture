using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectEntity;
using ProjectRepository;

namespace Project.Controllers
{
    public class AdminController : BaseController
    {
        AdminRepo ad = new AdminRepo();
        Product p = new Product();
        Customer cm = new Customer();
        mydbContext context = new mydbContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View(ad.GetAll());
        }
        public ActionResult Details(int id)
        {
            Customer c = context.Customers.SingleOrDefault(i => i.regid == id);
            ViewData["first_name"] = c.first_name;
            ViewData["last_name"] = c.last_name;
            ViewData["user_name"] = c.user_name;
            ViewData["phone"] = c.phone;
            return View(ad.GetAll(id));
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Product p = ad.Get(id);
            return View(p);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Delete_Confirmed(int id)
        {
             Product ppp = context.Products.SingleOrDefault(i => i.adid == id);
            Product pp = ad.Get(id);
            ad.Delete(pp);
            return RedirectToAction("Details", new { id = ppp.pregid });


        }


        [HttpPost]
        public ActionResult Index(FormCollection product)
        {
            string s = Request["search"];

            return View(ad.GetAll(s));

        }
    }
}