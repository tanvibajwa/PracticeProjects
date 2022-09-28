using System;

namespace interview
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int[] array_of_multiples(int number, int length)
        {
            int[] array_of_multiples = new int[length];
            for (int i=0; i<= length; i++)
            {
                array_of_multiples[i] = number * (i + 1);
            }
            return array_of_multiples;
        }

        public string reverse_case(string name)
        {
            var reverse_name = string.Empty;
           

            for (int i = 0; i < name.Length; i++)
            {
                if (Char.IsUpper(name[i]))
                {
                    reverse_name += char.ToLower(name[i]);
              }
                else
                    reverse_name += char.ToUpper(name[i]);
            }

            return reverse_name;
        }

        public string find_the_bomb(string statement)
        {
            string relax = "There is no bomb";
            string duck = "Duck!!";
            for (int i = 0; i < statement.Length; i++)
            {
                if (statement[i] == 'b' || statement[i]  == 'B')
                {
                    if (statement[i+1] == 'o' || statement[i+1] == 'O')
                    {
                        if (statement[i + 2] == 'm' || statement[i + 2] == 'M')
                        {
                            if (statement[i + 3] == 'b' || statement[i + 3] == 'B')
                            {
                                return duck;
                            }
                        }
                    }
                }
            }

            return relax;
        }

        public string[] parseToString(object[] arr)
        {
            string[] result = new string[arr.Length];
            var type = arr[0].GetType().FullName;
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].GetType() == typeof(int))
                {
                    result[i] += arr[i].ToString();
                }
                else
                {
            //        result[i] = arr[i];
                }
            }
            return result;
        }

        public int[] largestNumbersInGroups(int[][] groupOfArrays)
        {
            int[] largestNumbers = new int[groupOfArrays.Length];
            for (int i = 0; i< groupOfArrays.Length; i++)
            {
                largestNumbers[i]  = largestNumberInAnArray(groupOfArrays[i]);
               
            }
            return largestNumbers;
        }

        public int largestNumberInAnArray(int[] arr)
        {
            int largest_number = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[i] > arr[j])
                        largest_number = arr[i];
                    else
                        largest_number = arr[j];
                }
            }
            return largest_number;
        }

        public int stepsToReachOne(int number)
        {
            var result = number;
            var counter = 0; 

            while(result != 1)
            {
                if (number % 2 == 0)
                {
                    result = number / 2;
                }
                else
                {
                    result = number * 3 + 1;
                }
                counter++;
            }
            
            return result;
        }

    }
}
