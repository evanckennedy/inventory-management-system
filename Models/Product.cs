using inventory_management_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_management_system.Models
{
    internal class Product : IProduct
    {
        // Private fields
        // prepending private field name with '_' is a convention
        private static int _lastId = 0; // Static field to keep track of the last assigned ID
        private int _id;
        private string _name;
        // 'decimal' is better suited for calculations involving money, as it can exactly represent decimal fractions without rounding errors.
        private decimal _price;
        private int _quantity;

        // Constructor
        public Product(string name, decimal price, int quantity)
        {
            _id = ++_lastId; // Increment the last ID and assign it to the new product
            _name = name;
            _price = price;
            _quantity = quantity;
        }

        // Properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        // Methods
        public void UpdateQuantity(int quantityChange)
        {
            _quantity += quantityChange;
        }
    }
}
