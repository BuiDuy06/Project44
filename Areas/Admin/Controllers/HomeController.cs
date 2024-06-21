using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_Webbanhang.Areas.Admin.Controllers
{
    //[Authorize(Roles = "Admin,Employee")]
    //[Authorize(Roles = "Employee")]
     
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}