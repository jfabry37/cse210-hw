using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products1 = new List<Product>();
            products1.Add(new Product("shovel","TLM123", 25.99m, 1));
            products1.Add(new Product("rake","TLM456", 15.49m, 2));
            products1.Add(new Product("garden hose","TLM789", 25.00m, 1));
        Customer customer1 = new Customer ("Sally", new Address ("747 finn Ridge DR", "Centerville", "WA","98613" ,"USA"));
        Orders order1 = new Orders (customer1, products1);
        Console.WriteLine($"{order1.GetShippingLabel()}\n");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.Calculations());
        Console.WriteLine("________________________________");

        List<Product> products2 = new List<Product>();
            products2.Add(new Product("lawn mower","GDN123", 599.99m, 1));
            products2.Add(new Product("leaf blower","GDN456", 89.49m, 1));
        Customer customer2 = new Customer ("James", new Address ("123 Main St", "Fort Collins", "CO","80524", "USA"));
        Orders order2 = new Orders (customer2, products2);
        Console.WriteLine($"{order2.GetShippingLabel()}\n");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.Calculations());
        Console.WriteLine("________________________________");

        List<Product> products3 = new List<Product>();
            products3.Add(new Product("flower seeds","FLR123", 5.99m, 3));
            products3.Add(new Product("plant fertilizer","FLR456", 20.49m, 1));
            products3.Add(new Product("watering can","FLR789", 15.00m, 1));
        Customer customer3 = new Customer ("Weston", new Address ("Via Giuseppe Verdi", "Firenze", "FL", "50122", "Italy"));
        Orders order3 = new Orders (customer3, products3); 
        Console.WriteLine($"{order3.GetShippingLabel()}\n");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.Calculations());
        Console.WriteLine("________________________________");
    }
}
