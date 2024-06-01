using lab1task.lab1classes;
namespace lab1task
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money1 = new Money(10, 50, "UAH");
            Money money2 = new Money(5, 75, "EURO");
            Console.WriteLine($"Money1: {money1}");
            Console.WriteLine($"Money2: {money2}");

            Console.WriteLine("");
            Product phone = new Product("Phone", new Money(740, 23, "USD"), 1);
            Console.WriteLine(phone);
            phone.ReducePrice(new Money(330, 75));
            Console.WriteLine($"After reduction: {phone}");

            Console.WriteLine("");
            Product keyboard = new Product("Keyboard", new Money(233, 25, "EURO"), 1);
            Product book = new Product("Book", new Money(115, 75, "UAH"), 6);
            Console.WriteLine(keyboard);
            Console.WriteLine(book);

            Warehouse warehouse = new Warehouse();
            warehouse.AddProduct(phone, "pcs", 10, DateTime.Now);
            warehouse.AddProduct(keyboard, "pcs", 20, DateTime.Now);
            warehouse.AddProduct(book, "pcs", 50, DateTime.Now);

            Console.WriteLine("");
            Console.WriteLine("Inventory Report:");
            Console.WriteLine(warehouse.InventoryReport());
        }
    }
}