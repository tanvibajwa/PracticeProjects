//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FirstProject
//{
//    class FlipCase
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the string");
//            string input = Console.ReadLine();
          
//            flip_case(input);
//        }


//        static void flip_case(string input)
//        {
//            string new_string = string.Empty;
//            for (int i = 0; i < input.Length; i++)
//            {
//                if (char.IsUpper(input[i]))
//                    new_string = new_string + char.ToLower(input[i]);
//                else
//                    new_string = new_string + char.ToUpper(input[i]);
//            }

//            Console.WriteLine("Output string is: {0}", new_string);
//            Console.ReadKey();
//        }
//    }
//}
