using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.UI.Models
{
    public class CategoryVM
    {
        public List<Category> Categories { get; set; }
        public Category CategoryInstance { get; set; }
    }
}