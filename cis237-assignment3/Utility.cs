// Edrick Tamayo
// Thursday 3:30PM Class
// 20 Oct 2020

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class Utility : Droid
    {
        private const decimal TOOL_BOX_PRICE = 200.00m;
        private const decimal COMPUTER_CON_PRICE = 50.00m;
        private const decimal ARMS_PRICE = 100.00m;

        private string model = "Utility";
        private bool toolBox;
        private bool computerConnection;
        private bool arms;

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

            if (toolBox == true)
            {
                totalCost += TOOL_BOX_PRICE;
            }
            if (computerConnection == true)
            {
                totalCost += COMPUTER_CON_PRICE;
            }
            if (arms == true)
            {
                totalCost += ARMS_PRICE;
            }
        }
        /// <summary>
        /// Overrides to string in order to add line for number of languages.
        /// Get base.ToString() from base class.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return  base.ToString() +
                    "TOOLBOX: " + toolBox.ToString() + Environment.NewLine +
                    "COMP. CON.: " + computerConnection.ToString() + Environment.NewLine +
                    "ARMS: " + arms.ToString() + Environment.NewLine;
                    
        }
        /// <summary>
        /// Constructor for utility droid. Material and color is passed in from base class
        /// </summary>
        /// <param name="material"></param>
        /// <param name="color"></param>
        /// <param name="toolBox"></param>
        /// <param name="computerConnection"></param>
        /// <param name="arms"></param>
        public Utility(string material, string color, bool toolBox, bool computerConnection,
                       bool arms) : base(material, color)
        {
            this.toolBox = toolBox;
            this.computerConnection = computerConnection;
            this.arms = arms;

            CalculateBaseCost();
        }
    }
}
