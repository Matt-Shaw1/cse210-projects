using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "home", "CA", "USA");
        Address address2 = new Address("456 Garber St", "Town", "ON", "Canada");

        Customer customer1 = new Customer("John Shaw", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Widget", 101, 2.99, 3));
        order1.AddProduct(new Product("Gadget", 102, 1.99, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Widget", 101, 2.99, 5));
        order2.AddProduct(new Product("Gadget", 102, 1.99, 1));

        Order[] orders = { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: {order.GetTotalPrice():C2}\n");
        }
    }
}
