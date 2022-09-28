//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FirstProject
//{
//    class SubstringExtraction
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the 1st string");
//            string input1 = Console.ReadLine();
//            Console.WriteLine("Enter the start position");
//            string input2 = Console.ReadLine();
//            Console.WriteLine("Enter the length of substring");
//            string input3 = Console.ReadLine();

//            int start_position = int.Parse(input2);
//            int substring_length = int.Parse(input3);

//            substring(input1, start_position, substring_length);
//        }


//        static void substring(string input1, int start_position, int substring_length)
//        {
//            string substring = string.Empty;

//            for (int i = start_position; i < start_position + substring_length; i++)
//            {
//                substring = substring + input1[i];
//            }
//            Console.WriteLine($"Substring is: '{substring}'");
//            Console.ReadKey();
//        }
//    }
//}
