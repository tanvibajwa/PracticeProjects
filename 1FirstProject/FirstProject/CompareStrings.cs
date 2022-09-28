//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FirstProject
//{
//    class CompareStrings
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the 1st string");
//            string input1 = Console.ReadLine();

//            Console.WriteLine("Enter the 2nd string");
//            string input2 = Console.ReadLine();

//            compare_strings(input1, input2);
//        }


//        static void compare_strings(string input1, string input2)
//        {
//            int length_String1 = input1.Length;
//            int length_String2 = input2.Length;
//            int counter = 0;
//            int loop_length = 0;
//            input1 = input1.ToLower();
//            input2 = input2.ToLower();
//            string common_part = String.Empty;

//            if (length_String1 > length_String2)
//                loop_length = length_String2;
//            else if (length_String1 < length_String2)
//                loop_length = length_String1;
//            else
//                loop_length = length_String1;

//            for (counter = 0; counter < loop_length; counter++)
//            {
//                if (input1[counter] != input2[counter])
//                    break;

//                common_part = common_part + input1[counter];
//            }

//            if (length_String1 == length_String2 && length_String2 == counter)
//            {
//                Console.WriteLine("Strings are equal");
//                Console.ReadKey();
//            }
//            else
//            {
//                Console.WriteLine("Strings are no longer equal after {0} alphabets, {1}", counter, common_part);
//                Console.ReadKey();
//            }

//        }

//    }
//}
