using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.XPath;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    //  https://edabit.com/challenges/csharp    

    public class StringHelpers
    {
        public static string maskify(string input, int number_of_trailing_chars_to_display = 4, char mask_char = '#')
        {
            var result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (input.Length - i > number_of_trailing_chars_to_display)
                    result += "#";
                else
                    result += input[i];
            }

            return result;
        }

        public static string get_middle_characters(string input)
        {
            string output = string.Empty;

            int length_of_string = input.Length;
            int middle_char_index = length_of_string / 2;

            if (length_of_string % 2 > 0)
            {
                char letter = input[middle_char_index];
                output = output + letter;
            }
            else
            {
                char letter1 = input[middle_char_index - 1];
                char letter2 = input[middle_char_index];
                output = output + letter1 + letter2;
            }

            return output;
        }

        public static string reverse_case(string input)
        {
            if (input == null)
                input = string.Empty;

            string reverse_case = string.Empty;

            foreach (char element in input)
            {
                char single_char;

                //single_char = char.IsLower(element) ? char.ToUpper(element) : char.ToLower(element);

                if (Char.IsLower(element))
                {
                    single_char = Char.ToUpper(element);
                }
                else
                {
                    single_char = Char.ToLower(element);
                }

                reverse_case = reverse_case + single_char;
            }
            return reverse_case;
        }

        public static int char_counterpart_char_code(char input)
        {
            char reversed_case = reverse_case(input);
            var result = (int)reversed_case;

            return result;
        }

        public static char reverse_case(char input)
        {
            char result;

            if (char.IsUpper(input))
                result = char.ToLower(input);
            else
                result = char.ToUpper(input);

            return result;
        }
        
        //FIlter out strins from an array of strins and numbers.   
        public static int[] filter_string(object[] input)
        {
            List<int> output_list = new List<int>();

            foreach (object element in input)
            {
                if (element is int number)
                    output_list.Add(number);
            }
            int[] output = output_list.ToArray();
            return output;
        }

        public static string highest_and_lowest(string input)
        {
            string output = string.Empty;
           
            var max = double.MinValue;
            var min = double.MaxValue;
            
            string[] numbers_without_spaces = input.Split(' ');
            int[] array_of_integers = new int[numbers_without_spaces.Length];

            for (int i = 0; i < numbers_without_spaces.Length; i++)
            {
                int.TryParse(numbers_without_spaces[i], out int result);
                array_of_integers[i] = result;
            }

            for (int i = 0; i < array_of_integers.Length; i++)
            {
                if (array_of_integers[i] < min)
                    min = array_of_integers[i];
                if (array_of_integers[i] > max)
                    max = array_of_integers[i];
            }

            output += max + " " + min;
            return output;
        }

        //An isogram is a word that has no duplicate letters.   
        public static bool is_isogram(string input)
        {
            bool result = true;
            string input_upper = input.ToUpper();

            for (int i = 0; i < input_upper.Length; i++)
            {
                for (int j = i + 1; j < input_upper.Length; j++)
                {
                    if (input_upper[i] == input_upper[j])
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }

        public static bool is_strange(string input1, string input2)
        {
            bool result = false;
            string input1_lower = input1.ToLower();
            string input2_lower = input2.ToLower();

            if (input1_lower.Length == 0 && input2_lower.Length == 0)
                result = true;
            else if ((input1_lower.Length == 0 && input2_lower.Length > 0) || (input1_lower.Length > 0 && input2_lower.Length == 0))
                result = false;
            else if ((input1_lower[0] == input2_lower[input2_lower.Length - 1]) && (input1_lower[input1_lower.Length - 1] == input2_lower[0]))
                result = true;

            return result;
        }


        //Create a function that takes a number as an argument and returns a string formatted to separate thousands.
        //example: 20,000
        public static string comma_separated_thousands(int input)
        {
            string output = string.Empty;
            string input_str = input.ToString();
            int counter = 0;

            for (int j = input_str.Length - 1; j >= 0; j--)
            {
                output = output + input_str[j];
                counter++;
                if (counter == 3 && j > 0)
                {
                    output = output + ',';
                    counter = 0;
                }
            }

            var char_array = output.ToCharArray();
            Array.Reverse(char_array);
            output = new string(char_array);
            return output;
        }


        public static bool Is_phone_number(string input)
        {
            return Regex.IsMatch(input, @"^[(][1-9][0-9]{2}[)]( )[0-9]{3}(-)[0-9]{4}$");

        }

        public static string get_century(int input)
        {
            string century;
            string input_str = input.ToString();

            if (input % 100 == 0)
            {
                century = input_str.Substring(0, 2);
            }
            else
            {
                int temp = int.Parse(input_str.Substring(0, 2)) + 1;
                century = temp.ToString();
            }

            return century == "21" ? century + "st century" : century + "th century";
        }

        //remove multiple ??? or !!!! present at te end of a word
        public static string no_yelling(string input)
        {
            string formatted_string = input;
            int count = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] != '?' && input[i] != '!')
                    break;
                else
                    count++;
            }

            return count > 1 ? formatted_string.Remove(formatted_string.Length - count + 1) : formatted_string;
        }

        public static string reverse_string(string input)
        {
            var char_array = input.ToCharArray();
            Array.Reverse(char_array);
            var output = new string(char_array);
            return output;
        }

        public static string encrpyt_using_karaca_algo(string input)
        {
            string result;

            result = reverse_string(input);
            result = Regex.Replace(result, @"[aeiou]", "0");
            // result = result.Replace('a', '0').Replace('e', '1').Replace('i', '2').Replace('o', '2').Replace('u', '3');
            result += "aca";
            return result;
        }

        public static string remove_special_characters(string input)
        {
            string output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetterOrDigit(input[i]) || input[i] == '_' || input[i] == '-' || input[i] == ' ')
                {
                    output += input[i];
                }
            }
            return output;
        }

        public static bool Is_valid_email(string input)
        {
            return Regex.IsMatch(input, @"^[^@]+[@][0-9A-Za-z]+[.][0-9A-Za-z]+$");
        }

        public static string capitalize_first_letter(string input)
        {
            string output = input;

            if (input != null && input.Length > 1)
            {
                output = string.Empty;
                output += char.ToUpper(input[0]);

                for (int i = 1; i < input.Length; i++)
                {
                    if (char.IsWhiteSpace(input[i - 1]) || input[i - 1] == '-')
                        output += char.ToUpper(input[i]);
                    else
                        output += input[i];
                }
            }
            return output;
        }

       
        public static string compound_letters(string input)
        {
            string output = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                int count = 0;

                while (count <= i)
                {
                    output += input[i];
                    count++;
                }
            }

            return output;
        }

        //Create a function that takes a string and returns a new string with each new character accumulating by +1. Separate each set with a dash.

        public static string compunding_and_capitalising_dash_separated_letters(string input)
        {
            string output1 = compound_letters(input);
            string output2 = string.Empty;
            output2 += input[0];
            for (int i = 1; i < output1.Length; i++)
            {
                if (output1[i] != output1[i - 1])
                    output2 += "-" + output1[i];
                else
                    output2 += output1[i];
            }

            string output3 = capitalize_first_letter(output2);
            return output3;
        }

        //Write a function that takes a string of one or more words as an argument and returns the same string, but with all five or more letter words reversed. Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.

        public static string reverse_if_greater_than_five(string input)
        {
            string output = string.Empty;
            string word = string.Empty;
            
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsWhiteSpace(input[i]) || i == input.Length - 1)
                {
                    if (i == input.Length - 1)
                    {
                        word += input[i];
                    }
                    if (word.Length >= 5)
                    {
                        word = reverse_string(word);
                        output += word;
                    }
                    else
                    {
                        output += word;
                    }

                    if (char.IsWhiteSpace(input[i]))
                        output += input[i];

                    word = string.Empty;
                }
                else
                    word += input[i];
            }
            return output;
        }

        //Create a function that takes a string and returns a new string with its first and last characters swapped, except under three conditions:

        public static string switcharoo(object input)
        {
            string output;

            if (input.GetType() != typeof(string))
                output = "Incompatible.";
            else
            {
                var str_input = (string)input;
                if (str_input.Length < 2)
                    output = "Incompatible.";
                else
                {
                    if (str_input[0] == str_input[str_input.Length - 1])
                        output = "Two's a pair.";
                    else
                    {
                        string middle_part_of_string = str_input.Substring(1, str_input.Length - 2);
                        output = str_input[str_input.Length - 1] + middle_part_of_string + str_input[0];
                    }
                }


            }
            return output;
        }

        //anagrams- 2 same letters rearraned into a different word
        public static bool is_anagrams(string input1, string input2)
        {
            bool output = false;
            int i = 0;
            input1 = input1.ToLower().Replace(" ", "");
            input2 = input2.ToLower().Replace(" ", "");
            if (input1.Length == input2.Length)
            {
                for (int j = 0; j < input2.Length; j++)
                {
                    if (input1[i] == input2[j])
                    {
                        input1 = input1.Remove(i, 1);
                        input2 = input2.Remove(j, 1);
                        j = -1;
                    }
                    if (j == input2.Length - 1)
                        break;
                }
                if (input1.Length == 0)
                    output = true;
            }
            return output;
        }

        //public static string phone_number_word_decoder(string input)
        //{
        //    return Regex.Replace(input, @"[ABC][DEF][GHI][JKL][MNO][PQRS][TUV][WXYZ]" ;
        //}

        public static string alternating_caps(string input)
        {
            string output = string.Empty;

            input = input.ToLower();
            output += char.ToUpper(input[0]);
            output += char.ToLower(input[1]);

            if (input.Length > 2)
            {
                for (int i = 2; i < input.Length; i++)
                {
                    if (char.IsWhiteSpace(input[i]))
                        output += input[i];
                    else
                    {
                        if (char.IsWhiteSpace(output[i - 1]))
                        {
                            if (char.IsLower(output[i - 2]))
                                output += char.ToUpper(input[i]);

                            else
                                output += input[i];
                        }
                        else
                        {
                            if (char.IsLower(output[i - 1]))
                                output += char.ToUpper(input[i]);

                            else
                                output += input[i];
                        }
                    }
                }
            }

            return output.ToString();
        }

        //Create a function that takes an array of names and returns an array where only the first letter of each name is capitalized
        public static string[] caps_names(string[] names)
        {
            string[] capitalized_names = new string[names.Length];

            for (int i = 0; i < names.Length; i++)
            {
                string each_name = capitalize_first_letter(names[i]);
                capitalized_names[i] = each_name;
            }
            return capitalized_names;
        }


        //A smooth sentence is one where the last letter of each word is identical to the first letter the following word (and not case sensitive
        public static bool is_smooth(string input)
        {
            bool output = false;

            if (input != null)
            {
                input = input.ToLower();

                for (int i = 1; i < input.Length - 1; i++)
                {
                    if (char.IsWhiteSpace(input[i]))
                    {
                        if (input[i - 1] != input[i + 1])
                        {
                            output = false;
                            break;
                        }
                        else
                            output = true;
                    }
                }
            }

            return output;
        }

        public static string reverse_and_not(int input)
        {
            return $"{new string(input.ToString().Reverse().ToArray())}{input}";
        }

        public static bool is_valid_hex_code(string input)
        {
            return Regex.IsMatch(input, @"^[#][0-9A-Fa-f]{6}$");
        }

        public static bool check_brackets(string input)
        {
            bool result = false;
            int count = 0;
            if (input != null)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == ')')
                        count--;
                    else if (input[i] == '(')
                        count++;
                    if (count < 0)
                        break;
                }
            }
            
            if (count == 0)
                result = true;
            return result;
        }
    }



    //public interface IStringHelpers
    //{
    //    List<string> get_words(string sentence);

    //    //List<string> get_nouns(string sentence);
    //}

    //public class StringLowLevelHelpers : IStringHelpers
    //{
    //    public List<string> get_words(string sentence)
    //    {
    //        return new List<string>();
    //    }

    //    public bool is_sentency_empty(string input)
    //    {
    //        return false;
    //    }
    //}

    //public class StringHighLevelHelpers
    //{
    //    public IStringHelpers StringHelpersDependency;      // default value is null

    //    public bool is_smooth(string sentence)
    //    {
    //        StringHelpersDependency.get_words(sentence);
    //        return false;
    //    }
    //}


    //public class MainClass
    //{
    //    public static void Main()
    //    {
    //        // production env:
    //        var string_high_level_helper_object = new StringHighLevelHelpers();

    //        string_high_level_helper_object.StringHelpersDependency = new StringLowLevelHelpers();

    //        string_high_level_helper_object.is_smooth("blah Blah");



    //        // your test method:
    //        string_high_level_helper_object.StringHelpersDependency = new DummyStringLowLevelHelpers("input sentence", ["word1", "word2"]);
    //        Assert.IsFalse(string_high_level_helper_object.is_smooth("input sentence"));

    //        string_high_level_helper_object.StringHelpersDependency = new DummyStringLowLevelHelpers("input sentence", ["word1", "1word"]);
    //        Assert.IsTrue(string_high_level_helper_object.is_smooth("input sentence"));

    //        string_high_level_helper_object.StringHelpersDependency = new DummyStringLowLevelHelpers("input sentence", ["word1"]);
    //        Assert.IsTrue(string_high_level_helper_object.is_smooth("input sentence"));
    //    }
    //}
}
