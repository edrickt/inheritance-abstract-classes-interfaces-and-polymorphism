// Edrick Tamayo
// Thursday 3:30PM Class
// 20 Oct 2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class DroidCollection
    {
        public static IDroid[] myDroids = new IDroid[100];
        /// <summary>
        /// Find cost of droid from the choice of model
        /// </summary>
        /// <param name="model">Model passed in from input</param>
        /// <returns></returns>
        public static decimal FindModelCost(string model)
        {
            if (model == "Protocol")
            {
                return 600.00m;
            }
            else if (model == "Utility")
            {
                return 800.00m;
            }
            else if (model == "Astromech")
            {
                return 1000.00m;
            }
            else if (model == "Janitor")
            {
                return 700.00m;
            }
            return 0.00m;
        }
        /// <summary>
        /// Find price of material
        /// </summary>
        /// <param name="material">Input from user from interface</param>
        /// <returns></returns>
        public static decimal FindMaterialCost(string material)
        {
            if (material == "Aluminum")
            {
                return 100.00m;
            }
            else if (material == "Steel")
            {
                return 150.00m;
            }
            else if (material == "Titanium")
            {
                return 250.00m;
            }
            return 0.00m;
        }
        /// <summary>
        /// Add a droid to the list
        /// </summary>
        /// <param name="index">Pass in as ref to change number of index</param>
        /// <returns></returns>
        public static IDroid[] AddDroid(ref int index)
        {
            UserInterface ui = new UserInterface();

            // Assign these variables from the strings passed from methods
            string model = ui.SelectModel();
            string color = ui.SelectColor();
            string material = ui.SelectMaterial();

            // If model matches droid, then run methods that is needed for droid, add to myDroids
            // and return myDroids
            if (model == "Utility")
            {
                bool toolBox = ui.ToolBox();
                bool computerConnection = ui.ComputerConnection();
                bool arms = ui.Arms();
                myDroids[index] = new Utility(material, color, toolBox, computerConnection, arms);

                index++;

                return myDroids;
            }
            if (model == "Protocol")
            {
                int numberOfLanguages = ui.NumberOfLanguage();
                myDroids[index] = new Protocol(material, color, numberOfLanguages);

                index++;

                return myDroids;
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

                return myDroids;
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

                return myDroids;
            }
            return myDroids;
        }
        DroidCollection()
        {
        }
    }
}
