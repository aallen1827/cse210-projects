using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        
        int choice = menu.DisplayMenu();
        while (choice != 6)
        {
            if (choice == 1)
            {
                menu.CreateGoal();
            }
            else if (choice == 2)
            {
                menu.DisplayGoals();
            }
            else if (choice == 3)
            {
                menu.Save();
            }
            else if (choice == 4)
            {
                menu.Load();
            }
            else if (choice == 5)
            {
                menu.RecordEvent();
            }
            choice = menu.DisplayMenu();
        }
    }
}