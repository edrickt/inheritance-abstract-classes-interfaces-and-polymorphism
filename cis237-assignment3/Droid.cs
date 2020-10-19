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
    abstract class Droid : IDroid
    {
        protected string material;
        protected string color;
        protected decimal baseCost;
        protected decimal totalCost;

        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        /// <summary>
        /// Abstract since each class model name is different
        /// and needs to be overriden
        /// </summary>
        public abstract string Model
        {
            get;
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        /// <summary>
        /// Calculate base cost based on model and material
        /// </summary>
        protected void CalculateBaseCost()
        {
            baseCost = DroidCollection.FindMaterialCost(Material);
            baseCost += DroidCollection.FindModelCost(Model);
        }
        /// <summary>
        /// Made virtual because it is calculated differently in different
        /// derived classes
        /// </summary>
        public virtual void CalculateTotalCost()
        {
            totalCost = 0.0m;
            totalCost += baseCost;
        }
        /// <summary>
        /// Override ToString() to output features. Will calculate total cost here
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            CalculateTotalCost();

            return "MODEL: " + Model + Environment.NewLine +
                   "BASE COST: " + baseCost.ToString("C") + Environment.NewLine +
                   "TOTAL COST: " + totalCost.ToString("C") + Environment.NewLine +
                   "MATERIAL: " + material + Environment.NewLine +
                   "COLOR: " + color + Environment.NewLine;
        }
        /// <summary>
        /// Base constructor
        /// </summary>
        /// <param name="material"></param>
        /// <param name="color"></param>
        public Droid(string material, string color)
        {
            this.Material = material;
            this.Color = color;

            CalculateBaseCost();
        }
    }
}