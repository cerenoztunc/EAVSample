using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.UI.Models
{
    public class AppUserVM
    {
        public List<AppUser> AppUsers { get; set; }
        public AppUser AppUser { get; set; }
    }
}