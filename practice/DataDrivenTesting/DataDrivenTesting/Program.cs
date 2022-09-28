using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;


namespace DataDrivenTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GetIntDataSet();
        }

        public int CalculateChecksum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            
            return ~sum;
        }

        public IEnumerable<string> ReadFileData(string pathOfFile)
        {
            var fileData = File.ReadAllLines(pathOfFile);
            return fileData;
        }

        public List<int[]> ConvertTextToNumbersData(IEnumerable<string> fileData)
        {
            List<int[]> seriesOfNumbers = new List<int[]>();
            foreach (string line in fileData)
            {
                var stringArrayOfNumbersInALine = line.Split(',');
                int[] numbersInALine = new int[stringArrayOfNumbersInALine.Length];
                for (int i = 0; i < stringArrayOfNumbersInALine.Length; i++)
                {
                    numbersInALine[i] = int.Parse(stringArrayOfNumbersInALine[i]);
                }
                seriesOfNumbers.Add(numbersInALine);
            }
            return seriesOfNumbers;
        }

        public static List<int[]> GetIntDataSet()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            ExcelPackage package = new ExcelPackage(@"../../../../DataDrivenTesting/checksum.xlsx");
            ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];

            List<int[]> collectionOfNumbers = new List<int[]>();

            // var smt = new object[2] {1,2};


            string[] columns = new string[] { "A", "B", "C", "D", "E", "F" };
            //for (int i = 1; i < 3; i++)
            //{
            //    for (int j = 0; j < columns.Length; j++)
            //    {
            //        string row_address = i.ToString();
            //        string column_address = columns[j];
            //        string cell_address = column_address + row_address;
            //        var cell_value = worksheet.Cells[cell_address].Value;
            //    }
            //}
            var row_count = worksheet.Dimension.End.Row;
            for (int i = 1; i <= row_count; i++)
            {
                for (int j = 1; j < columns.Length; j++)
                {
                    var cell_value = worksheet.Cells[i, j].Value.ToString().Trim();
                }

            }
            return collectionOfNumbers;
        }
    }
}
