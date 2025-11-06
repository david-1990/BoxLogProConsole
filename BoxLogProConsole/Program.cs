using BoxLogProConsole;

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
                        session.Date = InputValidator.GetValidDate("Enter session date (yyyy-mm-dd):");

                        var exercises = ExerciseRepository.GetAvailableExercises();
                        Console.WriteLine("Choose exercises (comma-separated IDs):");
                        foreach (var ex in exercises)
                            Console.WriteLine($"{ex.Id}. {ex.Name}");

                        var selectedIds = Console.ReadLine()
                            .Split(',')
                            .Select(id => int.TryParse(id.Trim(), out int parsed) ? parsed : -1)
                            .Where(id => id > 0)
                            .ToList();

                        foreach (var id in selectedIds)
                        {
                            var exercise = exercises.FirstOrDefault(e => e.Id == id);
                            if (exercise != null)
                            {
                                var log = new ExerciseLog { Exercise = exercise };
                                log.DurationMinutes = InputValidator.GetValidInt($"Duration for {exercise.Name} (minutes):", 1, 180);
                                Console.Write("Notes: ");
                                log.Notes = Console.ReadLine();
                                session.ExerciseLogs.Add(log);
                            }
                        }
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
