﻿// Edrick Tamayo
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

        public bool TrashCompactor
        {
            get { return trashCompactor; }
        }
        public bool Vacuum
        {
            get { return vacuum; }
        }
        public override string Model
        {
            get { return model; }
            set { model = value; }
        }

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

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                   "TRASH COMPACTOR: " + trashCompactor.ToString() + Environment.NewLine +
                   "VACUUM: " + vacuum.ToString();
        }

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
