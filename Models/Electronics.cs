using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_management_system.Models
{
    internal class Electronics : Product
    {
        // public property
        public string Brand { get; set; }

        // Constructor
        public Electronics(string name, decimal price, int quantity, string brand)
            : base(name, price, quantity)
        {
            Brand = brand;
        }
    }
}
