using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_management_system.Models
{
    internal class Clothing : Product
    {
        // public property
        public string Size { get; set; }
        public string Colour { get; set; }

        // Constructor
        public Clothing(string name, decimal price, int quantity, string size, string colour)
            : base(name, price, quantity)
        {
            Size = size;
            Colour = colour;
        }
    }
}
