//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FirstProject
//{
//    class CharacterRecognition
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the character");
//            string input = Console.ReadLine();
//            if (input.Length > 1)
//            {
//                Console.WriteLine("Input must be exactly 1 character long");
//                Console.ReadKey();
//                return;
//            }
//            char character = char.Parse(input);

//            character_recognition(character);
//        }


//        static void character_recognition(char character)
//        {
//            if (char.IsLetterOrDigit(character))
//            {
//                if (char.IsLetter(character))
//                {
//                    if (char.IsUpper(character))
//                    {
//                        Console.WriteLine("The character is uppercase");
//                        Console.ReadKey();
//                    }
//                    else
//                    {
//                        Console.WriteLine("The character is lowercase");
//                        Console.ReadKey();
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("The character is a number");
//                    Console.ReadKey();
//                }
//            }
//            else
//            {
//                Console.WriteLine("The character is a special character");
//                Console.ReadKey();
//            }
//        }
//    }
//}
