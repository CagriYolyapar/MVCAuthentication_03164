using MVCAuthentication_0.AuthenticationClasses;
using MVCAuthentication_0.DesignPatterns.SingletonPattern;
using MVCAuthentication_0.Models.Context;
using MVCAuthentication_0.Models.Entities;
using MVCAuthentication_0.Models.VMClasses.PureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAuthentication_0.Controllers
{
    
    public class HomeController : Controller
    {

        MyContext _db;

        public HomeController()
        {
            _db = DBTool.DBInstance;
        }


        [AdminAuthentication]
        public ActionResult Index()
        {
           // _db.AppUsers.ToList(); //BU ifade Code First'te, MyInit class'ı tetiklensin diye herhangi bir istek göndermek amacıyla yazılmıstır...Bunun dısında bir işlevi yoktur.
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        
        
        public ActionResult Login(AppUserVM appUser)
        {
           
            AppUser ap = _db.AppUsers.FirstOrDefault(x=>x.UserName == appUser.UserName && x.Password == appUser.Password);
            if (ap != null)
            {
                if(ap.Role == Models.Enums.UserRole.Admin)
                {
                    Session["admin"] = ap;
                    return RedirectToAction("Index");
                }
                ViewBag.Message = "Yetkiniz admin degil";
                return View();
            }
            ViewBag.Message = "Böyle bir kullanıcı bulunamadı";
            return View();
        }
    }
}