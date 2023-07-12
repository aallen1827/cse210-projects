using System;

class Program
{
    static void Main(string[] args)
    {
        var homeList = new List<string> {"Select a catalogue", "Record Viewing", "Save", "Quit"};
        Menu homeMenu = new Menu(homeList, "Select an action:", 0);
        
        var catalogueList = new List<string> {"Messier", "NGC", "Caldwell", "IC", "Non NGC", "Satellite", "Back"};
        Menu catalogueMenu = new Menu(catalogueList, "Choose your catalogue:", 1);

        var DSOList = new List<string> {"List Objects", "Search", "Back"};

        Menu messierMenu = new Menu(DSOList, "Choose your activity:", 2);

        Menu NGCMenu = new Menu(DSOList, "Choose your activity:", 3);

        var backList = new List<string> {"Back"};
        Menu back = new Menu(backList, "", 4);

        Menu caldwellMenu = new Menu(DSOList, "Choose your activity:", 5);

        Menu ICMenu = new Menu(DSOList, "Choose your activity:", 6);

        Menu nonNGCMenu = new Menu(DSOList, "Choose your activity:", 7);

        Menu satelliteMenu = new Menu(DSOList, "Choose your activity:", 8);

        var messierObjects = new List<Messier> {};
        var NGCObjects = new List<NGC> {};
        var caldwellObjects = new List<Caldwell> {};
        var ICObjects = new List<IC> {};
        var nonNGCObjects = new List<NonNGC> {};
        var satelliteObjects = new List<Satellite> {};

        Load();

        ProcessList(homeMenu);

        void ProcessList(Menu menu)
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            Console.Clear();
            if (menu._listNumber == 0)
            {
                int choice = menu.Selection();
                if (choice == 0)
                {
                    ProcessList(catalogueMenu);
                }
                else if (choice == 1)
                {
                    RecordViewing();
                }
                else if (choice == 2)
                {
                    using (StreamWriter outputFile = new StreamWriter("test.txt")) {
                        messierObjects[0].Save(outputFile, messierObjects);
                        NGCObjects[0].Save(outputFile, NGCObjects);
                        caldwellObjects[0].Save(outputFile, caldwellObjects);
                        ICObjects[0].Save(outputFile, ICObjects);
                        nonNGCObjects[0].Save(outputFile, nonNGCObjects);
                        satelliteObjects[0].Save(outputFile, satelliteObjects);
                    }
                }
                else if (choice == 3)
                {
                    //ends program
                }
            }
            else if (menu._listNumber == 1)
            {
                int choice = menu.Selection();
                if (choice == 0)
                {
                    ProcessList(messierMenu);
                }
                else if (choice == 1)
                {
                    ProcessList(NGCMenu);
                }
                else if (choice == 2)
                {
                    ProcessList(caldwellMenu);
                }
                else if (choice == 3)
                {
                    ProcessList(ICMenu);
                }
                else if (choice == 4)
                {
                    ProcessList(nonNGCMenu);
                }
                else if (choice == 5)
                {
                    ProcessList(satelliteMenu);
                }
                else
                {
                    ProcessList(homeMenu);
                }
            }
            else if (menu._listNumber == 2)
            {
                //Messier
                int choice = menu.Selection();
                if (choice == 0)
                {
                    menu.DisplayObjects(messierObjects);
                    back.Selection();
                    ProcessList(messierMenu);
                }
                else if (choice == 1)
                {
                    messierObjects[0].Search(messierObjects);

                    back.Selection();
                    ProcessList(messierMenu);
                }
                else if (choice == 2)
                {
                    ProcessList(catalogueMenu);
                }
            }
            else if (menu._listNumber == 3)
            {
                //NGC
                int choice = menu.Selection();
                if (choice == 0)
                {
                    menu.DisplayObjects(NGCObjects);
                    back.Selection();
                    ProcessList(NGCMenu);
                }
                else if (choice == 1)
                {
                    NGCObjects[0].Search(NGCObjects);

                    back.Selection();
                    ProcessList(NGCMenu);
                }
                else if (choice == 2)
                {
                    ProcessList(catalogueMenu);
                }
            }
            else if (menu._listNumber == 5)
            {
                //Caldwell
                int choice = menu.Selection();
                if (choice == 0)
                {
                    menu.DisplayObjects(caldwellObjects);
                    back.Selection();
                    ProcessList(caldwellMenu);
                }
                else if (choice == 1)
                {
                    caldwellObjects[0].Search(caldwellObjects);
                    back.Selection();
                    ProcessList(caldwellMenu);
                }
                else if (choice == 2)
                {
                    ProcessList(catalogueMenu);
                }
            }
            else if (menu._listNumber == 6)
            {
                //IC
                int choice = menu.Selection();
                if (choice == 0)
                {
                    menu.DisplayObjects(ICObjects);
                    back.Selection();
                    ProcessList(ICMenu);
                }
                else if (choice == 1)
                {
                    ICObjects[0].Search(ICObjects);
                    back.Selection();
                    ProcessList(ICMenu);
                }
                else if (choice == 2)
                {
                    ProcessList(catalogueMenu);
                }
            }
            else if (menu._listNumber == 7)
            {
                //Non NGC
                int choice = menu.Selection();
                if (choice == 0)
                {
                    menu.DisplayObjects(nonNGCObjects);
                    back.Selection();
                    ProcessList(nonNGCMenu);
                }
                else if (choice == 1)
                {
                    nonNGCObjects[0].Search(nonNGCObjects);

                    back.Selection();
                    ProcessList(nonNGCMenu);
                }
                else if (choice == 2)
                {
                    ProcessList(catalogueMenu);
                }
            }
            else if (menu._listNumber == 8)
            {
                //Satellite
                int choice = menu.Selection();
                if (choice == 0)
                {
                    menu.DisplayObjects(satelliteObjects);
                    back.Selection();
                    ProcessList(satelliteMenu);
                }
                else if (choice == 1)
                {
                    satelliteObjects[0].Search(satelliteObjects);
                    back.Selection();
                    ProcessList(satelliteMenu);
                }
                else if (choice == 2)
                {
                    ProcessList(catalogueMenu);
                }
            }
        }

        void Load()
        {
            string filename = "test.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string className = parts[0];

                if (className == "Satellite")
                {
                    int number = int.Parse(parts[1]);
                    string dateLaunched = parts[2];
                    string name = parts[3];

                    Satellite satellite = new Satellite(number, dateLaunched, name);
                    satelliteObjects.Add(satellite);
                }
                else
                {
                    string objectType = parts[1];
                    double magnitude = double.Parse(parts[2]);
                    string dateLastSeen = parts[3];

                    if (className == "NonNGC")
                    {
                        string catalogue = parts[4];
                        int number = int.Parse(parts[5]);

                        NonNGC nonNGC = new NonNGC(objectType, magnitude, dateLastSeen, catalogue, number);
                        nonNGCObjects.Add(nonNGC);
                    }
                    else
                    {
                        int number = int.Parse(parts[4]);

                        if (className == "Messier")
                        {
                            int messierNumber = int.Parse(parts[5]);

                            Messier messier = new Messier(objectType, magnitude, dateLastSeen, number, messierNumber);
                            messierObjects.Add(messier);
                        }
                        else if (className == "NGC")
                        {
                            NGC ngc = new NGC(objectType, magnitude, dateLastSeen, number);
                            NGCObjects.Add(ngc);
                        }
                        else if (className == "Caldwell")
                        {
                            int caldwellNumber = int.Parse(parts[5]);

                            Caldwell caldwell = new Caldwell(objectType, magnitude, dateLastSeen, number, caldwellNumber);
                            caldwellObjects.Add(caldwell);
                        }
                        else if (className == "IC")
                        {
                            IC ic = new IC(objectType, magnitude, dateLastSeen, number);
                            ICObjects.Add(ic);
                        }
                    }
                }
            }
        }

        void RecordViewing()
        {
            Console.WriteLine("To record a viewing, input the following information:");
            Console.Write("Catalogue: ");
            string catalogue = Console.ReadLine();
            Console.WriteLine();
            if (catalogue.ToLower() == "messier")
            {
                messierObjects[0].RecordViewing(messierObjects, NGCObjects);
            }
            else if (catalogue.ToLower() == "ngc")
            {
                NGCObjects[0].RecordViewing(NGCObjects);
            }
            else if (catalogue.ToLower() == "caldwell")
            {
                caldwellObjects[0].RecordViewing(caldwellObjects, NGCObjects);
            }
            else if (catalogue.ToLower() == "ic")
            {
                ICObjects[0].RecordViewing(ICObjects);
            }
            else if (catalogue.ToLower() == "satellite")
            {
                satelliteObjects[0].RecordViewing(satelliteObjects);
            }
            else
            {
                nonNGCObjects[0].RecordViewing(nonNGCObjects);
            }
            back.Selection();
            ProcessList(homeMenu);
        }
    }
}