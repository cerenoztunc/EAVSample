using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.UI.Controllers
{
    public class AppUserController : Controller
    {
        AppUserRep _auRep;
        public AppUserController()
        {
            _auRep = new AppUserRep();
        }
        
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(AppUser appUser)
        {
            AppUser ap = _auRep.FirstOrDefault(x => x.UserName == appUser.UserName && x.Password == appUser.Password);

            if (ap != null)
            {
                if (ap.Role == ENTITIES.Enums.UserRoles.Admin)
                {
                    Session["admin"] = ap;
                    return RedirectToAction("ProductList", "Product");
                }
                ViewBag.Message = "Yetkiniz admin degil";
                return View();
            }

            ViewBag.Message = "Böyle bir kullanıcı bulunamadı";
            return View();
        }
    }
}