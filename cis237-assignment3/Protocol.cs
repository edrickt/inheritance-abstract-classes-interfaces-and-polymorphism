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

        /// <summary>
        /// Override the string model to droid model name
        /// </summary>
        public override string Model
        {
            get { return model; }
        }

        /// <summary>
        /// Calculate total costs based on number of languages * cost
        /// and base cost added
        /// </summary>
        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();

            totalCost += numberOfLanguages * COST_PER_LANGUAGE;
        }
        /// <summary>
        /// Overrides to string in order to add line for number of languages.
        /// Get base.ToString() from base class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "MODEL: " + model + Environment.NewLine + 
                    base.ToString() +
                    "# OF LANG: " + numberOfLanguages + Environment.NewLine;
        }
        /// <summary>
        /// Constructor for protocol droid
        /// </summary>
        /// <param name="material"></param>
        /// <param name="color"></param>
        /// <param name="numberOfLanguages"></param>
        public Protocol(string material, string color, int numberOfLanguages) : base(material, color)
        {
            this.numberOfLanguages = numberOfLanguages;

            CalculateBaseCost();
        }
    }
}
