using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_management_system.Interfaces
{
    internal interface IProduct
    {
        // Interfaces in object-oriented programming languages like C# only deal with the public aspects of the classes (or structs) that implement them.
        int ID { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        int Quantity { get; set; }

        void UpdateQuantity(int quantityChange);
    }
}
