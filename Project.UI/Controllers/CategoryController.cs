using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.UI.AuthenticationClasses;
using Project.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.UI.Controllers
{
    
    public class CategoryController : Controller
    {
        CategoryRep _cRep;
        public CategoryController()
        {
            _cRep = new CategoryRep();
        }
        public ActionResult CategoryList()
        {
            CategoryVM cvm = new CategoryVM
            {
                Categories = _cRep.GetActives()
            };
            return View(cvm);
        }
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category categoryInstance)
        {
            _cRep.Add(categoryInstance);
            return RedirectToAction("CategoryList");
        }

        public ActionResult UpdateCategory(int id)
        {
            CategoryVM cvm = new CategoryVM
            {
                CategoryInstance = _cRep.Find(id)
            };
            return View(cvm);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category categoryInstance)
        {
            _cRep.Update(categoryInstance);
            return RedirectToAction("CategoryList");
        }
        public ActionResult DeleteCategory(int id)
        {
            _cRep.Delete(_cRep.Find(id));
            return RedirectToAction("CategoryList");
        }
    }
}