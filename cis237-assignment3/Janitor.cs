// Edrick Tamayo
// Thursday 3:30PM Class
// 20 Oct 2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class Janitor : Utility
    {
        private const decimal TRASH_COMPACTOR_PRICE = 250.00m;
        private const decimal VACUUM_PRICE = 150.00m;

        private string model = "Janitor";
        private bool trashCompactor;
        private bool vacuum;

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

            if (trashCompactor == true)
            {
                totalCost += TRASH_COMPACTOR_PRICE;
            }
            if (vacuum == true)
            {
                totalCost += VACUUM_PRICE;
            }
        }
        /// <summary>
        /// Overrides to string in order to add line for options. Get
        /// base.ToString() from base class.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() +
                   "TRASH COMPACTOR: " + trashCompactor.ToString() + Environment.NewLine +
                   "VACUUM: " + vacuum.ToString() + Environment.NewLine;
        }
        /// <summary>
        /// Constructor for protocol droid. Material and color is passed in from base class
        /// </summary>
        /// <param name="material"></param>
        /// <param name="color"></param>
        /// <param name="toolBox"></param>
        /// <param name="computerConnection"></param>
        /// <param name="arms"></param>
        /// <param name="trashCompactor"></param>
        /// <param name="vacuum"></param>
        public Janitor(string material, string color, bool toolBox, bool computerConnection,
                       bool arms, bool trashCompactor, bool vacuum) : base (material, color, toolBox,
                       computerConnection, arms)
        {
            this.trashCompactor = trashCompactor;
            this.vacuum = vacuum;

            CalculateBaseCost();
        }
    }
}
