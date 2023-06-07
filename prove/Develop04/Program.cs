using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        ListingActivity listing = new ListingActivity();
        BreathingActivity breathing = new BreathingActivity();
        ReflectingActivity reflecting = new ReflectingActivity();

        int choice = menu.Display();
        
        while (choice != 4)
        {
            if (choice == 1)
            {
                breathing.BreathingInstructions();
            }

            else if (choice == 2)
            {
                reflecting.RunReflection();
            }

            else if (choice == 3)
            {
                listing.RunListingActivity();
            }

            choice = menu.Display();
        }
    }
}