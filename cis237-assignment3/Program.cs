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
                    string model = ui.SelectModel();
                    string color = ui.SelectColor();
                    string material = ui.SelectMaterial();

                    if (model == "Utility")
                    {
                        bool toolBox = ui.ToolBox();
                        bool computerConnection = ui.ComputerConnection();
                        bool arms = ui.Arms();
                        myDroids[index] = new Utility(material, color, toolBox, computerConnection, arms);

                        index++;
                    }
                    if (model == "Protocol")
                    {
                        int numberOfLanguages = ui.NumberOfLanguage();
                        myDroids[index] = new Protocol(material, color, numberOfLanguages);

                        index++;
                    }
                    if (model == "Astromech")
                    {
                        bool toolBox = ui.ToolBox();
                        bool computerConnection = ui.ComputerConnection();
                        bool arms = ui.Arms();
                        bool fireExtinguisher = ui.FireExtinguisher();
                        int numberOfShips = ui.NumberOfShips();
                        myDroids[index] = new Astromech(material, color, toolBox, computerConnection, arms, fireExtinguisher, numberOfShips);

                        index++;
                    }
                    if (model == "Janitor")
                    {
                        bool toolBox = ui.ToolBox();
                        bool computerConnection = ui.ComputerConnection();
                        bool arms = ui.Arms();
                        bool trashCompactor = ui.TrashCompactor();
                        bool vacuum = ui.Vacuum();
                        myDroids[index] = new Janitor(material, color, toolBox, computerConnection, arms, trashCompactor, vacuum);

                        index++;
                    }
                }
                else if (menuChoice == "2")
                {
                    Console.Clear();
                    string outputString = "";

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
