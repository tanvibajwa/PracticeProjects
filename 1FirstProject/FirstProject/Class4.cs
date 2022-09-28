//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FirstProject
//{
//    class Spacer
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the string");
//            string input = Console.ReadLine();

//            Console.WriteLine("Output string is: {0}", space_out(input));
//            Console.WriteLine("Output string is: {0}", space_out_2(input));
//            Console.ReadKey();
//        }

//        static string space_out(string input)
//        {
//            string new_string = string.Empty;
//            for (int i = 0; i < input.Length; i++)
//            {
//                new_string = new_string + input[i] + " ";
//            }
//            return new_string;       
//        }

//        static string space_out_2(string input)
//        {
//            char[] new_char_array = new char[input.Length * 2];
//            string random = string.Empty;
//            for (int i = 0; i < input.Length; i++)
//            {
//                new_char_array[i*2] = input[i];
//                new_char_array[i * 2 + 1] = ' ';
//            }

//            string output = new string(new_char_array);
//            return output;
//        }
//    }
//}
