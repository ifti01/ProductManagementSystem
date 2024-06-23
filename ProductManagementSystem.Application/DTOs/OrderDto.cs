using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.Application.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public ICollection<OrderItemDto> OrderItems { get; set; }
        public UserInfoDto UserInfo { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
