using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Homer Simpson", address1);
        Order order1 = new Order(customer1);
        
        order1.AddProduct(new Product("Laptop", "TECH01", 800.00, 1));
        order1.AddProduct(new Product("Mouse", "TECH02", 25.50, 2));

        
        Address address2 = new Address("456 Reforma", "Mexico City", "CDMX", "Mexico");
        Customer customer2 = new Customer("Juan Perez", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("C# Book", "BOK01", 45.00, 1));
        order2.AddProduct(new Product("Mechanical Keyboard", "TECH03", 120.00, 1));
        order2.AddProduct(new Product("Monitor", "TECH04", 250.00, 1));

        Console.WriteLine("============= ORDER 1 =============");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}\n");

        Console.WriteLine("============= ORDER 2 =============");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}\n");
    }
}