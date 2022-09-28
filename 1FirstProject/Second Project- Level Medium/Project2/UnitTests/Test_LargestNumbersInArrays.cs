using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ConsoleApp1;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;

namespace UnitTests
{
    public class Test_LargestNumbersInArrays
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public static void max_value_in_array()
        {
            var result = MathHelpers.largest_number(new double[] { -10, 12, 0 });
            Assert.That(result, Is.EqualTo(12));
        }

        [Test]
        public static void array_of_largest_numbers()
        {
            var result = MathHelpers.largest_numbers_array(new double[][]
                {
                    new double[] { -4, 2, -7, 1 },
                    new double[] { 20, 70, -40, -90 },
                    new double[] { 1, -2, 0, 11 }
                });
            List<double> numbers = new List<double>() { 2, 70, 11 };
            Assert.AreEqual(numbers, result);

            result = MathHelpers.largest_numbers_array(new double[][]
                {
                    new double[] { -34, -54, -74 },
                    new double[] { -32, -2, -65 },
                    new double[] { -54, 7, -43 }
                });
            numbers = new List<double>() { -34, -2, 7 };
            Assert.AreEqual(numbers, result);

        }

        [Test]
        public static void should_return_empty_when_null_is_passed()
        {
            var result = MathHelpers.largest_numbers_array(null);

            Assert.That(result, Is.Empty);
        }

        [Test]
        [TestCase(49, ExpectedResult = false)]
        [TestCase(12, ExpectedResult = false)]
        [TestCase(31, ExpectedResult = true)]
        [TestCase(18, ExpectedResult = false)]
        [TestCase(11, ExpectedResult = true)]
        [TestCase(12, ExpectedResult = false)]
        [TestCase(1, ExpectedResult = false)]
        [TestCase(3, ExpectedResult = true)]
        [TestCase(48, ExpectedResult = false)]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(5, ExpectedResult = true)]
        [TestCase(77, ExpectedResult = false)]
        [TestCase(7, ExpectedResult = true)]
        public static bool should_return_true_if_prime(int input)
        {
            return MathHelpers.is_prime(input);
        }


        [Test]
        [TestCase(0, ExpectedResult = true)]
        [TestCase(868, ExpectedResult = true)]
        [TestCase(77, ExpectedResult = true)]
        [TestCase(95159, ExpectedResult = true)]
        [TestCase(839, ExpectedResult = false)]
        [TestCase(11, ExpectedResult = true)]
        [TestCase(4234, ExpectedResult = false)]
        public static bool should_return_true_if_palindrome(int input)
        {
            return MathHelpers.is_palindrome(input);
        }

        [Test]
        public void should_match_the_sum_and_count_array()
        {
            var result = MathHelpers.count_sum(new double[] { 1, -9, -8, 5.5, 0 });
            var expected_result = new double[] { 2, -17 };
            Assert.That(result, Is.EqualTo(expected_result));

            result = MathHelpers.count_sum(new double[] { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 });
            expected_result = new double[] { 7, -252 };
            Assert.That(result, Is.EqualTo(expected_result));

            result = MathHelpers.count_sum(new double[] { });
            expected_result = new double[] { };
            Assert.That(result, Is.EqualTo(expected_result));
        }

        [Test]
        [TestCase("1 -245 4 59", ExpectedResult = "59 -245")]
        [TestCase("1 2 3 4 5", ExpectedResult = "5 1")]
        [TestCase("4 5 29 54 4 0 -214 542 -64 1 -3 6 -6", ExpectedResult = "542 -214")]
        [TestCase("1 -1", ExpectedResult = "1 -1")]
        [TestCase("-1 -1", ExpectedResult = "-1 -1")]
        [TestCase("1 -1 0", ExpectedResult = "1 -1")]
        [TestCase("1 1 0", ExpectedResult = "1 0")]
        [TestCase("-1 -1 0", ExpectedResult = "0 -1")]
        [TestCase("42", ExpectedResult = "42 42")]
        [TestCase("1 1", ExpectedResult = "1 1")]
        public static string should_return_highes_and_lowest(string input)
        {
            return StringHelpers.highest_and_lowest(input);
        }

        [Test]
        [TestCase(new int[] { 19, 5, 42, -2 }, ExpectedResult = 24)]
        [TestCase(new int[] { 19, 5, 42, 2, 77 }, ExpectedResult = 7)]
        [TestCase(new int[] { 10, 343445353, 3453445, 345354534 }, ExpectedResult = 3453455)]
        [TestCase(new int[] { 2, 9, 6, -1 }, ExpectedResult = 8)]
        [TestCase(new int[] { 879, 953, 694, -847, 342, 221, -91, -723, 791, -587 }, ExpectedResult = 563)]
        [TestCase(new int[] { 3683, 2902, 3951, -475, 1617, -2385 }, ExpectedResult = 4519)]
        [TestCase(new int[] { 280, 134, 108 }, ExpectedResult = 242)]
        [TestCase(new int[] { 280, 134, 108, 1 }, ExpectedResult = 109)]
        [TestCase(new int[] { 321, 406, -176 }, ExpectedResult = 727)]
        [TestCase(new int[] { 1, 1, 1, 1 }, ExpectedResult = 2)]
        [TestCase(new int[] { -1, -1, 1, 1 }, ExpectedResult = 2)]
        public int should_be_equal_to_the_sum_of_lowest_two_positive_numbers(int[] array_of_numbers)
        {
            return MathHelpers.sum_of_two_lowest_positive_numbers(array_of_numbers);
        }

        [Test]
        [TestCase(8129, ExpectedResult = 9821)]
        [TestCase(123, ExpectedResult = 321)]
        [TestCase(670276097, ExpectedResult = 977766200)]
        [TestCase(2619805, ExpectedResult = 9865210)]
        [TestCase(81294, ExpectedResult = 98421)]
        [TestCase(321, ExpectedResult = 321)]
        [TestCase(628904, ExpectedResult = 986420)]
        [TestCase(289327560, ExpectedResult = 987653220)]
        [TestCase(6456, ExpectedResult = 6654)]
        [TestCase(0, ExpectedResult = 0)]
        public int should_return_number_in_descending(int input)
        {
            return MathHelpers.sort_descending(input);
        }

        [Test]
        [TestCase(0, ExpectedResult = 3)]
        [TestCase(1, ExpectedResult = 3.1)]
        [TestCase(2, ExpectedResult = 3.14)]
        [TestCase(3, ExpectedResult = 3.142)]
        [TestCase(4, ExpectedResult = 3.1416)]
        [TestCase(5, ExpectedResult = 3.14159)]
        [TestCase(6, ExpectedResult = 3.141593)]
        [TestCase(7, ExpectedResult = 3.1415927)]
        [TestCase(8, ExpectedResult = 3.14159265)]
        [TestCase(9, ExpectedResult = 3.141592654)]
        [TestCase(10, ExpectedResult = 3.1415926536)]
        [TestCase(11, ExpectedResult = 3.14159265359)]
        [TestCase(12, ExpectedResult = 3.141592653590)]
        [TestCase(13, ExpectedResult = 3.1415926535898)]
        [TestCase(14, ExpectedResult = 3.14159265358979)]
        [TestCase(15, ExpectedResult = 3.141592653589793)]
        public double should_return_pi_to_n_decimal_places(int n)
        {
            return MathHelpers.PI_to_n_decimal_places(n);
        }


        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 0, 0, -3, -2 }, ExpectedResult = 10)]
        [TestCase(new int[] { 1, 2, 3, 4, 0, 0, -3, -2 }, ExpectedResult = 10)]
        [TestCase(new int[] { -4, -8, -12, -3, 4, 7, 1, 3, 0, 0, 0, 0 }, ExpectedResult = -27)]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 1, 2, -3 }, ExpectedResult = 5)]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, ExpectedResult = 11)]
        [TestCase(new int[] { 0 }, ExpectedResult = 1)]
        [TestCase(new int[] { 1 }, ExpectedResult = 1)]
        [TestCase(new int[] { -1 }, ExpectedResult = -1)]
        [TestCase(new int[] { 10, -12, 4, 0, -3, -7, -91, 45 }, ExpectedResult = -113)]
        [TestCase(new int[] { 0, 1, 0, 1, 0, 1, 0, 1, 0 }, ExpectedResult = 5)]
        [TestCase(new int[] { -1, -1, -1, -1, -1, 1, 1, 1, 1, 0, 0, 0, 0 }, ExpectedResult = -5)]
        [TestCase(new int[] { 1, 2, 3, 4, -5, -4, -3, -2, -1, 0 }, ExpectedResult = -15)]
        [TestCase(new int[] { 0, 1, -2 }, ExpectedResult = -2)]
        [TestCase(new int[] { 2, 0, -1 }, ExpectedResult = 2)]
        [TestCase(new int[] { 2, 0, 0, 0, -1 }, ExpectedResult = 3)]
        [TestCase(new int[] { 2, 0, 0, 0, 0, -1 }, ExpectedResult = 4)]

        public int should_return_the_major_sum(int[] input)
        {
            return MathHelpers.major_sum(input);
        }

        [Test]
        public static void should_return_days_taken_to_find_treassure()
        {
            var result = MathHelpers.days_to_find_treasure(10, 10);
            Assert.That(result, Is.EqualTo(23));

            result = MathHelpers.days_to_find_treasure(3, 3);
            Assert.That(result, Is.EqualTo(7));

            result = MathHelpers.days_to_find_treasure(-10, -9);
            Assert.That(result, Is.EqualTo(22));

            result = MathHelpers.days_to_find_treasure(-1, -4);
            Assert.That(result, Is.EqualTo(5));

            result = MathHelpers.days_to_find_treasure(-10, -2);
            Assert.That(result, Is.EqualTo(14));

            result = MathHelpers.days_to_find_treasure(3, 30);
            Assert.That(result, Is.EqualTo(39));

            result = MathHelpers.days_to_find_treasure(40, 1);
            Assert.That(result, Is.EqualTo(49));

            result = MathHelpers.days_to_find_treasure(3, 5);
            Assert.That(result, Is.EqualTo(9));
        }


        [Test]
        [TestCase(10, ExpectedResult = true)]
        [TestCase(13, ExpectedResult = false)]
        public bool should_return_true_if_even(int number)
        {
            return MathHelpers.is_even(number);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = 10)]
        [TestCase(new int[] { -10, 2, 3, 4 }, ExpectedResult = -1)]
        public int should_return_sum_of_numbers(int[] numbers)
        {
            return MathHelpers.add_signed_numbers_in_array(numbers);
        }

        [Test]
        [TestCase(189, ExpectedResult = new int[] { 9, 8, 1 })]
        [TestCase(56000, ExpectedResult = new int[] { 0, 0, 0, 6, 5 })]
        public int[] should_return_individual_digits_reverse_order(int number)
        {
            return MathHelpers.split_number_into_individual_digits(number);
        }

        [Test]
        [TestCase(43, ExpectedResult = "Oddish")]
        [TestCase(373, ExpectedResult = "Oddish")]
        [TestCase(55551, ExpectedResult = "Oddish")]
        [TestCase(694, ExpectedResult = "Oddish")]
        [TestCase(4433, ExpectedResult = "Evenish")]
        [TestCase(11, ExpectedResult = "Evenish")]
        [TestCase(211112, ExpectedResult = "Evenish")]
        public string OddishOrEvenish(int input)
        {
            return MathHelpers.oddish_or_evenish(input);
        }

        [Test]
        [TestCase(5, 31, 33, ExpectedResult = 1)]
        [TestCase(4, 250, 1300, ExpectedResult = 3)]
        [TestCase(2, 49, 65, ExpectedResult = 2)]
        [TestCase(3, 1, 27, ExpectedResult = 3)]
        [TestCase(10, 1, 5, ExpectedResult = 1)]
        [TestCase(1, 1, 5, ExpectedResult = 5)]
        [TestCase(2, 1, 100, ExpectedResult = 10)]
        public int powerRanger(int power, int min, int max)
        {
            return MathHelpers.power_ranger(power, min, max);
        }

        [Test]
        [TestCase(0, ExpectedResult = 2)]
        [TestCase(12, ExpectedResult = 13)]
        [TestCase(24, ExpectedResult = 29)]
        [TestCase(11, ExpectedResult = 11)]
        [TestCase(13, ExpectedResult = 13)]
        [TestCase(14, ExpectedResult = 17)]
        [TestCase(33, ExpectedResult = 37)]
        [TestCase(97, ExpectedResult = 97)]
        public int should_return_next_prime(int num)
        {
            return MathHelpers.next_prime(num);
        }
    

        public class when_checking_if_a_number_is_a_perfect_number
        {
            [SetUp]
            public void Setup()
            {

            }


            [Test]
            [TestCase(6, ExpectedResult = true)]
            [TestCase(28, ExpectedResult = true)]
            [TestCase(496, ExpectedResult = true)]
            [TestCase(8128, ExpectedResult = true)]
            [TestCase(33550336, ExpectedResult = true)]
            [TestCase(12, ExpectedResult = false)]
            [TestCase(97, ExpectedResult = false)]
            [TestCase(481, ExpectedResult = false)]
            [TestCase(1001, ExpectedResult = false)]
            [TestCase(55555, ExpectedResult = false)]
            public bool should_return_true_if_number_is_perfect(int input)
            {
                return MathHelpers.is_perfect_number(input);
            }

            [Test]
            [TestCase(10, ExpectedResult = new int[] { 1, 2, 5 })]

            public List<int> calculate_factors_test(int number)
            {
                return MathHelpers.calculate_factors(number);
            }

            [Test]
            [TestCase(10, ExpectedResult = new int[] { 1, 2, 5 })]
            [TestCase(24, ExpectedResult = new int[] { 1, 2, 3, 4 })]

            public List<int> should_return_factors_that_multiply_to_give_the_number(int input)
            {
                return MathHelpers.factors_that_multiply_to_form_the_number(input);

            }


            [Test]
            [TestCase(6, ExpectedResult = true)]
            [TestCase(16, ExpectedResult = false)]
            [TestCase(24, ExpectedResult = true)]
            [TestCase(36, ExpectedResult = false)]
            [TestCase(120, ExpectedResult = true)]
            [TestCase(721, ExpectedResult = false)]
            public bool should_return_true_if_number_is_factorial(int input)
            {
                return MathHelpers.is_factorial_of_an_integer(input);
            }

        }


    }
}
