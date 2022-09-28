using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace FruitSmoothie
{
    public class PriceChart
    {
        private Dictionary<string, double> IngredientPriceRawData { get; set; }

        public void ReadDataFromFile(string filepath)
        {
            if (File.Exists(filepath))
            {
                string complete_raw_data_from_file = File.ReadAllText(filepath);

                IngredientPriceRawData = JsonConvert.DeserializeObject<Dictionary<string, double>>(complete_raw_data_from_file);
            }

            else
                throw new Exception("File does not exist. Please enter the correct file path");
        }

        public double GetPrice(string ingredient)
        {
            ingredient = ingredient.ToLower();

            if (IngredientPriceRawData.ContainsKey(ingredient))
                return IngredientPriceRawData[ingredient];

            throw new Exception("Ingredient doesn't match. Enter ingredients from the list.");
        }
    }

}
