//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FirstProject
//{
//    class StringDeconcatenate
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter the text: ");
//            string text = Console.ReadLine();

//            var words = split(text);

//            Console.WriteLine("Numbers of words: {0}", words.Count());
//            foreach (string word in words)
//            {
//                if (word != null)
//                {
//                    Console.WriteLine("'{0}'", word);
//                    Console.ReadKey();
//                }
//            }
//        }

//        static IEnumerable<string> split(string text)
//        {
//            string first_word = string.Empty;
//            List<string> words = new List<string>(10);

//            for (int i = 0; i < text.Length; i++)
//            {
//                if (text[i] != ' ')
//                {
//                    char first_letter = text[i];
//                    first_word = first_word + first_letter;
//                }
//                else
//                {
//                    if (first_word != string.Empty)
//                        words.Add(first_word);                   
//                    first_word = string.Empty;
//                }
//            }
//            words.Add(first_word);
//            return words;
//        }
//    }
//}
