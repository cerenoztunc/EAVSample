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
    [AdminAuthentication]
    public class ProductController : Controller
    {
        // GET: Product
        ProductRep _pRep;
        public ProductController()
        {
            _pRep = new ProductRep();

        }
        public ActionResult ProductList()
        {
            ProductVM pvm = new ProductVM
            {
                Products = _pRep.GetActives()
            };
            return View(pvm);
        }

        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product productInstance)
        {
            _pRep.Add(productInstance);
            return RedirectToAction("ProductList");
        }

        public ActionResult UpdateProduct(int id)
        {
            ProductVM pvm = new ProductVM
            {
                ProductInstance = _pRep.Find(id)
            };
            return View(pvm);
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product productInstance)
        {
            _pRep.Update(productInstance);
            return RedirectToAction("ProductList");
        }
        public ActionResult DeleteProduct(int id)
        {
            _pRep.Delete(_pRep.Find(id));
            return RedirectToAction("ProductList");
        }
    }
}