using jQuery_AJAX_Model_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQuery_AJAX_Model_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AjaxMethod(PersonModel person)
        {
            string name = person.taskname;

            string name1 = person.Name;
            return Json(person);
        }
    }
}