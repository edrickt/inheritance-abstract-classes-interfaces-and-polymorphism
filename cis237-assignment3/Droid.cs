using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    abstract class Droid : IDroid
    {
        // ****************************************
        // Variables
        // ****************************************
        protected string material;
        protected string color;
        protected decimal baseCost;
        protected decimal totalCost;

        // ****************************************
        // Properties
        // ****************************************
        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }
        public decimal BaseCost
        {
            get { return baseCost; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        // ****************************************
        // Public Methods
        // ****************************************
        protected virtual void CalculateBaseCost()
        {
            baseCost = DroidCollection.FindMaterialCost(Material);
        }
        public virtual void CalculateTotalCost()
        {
            totalCost = 0.0m;
            totalCost += baseCost;
        }
        public override string ToString()
        {
            CalculateTotalCost();

            return "BASE COST: $" + baseCost + Environment.NewLine +
                   "TOTAL COST: $" + totalCost + Environment.NewLine +
                   "MATERIAL: " + material + Environment.NewLine +
                   "COLOR: " + color;
        }

        // ****************************************
        // Constructors
        // ****************************************
        public Droid(string material, string color)
        {
            this.Material = material;
            this.Color = color;
        }
    }
}