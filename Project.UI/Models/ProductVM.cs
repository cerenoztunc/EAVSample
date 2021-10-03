using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.UI.Models
{
    public class ProductVM
    {
        public List<Product> Products { get; set; }
        public Product ProductInstance { get; set; }
    }
}