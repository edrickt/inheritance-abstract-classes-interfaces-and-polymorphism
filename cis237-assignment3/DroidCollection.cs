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
        private string name;
        private decimal cost;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        //public static string[] protocol = { "Protocol", 600.00m.ToString() };
        //public static string[] utility = { "Utility", 800.00m.ToString() };
        //public static string[] astromech = { "Astromech", 1000.00m.ToString() };
        //public static string[] janitor = { "Janitor", 700.00m.ToString() };

        //public static string[] aluminum = { "Aluminum", 100.00m.ToString() };
        //public static string[] steel = { "Steel", 150.00m.ToString() };
        //public static string[] titanium = { "Titanium", 250.00m.ToString() };

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

        DroidCollection(string name, decimal cost)
        {
            name = Name;
            cost = Cost;
        }
        DroidCollection()
        {
        }
    }
}
