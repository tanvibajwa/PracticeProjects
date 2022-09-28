//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FirstProject
//{
//    class Reverse
//    {

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the string");
//            string input = Console.ReadLine();

//            Console.WriteLine("Output string is: {0}", space_out_2(input));
//            Console.ReadKey();
//        }


//        static string space_out_2(string input)
//        {
//            char[] new_char_array = new char[input.Length];  
//            int j = input.Length-1;   
//            for (int i = 0; i < input.Length; i++)
//            {
//                new_char_array[j] = input[i];   
//                j--;
//            }

//            string output = new string(new_char_array);
//            return output;
//        }
//    }
//}
