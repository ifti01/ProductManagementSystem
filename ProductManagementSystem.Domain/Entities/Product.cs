using ProductManagementSystem.Domain.Enamurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public ProductType Type { get; set; }
        public ICollection<Variant> Variants { get; set; }
    }
}
