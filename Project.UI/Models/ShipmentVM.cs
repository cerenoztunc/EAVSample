using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.UI.Models
{
    public class ShipmentVM
    {
        public List<Shipment> Shipments { get; set; }
        public Shipment ShipmentInstance { get; set; }
    }
}