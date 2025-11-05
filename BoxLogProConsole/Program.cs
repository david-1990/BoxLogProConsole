namespace BoxLogProConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new SessionManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("BoxLog Pro");
                Console.WriteLine("1. Add Session");
                Console.WriteLine("2. View Sessions");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        var session = new Session();
                        Console.Write("Date (yyyy-mm-dd): ");
                        session.Date = DateTime.Parse(Console.ReadLine());
                        Console.Write("Duration (minutes): ");
                        session.DurationMinutes = int.Parse(Console.ReadLine());
                        Console.Write("Type: ");
                        session.Type = Console.ReadLine();
                        Console.Write("Notes: ");
                        session.Notes = Console.ReadLine();
                        manager.AddSession(session);
                        break;

                    case "2":
                        manager.ViewSessions();
                        break;

                    case "3":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option.\n");
                        break;
                }
            }
        }
    }
}
