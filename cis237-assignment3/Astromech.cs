// Edrick Tamayo
// Thursday 3:30PM Class
// 20 Oct 2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class Astromech : Utility
    {
        private const decimal FIRE_EXTINGUISHER_PRICE = 50.00m;
        private const decimal SHIP_PRICE = 120.00m;

        public string model = "Astromech";
        private bool fireExtinguisher;
        private int numberOfShips;

        public bool FireExtinguisher
        {
            get { return fireExtinguisher; }
        }
        public int NumberOfShips
        {
            get { return numberOfShips; }
        }
        public override string Model
        {
            get { return model; }
        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            
            if (fireExtinguisher == true)
            {
                totalCost += FIRE_EXTINGUISHER_PRICE;
            }
            totalCost += numberOfShips * SHIP_PRICE;
        }

        public override string ToString()
        {
            return base.ToString() +
                   "FIRE EXTINGUISHER: " + fireExtinguisher.ToString() + Environment.NewLine +
                   "NUMBER OF SHIPS: " + numberOfShips + Environment.NewLine;
        }

        public Astromech (string material, string color, bool toolBox,
                          bool computerConnection, bool arms, bool fireExtinguisher,
                          int numberOfShips) : base(material, color, toolBox, computerConnection, arms)
        {
            this.fireExtinguisher = fireExtinguisher;
            this.numberOfShips = numberOfShips;

            CalculateBaseCost();
        }
    }
}
