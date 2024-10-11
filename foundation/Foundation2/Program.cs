using System;

class Program
{
    static void Main(string[] args)
    {
        //Create Adresses
        Address address1 = new Address("4321 Laguna Vista St", "Las Vegas", "NV", "USA");
        Address address2 = new Address("789 Cacique Ave", "Lambare", "CT", "Paraguay");

        //Create Customers
        Customer customer1 = new Customer("Madison Davis", address1);
        Customer customer2 = new Customer("Carol Roa", address2);

        //Create products
        Product product1 = new Product("Skirt", 205, 14.87, 1);
        Product product2 = new Product("Dress", 207, 20.50, 3);

        Product product3 = new Product("Nightgown", 213, 250.63, 1);
        Product product4 = new Product("Jacket", 225, 70.56, 1);

        //Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        //Display order details
        Console.WriteLine("Packing label: ");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order1.CalculateTotalCost() :F2}\n");

        Console.WriteLine("Packing label: ");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order2.CalculateTotalCost() :F2}");

    }
}