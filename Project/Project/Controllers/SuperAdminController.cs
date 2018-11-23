using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectEntity;
using ProjectRepository;

namespace Project.Controllers
{
    public class SuperAdminController : BaseController
    {
        AdminRepo ad = new AdminRepo();
        // GET: SuperAdmin
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin a)
        {

            if (ModelState.IsValid)
            {
                ad.Insert(a);
                return RedirectToAction("Index", "SuperAdmin");
            }
            else
            {
                return View(a);
            }
        }

        

    }
}