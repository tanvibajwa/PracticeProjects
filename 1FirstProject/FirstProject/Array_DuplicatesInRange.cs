using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class OneIsToMany
    {
        public int number { get; set; }
        public List<int> indices { get; set; }

        public OneIsToMany()
        {
            indices = new List<int>();
        }

        public override string ToString()
        {
            string string_output = number + " : [";

            for (int i = 0; i < indices.Count; i++)
            {
                string_output = string_output + indices[i];

                if (i < indices.Count - 1)
                {
                    string_output = string_output + ", ";
                }
            }

            string_output = string_output + "]";

            return string_output;
        }
    }

    //    class Array_DuplicatesInRange
    //    {

    //        static void Main(string[] args)
    //        {

    //            List<int> inputs_collection = read_array_input_from_user();

    //            read_range_from_user(inputs_collection, out int starting_index, out int ending_index);

    //            var scooped_array = scoop_out_a_range(inputs_collection, starting_index, ending_index);

    //            var duplicate_values = find_duplicates(scooped_array);

    //            foreach (var value in duplicate_values)
    //            {
    //                Console.WriteLine(value);
    //            }
    //            Console.ReadKey();
    //        }

    //        private static List<int> read_array_input_from_user()
    //        {
    //            List<int> inputs_collection = new List<int>();

    //            Console.WriteLine($"Enter all the numbers ");
    //            while (true)
    //            {
    //                var str_input = Console.ReadLine();

    //                if (string.IsNullOrEmpty(str_input))
    //                    break;

    //                inputs_collection.Add(int.Parse(str_input));
    //            }

    //            return inputs_collection;
    //        }

    //        private static void read_range_from_user(List<int> inputs_collection, out int starting_index, out int ending_index)
    //        {
    //            Console.WriteLine($"Enter the starting index for the range. Should be between 0 and {inputs_collection.Count - 1}");
    //            string str_starting_index = Console.ReadLine();
    //            starting_index = int.Parse(str_starting_index);
    //            Console.WriteLine($"Enter the ending index for the range. Should be between {starting_index + 1} and { inputs_collection.Count - 1}");
    //            string str_ending_index = Console.ReadLine();
    //            ending_index = int.Parse(str_ending_index);
    //        }

    //        static int[] scoop_out_a_range(List<int> inputs, int starting_index, int ending_index)
    //        {
    //            int scooped_array_length = ending_index - starting_index + 1;
    //            int[] scooped_array = new int[scooped_array_length];
    //            int j = 0;

    //            for (int i = starting_index; i <= ending_index; i++)
    //            {
    //                scooped_array[j] = inputs[i];
    //                j++;
    //            }

    //            return scooped_array;
    //        }

    //        static List<OneIsToMany> find_duplicates(int[] scooped_array)
    //        {
    //            List<OneIsToMany> duplicate_values = new List<OneIsToMany>();
    //            int counter = 0;         
    //            List<int> discarded_indices = new List<int>();

    //            for (int i = 0; i < scooped_array.Length; i++)
    //            {
    //                if (discarded_indices.Contains(i))
    //                    continue;

    //                OneIsToMany duplicate_entry = new OneIsToMany();
    //                duplicate_entry.number = scooped_array[i];
    //                duplicate_entry.indices.Add(i);

    //                for (int j = i + 1; j < scooped_array.Length; j++)
    //                {
    //                    if (scooped_array[i] == scooped_array[j])
    //                    {
    //                        duplicate_entry.indices.Add(j);
    //                        discarded_indices.Add(j);
    //                        counter++;
    //                    }

    //                }
    //                if (counter > 0)
    //                {
    //                    duplicate_values.Add(duplicate_entry);
    //                    counter = 0;
    //                }
    //            }

    //            return duplicate_values;
    //        }
    //    }
}
