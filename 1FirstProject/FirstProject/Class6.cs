//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FirstProject
//{
//    class Class6
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the string");
//            string input = Console.ReadLine();

//            segregate(input);
//        }


//        static void segregate(string input)
//        {
//            int alphabets = 0;
//            int numbers = 0;
//            int special_characters = 0;

//            foreach(char word in input)
//            {
//                if (char.IsLetter(word))
//                    alphabets++;

//                else if (char.IsNumber(word))
//                    numbers++;

//                else
//                    special_characters++;
//            }

//            Console.WriteLine("Output: {0},{1},{2}", alphabets, numbers, special_characters);
//            Console.ReadKey();
//        }
//    }
//}
