using System;

//I exceeded the core requirements by making only words that have not already been hidden are hidden when the program calls the HideWords function.

class Program
{
    static void Main(string[] args)
    {
        string scriptureText = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        Reference reference1 = new Reference("1 Nephi", "3", "7");
        Scripture scripture1 = new Scripture(reference1, scriptureText);
        scripture1.CreateWords(scriptureText);
        bool finished = false;

        while (finished == false)
        {
            scripture1.Display();
            ConsoleKeyInfo keyPressed = Console.ReadKey(true);

            if (keyPressed.Key == ConsoleKey.Enter)
            {
                finished = scripture1.AllHidden();
                scripture1.HideWords();
            }

            if (keyPressed.KeyChar == 'q')
            {
                Console.Write("q");
                string entry = Console.ReadLine();

                if (entry == "uit")
                {
                    finished = true;
                }
            }
        }
    }
}