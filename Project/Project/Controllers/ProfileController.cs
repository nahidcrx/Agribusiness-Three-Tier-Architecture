using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectRepository;
using ProjectEntity;

namespace Project.Controllers
{
    public class ProfileController : BaseController
    {
        // GET: Profile
        mydbContext context = new mydbContext();
        ProfileRepo pro = new ProfileRepo();

        ProductRepo pr = new ProductRepo();

        public ActionResult Index(int id)
        {
            Customer c = context.Customers.SingleOrDefault(i => i.regid == id);
            ViewData["first_name"] = c.first_name;
            ViewData["last_name"] = c.last_name;
            return View(pro.GetAll(id));
        }

        [HttpGet]
        public ActionResult AdPost()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdPost(Product p)
        {
            if (ModelState.IsValid)
            {
                pro.insert(p);
                return RedirectToAction("Index", new { id = Session["regid"] });
            }
            else
            {
                return View(p);
            }
        }

        [HttpGet]
        public ActionResult Myinfo(int id)
        {
            return View(pro.getmyinfo(id));
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Customer nc = pro.Get(id);
            return View(nc);
        }

        [HttpPost]
        public ActionResult Edit(Customer nc)
        {

            pro.Update(nc);
            return RedirectToAction("Myinfo", new { id = Session["regid"] });

            /* if (ModelState.IsValid)
             {
                 pro.Update(nc);
                 return RedirectToAction("Myinfo", new { id = Session["regid"] });
             }

             else
             {
                 return View(nc);
             }*/



        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Product p = pr.Get(id);
            return View(p);
        }

        [HttpPost][ActionName("Delete")]
        public ActionResult Delete_Confirmed(int id)
        {
            Product pp = pr.Get(id);
            pr.Delete(pp);
            return RedirectToAction("Index",new { id=Session["regid"] });


        }


        }
}