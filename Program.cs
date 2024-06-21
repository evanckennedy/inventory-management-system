using inventory_management_system.Models;
using inventory_management_system.Security;

namespace inventory_management_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Inventory Management System!");
            Console.WriteLine("This demo will showcase some of the system's functionality, including:");
            Console.WriteLine("- Creating an inventory instance");
            Console.WriteLine("- Adding products to the inventory");
            Console.WriteLine("- Displaying the inventory");
            Console.WriteLine("- Processing a transaction");
            Console.WriteLine("- Authenticating a user\n");
            Thread.Sleep(5000); 

            // Create inventory instance
            Inventory inventory = new Inventory();
            Console.WriteLine("Inventory instance created.\n");
            Thread.Sleep(1000);

            // Add products to inventory
            inventory.AddProduct(new Clothing("T-Shirt", 19.99m, 15, "Large", "Black"));
            Console.WriteLine("T-Shirt added to inventory.");
            Thread.Sleep(500);
            inventory.AddProduct(new Electronics("AirPods", 139.99m, 5, "Apple"));
            Console.WriteLine("AirPods added to inventory.");
            Thread.Sleep(500);
            inventory.AddProduct(new Groceries("Milk", 4.99m, 5, "Dairy"));
            Console.WriteLine("Milk added to inventory.\n");
            Thread.Sleep(1000);

            // Display inventory
            Console.WriteLine("Inventory:");
            foreach (Product product in inventory.Products)
            {
                Thread.Sleep(500);
                Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
            }
            Thread.Sleep(2000);

            // Process a transaction
            /*
             * Since I didn't define a custom constructor for the Transaction class, the compiler automatically generates a default constructor (also known as a parameterless constructor) for me. This default constructor takes no arguments and initializes the object with default values.
             */
            Console.WriteLine("\nProcessing transaction...");
            Thread.Sleep(500);
            Transaction transaction = new Transaction();
            transaction.ProcessTransaction(inventory.Products[0], 3);
            Console.WriteLine("Transaction processed.");
            Thread.Sleep(1000);

            // Display updated inventory
            Console.WriteLine("\nInventory after transaction:");
            foreach (Product product in inventory.Products)
            {
                Thread.Sleep(500);
                Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
            }
            Thread.Sleep(1000);

            // Authenticate a user
            Console.WriteLine("\nLogging in with invalid credentials...");
            Thread.Sleep(500);
            if (UserAuthentication.Authenticate("ivnalid username", "invalid password"))
            {
                Console.WriteLine("User authenticated successfully!");
            }
            else
            {
                Console.WriteLine("Invalid username or password!");
            }
            Thread.Sleep(1000);

            Console.WriteLine("\nLogging in with valid credentials...");
            Thread.Sleep(500);
            if (UserAuthentication.Authenticate("admin", "1234"))
            {
                Console.WriteLine("User authenticated successfully!");
            }
            else
            {
                Console.WriteLine("Invalid username or password!");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
