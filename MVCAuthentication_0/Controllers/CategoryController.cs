using MVCAuthentication_0.AuthenticationClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAuthentication_0.Controllers
{
    [AdminAuthentication]
    public class CategoryController : Controller
    {
        // GET: Categpory
        public ActionResult CategoryPanel()
        {
            return View();
        }
    }
}