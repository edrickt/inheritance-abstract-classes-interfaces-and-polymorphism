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

        public bool ToolBox
        {
            get { return toolBox; }
        }
        public bool ComputerConnection
        {
            get { return computerConnection; }
        }
        public bool Arms
        {
            get { return arms; }
        }

        public override string Model
        {
            get { return model; }
        }

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
        public override string ToString()
        {
            return "MODEL: " + model + Environment.NewLine +
                    base.ToString() +
                    "TOOLBOX: " + toolBox.ToString() + Environment.NewLine +
                    "COMP. CON.: " + computerConnection.ToString() + Environment.NewLine +
                    "ARMS: " + arms.ToString() + Environment.NewLine;
                    
        }

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
