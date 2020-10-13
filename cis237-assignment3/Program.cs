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

            myDroids[0] = new Utility("Titanium", "Blue", true, true, true);
            myDroids[1] = new Astromech("Titanium", "Blue", true, true, true, true, 4);
            myDroids[2] = new Janitor("Titanium", "Blue", true, true, true, true, true);

            string outputString = "";

            //Print out the employees in the array
            foreach (IDroid droids in myDroids)
            {
                if (droids != null)
                {
                    //Concat to the outputString
                    outputString += droids.ToString() +
                        Environment.NewLine;
                }
            }
            ui.Output(outputString);
        }
    }
}
