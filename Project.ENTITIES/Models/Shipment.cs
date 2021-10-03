using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Shipment:BaseEntity
    {
        [Required(ErrorMessage = "{0} girilmesi zorunludur")]
        [MinLength(5, ErrorMessage = "{0} minimum {1} karakter alabilir")]
        [MaxLength(15, ErrorMessage = "{0} max {1} karakter alabilir")]
        public string CompanyName { get; set; }

        //Relational properties
        public virtual List<Product> Products { get; set; }

    }
}
