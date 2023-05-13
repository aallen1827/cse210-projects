using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program");
        
        Prompt prompt1 = new Prompt();
        prompt1._prompt = "Who was the most interesting person I interacted with today?";

        Prompt prompt2 = new Prompt();
        prompt2._prompt = "What was the most interesting thing that happened today?";

        Prompt prompt3 = new Prompt();
        prompt3._prompt = "What was the best part of my day?";

        Prompt prompt4 = new Prompt();
        prompt4._prompt = "If I could do one thing over today what would it be?";

        Prompt prompt5 = new Prompt();
        prompt5._prompt = "What was the funniest thing that happened today?";

        Menu menu1 = new Menu();

        Prompt prompts = new Prompt();
        prompts._prompts.Add(prompt1);
        prompts._prompts.Add(prompt2);
        prompts._prompts.Add(prompt3);
        prompts._prompts.Add(prompt4);
        prompts._prompts.Add(prompt5);
        
        bool run = true;

        Entry entries = new Entry();

        while (run)
        {
            menu1.Display();
            
            int choice = int.Parse(Console.ReadLine());
            
            if (choice == 1)
            {
                string usedPrompt = prompts.GeneratePrompt();
                Console.Write("> ");
                string journalEntry = Console.ReadLine();
                DateTime date = DateTime.Today;
                string newDate = date.ToShortDateString();
                Entry entry1 = new Entry();
                entry1._date = newDate;
                entry1._journalEntry = journalEntry;
                entry1._prompt = usedPrompt;
                entries._entries.Add(entry1);
            }
            else if (choice == 2)
            {
               foreach (Entry entry in entries._entries)
               {
                    entry.Display();
               }
            }
            else if (choice == 3)
            {
                Console.Write("What is the name of your file? ");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");
                    string date = parts[0];
                    string prompt = parts[1];
                    string journalEntry = parts[2];
                    Console.WriteLine($"Date: {date} - {prompt}\n{journalEntry}");
                }
            }
            else if (choice == 4)
            {
                Console.Write("What would you like to name your file? ");
                string filename = Console.ReadLine();
                using (StreamWriter outputfile = new StreamWriter(filename))
                {
                    foreach (Entry entry in entries._entries)
                    {
                        outputfile.WriteLine($"{entry._date},{entry._prompt},{entry._journalEntry}");
                    }
                }
            }
            else if (choice == 5)
            {
                run = false;
            }
        }
    }
}