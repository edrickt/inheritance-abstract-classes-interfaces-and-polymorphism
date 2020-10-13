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

            if (input == "1")
            {
                return "1";
            }
            else if (input == "2")
            {
                
                return "2";
            }
            else if (input == "3")
            {
                Environment.Exit(0);
                return "3";
            }
            return "-1";
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
    }
}
