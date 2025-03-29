using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product("Laptop", 101, 2, 15000);
        order1.AddProduct(product1);
        Product product2 = new Product("Mouse", 102, 2, 200);
        order1.AddProduct(product2);
        Product product3 = new Product("Keyboard", 103, 2, 500);
        order1.AddProduct(product3);
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.DisplayPackingLabel());
        Console.WriteLine(order1.DisplayShippingLabel());
        Console.WriteLine($"Total Cost: {order1.CalculateTotalCost()}\n");

        Address address2 = new Address("456 Bloem Road", "Joburg", "Gauteng", "South Africa");
        Customer customer2 = new Customer("Bob Boet", address2);
        Order order2 = new Order(customer2);
        Product product2_1 = new Product("Headphones", 104, 1, 3000);
        order2.AddProduct(product2_1);
        Product product2_2 = new Product("PS5 Dualshock", 105, 2, 1500);
        order2.AddProduct(product2_2);
        Product product2_3 = new Product("PS5", 106, 1, 12000);
        order2.AddProduct(product2_3);
        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.DisplayPackingLabel());
        Console.WriteLine(order2.DisplayShippingLabel());
        Console.WriteLine($"Total Cost: {order2.CalculateTotalCost()}");
    }
}