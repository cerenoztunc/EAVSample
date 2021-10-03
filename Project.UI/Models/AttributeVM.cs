using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.UI.Models
{
    public class AttributeVM
    {
        public List<AttributeEnt> Attributes { get; set; }
        public AttributeEnt AttributeInstance { get; set; }
        public Product ProductInstance { get; set; }
    }
}