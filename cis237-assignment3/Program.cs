// Edrick Tamayo
// Thursday 3:30PM Class
// 20 Oct 2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();

            IDroid[] myDroids = new IDroid[100];

            int index = 0;

            bool loopBool = true;

            while (loopBool)
            {
                string menuChoice = ui.GetUserInput();

                if (menuChoice == "1")
                {
                    myDroids = DroidCollection.AddDroid(ref index);
                }
                else if (menuChoice == "2")
                {
                    Console.Clear();
                    string outputString = "";

                    if (myDroids[0] == null)
                    {
                        Console.WriteLine("LIST EMPTY" + Environment.NewLine + 
                                          "Please add a droid first" + Environment.NewLine);
                    }
                    else
                    {     
                        foreach (IDroid droids in myDroids)
                        {
                            if (droids != null)
                            {
                                outputString += droids.ToString() +
                                    Environment.NewLine;
                            }
                        }
                        ui.Output(outputString);
                    }
                }
                else if (menuChoice == "3")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter valid option");
                }
                
            }
        }
    }
}
