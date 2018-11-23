using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectEntity;
using ProjectRepository;

namespace Project.Controllers
{
    public class HomeController : BaseController
    {
        ProductRepo p = new ProductRepo();
        ProfileRepo sr = new ProfileRepo();
        // GET: Product

       [HttpGet]
        public ActionResult Index()
        {
            return View(p.GetAll());
        }

        
        public ActionResult Details(int id)
        {
            return View(p.Details(id));
        }

        [HttpPost]
        public ActionResult Index(FormCollection product)
        {
            string s = Request["search"];

            return View(sr.GetAll(s));

        }



    }
}