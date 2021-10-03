using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ProductAttribute:BaseEntity
    {
        public int ProductID { get; set; }
        public int AttributeID { get; set; }

        //Relational properties
        public virtual Product Product { get; set; }
        public virtual AttributeEnt Attribute { get; set; }
    }
}
