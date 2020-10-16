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
            // New instance of UserInterface class
            UserInterface ui = new UserInterface();
            // New array of IDroid
            IDroid[] myDroids = new IDroid[100];
            // Used to add to the droid list
            int index = 0;
            // Loop through menu
            bool loopBool = true;

            while (loopBool)
            {
                // Gets user input and runs PrintMenu()
                string menuChoice = ui.GetUserInput();
                // If input is 1 then add a droid
                if (menuChoice == "1")
                {
                    // myDroids array set to the array returned by AddDroid()
                    // Pass index as ref to change index
                    myDroids = DroidCollection.AddDroid(ref index);
                }
                // If input is 2 then print list
                else if (menuChoice == "2")
                {
                    Console.Clear();
                    string outputString = "";
                    // If empty then output "LIST EMPTY"
                    if (myDroids[0] == null)
                    {
                        Console.WriteLine("LIST EMPTY" + Environment.NewLine + 
                                          "Please add a droid first" + Environment.NewLine);
                    }
                    // Else print all droids in myDroids 
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
                // If input is 3 then exit
                else if (menuChoice == "3")
                {
                    Environment.Exit(0);
                }
                // If string is inputed and is not menu option, then output this
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter valid option");
                }
                
            }
        }
    }
}
