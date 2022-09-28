//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FirstProject
//{
//    class InsertSubstring
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the string");
//            string input1 = Console.ReadLine();

//            Console.WriteLine("Enter the substring to search");
//            string search = Console.ReadLine();

//            Console.WriteLine("Enter the substring to insert");
//            string insert = Console.ReadLine();

//            find_and_insert(input1, search, insert);
//        }


//        static void find_and_insert(string input, string search_substring, string insert_substring)
//        {
//            string new_string = string.Empty;
//            int index = 0;
//            string first_half = string.Empty;
//            string second_half = string.Empty;

//            for (int i = 0; i < input.Length; i++)
//            {
//                if (input[i] == search_substring[0])
//                {
//                    new_string = new_string + input[i];
//                    for (int j = 1; j < search_substring.Length; j++)
//                    {
//                        i++;
//                        if (input[i] == search_substring[j])
//                        {
//                            index = i;
//                            new_string = new_string + input[i];
//                            if (new_string == search_substring)
//                            {
//                                Console.WriteLine("Output: {0}, {1}", new_string, index - search_substring.Length + 1);
//                                Console.ReadKey();
//                                for (int k = 0; k <= index; k++)
//                                {
//                                    first_half = first_half + input[k];
//                                }
//                                for (int l = index + 1; l < input.Length; l++)
//                                {
//                                    second_half = second_half + input[l];
//                                }
//                                Console.WriteLine("Output: {0}", first_half + " " + insert_substring + second_half);
//                                Console.ReadKey();
//                            }
//                        }
//                        else
//                        {
//                            i--;
//                            index = 0;
//                            new_string = string.Empty;
//                            break;
//                        }

//                    }
//                }
//            }

//        }
//    }
//}
