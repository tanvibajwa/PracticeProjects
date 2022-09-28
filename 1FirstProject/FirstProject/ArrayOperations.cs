using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class ArrayOperationsMain
    {
        public static void Main(string[]args)
        {
            List<int> inputs_collection = read_array_input_from_user();

            OtherOperations.split_odd_even(inputs_collection, out List<int> odd, out List<int> even);
            var analysis = do_analysis(inputs_collection);
            var analysis_odd = do_analysis(odd);
            var analysis_even = do_analysis(even);

            Console.WriteLine("Raw input analysis:");
            display_results(analysis);
            Console.WriteLine("Odd inputs analysis:");
            display_results(analysis_odd);
            Console.WriteLine("Even inputs analysis:");
            display_results(analysis_even);
        }

        private static List<int> read_array_input_from_user()
        {
            List<int> inputs_collection = new List<int>();

            Console.WriteLine($"Enter all the numbers ");
            while (true)
            {
                var str_input = Console.ReadLine();

                if (string.IsNullOrEmpty(str_input))
                    break;

                inputs_collection.Add(int.Parse(str_input));
            }

            return inputs_collection;
        }
        

        private static ArrayAnalysis do_analysis(List<int> input)
        {
            ArrayAnalysis analysis = new ArrayAnalysis(input);
            analysis.calc_max();
            analysis.calc_min();
            analysis.average_value();
            return analysis;
        }

        public static void display_results(ArrayAnalysis analysis)
        {
            Console.WriteLine($"Maximum number is {analysis.max.number} and indices are {OtherOperations.collection_to_string(analysis.max.indices)}");
            Console.WriteLine($"Minimum number is {analysis.min.number} and indices are {OtherOperations.collection_to_string(analysis.min.indices)}");
            Console.WriteLine($"Average value is {analysis.average}{Environment.NewLine}");
            Console.ReadKey();
        }

    }

    public class ArrayAnalysis
    {
        public List<int> raw_input { get; private set; }
        public OneIsToMany min { get; private set; }
        public OneIsToMany max { get; private set; }
        public float average { get; private set; }

        public ArrayAnalysis(List<int> input)
        {
            raw_input = input;
            min = new OneIsToMany();
            max = new OneIsToMany();
        }


        public void calc_max()
        {
            OneIsToMany ref_max = new OneIsToMany();
            int max_number = 0;

            for (int i = 0; i < raw_input.Count; i++)
            {
                if (raw_input[i] >  max_number)
                {
                    max_number = raw_input[i];
                }
            }

            ref_max.number = max_number;

            for (int i = 0; i < raw_input.Count; i++)
            {
                if (raw_input[i] == max_number)
                {
                    ref_max.indices.Add(i);
                }
            }

            max = ref_max;
        }

        public void calc_min()
        {
            OneIsToMany ref_min = new OneIsToMany();
            
            int min_number = raw_input[0];

            for (int i = 0; i < raw_input.Count; i++)
            {
                if (raw_input[i] < min_number)
                {
                    min_number = raw_input[i];
                }
            }

            ref_min.number = min_number;

            for (int i = 0; i < raw_input.Count; i++)
            {
                if (raw_input[i] == min_number)
                {
                    ref_min.indices.Add(i);
                }
            }

            min = ref_min;
        }

        public void average_value()
        {
            float sum = 0;
            
            foreach (var value in raw_input)
            {
                 sum = sum + value;
            }

            float average_val = sum / raw_input.Count;
            average = average_val;
        }

        
    }

    class OtherOperations
    {
        public static void split_odd_even(List<int> inputs_collection, out List<int> odd, out List<int> even)
        {
            odd = null;
            even = null;

            odd = new List<int>();
            even = new List<int>();

            for ( int i = 0; i < inputs_collection.Count; i++)
            {
                if (inputs_collection[i] % 2 == 0)
                    even.Add(inputs_collection[i]);
                else
                    odd.Add(inputs_collection[i]);
            }
        }

        public static string collection_to_string(IEnumerable<int> collection)
        {
            string output = "[";
            foreach (var element in collection)
            {
                output = output + element + ", ";
            }
            output = output.Substring(0, output.Length - 2);
            output = output + "]";
            return output;
        }

    }
}
