using System;

class Program
{
    static void Main(string[] args)
    {
        var homeList = new List<string> {"Messier", "New General", "Caldwell"};
        Menu homeMenu = new Menu(homeList, "Choose your catalogue:", 1);

        var messierList = new List<string> {"List Objects", "Add Viewing", "Back"};
        Menu messierMenu = new Menu(messierList, "Choose your activity:", 2);

        var NGCList = new List<string> {"List Objects", "Search", "Back"};
        Menu NGCMenu = new Menu(NGCList, "Choose your activity:", 3);

        var backList = new List<string> {"Back"};
        Menu back = new Menu(backList, "Choose your activity:", 4);

        ProcessList(homeMenu);

        void ProcessList(Menu menu)
        {
            
            if (menu._listNumber == 1)
            {
                int choice = menu.Selection();
                if (choice == 0)
                {
                    ProcessList(messierMenu);
                }
                if (choice == 1)
                {
                    ProcessList(NGCMenu);
                }
                if (choice == 2)
                {
                    
                }
            }
            else if (menu._listNumber == 2)
            {
                int choice = menu.Selection();
                if (choice == 0)
                {
                    menu.DisplayObjects("Messier");
                    back.Selection();
                    ProcessList(messierMenu);
                }
                if (choice == 1)
                {
                    
                }
                if (choice == 2)
                {
                    ProcessList(homeMenu);
                }
            }
            else if (menu._listNumber == 3)
            {
                int choice = menu.Selection();
                if (choice == 0)
                {
                    menu.DisplayObjects("NGC");
                    back.Selection();
                    ProcessList(NGCMenu);
                }
                if (choice == 1)
                {
                    menu.Search("ngc.txt");
                    back.Selection();
                    ProcessList(NGCMenu);
                }
                if (choice == 2)
                {
                    ProcessList(homeMenu);
                }
            }
        }
    }
}