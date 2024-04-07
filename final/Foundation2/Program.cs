using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 First St", "Bothell", "WA", "USA");
        
       
        Customer customer = new Customer("Thomas Lee", address);

        Product product1 = new Product("Toy1", "W123", 20.99, 4);
        Product product2 = new Product("Toy2", "G456", 49.99, 1);

      
        Order order = new Order(customer);

        order.AddProduct(product1);
        order.AddProduct(product2);

     
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine("\nTotal Price: $" + order.GetTotalPrice());
    }
}

