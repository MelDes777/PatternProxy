using PatternProxy;

IChief chief = new ChiefProxy(new Chief());

while (true)
{
    Thread.Sleep(2000);

    Console.Clear();

    Console.WriteLine("Welcome to cooker\n");
    Console.WriteLine("========= Orders ==========\n");

    IEnumerable<Order> orders = chief.GetOrders();

    foreach (var order in orders)
    {
        string status = chief.GetStatuses().First(s => s.Key == order.StatusId).Value;
        Console.WriteLine($"{order.Name}\t\t{status}");
    }
}