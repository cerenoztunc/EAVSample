using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.UI.AuthenticationClasses;
using Project.UI.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.UI.Controllers
{
    
    public class ProductAttributeController : Controller
    {
        ProductAttributeRep _paRep;
        ProductRep _pRep;
        AttributeRep _aRep;

        public ProductAttributeController()
        {
            _paRep = new ProductAttributeRep();
            _pRep = new ProductRep();
            _aRep = new AttributeRep();
        }
        public ActionResult ProductList()
        {
            ProductVM pvm = new ProductVM
            {
                Products = _pRep.GetAll()
            };
            return View(pvm);
        }

        public ActionResult AddProductAttribute()
        {
            ProductAttributeVM pavm = new ProductAttributeVM
            {
                Products = _pRep.GetActives(),
                AttributeEnts = _aRep.GetActives()
            };
            return View(pavm);
        }
        [HttpPost]
        public ActionResult AddProductAttribute(ProductAttribute productAttributeInstance)
        {
            _paRep.Add(productAttributeInstance);
            return RedirectToAction("ProductList");
        }
        public ActionResult AddAttribute(int id)
        {
            List<ProductAttribute> chosenProductAttributes = _paRep.GetAttributes(id);
            List<AttributeEnt> a = new List<AttributeEnt>();
            foreach (ProductAttribute item in chosenProductAttributes)
            {
               var attribute = _aRep.Find(item.AttributeID);
               a.Add(attribute);
            }
            
            AttributeVM avm = new AttributeVM
            {
                Attributes = a,
                ProductInstance = _pRep.Find(id) 
                
            };
            return View(avm);
        }
        [HttpPost]
        public ActionResult AddAttribute(List<AttributeEnt> Attributes)
        {
            
            foreach (var item in Attributes)
            {
                _aRep.Add(item);
            }
           

            return RedirectToAction("ProductAttributeList");
        }

        public ActionResult ProductAttributeList(int id)
        {
            ProductAttributeVM pavm = new ProductAttributeVM
            {
                ProductInstance = _pRep.Find(id),
                ProductAttributes = _paRep.GetAll()

            };
            return View(pavm);
        }
    }
}