namespace Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            string choice = "";

            while (choice != "5")
            {
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do? ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        WriteEntry(journal);
                        break;
                    case "2":
                        journal.Display();
                        break;
                    case "3":
                        LoadJournal(journal);
                        break;
                    case "4":
                        SaveJournal(journal);
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Please enter a number from 1 to 5.");
                        break;
                }
            }
        }

        static void WriteEntry(Journal journal)
        {
            string[] prompts =
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?",
                "What is one thing I learned today?"
            };

            string prompt = prompts[Random.Shared.Next(prompts.Length)];
            Console.WriteLine(prompt);
            Console.Write("> ");
            string response = Console.ReadLine();

            Entry entry = new Entry();
            entry._theDate = DateTime.Now.ToShortDateString();
            entry._thePrompt = prompt;
            entry._userResponse = response;
            journal.AddEntry(entry);
        }

        static void SaveJournal(Journal journal)
        {
            Console.Write("Enter the filename to save: ");
            string fileName = Console.ReadLine();

            try
            {
                journal.SaveToFile(fileName);
            }
            catch (IOException exception)
            {
                Console.WriteLine($"Could not save the journal: {exception.Message}");
            }
            catch (UnauthorizedAccessException exception)
            {
                Console.WriteLine($"Could not save the journal: {exception.Message}");
            }
        }

        static void LoadJournal(Journal journal)
        {
            Console.Write("Enter the filename to load: ");
            string fileName = Console.ReadLine();

            try
            {
                journal.LoadFromFile(fileName);
            }
            catch (IOException exception)
            {
                Console.WriteLine($"Could not load the journal: {exception.Message}");
            }
            catch (UnauthorizedAccessException exception)
            {
                Console.WriteLine($"Could not load the journal: {exception.Message}");
            }
            catch (FormatException exception)
            {
                Console.WriteLine($"Could not load the journal: {exception.Message}");
            }
        }
    }
}