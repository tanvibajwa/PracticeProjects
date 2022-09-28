using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var helperMethods = new HelperMethods();
            var filedata = helperMethods.ReadFileData(@"C:\Users\tsingh\Documents\maxOccurence.txt");
            var numberData = helperMethods.ConvertTextToNumbersData(filedata);

            List<List<int>> maximumOccuringNumbersInAllRows = new List<List<int>>();

            foreach (int[] row in numberData)
            {
                var maxOccuringNumbers = helperMethods.ListOfAllMaximumConsecutiveOccuringNumbers(row);
                maximumOccuringNumbersInAllRows.Add(maxOccuringNumbers);
            }
            string text = helperMethods.convertNumbersToString(maximumOccuringNumbersInAllRows);
            helperMethods.writeDataToFile(@"C:\Users\tsingh\Documents\maxOccurence-result.txt", text);
        }

    }
}
