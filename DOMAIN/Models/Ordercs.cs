using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMAIN.Enums;

namespace DOMAIN.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

        public User User { get; set; }
    }

}
