public class Menu
{
    public int Display()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("1. Start breathing activity");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("2. Start reflecting activity");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("3. Start listing activity");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("4. Quit");
        Console.ResetColor();
        Console.Write("Select a coice from the menu: ");
        int selectedActivity = int.Parse(Console.ReadLine());
        return selectedActivity;
    }
}