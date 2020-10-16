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
    class Protocol : Droid
    {
        private const decimal COST_PER_LANGUAGE = 10m;

        private string model = "Protocol";
        private int numberOfLanguages; 

        public override string Model
        {
            get { return model; }
        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();

            totalCost += numberOfLanguages * COST_PER_LANGUAGE;
        }
        public override string ToString()
        {
            return "MODEL: " + model + Environment.NewLine + 
                    base.ToString() +
                    "# OF LANG: " + numberOfLanguages + Environment.NewLine;
        }

        public Protocol(string material, string color, int numberOfLanguages) : base(material, color)
        {
            this.numberOfLanguages = numberOfLanguages;

            CalculateBaseCost();
        }
    }
}
