using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public UserInfo UserInfo { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
