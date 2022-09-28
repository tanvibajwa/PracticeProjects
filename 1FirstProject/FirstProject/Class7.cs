//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FirstProject
//{
//    class Class7
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the string");
//            string input = Console.ReadLine();

//            vowels_consonants(input);
//        }


//        static void vowels_consonants(string input)
//        {
//            int vowels = 0;
//            int consonants = 0;
//            string vowelString = "aeiouAEIOU";

//            foreach (char word in input)
//            {
//                if (char.IsLetter(word))
//                {
//                    if (vowelString.Contains(word))
//                        vowels++;
//                    else
//                        consonants++;
//                }
//            }
//            Console.WriteLine("Output: {0},{1}", vowels, consonants);
//            Console.ReadKey();
//        }
//    }
//}
