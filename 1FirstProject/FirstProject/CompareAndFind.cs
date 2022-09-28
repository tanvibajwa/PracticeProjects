//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FirstProject
//{
//    class CompareAndFind
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the string");
//            string input1 = Console.ReadLine();

//            Console.WriteLine("Enter the substring");
//            string input2 = Console.ReadLine();

//            find_substring(input1, input2);
//        }


//        static void find_substring(string input, string substring)
//        {
//            string new_string = string.Empty;
//            int index = 0;
//            int number_of_occurences = 0;

//            for (int i = 0; i < input.Length; i++)
//            {
//                if (input[i] == substring[0])
//                {
//                    new_string = new_string + input[i];
//                    for (int j = 1; j < substring.Length; j++)
//                    {
//                        i++;
//                        if (input[i] == substring[j])
//                        {
//                            index = i;
//                            new_string = new_string + input[i];
//                            if (new_string == substring)
//                            {
//                                number_of_occurences++;
//                                Console.WriteLine("Output: {0}, {1}", new_string, index - substring.Length + 1);
//                                Console.ReadKey();
//                                new_string = string.Empty;
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

//            Console.WriteLine("Total number of occurences: {0}", number_of_occurences);
//            Console.ReadKey();
//            Console.WriteLine("Do you want to enter more strings? ");
//            string answer = Console.ReadLine();
            
//        }
//    }
//}
