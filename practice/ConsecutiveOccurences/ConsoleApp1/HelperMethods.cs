using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    public class HelperMethods
    {
        public int MaxConsecutiveOccurences(int[] numbers)
        {
            int prev_occurence = 1;
            int new_occurence = 1;
            int max_occuring_number = 0;

            if (numbers != null && numbers.Length > 0)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        new_occurence++;
                    }
                    if (new_occurence > prev_occurence)
                    {
                        max_occuring_number = numbers[i];
                        prev_occurence = new_occurence;
                    }
                    if (numbers[i] != numbers[i + 1] && new_occurence > 1)
                    {
                        new_occurence = 1;
                    }
                }

                return max_occuring_number;
            }

            else
                return 0;
        }

        public List<int> ListOfAllMaximumConsecutiveOccuringNumbers(int[] numbers)
        {
            int prev_occurence = 1;
            int new_occurence = 1;
            int max_occuring_number = 0;
            int any_consecutive_occurences = 0;
            List<int> max_occuring_numbers = new List<int>();

            if (numbers != null && numbers.Length > 0)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        new_occurence++;
                        any_consecutive_occurences++;
                    }

                    if (new_occurence >= prev_occurence && new_occurence != 1)
                    {
                        max_occuring_number = numbers[i];
                        prev_occurence = new_occurence;
                    }

                    if (numbers[i] != numbers[i + 1] && new_occurence == prev_occurence && new_occurence > 1)
                    {
                        max_occuring_numbers.Add(numbers[i]);
                        new_occurence = 1;
                    }

                    if (i == numbers.Length - 2 && new_occurence >= prev_occurence && new_occurence != 1)
                    {
                        max_occuring_numbers.Add(numbers[i]);
                        new_occurence = 1;
                    }

                }
                
                if (any_consecutive_occurences == 0)
                {
                    max_occuring_numbers.Add(numbers[0]);
                    for (int i = 0; i < numbers.Length-1; i++)
                    {
                        for (int j = i+1; j < numbers.Length; j++)
                        {
                            if (numbers[i] != numbers[j])
                            {
                                if (!max_occuring_numbers.Contains(numbers[j]))
                                    max_occuring_numbers.Add(numbers[j]);
                            }
                        }
                    }
                }
                return max_occuring_numbers;
            }

            else
                return null;
        }

        public IEnumerable<string> ReadFileData(string pathOfFile)
        {
            var fileData = File.ReadLines(pathOfFile);
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

        public string convertNumbersToString(List<List<int>> maximumOccuringNumbersInAllRows)
        {
            StringBuilder result = new StringBuilder();

            foreach (List<int> maxOccuringNumbers in maximumOccuringNumbersInAllRows)
            {
                foreach (int number in maxOccuringNumbers)
                {
                    result.Append(number);
                    result.Append(",");
                }

                result.Remove(result.Length - 1, 1);
                result.Append(Environment.NewLine);
            }
            return result.ToString();
        }

        public void writeDataToFile(string file_path, string text)
        {
            File.WriteAllText(file_path, text);
        }

    }
}
