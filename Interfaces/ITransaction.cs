using inventory_management_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_management_system.Interfaces
{
    internal interface ITransaction
    {
        public void ProcessTransaction(Product product, int quantity);
    }
}
