//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FirstProject
//{
//    class CopyString
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the 1st string");
//            string input1 = Console.ReadLine();

//            Console.WriteLine("Enter the 2nd string");
//            string input2 = Console.ReadLine();

//            copy_string(input1, input2);
//        }


//        static void copy_string(string input1, string input2)
//        {
//            char[] temporary_storage = new char[input1.Length];            
         
//            input1.CopyTo(0, temporary_storage, 0, input1.Length);  
//            input2 = new string(temporary_storage);
            
//            Console.WriteLine("Output is {0}", input2);
//            Console.ReadKey();
//        }
//    }
//}

//// String is reference type so assignment does not work. Assigning would simply mean that both string1 and string2 now have the reference to the same value