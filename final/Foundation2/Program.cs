using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = Config.CreateOrders();

        int count = 1;

        foreach (Order order in orders)
        {
            Console.WriteLine($"ORDER {count++}");

            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine($"Total Cost: ${order.GetTotalCost():F2}");
            Console.WriteLine();
        }
    }
}