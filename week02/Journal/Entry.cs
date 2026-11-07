namespace Journal
{
    public class Entry
    {
        public string _theDate;
        public string _thePrompt;
        public string _userResponse;

        public void Display()
        {
            Console.WriteLine($"Date: {_theDate}");
            Console.WriteLine($"Prompt: {_thePrompt}");
            Console.WriteLine($"Response: {_userResponse}");
            Console.WriteLine();
        }
    }
}