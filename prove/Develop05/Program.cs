using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        EternalGoal one = new EternalGoal("goal1", "a goal", 2);
        menu._goals.Add(one);
        SimpleGoal two = new SimpleGoal("goal2", "another goal", 3, true);
        menu._goals.Add(two);
        ChecklistGoal three = new ChecklistGoal("goal 3", "third goal", 2, 3, 30, 3, false);
        menu._goals.Add(three);
        
        int choice = menu.DisplayMenu();
        while (choice != 6)
        {
            if (choice == 1)
            {

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

            }
            else if (choice == 5)
            {

            }
            menu.DisplayMenu();
        }
    }
}