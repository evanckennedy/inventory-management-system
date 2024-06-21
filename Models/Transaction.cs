using inventory_management_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_management_system.Models
{
    internal class Transaction : ITransaction
    {
        // Methods
        public void ProcessTransaction(Product product, int quantity)
        {
            product.UpdateQuantity(-quantity);
            Console.WriteLine($"{quantity} unit(s) of {product.Name} sold.");
        }

        public decimal AddDiscount(Product product, decimal discountPercentage)
        {
            return product.Price * (1 - (discountPercentage / 100));
        }
    }
}
