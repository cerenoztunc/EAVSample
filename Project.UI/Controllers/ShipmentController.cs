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
    
    public class ShipmentController : Controller
    {
        ShipmentRep _sRep;
        public ShipmentController()
        {
            _sRep = new ShipmentRep();
        }
        public ActionResult ShipmentList()
        {
            ShipmentVM svm = new ShipmentVM
            {
                Shipments = _sRep.GetActives()
            };
            return View(svm);
        }
        public ActionResult AddShipment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddShipment(Shipment shipmentInstance)
        {
            _sRep.Add(shipmentInstance);
            return RedirectToAction("ShipmentList");
        }
        public ActionResult UpdateShipment(int id)
        {
            ShipmentVM svm = new ShipmentVM
            {
                ShipmentInstance = _sRep.Find(id)
            };
            return View(svm);
        }
        [HttpPost]
        public ActionResult UpdateShipment(Shipment shipmentInstance)
        {
            _sRep.Update(shipmentInstance);
            return RedirectToAction("ShipmentList");
        }
        public ActionResult DeleteShipment(int id)
        {
            _sRep.Delete(_sRep.Find(id));
            return RedirectToAction("ShipmentList");
        }
    }
}