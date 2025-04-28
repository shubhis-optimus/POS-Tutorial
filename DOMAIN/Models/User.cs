using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; } // Store hashed password
        public string Role { get; set; } // Admin, Cashier, Customer
        public ICollection<Order> Orders { get; set; }
    }

}
