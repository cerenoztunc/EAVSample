using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Product:BaseEntity
    {
        [Required(ErrorMessage = "{0} girilmesi zorunludur")]
        [MinLength(5, ErrorMessage = "{0} minimum {1} karakter alabilir")]
        [MaxLength(15, ErrorMessage = "{0} max {1} karakter alabilir")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "{0} girilmesi zorunludur")]
        public int UnitPrice { get; set; }
        public short? Amount { get; set; }
        public int? CategoryID { get; set; }
        public int? ShipmentID { get; set; }
        public int? AppUserID { get; set; }

        //Relational properties
        public virtual List<ProductAttribute> ProductAttributes { get; set; }
        public virtual Category Category { get; set; }
        public virtual  Shipment Shipment { get; set; }
        public virtual AppUser AppUser { get; set; }

    }
}
