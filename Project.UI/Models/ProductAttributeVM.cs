using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.UI.Models
{
    public class ProductAttributeVM
    {
        public List<ProductAttribute> ProductAttributes { get; set; }
        public ProductAttribute ProductAttributeInstance { get; set; }
        public Product ProductInstance { get; set; }
        public List<Product> Products { get; set; }
        public AttributeEnt AttributeInstance { get; set; }
        public List<AttributeEnt> AttributeEnts { get; set; }
        public bool IsSelect { get; set; }
    }
}