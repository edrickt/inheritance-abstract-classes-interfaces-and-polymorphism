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

        private string model = "Astromech";
        private bool fireExtinguisher;
        private int numberOfShips;

        /// <summary>
        /// Used to override model string
        /// </summary>
        public override string Model
        {
            get { return model; }
        }
        /// <summary>
        /// Will calculate total cost according to options
        /// chosen, plus base cost.
        /// </summary>
        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            
            if (fireExtinguisher == true)
            {
                totalCost += FIRE_EXTINGUISHER_PRICE;
            }
            totalCost += numberOfShips * SHIP_PRICE;
        }
        /// <summary>
        /// Overrides to string in order to add line for options. Get
        /// base.ToString() from base class.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() +
                   "FIRE EXTINGUISHER: " + fireExtinguisher.ToString() + Environment.NewLine +
                   "NUMBER OF SHIPS: " + numberOfShips + Environment.NewLine;
        }
        /// <summary>
        /// Constructor for protocol droid. Material and color is passed in from base class
        /// </summary>
        /// <param name="material"></param>
        /// <param name="color"></param>
        /// <param name="toolBox"></param>
        /// <param name="computerConnection"></param>
        /// <param name="arms"></param>
        /// <param name="fireExtinguisher"></param>
        /// <param name="numberOfShips"></param>
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
