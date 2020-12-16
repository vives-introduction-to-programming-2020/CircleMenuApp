using CircleLibrary;
using MenuLibrary;
using System;

namespace CircleMenuApp
{
    class Program
    {
        // Attributes are available to all methods
        private static Circle circle = new Circle();
        private static Menu main = new Menu();

        private static void CreateMenu()
        {
            main.Add("Change Radius");   // 0
            main.Add("About");  // 1
            main.Add("Exit");   // 2
        }

        private static void ShowMainScreen()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the awesome circle app");
            Console.WriteLine("\n---------------------------------");
            Console.WriteLine(circle);
            Console.WriteLine("---------------------------------\n");
            Console.WriteLine(main);
        }

        private static void RequestMenuSelection()
        {
            ConsoleKey key;
            do
            {
                ShowMainScreen();
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.UpArrow)
                {
                    main.Previous();
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    main.Next();
                }
            } while (key != ConsoleKey.Enter);
        }

        private static void ShowAbout()
        {
            Console.WriteLine("This app was created as a demo for students");
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }

        private static void ChangeRadius()
        {
            Console.Write("Please enter radius of circle: ");
            circle.SetRadius(Convert.ToDouble(Console.ReadLine()));
        }

        private static void ProcessMenuItem()
        {
            if (main.GetSelected() == "Change Radius")
            {
                ChangeRadius();
            }
            else if (main.GetSelected() == "About")
            {
                ShowAbout();
            }
        }


        static void Main(string[] args)
        {
            CreateMenu();

            do
            {
                RequestMenuSelection();
                ProcessMenuItem();
            } while (main.GetSelected() != "Exit");
        }
    }
}
