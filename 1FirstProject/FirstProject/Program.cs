//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace FirstProject.Credentials
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //UsernameProgram.Run(args);

//            // convert this program so that it can scale with any number of usernames
//            Console.WriteLine("Enter the username: ");
//            string username = Console.ReadLine();
            
//            string[] array_of_names = new string[] { "Tanvi", "Sita", "Gita", "Ram", "Sham" };
//            bool result = false;
//            foreach(var name in array_of_names)
//            //for (int i = 0; i < array_of_names.Length; i++)
//            {
//                //bool result = compare(username, array_of_names[i], true);
//                result = compare(username, name, true);
//                if (result == true)
//                {
//                    Console.WriteLine(username + " is a valid username");
//                    Console.ReadKey();
//                    break;
//                }     
//            }

//            if (result == false)
//            {
//                Console.WriteLine(username + " is an invalid username");
//                Console.ReadKey();
//            }

//        }

//        static bool compare(string username, string name, bool caseInsensitive)
//        {            
//            int result1 = string.Compare(username, name, caseInsensitive);

//            IEnumerable<char> enumerated_object = username.Reverse();
//            char[] char_array = enumerated_object.ToArray();

//            string reversedName = new string(char_array);

//            int result2 = string.Compare(reversedName, name, caseInsensitive);

//            if (result1 == 0 || result2 == 0)
//                return true;
//            else
//                return false;
//        }
//    }
//}
