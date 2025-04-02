/*
Exceeding Requirements:
1. Scripture Library: Loads multiple scriptures from scriptures.txt file
2. Smart Reference Parsing: Handles complex references like "2 Nephi 2:25" and verse ranges
3. Non-redundant Hiding: Only hides words that aren't already hidden
4. Error Handling: Gracefully skips invalid entries in scripture file
*/

class Program
{
    static void Main()
    {
        var scriptures = LoadScriptures();
        if (!scriptures.Any()) return;

        var scripture = SelectRandomScripture(scriptures);
        RunMemorizationLoop(scripture);
    }

    static List<Scripture> LoadScriptures()
    {
        var scriptures = new List<Scripture>();
        
        try
        {
            foreach (var line in File.ReadAllLines("scriptures.txt"))
            {
                var parts = line.Split('|');
                if (parts.Length != 2) continue;
                
                var reference = Reference.Parse(parts[0].Trim());
                scriptures.Add(new Scripture(reference, parts[1].Trim()));
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Scripture file not found");
        }
        
        return scriptures;
    }

    static Scripture SelectRandomScripture(List<Scripture> scriptures)
    {
        var random = new Random();
        return scriptures[random.Next(scriptures.Count)];
    }

    static void RunMemorizationLoop(Scripture scripture)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            
            if (scripture.AllWordsHidden()) break;
            
            Console.Write("\nPress ENTER to continue or type QUIT: ");
            var input = Console.ReadLine();
            
            if (input?.Equals("quit", StringComparison.OrdinalIgnoreCase) == true)
                break;

            scripture.HideRandomWords(3);
        }
        
        Console.WriteLine("\nAll words hidden! Program ending.");
    }
}