using System;

class Program
{
    static void Main(string[] args)
    {

        Product product1 = new Product("product1", "ID1", 10.99, 3);
        Product product2 = new Product("product2", "ID2", 1.99, 8);
        Product product3 = new Product("product3", "ID3", 35.99, 2);
        Product product4 = new Product("product4", "ID4", 100.99, 1);
        Product product5 = new Product("product5", "ID5", 15.99, 3);

        Address address1 = new Address("street1", "Tallahasee", "Florida", "USA");
        Address address2 = new Address("street2", "Ontario", "British Columbia", "Canada");


        Customer customer1 = new Customer("Greasy Steve", address1);
        Customer customer2 = new Customer("Sloppy Joe", address2);


        Order order1 = new Order([product1, product2, product3], customer1);
        Order order2 = new Order([product4, product5, ], customer2);
        
        
        Console.WriteLine("Packing Label: ");
        Console.WriteLine($"{order1.PackingLabel()}");
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine($"{order1.ShippingLabel()}");
        Console.WriteLine("Total Price: ");
        Console.WriteLine($"${order1.TotalPrice()}");


        Console.WriteLine("\n--------\n");


        Console.WriteLine("Packing Label: ");
        Console.WriteLine($"{order2.PackingLabel()}");
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine($"{order2.ShippingLabel()}");
        Console.WriteLine("Total Price: ");
        Console.WriteLine($"${order2.TotalPrice()}");


    }
}