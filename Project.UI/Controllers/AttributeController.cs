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
    public class AttributeController : Controller
    {
        AttributeRep _aRep;
        public AttributeController()
        {
            _aRep = new AttributeRep();
        }
        public ActionResult AttributeList()
        {
            AttributeVM avm = new AttributeVM
            {
                Attributes = _aRep.GetActives()
            };
            return View(avm);
        }

        public ActionResult AddAttribute()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAttribute(AttributeEnt attributeInstance)
        {
            _aRep.Add(attributeInstance);
            return RedirectToAction("AttributeList");
        }

        public ActionResult UpdateAttribute(int id)
        {
            AttributeVM avm = new AttributeVM
            {
                AttributeInstance = _aRep.Find(id)
            };
            return View(avm);
        }
        [HttpPost]
        public ActionResult UpdateAttribute(AttributeEnt attributeInstance)
        {
            _aRep.Update(attributeInstance);
            return RedirectToAction("AttributeList");
        }
        public ActionResult DeleteAttribute(int id)
        {
            _aRep.Delete(_aRep.Find(id));
            return RedirectToAction("AttributeList");
        }
    }
}