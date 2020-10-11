using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Environment.Exit(0);
                return "2";
            }
            return "-1";
        }
        private void PrintMenu()
        {
            Console.WriteLine("OPTIONS:");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. EXIT");
        }
    }
}
