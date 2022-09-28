//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FirstProject
//{
//    class CompareUntilNewLine
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the main string");
//            string given_string = Console.ReadLine();

//            var input_strings = new List<string>();

//            Console.WriteLine("Enter the string to compare");
//            string input = Console.ReadLine();

//            while (input != string.Empty) 
//            {
//                input_strings.Add(input);
//                input = Console.ReadLine();
//            }

//            compare_until_newLine(given_string, input_strings);
//        }


//        static void compare_until_newLine(string given_string, List<string> input_strings)
//        {
//            int number_of_strings = input_strings.Count;
//            var counter = new List<int>(1);
//            int j = 0;

//            for ( j = 0; j < number_of_strings; j++) //3 times loop
//            {
//                if (given_string.Length == input_strings[j].Length) //length eq 
//                {
//                    for (int i = 0; i < given_string.Length; i++) //
//                    {
//                        if (given_string[i] == input_strings[j][i])
//                        {
//                            counter[j] = counter[j] + 1;
//                        }
//                        else
//                        {
//                            Console.WriteLine(j + "th string is not equal");
//                            Console.ReadKey();
//                        }
//                    }                
//                    continue;
//                }
//                else
//                {
//                    Console.WriteLine("None of the strings are equal");
//                    Console.ReadKey();
//                }
//            }
//            for (int length = 0; length < counter.Count; length++)
//            {
//                if (counter[j] == given_string.Length)
//                {
//                    Console.WriteLine(j + "th string is equal to the main string");
//                    Console.ReadLine();
//                }
//            }
//            return;
//        }
//    }
//}
