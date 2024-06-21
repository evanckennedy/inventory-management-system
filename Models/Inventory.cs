using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_management_system.Models
{
    internal class Inventory
    {
        // Create a public list of products
        public List<Product> Products = new List<Product>();

        // Methods
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(int productId)
        {
            foreach(Product product in Products)
            {
                if (product.ID == productId)
                {
                    Products.Remove(product);
                }
            }
        }

        public void UpdateProductQuantity(string productName, int quantity)
        {
            Product product = Products.Find(p => p.Name == productName);
            if (product != null)
            {
                product.UpdateQuantity(quantity);
            }
        }
    }
}
