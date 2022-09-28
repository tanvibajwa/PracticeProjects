//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FirstProject
//{
//    class AddArrayElements
//    {
//        static void Main(string[]args)
//        {
//            Console.WriteLine("Enter all the numbers to add with the max limit of 10 numbers");

//            int[] inputs_collection = new int[10];
//            int loop_count = 0;

//            var str_input = "blah";
//            while (loop_count < 11)
//            {
//                str_input = Console.ReadLine();

//                if (string.IsNullOrEmpty(str_input))
//                    break;

//                inputs_collection[loop_count] = int.Parse(str_input);
//                loop_count++;
//            }

//            compute(inputs_collection, loop_count, out int sum, out float average);
//            Console.WriteLine($"Sum is {sum} and average is {average}");
//            Console.ReadKey();
//        }

//        static void compute(int[] inputs, int loop_count, out int sum, out float average)
//        {
//            sum = 0;
//            average = 0;

//            foreach (var element in inputs)
//                sum = sum + element;

//            average = sum / loop_count;
//        }
//    }

    
//}
