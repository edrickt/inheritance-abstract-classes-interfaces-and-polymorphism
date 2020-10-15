// Edrick Tamayo
// Thursday 3:30PM Class
// 20 Oct 2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace cis237_assignment3
{
    class UserInterface
    {
        public string GetUserInput()
        {
            this.PrintMenu();

            string input = Console.ReadLine();

            return input;
        }
        private void PrintMenu()
        {
            Console.WriteLine("OPTIONS:");
            Console.WriteLine("1. Add Droid");
            Console.WriteLine("2. Print List");
            Console.WriteLine("3. Exit");
        }
        public void Output(string outputString)
        {
            Console.WriteLine(outputString);
        }
        public string SelectModel()
        {
            Console.Clear();
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine("Enter number corresponding with option and press ENTER" + Environment.NewLine + Environment.NewLine +
                              "Model: " + Environment.NewLine +
                              "1. Protocol" + Environment.NewLine +
                              "2. Utility" + Environment.NewLine +
                              "3. Astromech" + Environment.NewLine +
                              "4. Janitor" + Environment.NewLine);
                string choice = Console.ReadLine();
                Console.Clear();

                if (choice == "1")
                {
                    loop = false;
                    return "Protocol";
                }
                else if (choice == "2")
                {
                    loop = false;
                    return "Utility";
                }
                else if (choice == "3")
                {
                    loop = false;
                    return "Astromech";
                }
                else if (choice == "4")
                {
                    loop = false;
                    return "Janitor";
                }
                else
                {
                    Console.WriteLine("PLEASE ENTER VALID INPUT");
                }
            }
            return "-1";
        }
        public string SelectMaterial()
        {
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine("Enter number corresponding with option and press ENTER" + Environment.NewLine + Environment.NewLine +
                                 "Material: " + Environment.NewLine +
                                 "1. Aluminum" + Environment.NewLine +
                                 "2. Steel" + Environment.NewLine +
                                 "3. Titanium" + Environment.NewLine);

                string choice = Console.ReadLine();
                Console.Clear();

                if (choice == "1")
                {
                    return "Aluminum";
                }
                else if (choice == "2")
                {
                    return "Steel";
                }
                else if (choice == "3")
                {
                    return "Titanium";
                }
                else
                {
                    Console.WriteLine("PLEASE ENTER VALID INPUT");
                }
            }
            return "-1";
        }
        public string SelectColor()
        {
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine("Enter number corresponding with option and press ENTER" + Environment.NewLine + Environment.NewLine +
                                  "Color: " + Environment.NewLine +
                                  "1. Silver" + Environment.NewLine +
                                  "2. Black" + Environment.NewLine +
                                  "3. Gold" + Environment.NewLine);

                string choice = Console.ReadLine();
                Console.Clear();

                if (choice == "1")
                {
                    return "Silver";
                }
                else if (choice == "2")
                {
                    return "Black";
                }
                else if (choice == "3")
                {
                    return "Gold";
                }
                else
                {
                    Console.WriteLine("PLEASE ENTER VALID INPUT"); ;
                }
            }
            return "-1";
        }
        public int NumberOfLanguage()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("How many languages?" + Environment.NewLine +
                                  "Type a number without commas" +
                                  Environment.NewLine);
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    Console.Clear();
                    return choice;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("PLEASE ENTER VALID INPUT");
                }
            }
            return -1;
        }
        public int NumberOfShips()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("How many ships?" + Environment.NewLine +
                                  "Type a number without commas and press ENTER" +
                                  Environment.NewLine);
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    return choice;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("PLEASE ENTER VALID INPUT");
                }
            }
            return -1;
        }
        public bool ToolBox()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Add Tool Box?" + Environment.NewLine +
                              "1. YES" + Environment.NewLine +
                              "2. NO" + Environment.NewLine);
                string choice = Console.ReadLine();
                Console.Clear();

                if (choice == "1")
                {
                    return true;
                }
                else if (choice == "2")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("PLEASE ENTER VALID INPUT"); ;
                };
            }
            return false;
        }
        public bool ComputerConnection()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Add Computer Connection?" + Environment.NewLine +
                              "1. YES" + Environment.NewLine +
                              "2. NO" + Environment.NewLine);
                string choice = Console.ReadLine();
                Console.Clear();
                if (choice == "1")
                {
                    return true;
                }
                else if (choice == "2")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("PLEASE ENTER VALID INPUT"); ;
                }
            }
            return false;
        }
        public bool Arms()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Add Arms" + Environment.NewLine +
                              "1. YES" + Environment.NewLine +
                              "2. NO" + Environment.NewLine);
                string choice = Console.ReadLine();
                Console.Clear();
                if (choice == "1")
                {
                    return true;
                }
                else if (choice == "2")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("PLEASE ENTER VALID INPUT"); ;
                }
            }
            return false;
        }
        public bool TrashCompactor()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Add Trash Compactor?" + Environment.NewLine +
                              "1. YES" + Environment.NewLine +
                              "2. NO" + Environment.NewLine);
                string choice = Console.ReadLine();
                Console.Clear();
                if (choice == "1")
                {
                    return true;
                }
                else if (choice == "2")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("PLEASE ENTER VALID INPUT"); ;
                }
            }
            return false;
        }
        public bool Vacuum()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Add Vacuum?" + Environment.NewLine +
                              "1. YES" + Environment.NewLine +
                              "2. NO" + Environment.NewLine);
                string choice = Console.ReadLine();
                Console.Clear();
                if (choice == "1")
                {
                    return true;
                }
                else if (choice == "2")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("PLEASE ENTER VALID INPUT"); ;
                }
            }
            return false;
        }
        public bool FireExtinguisher()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Add Fire Extinguisher?" + Environment.NewLine +
                              "1. YES" + Environment.NewLine +
                              "2. NO" + Environment.NewLine);
                string choice = Console.ReadLine();
                Console.Clear();
                if (choice == "1")
                {
                    return true;
                }
                else if (choice == "2")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("PLEASE ENTER VALID INPUT"); ;
                }
            }
            return false;
        }
    }
}
