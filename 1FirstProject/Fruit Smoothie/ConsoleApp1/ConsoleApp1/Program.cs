using System;

namespace FruitSmoothie
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Diagnostics.Debugger.Launch();
            //args = new string[] { "shena" };
            try
            {
                if (args.Length == 0)
                    throw new Exception("Please enter all the ingredients");


                // Getting ingredients and price data from file and storing it in pricechart object
                PriceChart pricechart = new PriceChart();
                pricechart.ReadDataFromFile("PriceChartDictionary.json");
                Smoothie.PriceChartDependency = pricechart;

                // Process
                Smoothie smoothie = new Smoothie(args);
                var cost = smoothie.GetCost();
                var price = smoothie.GetPrice();
                var name = smoothie.GetName();


                //Show
                Console.WriteLine($"Smoothie Name  : {name}");
                Console.WriteLine($"Smoothie Price : {price}");
                Console.WriteLine($"Smoothie Cost  : {cost}");
            }

            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            
        }

    }
}
