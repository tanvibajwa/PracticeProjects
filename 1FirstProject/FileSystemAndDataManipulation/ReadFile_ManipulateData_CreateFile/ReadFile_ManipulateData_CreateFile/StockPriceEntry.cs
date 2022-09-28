using System;
using System.Collections.Generic;
using System.Text;


namespace ReadFile_ManipulateData_CreateFile
{
    public class StockPriceEntry
    {
        public DateTime Time { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float PercentDifference { get; set; }

        public StockPriceEntry()
        {

        }

        public StockPriceEntry(string name, float price, DateTime time, float percentageDifference)
        {
            Name = name;
            Price = price;
            Time = time;
            PercentDifference = percentageDifference;
        }

        public static bool TryParseFromCSVEntry(string data_row, out StockPriceEntry result)
        {
            result = null;
            DateTime dt;
            float price;

            string[] each_attribute = data_row.Split(',');
            if (each_attribute.Length < 3 || string.IsNullOrEmpty(each_attribute[0]) || string.IsNullOrEmpty(each_attribute[1]) || string.IsNullOrEmpty(each_attribute[2]))
                return false;
            bool datetime_conversion_successful = DateTime.TryParse(each_attribute[0], out dt);

            StockPriceEntry stockPriceEntry = new StockPriceEntry();
            stockPriceEntry.Time = dt;
            stockPriceEntry.Name = each_attribute[1];
            bool price_conversion_successful = float.TryParse(each_attribute[2], out price);
            stockPriceEntry.Price = price;

            result = stockPriceEntry;

            return (price < 0 || datetime_conversion_successful == false || price_conversion_successful == false) ? false : true;
             
        }

        public static List<string> CollectionToStringCSV(List<StockPriceEntry> collection) //for serialization - module 3
        {
            var output = new List<string>();

            output.Add("Time,Name,Price,PercentageDifference");

            foreach (var entry in collection)
                output.Add($"{entry.Time},{entry.Name},{entry.Price},{entry.PercentDifference}");

            return output;
        }
    }


    public class ParseData
    {
        public static List<StockPriceEntry> ParseDataFromStringArray(string[] data)
        {
            List<StockPriceEntry> collection = new List<StockPriceEntry>();

            for (int row = 1; row < data.Length; row++) //discard the 1st row which has column names.
            {
                var result = StockPriceEntry.TryParseFromCSVEntry(data[row], out StockPriceEntry stockEntry);
                if (result == true)
                    collection.Add(stockEntry);
                else
                    throw new Exception("File contains corrupt data");
            }
            return collection;
        }

    }
}
