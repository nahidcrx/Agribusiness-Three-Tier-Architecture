using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectEntity;
using ProjectRepository;

namespace Project.Controllers
{
    public class RegistrationController : Controller
    {

        CustomerRepo cr = new CustomerRepo();
        // GET: Registration
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Customer c)
        {

            if (ModelState.IsValid)
            {
                cr.insert(c);
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return View(c);
            }
        }
    }
}