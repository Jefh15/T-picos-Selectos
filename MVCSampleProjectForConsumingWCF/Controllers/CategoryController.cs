using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleProjectForConsumingWCF.ServiceReference1;

namespace MVCSampleProjectForConsumingWCF.Controllers
{
    public class CategoryController : Controller
    {
        ServiceReference1.category category = new ServiceReference1.category();

        // GET: Category

        public ActionResult getCategories()
        {
            Service1Client o = new Service1Client();//this object get all methods in the WCF
            List<category> li = o.getCategory().ToList();
            ViewBag.List = li;//to get in view the list
            return View();
        }

        //this display the view with the empty form
        public ActionResult insertCategory()
        {
            return View();
        }

        [HttpPost]//this using for insert elemement
        public ActionResult insertCategory(category obj)
        {
            Service1Client o = new Service1Client();//this object get all methods in the WCF
            o.InsertCategory(obj);
            return View();
        }

        public ActionResult updateCategory()
        {
            return View();
        }

        [HttpPost]//this using for update elemement
        public ActionResult updateCategory(category obj)
        {
            Service1Client o = new Service1Client();//this object get all methods in the WCF
            o.UpdateCategory(obj);
            return View();
        }

        public ActionResult deleteCategory()
        {
            return View();
        }

        [HttpPost]//this using for update elemement
        public ActionResult deleteCategory(int id)
        {
            Service1Client o = new Service1Client();//this object get all methods in the WCF
            o.DeleteCategory(id);
            return View();
        }
    }
}