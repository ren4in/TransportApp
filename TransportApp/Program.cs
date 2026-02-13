namespace TransportApp
{
    class Program
    {
        static void Main()
        {
            Driver[] drivers =
            {
                new Driver("Иван", "Иванов", new DateTime(2000, 2, 13), "3576453492"),
                new Driver("Петр", "Петров", new DateTime(2000, 3, 26), "9876543210")
            };

            Console.WriteLine($"Возраст первого водителя: {drivers[0].GetAge()}");
            Console.WriteLine($"Возраст второго водителя: {drivers[1].GetAge()}");

        }
    }
}