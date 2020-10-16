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
        /// <summary>
        /// Receive user input for menu
        /// </summary>
        /// <returns></returns>
        public string GetUserInput()
        {
            this.PrintMenu();

            string input = Console.ReadLine();

            return input;
        }
        /// <summary>
        /// Print menu
        /// </summary>
        private void PrintMenu()
        {
            Console.WriteLine("OPTIONS:");
            Console.WriteLine("1. Add Droid");
            Console.WriteLine("2. Print List");
            Console.WriteLine("3. Exit");
        }
        /// <summary>
        /// Output the list
        /// </summary>
        /// <param name="outputString"></param>
        public void Output(string outputString)
        {
            Console.WriteLine(outputString);
        }
        /// <summary>
        /// Menu to select model. Will return corresponding string
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Run menu for selecting material and returns it as string
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Runs menu to select color and returns it as string
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Run menu to select number of languages
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Run menu to select number of ships
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Run menu to select if Y/N toolbox
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Run menu to select if Y/N computer connection
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Run menu if Y/N for arms
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Run menu if Y/N for trash compactor
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Run menu if Y/N for vacuum
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Run menu for Y/N for fire extinguisher
        /// </summary>
        /// <returns></returns>
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
