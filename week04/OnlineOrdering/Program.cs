using System;

namespace OnlineOrderingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create addresses
            Address usaAddress = new Address("123 Main St", "Rexburg", "ID", "USA");
            Address canadaAddress = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

            // Create customers
            Customer customer1 = new Customer("John Smith", usaAddress);
            Customer customer2 = new Customer("Emma Johnson", canadaAddress);

            // Create products
            Product product1 = new Product("Laptop", "P100", 999.99, 1);
            Product product2 = new Product("Mouse", "P101", 19.99, 2);
            Product product3 = new Product("Keyboard", "P102", 49.99, 1);
            Product product4 = new Product("Monitor", "P103", 199.99, 2);

            // Create orders
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product3);
            order2.AddProduct(product4);
            order2.AddProduct(product2);

            // Display order information
            Console.WriteLine("Order Processing System\n");

            Console.WriteLine("=== Order 1 ===");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():0.00}\n");

            Console.WriteLine("=== Order 2 ===");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():0.00}\n");
        }
    }
}