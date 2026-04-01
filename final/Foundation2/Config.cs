
public static class Config
{
    public const double USA_SHIPPING = 5;
    public const double INTERNATIONAL_SHIPPING = 35;

    public static List<Order> CreateOrders()
    {
        var orders = new List<Order>();

        // Order 1
        Address a1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer c1 = new Customer("John Smith", a1);
        Order o1 = new Order(c1);
        // Add products
        // product name, product id, product price, product quantity
        o1.AddProduct(new Product("Laptop", "P127", 799.99, 1));
        o1.AddProduct(new Product("USB Drive", "P593", 24.87, 2));

        // Order 2
        Address a2 = new Address("456 King St", "Toronto", "ON", "Canada");
        Customer c2 = new Customer("Alice Brown", a2);
        Order o2 = new Order(c2);
        // Add products
        // product name, product id, product price, product quantity
        o2.AddProduct(new Product("Phone", "P148", 599.99, 1));
        o2.AddProduct(new Product("Headphones", "P530", 124.99, 1));
        o2.AddProduct(new Product("Charger", "P246", 19.99, 2));

        orders.Add(o1);
        orders.Add(o2);

        return orders;
    }
}