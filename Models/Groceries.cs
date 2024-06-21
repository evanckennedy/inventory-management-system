using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_management_system.Models
{
    internal class Groceries : Product
    {
        // public property defining accessors
        public string Category { get; set; }

        // Constructor
        public Groceries(string name, decimal price, int quantity, string category)
            : base(name, price, quantity)
        {
            Category = category;
        }
    }
}
