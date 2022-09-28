using System;
using System.Collections.Generic;
using System.IO;

namespace ReadFile_ManipulateData_CreateFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length < 2)
                {
                    throw new Exception("Send both file names");
                }


                // deserialize it
                string[] raw_file_data = null;

                // read raw data
                if (File.Exists(args[0]))
                {
                    raw_file_data = File.ReadAllLines(args[0]);
                }
                else
                {
                    Console.WriteLine("Specified file does not exist. Using stock-data.csv instead.");
                    raw_file_data = File.ReadAllLines(@"C:\Users\tsingh\Downloads\stock-data.csv");
                }


                var collection = ParseData.ParseDataFromStringArray(raw_file_data);


                // perform data manipulation
                DataManipulation.SortEntriesByAscendingPrice(collection);
                DataManipulation.CalculateAndAddPercentageDifferenceAttribute(collection);


                // serialize result
                var string_data = StockPriceEntry.CollectionToStringCSV(collection);
                File.WriteAllLines(args[1], string_data);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return;
            }
        }
    }
}
