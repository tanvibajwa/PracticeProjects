//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FirstProject
//{
//    class mathematics
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("For which number do you want the table?");
//            string table_number_str = Console.ReadLine();
//            var table_number = float.Parse(table_number_str);

//            Console.WriteLine("Until which digit?");
//            string last_number_str = Console.ReadLine();
//            var last_number = float.Parse(last_number_str);

//            var computed_table = generate_table(table_number, last_number);

//            for (int i = 0; i < computed_table.Count(); i++)
//                Console.WriteLine(table_number + "*" + i + "=" + computed_table.ElementAt(i));

//            Console.ReadKey();
//        }

//        static IEnumerable<float> generate_table(float table_number, float last_number)
//        {
//            float[] array_of_output = new float[(int)Math.Ceiling(last_number + 1)];

//            for (int i = 0; i < last_number + 1; i++)
//                array_of_output[i] = table_number * i;

//            return array_of_output;
//        }
//    }
//}
