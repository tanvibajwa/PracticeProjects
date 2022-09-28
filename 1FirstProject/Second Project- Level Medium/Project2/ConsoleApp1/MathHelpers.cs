using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class MathHelpers
    {
        public static List<double> largest_numbers_array(double[][] collection_of_arrays)
        {
            var largestNumbersCollection = new List<double>();

            if (collection_of_arrays != null)
                for (int i = 0; i < collection_of_arrays.Length; i++)
                {
                    double largest_number_single_array = largest_number(collection_of_arrays[i]);
                    largestNumbersCollection.Add(largest_number_single_array);
                }

            return largestNumbersCollection;
        }

        public static double largest_number(double[] single_array)
        {
            double largest_number = Double.MinValue;

            for (int i = 0; i < single_array.Length; i++)
            {
                if (single_array[i] > largest_number)
                    largest_number = single_array[i];
            }

            return largest_number;
        }

        public static bool pin_validation(string input)
        {
            bool output = true;

            if (input.Length != 4 && input.Length != 6)
                output = false;

            else
            {
                foreach (char element in input)
                {
                    if (char.IsDigit(element) == false)
                    {
                        output = false;
                        break;
                    }
                }
            }

            return output;
        }

        public static int[] array_of_multiples(int number, int length)
        {
            int[] array_of_multiples = new int[length];
            for (int i = 1; i <= length; i++)
            {
                var result = number * i;
                array_of_multiples[i - 1] = result;
            }
            return array_of_multiples;
        }

        public static long factorial(int input)
        {
            var result = 1;

            if (input > 0)
                for (int i = input; i >= 1; i--)
                {
                    result = result * i;
                }
            else if (input < 0)
                result = 0;

            return result;
        }

        public static double area_of_square(double side)
        {
            double area = side * side;
            return area;
        }

        public static double area_of_circle(double radius)
        {
            double area = 3.14 * radius * radius;
            return area;
        }

        public static double side_of_right_angled_triangle(double hypotenuse)
        {
            double side = 0;
            side = Math.Sqrt(hypotenuse * hypotenuse / 2);
            return side;
        }

        public static double square_area_difference(double radius)
        {
            double difference = 0;
            double bigger_square_area = 0;
            double smaller_square_area = 0;
            bigger_square_area = area_of_square(radius * 2);
            var small_square_side = side_of_right_angled_triangle(radius * 2);
            smaller_square_area = area_of_square(small_square_side);
            difference = bigger_square_area - smaller_square_area;
            return difference;
        }

        public static int count_ones(int input)
        {
            int number_of_ones = 0;
            var binary_number = convert_to_binary(input);
            foreach (char element in binary_number)
            {
                if (element == '1')
                    number_of_ones++;
            }
            return number_of_ones;
        }

        public static string convert_to_binary(int input)
        {
            // var binary_number = input & 0000; 
            var binary_number = Convert.ToString(input, 2);
            return binary_number;
        }

        public static bool is_prime(int input)
        {
            bool output = true;
            int[] divisors = new int[] { 2, 3, 5, 7 };
            if (input == 2 || input == 3 || input == 5 || input == 7)
                output = true;
            else if (input == 1)
                output = false;
            else
            {
                foreach (int divisor in divisors)
                {
                    if (input % divisor == 0)
                    {
                        output = false;
                        break;
                    }
                    else
                        output = true;
                }
            }

            return output;
        }


        public static bool is_palindrome(int input)
        {
            bool output;

            int[] number_array = split_number_into_individual_digits(input);

            output = true;
            for (int i = 0; i <= number_array.Length / 2 && output == true; i++)
            {
                if (number_array[0 + i] != number_array[number_array.Length - 1 - i])
                    output = false;
            }

            return output;
        }

        public static double[] count_sum(double[] input)
        {
            double[] output = new double[2];
            int count = 0;
            double sum = 0;

            if (input.Length > 0)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] <= 0)
                        sum += input[i];
                    else
                        count++;
                }
                output[0] = count;
                output[1] = sum;
            }
            else
                output = new double[0];

            return output;
        }

        public static int sum_of_two_lowest_positive_numbers(int[] numbers)
        {
            int lowest_number = int.MaxValue;
            int second_lowest_number = int.MaxValue;
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    if (numbers[i] < lowest_number)
                    {
                        lowest_number = numbers[i];
                        index = i;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    if ((numbers[i] < second_lowest_number) && (i != index))
                        second_lowest_number = numbers[i];
                }
            }

            int sum = lowest_number + second_lowest_number;
            return sum;
        }

        public static int sort_descending(int input)
        {
            string output_str = string.Empty;
            int output;

            int[] number_array = split_number_into_individual_digits(input);


            for (int i = 0; i < number_array.Length; i++)
            {
                for (int j = i + 1; j < number_array.Length; j++)
                {
                    if (number_array[j] > number_array[i])
                    {
                        int temp = number_array[j];
                        number_array[j] = number_array[i];
                        number_array[i] = temp;
                    }
                }
            }

            for (int k = 0; k < number_array.Length; k++)
            {
                output_str += number_array[k];
            }

            output = int.Parse(output_str);

            return output;
        }

        public static double PI_to_n_decimal_places(int n)
        {
            var pi = Math.PI;
            string pi_string = pi.ToString();

            string truncated_pi = pi_string.Remove(n + 3);

            if (truncated_pi[truncated_pi.Length - 1] < 53)
            {
                truncated_pi = truncated_pi.Remove(n + 2);
            }

            else
            {
                truncated_pi = truncated_pi.Remove(n + 2);
                char last_value = truncated_pi[truncated_pi.Length - 1]; //55
                if (last_value == 57)
                {
                    char last_incremented_value = (char)0;
                    char second_last_value = truncated_pi[truncated_pi.Length - 2];
                    var second_last_number = (int)second_last_value + 1;
                    char second_last_incremented_value = (char)second_last_number;
                    truncated_pi = truncated_pi.Remove(n);
                    truncated_pi = truncated_pi + second_last_incremented_value + last_incremented_value;
                }
                else
                {
                    var last_number = (int)last_value + 1; //
                    char last_incremented_value = (char)last_number;
                    truncated_pi = truncated_pi.Remove(n + 1);
                    truncated_pi = truncated_pi + last_incremented_value;
                }


            }

            double output = double.Parse(truncated_pi);
            return output;
        }

        public static bool is_perfect_number(int input)
        {
            var factors = calculate_factors(input);

            int sum = 0;
            foreach (int element in factors)
            {
                sum += element;
            }

            return sum == input ? true : false;
        }

        public static List<int> calculate_factors(int input)
        {
            var factors = new List<int>();

            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                    factors.Add(i);
            }

            return factors;
        }

        public static List<int> factors_that_multiply_to_form_the_number(int input)
        {
            var factors = calculate_factors(input);
            int product = 1;
            List<int> limited_factors = new List<int> { };

            for (int i = 0; i < factors.Count; i++)
            {
                product = product * factors[i];
                limited_factors.Add(factors[i]);

                if (product == input)
                {
                    break;
                }
            }

            return limited_factors;
        }

        public static bool is_factorial_of_an_integer(int input)
        {
            bool result = true;

            var factors = factors_that_multiply_to_form_the_number(input);

            for (int j = factors.Count - 1; j > 0; j--)
            {
                if (factors[j] != factors[j - 1] + 1)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        public static int major_sum(int[] input)
        {
            int positives_sum = 0;
            int negatives_sum = 0;
            int count_of_zeroes = 0;
            int max = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0)
                    positives_sum += input[i];
                else if (input[i] < 0)
                    negatives_sum += input[i];
                else
                    count_of_zeroes++;
            }

            negatives_sum = negatives_sum * -1;

            //if (positives_sum > negatives_sum && positives_sum > count_of_zeroes)
            //    max = positives_sum;
            //else if (negatives_sum > positives_sum && negatives_sum > count_of_zeroes)
            //    max = negatives_sum * -1;
            //else
            //    max = count_of_zeroes;
            if (positives_sum > negatives_sum) //1,2,5
            {
                if (positives_sum > count_of_zeroes)
                    max = positives_sum;
                else
                    max = count_of_zeroes;
            }
            else
            {
                if (negatives_sum > count_of_zeroes)
                    max = negatives_sum * -1;
                else
                    max = count_of_zeroes;
            }

            return max;
        }

        public static int days_to_find_treasure(int coordinate1, int coordinate2)
        {
            if (coordinate1 < 0)
                coordinate1 = coordinate1 * -1;
            if (coordinate2 < 0)
                coordinate2 = coordinate2 * -1;
            int sum = coordinate1 + coordinate2;

            int days_of_rest = sum / 5;

            if (sum % 5 == 0)
                sum += days_of_rest - 1;
            else
                sum += days_of_rest;
            return sum;
        }

        public static string oddish_or_evenish(int input)
        {
            int[] number_array = split_number_into_individual_digits(input);
            int sum = add_signed_numbers_in_array(number_array);
            bool is_sum_even = is_even(sum);

            return is_sum_even == true ? "Evenish" : "Oddish";
        }

        public static int[] split_number_into_individual_digits(int input)
        {
            int divisor = 10;
            int divident = input;
            int[] number_array = new int[input.ToString().Length];
            int index_of_array = 0;

            if (input > 0)
            {
                do
                {
                    number_array[index_of_array] = divident % divisor;
                    divident = divident / divisor;
                    index_of_array++;
                }
                while (divident > 9);
                number_array[index_of_array] = divident;
            }

            return number_array;
        }

        public static int add_signed_numbers_in_array(int[] number_array)
        {
            int sum = 0;
            foreach (int number in number_array)
            {
                sum += number;
            }
            return sum;
        }

        public static bool is_even(int number)
        {
            bool result = false;

            if (number % 2 == 0)
                result = true;

            return result;
        }


        public static int power_ranger(int power, int starting_number, int ending_number)
        {
            int count = 0;

            for (int i = 1; i <= ending_number; i++)
            {
                double product = Math.Pow(i, power);

                if (product < starting_number)
                    continue;

                if (product > ending_number)
                    break;

                for (int j = starting_number; j <= ending_number; j++)
                {
                    if (product == j)
                    {
                        count++;
                        continue;
                    }
                }
            }

            return count;
        }

        public static int next_prime(int input)
        {
            int next_prime = 0;
            int last_number_to_check = int.MaxValue;
            bool is_the_input_prime = is_prime(input);

            if (is_the_input_prime == true)
                return input;
            else
                for (int i = input + 1; i <= last_number_to_check; i++)
                {
                    is_the_input_prime = is_prime(i);
                    if (is_the_input_prime == true)
                    {
                       next_prime = i;
                       break;
                    }
                }
            return next_prime;
        }
    }

}
