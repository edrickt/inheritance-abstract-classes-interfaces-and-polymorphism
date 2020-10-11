﻿using System;
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

        public int NumberOfLanguages
        {
            get { return numberOfLanguages; }
            set { numberOfLanguages = value; }
        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();

            totalCost += numberOfLanguages * COST_PER_LANGUAGE;
        }
        public override string ToString()
        {
            return "MODEL: " + model + Environment.NewLine + 
                    base.ToString() + Environment.NewLine + 
                    "# OF LANG: " + numberOfLanguages;
        }

        public Protocol(string material, string color, int numberOfLanguages) : base(material, color)
        {
            this.NumberOfLanguages = numberOfLanguages;

            CalculateBaseCost();
        }
    }
}
