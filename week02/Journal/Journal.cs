namespace Journal
{
    public class Journal
    {
        private const string Separator = "~|~";
        public List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        public void Display()
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }

        public void SaveToFile(string fileName)
        {
            List<string> lines = new List<string>();

            foreach (Entry entry in _entries)
            {
                lines.Add($"{entry._theDate}{Separator}{entry._thePrompt}{Separator}{entry._userResponse}");
            }

            File.WriteAllLines(fileName, lines);
            Console.WriteLine("Journal saved.");
        }

        public void LoadFromFile(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            List<Entry> loadedEntries = new List<Entry>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] { Separator }, 3, StringSplitOptions.None);

                if (parts.Length != 3)
                {
                    throw new FormatException("The selected file contains an entry in an invalid format.");
                }

                Entry entry = new Entry();
                entry._theDate = parts[0];
                entry._thePrompt = parts[1];
                entry._userResponse = parts[2];
                loadedEntries.Add(entry);
            }

            _entries.Clear();
            _entries.AddRange(loadedEntries);
            Console.WriteLine("Journal loaded.");
        }
    }
}