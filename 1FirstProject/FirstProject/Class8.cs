//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FirstProject
//{
//    class Class8
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the string");
//            string input = Console.ReadLine();

//            most_frequent_char(input);
//        }


//        static void most_frequent_char(string input)
//        {
//            char[] array_of_characters = new char[26] {'a','b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
//            int[] array_of_frequency = new int[26];
//            Array.Clear(array_of_frequency, 0, array_of_frequency.Length);
//            string input_lower = input.ToLower();
//            for (int j = 0; j < input.Length; j++)  
//            {
//                for (int i = 0; i < 26; i++)
//                {
//                    if (input_lower[j] == array_of_characters[i])
//                    {
//                        array_of_frequency[i]++;
//                        break;
//                    }                    
//                }
//            }

//            for (int i = 0; i < 26; i++)
//            {
//                if (array_of_frequency[i] == array_of_frequency.Max())
//                {
//                    Console.WriteLine("Max occuring alphabet is {0} with {1} occurences", array_of_characters[i], array_of_frequency.Max() );
//                    Console.ReadKey();
//                }
                    
//            }
            
//        }
//    }
//}
