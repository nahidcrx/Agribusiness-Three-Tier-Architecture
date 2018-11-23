using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectEntity;
using ProjectRepository;

namespace Project.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        ProductRepo p = new ProductRepo();
        // GET: Product

        [HttpGet]
        public ActionResult Index()
        {
            return View(p.GetAll());
        }
    }
}