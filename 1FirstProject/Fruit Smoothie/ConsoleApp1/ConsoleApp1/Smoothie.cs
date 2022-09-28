using System;
using System.Collections.Generic;
using System.Text;

namespace FruitSmoothie
{
    public class Smoothie
    {
        public static PriceChart PriceChartDependency { get; set; }


        public string[] Ingredients { get; private set; }

        public Smoothie(string[] ingredients)
        {
            Ingredients = ingredients;
        }


        public double GetCost()
        {
            double total_cost = 0;

            foreach (string ingredient in Ingredients)
            {
                var cost = PriceChartDependency.GetPrice(ingredient);
                total_cost += cost;
            }
            return total_cost;
        }

        public double GetPrice()
        {
            double total_cost = GetCost();
            return total_cost + (total_cost * 1.5);
        }

        public string GetName()
        {
            string name = string.Empty;

            foreach (string value in Ingredients)
            {
                if (value.EndsWith("berries"))
                    name += value.Remove(value.Length - 3) + "y ";
                else
                    name += value + " ";
            }

            return name + (Ingredients.Length == 1 ? "Smoothie" : "Fusion");
        }
    }
}
