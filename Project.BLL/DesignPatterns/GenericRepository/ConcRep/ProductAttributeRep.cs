using Project.BLL.DesignPatterns.GenericRepository.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRep
{
    public class ProductAttributeRep:BaseRepository<ProductAttribute>
    {
        public ProductAttributeRep()
        {

        }
        public List<ProductAttribute> GetAttributes(int id)
        {
            var attributes = Where(x => x.ProductID == id);

            return attributes.ToList();

        }
    }
}
